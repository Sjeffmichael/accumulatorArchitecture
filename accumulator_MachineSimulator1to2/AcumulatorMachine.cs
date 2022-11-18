using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accumulator_MachineSimulator1to2
{
    class AcumulatorMachine
    {

        //Display information vars
        private Label lbX, lbY, lbZ, lbOP, lbINST, lbPC, lbMAR, lbMDR;
        RichTextBox Console;
        DataGridView Vars;

        private void SetX(int v)
        {
            lbX.Text = v.ToString();
        }

        private void SetY(int v)
        {
            lbY.Text = v.ToString();
        }

        private void SetZ(int v)
        {
            lbZ.Text = v.ToString();
        }

        public AcumulatorMachine(Label lbx, Label lby, Label lbz, Label lbop,
            Label lbpc, Label lbinst, Label lbmar, Label lbmdr, RichTextBox console, DataGridView vars)
        {
            lbX = lbx;
            lbY = lby;
            lbZ = lbz;
            lbOP = lbop;
            lbPC = lbpc;
            lbINST = lbinst;
            lbMDR = lbmdr;
            lbMAR = lbmar;
            Console = console;
            Vars = vars;
        }

        public void StartMachine()
        {
            SetX(0);
            SetY(0);
            SetZ(0);
            lbOP.Text = "=";
            lbINST.Text = "Nothing";
            lbPC.Text = "0";
            Console.Clear();
            Console.Text += "===================Inicio de ejecución===================\n";
        }

        public void RecognizeVars(List<string> variablesDeclaradas)
        {
            Console.Text += "Reconociendo variables\n\n";
            foreach (string IdVar in variablesDeclaradas)
            {
                Vars.Rows.Add(IdVar, "");
            }
        }

        public void StopMachine()
        {
            Console.Text += "\n\n===================Fin de ejecución===================";
        }

        public void ProcessLine(DataGridViewRow row)
        {
            lbPC.Text = (Int32.Parse(lbPC.Text) + 1).ToString();

            string tokenName = row.Cells[0].Value.ToString();
            
            if (tokenName.Equals("COMENTARIO")) return;
            if (tokenName.Equals("DIRECTIVA_DATOS")) return;
            if (tokenName.Equals("DIRECTIVA_CODIGO")) return;

            string[] lexema = row.Cells[1].Value.ToString().Split(' ');
            lbINST.Text = row.Cells[1].Value.ToString();

            switch (tokenName)
            {
                case "ACUMULADOR":
                    Load(lexema[1]);
                    lbMDR.Text = "0000";
                    lbOP.Text = "=";
                    break;
                case "VARIABLE":
                    Store(lexema[1]);
                    lbMDR.Text = "0001";
                    break;
                case "SUMA":
                    Sumar(lexema[1]);
                    lbOP.Text = "+";
                    lbMDR.Text = "0002";
                    break;
                case "RESTA":
                    Resta(lexema[1]);
                    lbOP.Text = "-";
                    lbMDR.Text = "0003";
                    break;
                case "MULTIPLICACION":
                    Mul(lexema[1]);
                    lbOP.Text = "*";
                    lbMDR.Text = "0004";
                    break;
                case "DIVISION":
                    Div(lexema[1]);
                    lbOP.Text = "/";
                    lbMDR.Text = "0005";
                    break;
                default:
                    Console.Text += "ERROR\n";
                    break;
            }

        }

        private void Load(string NV)
        {
            int valor = GetValueFrom(NV);
            SetX(valor);
            SetZ(valor);
        }

        private void Store(string NV)
        {
            int index = IndexOfVar(NV);
            if (index != -1)
            {
                Vars.Rows[index].Cells[1].Value = lbZ.Text;
            }
        }

        private void Sumar(string value)
        {
            int valor = GetValueFrom(value);
            SetY(valor);
            SetZ(Int32.Parse(lbX.Text) + valor);
        }

        private void Resta(string value)
        {
            int valor = GetValueFrom(value);
            SetY(valor);
            SetZ(Int32.Parse(lbX.Text) - valor);
        }

        private void Mul(string value)
        {
            int valor = GetValueFrom(value);
            SetY(valor);
            SetZ(Int32.Parse(lbX.Text) * valor);
        }

        private void Div(string value)
        {
            int valor = GetValueFrom(value);
            SetY(valor);
            SetZ(Int32.Parse(lbX.Text) / valor);
        }

        private int GetValueFrom(string value)
        {
            int num;
            if (int.TryParse(value, out num))
                return num;
            else
                return Int32.Parse(Vars.Rows[IndexOfVar(value)].Cells[1].Value.ToString());
        }

        private int IndexOfVar(string NV)
        {
            for (int i = 0; i < Vars.Rows.Count; i++)
            {
                if (Vars.Rows[i].Cells[0].Value.ToString().Equals(NV)) return i;
            }
            return -1;
        }

        public async Task Esperar(int valor)
        {
            await Task.Delay(valor);
        }

    }
}
