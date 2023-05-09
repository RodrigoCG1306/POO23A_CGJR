namespace POO23A_CGJR
{
    partial class DlgSeleccionPractica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgSeleccionPractica));
            this.PBSelecciónPractica = new System.Windows.Forms.PictureBox();
            this.BtnPractica1 = new System.Windows.Forms.Button();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnPractica2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelecciónPractica)).BeginInit();
            this.SuspendLayout();
            // 
            // PBSelecciónPractica
            // 
            this.PBSelecciónPractica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBSelecciónPractica.Image = global::POO23A_CGJR.Properties.Resources.Selección_de_Agentes;
            this.PBSelecciónPractica.Location = new System.Drawing.Point(0, 0);
            this.PBSelecciónPractica.Name = "PBSelecciónPractica";
            this.PBSelecciónPractica.Size = new System.Drawing.Size(1350, 729);
            this.PBSelecciónPractica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSelecciónPractica.TabIndex = 0;
            this.PBSelecciónPractica.TabStop = false;
            // 
            // BtnPractica1
            // 
            this.BtnPractica1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPractica1.BackgroundImage")));
            this.BtnPractica1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPractica1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica1.Location = new System.Drawing.Point(380, 596);
            this.BtnPractica1.Name = "BtnPractica1";
            this.BtnPractica1.Size = new System.Drawing.Size(58, 57);
            this.BtnPractica1.TabIndex = 2;
            this.BtnPractica1.UseVisualStyleBackColor = true;
            this.BtnPractica1.Click += new System.EventHandler(this.BtnPractica1_Click);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.BackColor = System.Drawing.Color.Turquoise;
            this.BtnEjecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEjecutar.BackgroundImage")));
            this.BtnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEjecutar.Enabled = false;
            this.BtnEjecutar.FlatAppearance.BorderSize = 0;
            this.BtnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEjecutar.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEjecutar.ForeColor = System.Drawing.Color.White;
            this.BtnEjecutar.Location = new System.Drawing.Point(589, 527);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(173, 45);
            this.BtnEjecutar.TabIndex = 3;
            this.BtnEjecutar.UseVisualStyleBackColor = false;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnPractica1Exe_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(1294, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(56, 52);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnPractica2
            // 
            this.BtnPractica2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPractica2.BackgroundImage")));
            this.BtnPractica2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPractica2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica2.Location = new System.Drawing.Point(381, 654);
            this.BtnPractica2.Name = "BtnPractica2";
            this.BtnPractica2.Size = new System.Drawing.Size(58, 57);
            this.BtnPractica2.TabIndex = 5;
            this.BtnPractica2.UseVisualStyleBackColor = true;
            this.BtnPractica2.Click += new System.EventHandler(this.BtnPractica2_Click);
            // 
            // DlgSeleccionPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BtnPractica2);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnPractica1);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.PBSelecciónPractica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgSeleccionPractica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgSeleccionPractica";
            ((System.ComponentModel.ISupportInitialize)(this.PBSelecciónPractica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PBSelecciónPractica;
        private Button BtnPractica1;
        private Button BtnEjecutar;
        private Button BtnCerrar;
        private Button BtnPractica2;
    }
}