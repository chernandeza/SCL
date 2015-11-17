namespace Client
{
    partial class mainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblEscriba = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.rbBajo = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.rbCritico = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbDebug = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnEnviar);
            this.mainPanel.Controls.Add(this.rbDebug);
            this.mainPanel.Controls.Add(this.rbError);
            this.mainPanel.Controls.Add(this.rbCritico);
            this.mainPanel.Controls.Add(this.rbAlto);
            this.mainPanel.Controls.Add(this.rbBajo);
            this.mainPanel.Controls.Add(this.lblCriticidad);
            this.mainPanel.Controls.Add(this.txtMensaje);
            this.mainPanel.Controls.Add(this.lblEscriba);
            this.mainPanel.Location = new System.Drawing.Point(13, 13);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(388, 230);
            this.mainPanel.TabIndex = 0;
            // 
            // lblEscriba
            // 
            this.lblEscriba.AutoSize = true;
            this.lblEscriba.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscriba.Location = new System.Drawing.Point(4, 4);
            this.lblEscriba.Name = "lblEscriba";
            this.lblEscriba.Size = new System.Drawing.Size(152, 18);
            this.lblEscriba.TabIndex = 0;
            this.lblEscriba.Text = "Escriba su mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(3, 25);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(378, 64);
            this.txtMensaje.TabIndex = 1;
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticidad.Location = new System.Drawing.Point(4, 92);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(152, 18);
            this.lblCriticidad.TabIndex = 2;
            this.lblCriticidad.Text = "Escoja la urgencia";
            // 
            // rbBajo
            // 
            this.rbBajo.AutoSize = true;
            this.rbBajo.Location = new System.Drawing.Point(7, 113);
            this.rbBajo.Name = "rbBajo";
            this.rbBajo.Size = new System.Drawing.Size(45, 17);
            this.rbBajo.TabIndex = 3;
            this.rbBajo.TabStop = true;
            this.rbBajo.Text = "Low";
            this.rbBajo.UseVisualStyleBackColor = true;
            // 
            // rbAlto
            // 
            this.rbAlto.AutoSize = true;
            this.rbAlto.Location = new System.Drawing.Point(7, 136);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(65, 17);
            this.rbAlto.TabIndex = 4;
            this.rbAlto.TabStop = true;
            this.rbAlto.Text = "Warning";
            this.rbAlto.UseVisualStyleBackColor = true;
            // 
            // rbCritico
            // 
            this.rbCritico.AutoSize = true;
            this.rbCritico.Location = new System.Drawing.Point(7, 159);
            this.rbCritico.Name = "rbCritico";
            this.rbCritico.Size = new System.Drawing.Size(47, 17);
            this.rbCritico.TabIndex = 5;
            this.rbCritico.TabStop = true;
            this.rbCritico.Text = "Error";
            this.rbCritico.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(7, 182);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(56, 17);
            this.rbError.TabIndex = 6;
            this.rbError.TabStop = true;
            this.rbError.Text = "Critical";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // rbDebug
            // 
            this.rbDebug.AutoSize = true;
            this.rbDebug.Location = new System.Drawing.Point(7, 206);
            this.rbDebug.Name = "rbDebug";
            this.rbDebug.Size = new System.Drawing.Size(57, 17);
            this.rbDebug.TabIndex = 7;
            this.rbDebug.TabStop = true;
            this.rbDebug.Text = "Debug";
            this.rbDebug.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(209, 136);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(172, 63);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Mensaje";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 255);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Text Message Sending Application";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RadioButton rbDebug;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbCritico;
        private System.Windows.Forms.RadioButton rbAlto;
        private System.Windows.Forms.RadioButton rbBajo;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblEscriba;
    }
}

