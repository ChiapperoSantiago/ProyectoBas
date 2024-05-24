namespace proyectoBase
{
    partial class LoginUser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreDeUsuario = new System.Windows.Forms.Label();
            this.txtbNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtIniciarSesion = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.AutoSize = true;
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(40, 66);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(102, 13);
            this.txtNombreDeUsuario.TabIndex = 0;
            this.txtNombreDeUsuario.Text = "Nombre de usuario: ";
            // 
            // txtbNombreDeUsuario
            // 
            this.txtbNombreDeUsuario.Location = new System.Drawing.Point(144, 63);
            this.txtbNombreDeUsuario.Name = "txtbNombreDeUsuario";
            this.txtbNombreDeUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtbNombreDeUsuario.TabIndex = 1;
            this.txtbNombreDeUsuario.TextChanged += new System.EventHandler(this.txtbNombreDeUsuario_TextChanged);
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(144, 103);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.PasswordChar = '*';
            this.txtbContraseña.Size = new System.Drawing.Size(177, 20);
            this.txtbContraseña.TabIndex = 3;
            this.txtbContraseña.UseSystemPasswordChar = true;
            this.txtbContraseña.TextChanged += new System.EventHandler(this.txtbContraseña_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Location = new System.Drawing.Point(40, 106);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(67, 13);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(153, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 4;
            // 
            // txtIniciarSesion
            // 
            this.txtIniciarSesion.AutoSize = true;
            this.txtIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIniciarSesion.Location = new System.Drawing.Point(168, 20);
            this.txtIniciarSesion.Name = "txtIniciarSesion";
            this.txtIniciarSesion.Size = new System.Drawing.Size(101, 20);
            this.txtIniciarSesion.TabIndex = 5;
            this.txtIniciarSesion.Text = "Iniciar sesión";
            this.txtIniciarSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(194, 147);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 222);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtIniciarSesion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtbNombreDeUsuario);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Name = "LoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login User";
            this.Load += new System.EventHandler(this.LoginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombreDeUsuario;
        private System.Windows.Forms.TextBox txtbNombreDeUsuario;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label txtIniciarSesion;
        private System.Windows.Forms.Button btnIngresar;
    }
}

