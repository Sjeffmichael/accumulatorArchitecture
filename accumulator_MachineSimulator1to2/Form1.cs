using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace accumulator_MachineSimulator1to2
{
    public partial class Form1 : Form
    {
        //Esta var indica el archivo que tenemos abierto actualmente
        string actualFilePath = null;
        int errors = 0;

        RegexLexer csLexer = new RegexLexer();
        List<string> palabrasReservadas;
        List<string> variablesDeclaradas = new List<string>();
        bool load;
        string regexAcumulador;
        Regex regexValidVar = new Regex(@"[_a-zA-Z][\w]*");
        Dictionary<string, List<string>> regexLineaPrevia = new Dictionary<string, List<string>>()
        {
            //{"VARIABLE", new Regex(@"\b^((\bload)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*))(\s+)(\bstore)(\s+)([_a-zA-Z][\w]*)\b")},
            {"DIRECTIVA_DATOS", new List<string>{"", "COMENTARIO"}},
            {"DIRECTIVA_CODIGO", new List<string>{"VARIABLE"}},
            {"VARIABLE", new List<string>{"ACUMULADOR", "SUMA", "RESTA", "MULTIPLICACION", "DIVISION"}},
            {"ACUMULADOR", new List<string>{"VARIABLE", "SUMA", "RESTA", "MULTIPLICACION", "DIVISION", "DIRECTIVA_DATOS", "ACUMULADOR", "DIRECTIVA_CODIGO"}},
            {"SUMA", new List<string>{ "ACUMULADOR", "RESTA", "MULTIPLICACION", "DIVISION"}},
            {"RESTA", new List<string>{ "ACUMULADOR", "RESTA", "MULTIPLICACION", "DIVISION"}},
            {"MULTIPLICACION", new List<string>{ "ACUMULADOR", "RESTA", "MULTIPLICACION", "DIVISION"}},
            {"DIVISION", new List<string>{ "ACUMULADOR", "RESTA", "MULTIPLICACION", "DIVISION"}},
        };

        //==========================================================
        //Delay para llamar una funcion (siempre y cuando no se interrumpa).
        //En este proyecto se usa para analizar el codigo en tiempo real, siempre
        //que el usuario no escriba por mas de 2 segundos
        //==========================================================
        System.Windows.Forms.Timer jumper = new System.Windows.Forms.Timer();
        bool timing = false;

        //==========================================================
        //Formulario para enseñar el diagrama
        //==========================================================
        private Diagram diagrama = null;

        //==========================================================
        // Variable logica del acumulador
        //==========================================================
        AcumulatorMachine Acumulator;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (errors != 0)
            {
                MessageBox.Show(
                    "Imposible empezar con "+errors+" errores",
                    "Errores"
                    );
                return;
            }

            int posSelected = 0;

            btnPlay.Enabled = false;
            txtCodif.ReadOnly = false;
            txtCodif.Focus();
            dgVars.Rows.Clear();
            Acumulator.StartMachine();

            Acumulator.RecognizeVars(variablesDeclaradas);

            foreach (DataGridViewRow row in dgvToken.Rows)
            {
                // ANIMATION select for each line
                posSelected = Int32.Parse(row.Cells[4].Value.ToString());
                txtCodif.Select(
                    posSelected, 
                    txtCodif.Lines[Int32.Parse(row.Cells[2].Value.ToString()) - 1].Length
                );
                txtCodif.SelectionColor = Color.AliceBlue;

                lbMAR.Text = row.Cells[2].Value.ToString();

                Acumulator.ProcessLine(row);

                Task.Run(async delegate
                {
                    await Acumulator.Esperar(3000);
                }).Wait();
                txtCodif.SelectionColor = Color.White;
            }

            Acumulator.StopMachine();
            btnPlay.Enabled = true;
            txtCodif.ReadOnly = false;
        }

        //==========================================================
        //Administracion de archivos
        //==========================================================

        private void SaveFile(string path, string text) //Wer
        {
            System.IO.File.WriteAllText(path, text);
        }

        //-------------Cuando un usuario quiere Guardar un nuevo archivo-------------//
        private void ShowDialogSave(string text)
        {
            saveFileDialog1.Filter = "asm files (*.asm)|*.asm";
            saveFileDialog1.Title = "Crear nuevo archivo";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                actualFilePath = saveFileDialog1.FileName;
                SaveFile(actualFilePath, text);
            }
        }

        //-------------Cuando un usuario quiere Abrir un nuevo archivo-------------//
        private void ShowDialogOpen()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Abrir archivo";
            openFileDialog1.Filter = "asm files (*.asm)|*.asm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                actualFilePath = openFileDialog1.FileName;

                txtCodif.Text = System.IO.File.ReadAllText(actualFilePath);
            }
        }

        /*Al seleccionar abrir nuevo archivo en el programa*/
        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si existe un archivo ya abierto
            if (actualFilePath != null)
            {
                DialogResult result = MessageBox.Show(
                    "¿Desea guardar los cambios de este archivo?", 
                    "¿Guardar?",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveFile(actualFilePath,txtCodif.Text.ToString());
                }
            }

            ShowDialogSave("");
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si existe un archivo ya abierto
            if (actualFilePath != null)
            {
                DialogResult result = MessageBox.Show(
                    "¿Desea guardar los cambios de este archivo?",
                    "¿Guardar?",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveFile(actualFilePath, txtCodif.Text.ToString());
                }
            }

            ShowDialogOpen();
        }

        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actualFilePath == null)
            {
                ShowDialogSave(txtCodif.Text.ToString());
            }
            SaveFile(actualFilePath, txtCodif.Text.ToString());
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            regexAcumulador = @"\b(\bload)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*)\b";

            using (StreamReader sr = new StreamReader(@"..\..\RegexLexer.cs"))
            {
                csLexer.AddTokenRule(@"((\s*|)(\.data))", "DIRECTIVA_DATOS");
                csLexer.AddTokenRule(@"\.code", "DIRECTIVA_CODIGO");

                //csLexer.AddTokenRule(@"\b^((\bload)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*))(\s+)(\bstore)(\s+)([_a-zA-Z][\w]*)\b", "VARIABLE_PRESEDENCIA", true);
                csLexer.AddTokenRule(@"\b(\bstore)(\s+)([_a-zA-Z][\w]*)\b", "VARIABLE");
                csLexer.AddTokenRule(@"\b(\bload)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*)\b", "ACUMULADOR");
                csLexer.AddTokenRule(@"(\badd)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*)", "SUMA");
                csLexer.AddTokenRule(@"(\bsub)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*)", "RESTA");
                csLexer.AddTokenRule(@"(\bmul)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*)", "MULTIPLICACION");
                csLexer.AddTokenRule(@"(\bdiv)(\s+)((\+|-)*\d*\.?\d+|[_a-zA-Z][\w]*)", "DIVISION");
                //csLexer.AddTokenRule(@"\d*\.?\d+", "NUMERO");
                csLexer.AddTokenRule(@"\s+", "ESPACIO", true);
                csLexer.AddTokenRule(";[^\r\n]*", "COMENTARIO");

                palabrasReservadas = new List<string>() {
                    "load", "store", "div", "add", "mul", "sub"
                };
                csLexer.Compile(RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.ExplicitCapture);

                load = true;
                AnalizeCode();
                txtCodif.Focus();

                jumper.Tick += new EventHandler(jumperTick);
                jumper.Interval = 2000;

                Acumulator = new AcumulatorMachine(
                    lbX, lbY, lbZ, lbOperator, lbPC, lbInst, lbMAR, lbMDR, console, dgVars);
            }
        }

        private bool validarLineaAnterior(string ultimaLinea, string token)
        {
            if (token != "ERROR")
            {
                regexLineaPrevia.TryGetValue(token, out List<string> regex);

                    return regex.Contains(ultimaLinea);
            }

            return false;
            
        }

        private void variablesExistentes()
        {
            foreach (string variable in variablesDeclaradas.ToList())
            {
                if (!txtCodif.Text.Contains("store " + variable))
                {
                    variablesDeclaradas.Remove(variable);
                }
            }
        }

        //==========================================================
        //Analizador en tiempo Real del codigo
        //==========================================================
        private void AnalizeCode()
        {
            variablesExistentes();
            dgvToken.Rows.Clear();
            List<string> lineasAnalizadas = new List<string>();
            string lineaAnterior = "";
            lineasAnalizadas.Add("");

            int n = 0;
            errors = 0;

            foreach (var tk in csLexer.GetTokens(txtCodif.Text))
            {
                if (tk.Name != "COMENTARIO")
                    if (!validarLineaAnterior(lineaAnterior, tk.Name))
                        tk.Name = "ERROR";

                if (tk.Name == "ERROR") errors++;

                if (tk.Name == "IDENTIFICADOR")
                    if (palabrasReservadas.Contains(tk.Lexema))
                        tk.Name = "RESERVADO";


                if ((tk.Name == "ACUMULADOR" 
                    || tk.Name == "SUMA"
                    || tk.Name == "RESTA"
                    || tk.Name == "MULTIPLICACION"
                    || tk.Name == "DIVISION")
                    && tk.Lexema.Split(' ').Count() == 2)
                {
                    string DeclareVar = tk.Lexema.Split(' ')[1];

                    if (
                        regexValidVar.IsMatch(DeclareVar)
                        && !lineasAnalizadas.Contains("store " + DeclareVar)
                    )
                    {
                        tk.Name = "ERROR";
                        errors++;
                    }

                }

                if (tk.Name == "VARIABLE" && tk.Lexema.Split(' ').Count() == 2)
                {
                    string newVar = tk.Lexema.Split(' ')[1];
                    /* Agregar a la lista de variables declaradas */
                    if (!variablesDeclaradas.Contains(newVar))
                    {
                        variablesDeclaradas.Add(newVar);
                    }
                }

                if (tk.Name != "COMENTARIO")
                    lineaAnterior = tk.Name;
                dgvToken.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index);
                dgvToken.FirstDisplayedScrollingRowIndex = dgvToken.RowCount - 1;
                lineasAnalizadas.Add(tk.Lexema);
                n++;
            }

        }

        //Si el usuario no interrumpe esto se mandara a llamar
        private void jumperTick(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            AnalizeCode();
            jumper.Stop();
            timing = false;
        }

        // Si el temporizador ya fue llamado, solo lo reinicia si el usuario sigue escribiendo
        private void CallJumper()
        {
            btnPlay.Enabled = false;
            if (timing)
            {
                jumper.Stop();
                jumper.Start();
            }
            else
            {
                timing = true;
                jumper.Start();
            }
        }

        private void CodeChanged(object sender, EventArgs e)
        {
            if (!load) return;

            CallJumper();
        }

        private void diagramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (diagrama == null)
            {
                diagrama = new Diagram();
                diagrama.Show();
            } 
            else
            {
                diagrama.Close();
                diagrama = null;
            }
            
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string actualPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            txtCodif.Text = System.IO.File.ReadAllText(actualPath+ "/Examples/AllOps.asm");
        }
    }
}