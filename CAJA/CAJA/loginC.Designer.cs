namespace CAJA
{
    partial class loginC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtBox_contrasena = new System.Windows.Forms.TextBox();
            this.txtBox_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasena_login = new System.Windows.Forms.Label();
            this.txt_usuario_login = new System.Windows.Forms.Label();
            this.img_logo_login = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txtBox_contrasena);
            this.panel1.Controls.Add(this.txtBox_usuario);
            this.panel1.Controls.Add(this.txt_contrasena_login);
            this.panel1.Controls.Add(this.txt_usuario_login);
            this.panel1.Location = new System.Drawing.Point(319, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 295);
            this.panel1.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(7)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(158)))), ((int)(((byte)(7)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_login.Location = new System.Drawing.Point(145, 226);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 37);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtBox_contrasena
            // 
            this.txtBox_contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBox_contrasena.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_contrasena.Location = new System.Drawing.Point(79, 172);
            this.txtBox_contrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_contrasena.Name = "txtBox_contrasena";
            this.txtBox_contrasena.Size = new System.Drawing.Size(263, 28);
            this.txtBox_contrasena.TabIndex = 3;
            this.txtBox_contrasena.UseSystemPasswordChar = true;
            // 
            // txtBox_usuario
            // 
            this.txtBox_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBox_usuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBox_usuario.Location = new System.Drawing.Point(79, 70);
            this.txtBox_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_usuario.Name = "txtBox_usuario";
            this.txtBox_usuario.Size = new System.Drawing.Size(263, 28);
            this.txtBox_usuario.TabIndex = 2;
            // 
            // txt_contrasena_login
            // 
            this.txt_contrasena_login.AutoSize = true;
            this.txt_contrasena_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_contrasena_login.Location = new System.Drawing.Point(73, 134);
            this.txt_contrasena_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_contrasena_login.Name = "txt_contrasena_login";
            this.txt_contrasena_login.Size = new System.Drawing.Size(123, 23);
            this.txt_contrasena_login.TabIndex = 1;
            this.txt_contrasena_login.Text = "Contraseña";
            // 
            // txt_usuario_login
            // 
            this.txt_usuario_login.AutoSize = true;
            this.txt_usuario_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_login.Location = new System.Drawing.Point(73, 32);
            this.txt_usuario_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_usuario_login.Name = "txt_usuario_login";
            this.txt_usuario_login.Size = new System.Drawing.Size(81, 23);
            this.txt_usuario_login.TabIndex = 0;
            this.txt_usuario_login.Text = "Usuario";
            // 
            // img_logo_login
            // 
            this.img_logo_login.Image = ((System.Drawing.Image)(resources.GetObject("img_logo_login.Image")));
            this.img_logo_login.ImageLocation = "";
            this.img_logo_login.Location = new System.Drawing.Point(367, 15);
            this.img_logo_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_logo_login.Name = "img_logo_login";
            this.img_logo_login.Size = new System.Drawing.Size(329, 145);
            this.img_logo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_logo_login.TabIndex = 1;
            this.img_logo_login.TabStop = false;
            // 
            // loginC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(6)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.img_logo_login);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loginC";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_usuario_login;
        private System.Windows.Forms.Label txt_contrasena_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtBox_contrasena;
        private System.Windows.Forms.TextBox txtBox_usuario;
        private System.Windows.Forms.PictureBox img_logo_login;
    }
}

