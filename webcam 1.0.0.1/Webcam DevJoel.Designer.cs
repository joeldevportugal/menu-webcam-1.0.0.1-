namespace webcam_1._0._0._1
{
    partial class FreWebcam1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreWebcam1));
            this.picimagem = new System.Windows.Forms.PictureBox();
            this.picCopia = new System.Windows.Forms.PictureBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnCapturar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.CmbDevice = new System.Windows.Forms.ComboBox();
            this.BtnEncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopia)).BeginInit();
            this.SuspendLayout();
            // 
            // picimagem
            // 
            this.picimagem.BackColor = System.Drawing.Color.LightGray;
            this.picimagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimagem.Location = new System.Drawing.Point(24, 49);
            this.picimagem.Name = "picimagem";
            this.picimagem.Size = new System.Drawing.Size(507, 459);
            this.picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimagem.TabIndex = 0;
            this.picimagem.TabStop = false;
            // 
            // picCopia
            // 
            this.picCopia.BackColor = System.Drawing.Color.LightGray;
            this.picCopia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCopia.Location = new System.Drawing.Point(537, 50);
            this.picCopia.Name = "picCopia";
            this.picCopia.Size = new System.Drawing.Size(483, 459);
            this.picCopia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCopia.TabIndex = 1;
            this.picCopia.TabStop = false;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("BtnIniciar.Image")));
            this.BtnIniciar.Location = new System.Drawing.Point(24, 515);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(116, 49);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnCapturar
            // 
            this.BtnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCapturar.Image")));
            this.BtnCapturar.Location = new System.Drawing.Point(271, 514);
            this.BtnCapturar.Name = "BtnCapturar";
            this.BtnCapturar.Size = new System.Drawing.Size(115, 49);
            this.BtnCapturar.TabIndex = 3;
            this.BtnCapturar.UseVisualStyleBackColor = false;
            this.BtnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(537, 514);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 49);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.Location = new System.Drawing.Point(674, 514);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(124, 49);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(804, 515);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(124, 49);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // CmbDevice
            // 
            this.CmbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDevice.FormattingEnabled = true;
            this.CmbDevice.Location = new System.Drawing.Point(24, 9);
            this.CmbDevice.Name = "CmbDevice";
            this.CmbDevice.Size = new System.Drawing.Size(507, 33);
            this.CmbDevice.TabIndex = 7;
            // 
            // BtnEncerrar
            // 
            this.BtnEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEncerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEncerrar.Image")));
            this.BtnEncerrar.Location = new System.Drawing.Point(146, 514);
            this.BtnEncerrar.Name = "BtnEncerrar";
            this.BtnEncerrar.Size = new System.Drawing.Size(119, 49);
            this.BtnEncerrar.TabIndex = 8;
            this.BtnEncerrar.UseVisualStyleBackColor = false;
            this.BtnEncerrar.Click += new System.EventHandler(this.BtnEncerrar_Click);
            // 
            // FreWebcam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 570);
            this.Controls.Add(this.BtnEncerrar);
            this.Controls.Add(this.CmbDevice);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCapturar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.picCopia);
            this.Controls.Add(this.picimagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FreWebcam1";
            this.Text = "Webcam1 © Dev Joel 2024";
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimagem;
        private System.Windows.Forms.PictureBox picCopia;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.ComboBox CmbDevice;
        private System.Windows.Forms.Button BtnEncerrar;
    }
}

