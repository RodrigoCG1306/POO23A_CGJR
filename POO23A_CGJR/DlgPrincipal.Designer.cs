namespace POO23A_CGJR
{
    partial class DlgPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPrincipal));
            this.btnPruebas1 = new System.Windows.Forms.Button();
            this.LblIniciar = new System.Windows.Forms.Label();
            this.POO = new System.Windows.Forms.Label();
            this.PnlKRU = new System.Windows.Forms.Panel();
            this.PnlGrupo = new System.Windows.Forms.Panel();
            this.PbValorant = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbValorant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPruebas1
            // 
            this.btnPruebas1.Location = new System.Drawing.Point(1749, 6);
            this.btnPruebas1.Name = "btnPruebas1";
            this.btnPruebas1.Size = new System.Drawing.Size(152, 28);
            this.btnPruebas1.TabIndex = 0;
            this.btnPruebas1.Text = "Maximizar";
            this.btnPruebas1.UseVisualStyleBackColor = true;
            this.btnPruebas1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblIniciar
            // 
            this.LblIniciar.AutoSize = true;
            this.LblIniciar.BackColor = System.Drawing.Color.Transparent;
            this.LblIniciar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIniciar.ForeColor = System.Drawing.Color.Firebrick;
            this.LblIniciar.Location = new System.Drawing.Point(-5, 62);
            this.LblIniciar.Name = "LblIniciar";
            this.LblIniciar.Size = new System.Drawing.Size(176, 77);
            this.LblIniciar.TabIndex = 3;
            this.LblIniciar.Text = "Jugar";
            this.LblIniciar.Click += new System.EventHandler(this.LblIniciar_Click);
            // 
            // POO
            // 
            this.POO.AutoSize = true;
            this.POO.BackColor = System.Drawing.Color.Transparent;
            this.POO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.POO.ForeColor = System.Drawing.Color.White;
            this.POO.Location = new System.Drawing.Point(12, 12);
            this.POO.Name = "POO";
            this.POO.Size = new System.Drawing.Size(99, 20);
            this.POO.TabIndex = 4;
            this.POO.Text = "POO CGJR";
            // 
            // PnlKRU
            // 
            this.PnlKRU.AutoScroll = true;
            this.PnlKRU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlKRU.BackgroundImage")));
            this.PnlKRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlKRU.Location = new System.Drawing.Point(1623, 84);
            this.PnlKRU.Name = "PnlKRU";
            this.PnlKRU.Size = new System.Drawing.Size(269, 264);
            this.PnlKRU.TabIndex = 5;
            // 
            // PnlGrupo
            // 
            this.PnlGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlGrupo.BackgroundImage")));
            this.PnlGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlGrupo.Location = new System.Drawing.Point(1623, 354);
            this.PnlGrupo.Name = "PnlGrupo";
            this.PnlGrupo.Size = new System.Drawing.Size(269, 136);
            this.PnlGrupo.TabIndex = 6;
            // 
            // PbValorant
            // 
            this.PbValorant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbValorant.Image = global::POO23A_CGJR.Properties.Resources.Valo__1_;
            this.PbValorant.Location = new System.Drawing.Point(0, 0);
            this.PbValorant.Name = "PbValorant";
            this.PbValorant.Size = new System.Drawing.Size(1370, 749);
            this.PbValorant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbValorant.TabIndex = 7;
            this.PbValorant.TabStop = false;
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POO23A_CGJR.Properties.Resources.Valo__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PnlGrupo);
            this.Controls.Add(this.PnlKRU);
            this.Controls.Add(this.POO);
            this.Controls.Add(this.LblIniciar);
            this.Controls.Add(this.btnPruebas1);
            this.Controls.Add(this.PbValorant);
            this.DoubleBuffered = true;
            this.Name = "DlgPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PbValorant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPruebas1;
        private Label LblIniciar;
        private Label POO;
        private Panel PnlKRU;
        private Panel PnlGrupo;
        private PictureBox PbValorant;
    }
}