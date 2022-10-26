using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace accumulator_MachineSimulator1to2
{
    public partial class Form1 : Form
    {
        //Esta var indica el archivo que tenemos abierto actualmente
        string actualFilePath = null;
        RegexLexer csLexer = new RegexLexer();
        List<string> palabrasReservadas;
        bool load;

        /* Delay para llamar una funcion (siempre y cuando no se interrumpa).
        En este proyecto se usa para analizar el codigo en tiempo real, siempre
        que el usuario no escriba por mas de 2 segundos*/
        Timer jumper = new Timer();
        bool timing = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

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
            using (StreamReader sr = new StreamReader(@"..\..\RegexLexer.cs"))
            {
                
                csLexer.AddTokenRule(@"\.code|\.data", "DIRECTIVA");
                csLexer.AddTokenRule(@"[^\.]\b[_a-zA-Z][\w]*\b", "IDENTIFICADOR");
                csLexer.AddTokenRule(@"\d*\.?\d+", "NUMERO");
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
                
            }
        }

        //==========================================================
        //Analizador en tiempo Real del codigo
        //==========================================================
        private void AnalizeCode()
        {
            //lvToken.Items.Clear();
            dgvToken.Rows.Clear();

            int n = 0, e = 0;

            foreach (var tk in csLexer.GetTokens(txtCodif.Text))
            {
                if (tk.Name == "ERROR") e++;

                if (tk.Name == "IDENTIFICADOR")
                    if (palabrasReservadas.Contains(tk.Lexema))
                        tk.Name = "RESERVADO";

                //lvToken.Items.Add(tk);
                dgvToken.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index);
                n++;
            }
            //var bindingList = new BindingList<Token>();
            //var source = new BindingSource(bindingList, null);
            //dgvToken.DataSource = source;

            //this.Title = string.Format("Analizador Lexico - {0} tokens {1} errores", n, e);
        }

        //Si el usuario no interrumpe esto se mandara a llamar
        private void jumperTick(object sender, EventArgs e)
        {
            AnalizeCode();
            jumper.Stop();
            timing = false;
        }

        // Si el temporizador ya fue llamado, solo lo reinicia si el usuario sigue escribiendo
        private void CallJumper()
        {
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
    }
}