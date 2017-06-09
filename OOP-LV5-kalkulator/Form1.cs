using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting; //Pristup IronPython interpretreru
using IronPython.Runtime; //Pristup IronPython tipovima podataka
using Microsoft.Scripting; //DLR podrška
using Microsoft.Scripting.Hosting; 

namespace OOP_LV5_kalkulator
{
    public partial class Form1 : Form
    {
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;

        double prviBroj = 0;
        double drugiBroj = 0;
        public Form1()
        {
            InitializeComponent();

           

            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();

                }

        private void loadExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
            ScriptSource skript = pyEngine.CreateScriptSourceFromFile(openFileDialog1.FileName);
            skript.Execute(pyScope);
            Console.WriteLine(openFileDialog1.FileName);
            dynamic DodajFunkciju = pyScope.GetVariable("DodajFunkciju");
            DodajFunkciju(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prviBroj = Convert.ToDouble(tbPrvi.Text);
            drugiBroj = Convert.ToDouble(tbDrugi.Text);
            tbRez.Text = Convert.ToString( prviBroj + drugiBroj) ;
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prviBroj = Convert.ToDouble(tbPrvi.Text);
            drugiBroj = Convert.ToDouble(tbDrugi.Text);
            tbRez.Text = Convert.ToString(prviBroj - drugiBroj);
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prviBroj = Convert.ToDouble(tbPrvi.Text);
            drugiBroj = Convert.ToDouble(tbDrugi.Text);
            tbRez.Text = Convert.ToString(prviBroj * drugiBroj);
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prviBroj = Convert.ToDouble(tbPrvi.Text);
            drugiBroj = Convert.ToDouble(tbDrugi.Text);
            tbRez.Text = Convert.ToString(prviBroj / drugiBroj);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
