namespace geolocalizador_de_ip
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnGeolocalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblGeolocalizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.txbIpPublico = new System.Windows.Forms.TextBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.lblOBS = new System.Windows.Forms.Label();
            this.lblIpPublico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeolocalizar
            // 
            this.btnGeolocalizar.BackColor = System.Drawing.Color.White;
            this.btnGeolocalizar.BackgroundImage = global::geolocalizador_de_ip.Properties.Resources.geolocalizacao;
            this.btnGeolocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeolocalizar.Location = new System.Drawing.Point(61, 77);
            this.btnGeolocalizar.Name = "btnGeolocalizar";
            this.btnGeolocalizar.Size = new System.Drawing.Size(100, 100);
            this.btnGeolocalizar.TabIndex = 0;
            this.btnGeolocalizar.UseVisualStyleBackColor = false;
            this.btnGeolocalizar.Click += new System.EventHandler(this.btnGeolocalizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = global::geolocalizador_de_ip.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(167, 77);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 100);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblGeolocalizar
            // 
            this.lblGeolocalizar.AutoSize = true;
            this.lblGeolocalizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeolocalizar.Location = new System.Drawing.Point(62, 180);
            this.lblGeolocalizar.Name = "lblGeolocalizar";
            this.lblGeolocalizar.Size = new System.Drawing.Size(99, 17);
            this.lblGeolocalizar.TabIndex = 2;
            this.lblGeolocalizar.Text = "Geolocalizar IP";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSair.Location = new System.Drawing.Point(201, 180);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(31, 17);
            this.lblSair.TabIndex = 3;
            this.lblSair.Text = "Sair";
            // 
            // txbIpPublico
            // 
            this.txbIpPublico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIpPublico.ForeColor = System.Drawing.Color.Black;
            this.txbIpPublico.Location = new System.Drawing.Point(62, 35);
            this.txbIpPublico.Name = "txbIpPublico";
            this.txbIpPublico.Size = new System.Drawing.Size(170, 25);
            this.txbIpPublico.TabIndex = 4;
            this.txbIpPublico.TextChanged += new System.EventHandler(this.FormMenu_Load);
            this.txbIpPublico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIpPublico_KeyPress);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.White;
            this.btnRecarregar.BackgroundImage = global::geolocalizador_de_ip.Properties.Resources.refresh;
            this.btnRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecarregar.Location = new System.Drawing.Point(237, 35);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(30, 30);
            this.btnRecarregar.TabIndex = 5;
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // lblOBS
            // 
            this.lblOBS.AutoSize = true;
            this.lblOBS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOBS.Location = new System.Drawing.Point(12, 209);
            this.lblOBS.Name = "lblOBS";
            this.lblOBS.Size = new System.Drawing.Size(310, 13);
            this.lblOBS.TabIndex = 6;
            this.lblOBS.Text = "*Localização de coordenadas e código postal aproximadas.";
            // 
            // lblIpPublico
            // 
            this.lblIpPublico.AutoSize = true;
            this.lblIpPublico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIpPublico.Location = new System.Drawing.Point(61, 19);
            this.lblIpPublico.Name = "lblIpPublico";
            this.lblIpPublico.Size = new System.Drawing.Size(114, 13);
            this.lblIpPublico.TabIndex = 7;
            this.lblIpPublico.Text = "Digite um IP público:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(334, 246);
            this.Controls.Add(this.lblIpPublico);
            this.Controls.Add(this.lblOBS);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.txbIpPublico);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblGeolocalizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGeolocalizar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geolocalizador de IP";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGeolocalizar;
        private Button btnSair;
        private Label lblGeolocalizar;
        private Label lblSair;
        private TextBox txbIpPublico;
        private Button btnRecarregar;
        private Label lblOBS;
        private Label lblIpPublico;
    }
}