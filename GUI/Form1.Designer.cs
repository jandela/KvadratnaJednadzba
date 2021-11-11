using KvadratnaJednadzba;

namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.functionPanel = new Vsite.CSharp.KvadratnaJednadzba.Gui.FunctionPanel();
            this.resultDisplay1 = new Vsite.CSharp.KvadratnaJednadzba.Gui.ResultDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // functionPanel
            // 
            this.functionPanel.BackColor = System.Drawing.Color.Transparent;
            this.functionPanel.Location = new System.Drawing.Point(347, 12);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(463, 426);
            this.functionPanel.TabIndex = 1;
            this.functionPanel.TabStop = false;
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(0, 12);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultDisplay1.Size = new System.Drawing.Size(341, 426);
            this.resultDisplay1.TabIndex = 0;
            this.resultDisplay1.CoefficientsChanged += ResultDisplay1_CoefficientsChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.resultDisplay1);
            this.Controls.Add(this.functionPanel);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FunctionPanel functionPanel;
        public ResultDisplay resultDisplay1;
    }
}

