using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            functionPanel.Function = resultDisplay1.qe.Y;
        }

        private void ResultDisplay1_CoefficientsChanged(object sender, EventArgs e)
        {
            functionPanel.Invalidate();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            resultDisplay1.FillResults();
        }
    }
}
