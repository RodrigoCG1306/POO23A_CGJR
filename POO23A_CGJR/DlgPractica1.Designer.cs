namespace POO23A_CGJR
{
    partial class DlgPractica1
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
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.Btn100Calc = new System.Windows.Forms.Button();
            this.BtnFigura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.Location = new System.Drawing.Point(12, 12);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Size = new System.Drawing.Size(116, 21);
            this.BtnCalculadora.TabIndex = 0;
            this.BtnCalculadora.Text = "Calculadora básica";
            this.BtnCalculadora.UseVisualStyleBackColor = true;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // Btn100Calc
            // 
            this.Btn100Calc.Location = new System.Drawing.Point(12, 39);
            this.Btn100Calc.Name = "Btn100Calc";
            this.Btn100Calc.Size = new System.Drawing.Size(116, 21);
            this.Btn100Calc.TabIndex = 1;
            this.Btn100Calc.Text = "100 Calculadoras";
            this.Btn100Calc.UseVisualStyleBackColor = true;
            this.Btn100Calc.Click += new System.EventHandler(this.Btn100Calc_Click);
            // 
            // BtnFigura
            // 
            this.BtnFigura.Location = new System.Drawing.Point(12, 66);
            this.BtnFigura.Name = "BtnFigura";
            this.BtnFigura.Size = new System.Drawing.Size(116, 21);
            this.BtnFigura.TabIndex = 2;
            this.BtnFigura.Text = "Figura";
            this.BtnFigura.UseVisualStyleBackColor = true;
            this.BtnFigura.Click += new System.EventHandler(this.BtnFigura_Click);
            // 
            // DlgPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFigura);
            this.Controls.Add(this.Btn100Calc);
            this.Controls.Add(this.BtnCalculadora);
            this.Name = "DlgPractica1";
            this.Text = "DlgPractica1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCalculadora;
        private Button Btn100Calc;
        private Button BtnFigura;
    }
}