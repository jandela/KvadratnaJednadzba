
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class ResultDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowna = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRoot2 = new System.Windows.Forms.TextBox();
            this.textBoxRoot1 = new System.Windows.Forms.TextBox();
            this.textBoxDiscriminant = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownc);
            this.groupBox1.Controls.Add(this.numericUpDownb);
            this.groupBox1.Controls.Add(this.numericUpDowna);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coeficients";
            // 
            // numericUpDownc
            // 
            this.numericUpDownc.DecimalPlaces = 2;
            this.numericUpDownc.Location = new System.Drawing.Point(55, 102);
            this.numericUpDownc.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownc.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownc.Name = "numericUpDownc";
            this.numericUpDownc.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownc.TabIndex = 5;
            this.numericUpDownc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownc.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownb
            // 
            this.numericUpDownb.DecimalPlaces = 2;
            this.numericUpDownb.Location = new System.Drawing.Point(55, 71);
            this.numericUpDownb.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownb.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownb.Name = "numericUpDownb";
            this.numericUpDownb.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownb.TabIndex = 4;
            this.numericUpDownb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownb.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDowna
            // 
            this.numericUpDowna.DecimalPlaces = 2;
            this.numericUpDowna.Location = new System.Drawing.Point(55, 39);
            this.numericUpDowna.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDowna.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDowna.Name = "numericUpDowna";
            this.numericUpDowna.Size = new System.Drawing.Size(120, 22);
            this.numericUpDowna.TabIndex = 3;
            this.numericUpDowna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDowna.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&c:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "&b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Discriminant:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRoot2);
            this.groupBox2.Controls.Add(this.textBoxRoot1);
            this.groupBox2.Location = new System.Drawing.Point(38, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Roots";
            // 
            // textBoxRoot2
            // 
            this.textBoxRoot2.Location = new System.Drawing.Point(22, 68);
            this.textBoxRoot2.Name = "textBoxRoot2";
            this.textBoxRoot2.ReadOnly = true;
            this.textBoxRoot2.Size = new System.Drawing.Size(278, 22);
            this.textBoxRoot2.TabIndex = 1;
            this.textBoxRoot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRoot1
            // 
            this.textBoxRoot1.Location = new System.Drawing.Point(22, 31);
            this.textBoxRoot1.Name = "textBoxRoot1";
            this.textBoxRoot1.ReadOnly = true;
            this.textBoxRoot1.Size = new System.Drawing.Size(278, 22);
            this.textBoxRoot1.TabIndex = 0;
            this.textBoxRoot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDiscriminant
            // 
            this.textBoxDiscriminant.Location = new System.Drawing.Point(159, 246);
            this.textBoxDiscriminant.Name = "textBoxDiscriminant";
            this.textBoxDiscriminant.ReadOnly = true;
            this.textBoxDiscriminant.Size = new System.Drawing.Size(179, 22);
            this.textBoxDiscriminant.TabIndex = 4;
            this.textBoxDiscriminant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDiscriminant);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultDisplay";
            this.Size = new System.Drawing.Size(393, 431);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownc;
        private System.Windows.Forms.NumericUpDown numericUpDownb;
        private System.Windows.Forms.NumericUpDown numericUpDowna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRoot2;
        private System.Windows.Forms.TextBox textBoxRoot1;
        private System.Windows.Forms.TextBox textBoxDiscriminant;
    }
}
