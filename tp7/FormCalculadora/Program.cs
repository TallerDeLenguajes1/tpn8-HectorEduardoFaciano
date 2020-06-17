using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculadora
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Calculadora
    {
        private float operando1;
        private float operando2;

        public float OP1 { get => operando1; set => operando1 = value; }
        public float OP2 { get => operando2; set => operando2 = value; }

        public float Suma()
        {
            return operando1 + operando2;
        }
        public float Resta()
        {
            return operando1 - operando2;
        }
        public float Multiplicacion()
        {
            return operando1 * operando2;
        }
        public float Division()
        {
            return operando1 / operando2;
        }
    }
}
