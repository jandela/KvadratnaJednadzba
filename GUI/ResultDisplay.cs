using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJednadzba;

namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    public partial class ResultDisplay : UserControl
    {
        public ResultDisplay()
        {
            InitializeComponent();
        }

        public readonly global::KvadratnaJednadzba.QuadraticEquation qe = new global::KvadratnaJednadzba.QuadraticEquation();

        public void FillResults()
        {
            qe.A = (double)numericUpDowna.Value;
            qe.B = (double)numericUpDownb.Value;
            qe.C = (double)numericUpDownc.Value;

            double Discriminant = qe.Discriminant;
            textBoxDiscriminant.Text = Discriminant.ToString();

            textBoxRoot1.Text = qe.Roots[0].ToString();
            textBoxRoot2.Text = qe.Roots[1].ToString();

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }
    }
    
}
