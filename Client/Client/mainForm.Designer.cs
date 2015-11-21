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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rbDebug = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbCritico = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.rbBajo = new System.Windows.Forms.RadioButton();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblEscriba = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDataMsg = new System.Windows.Forms.DataGridView();
            this.btnGetMsg = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMsg)).BeginInit();
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
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(3, 25);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(378, 64);
            this.txtMensaje.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.btnGetMsg);
            this.panel1.Controls.Add(this.dgvDataMsg);
            this.panel1.Location = new System.Drawing.Point(407, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 230);
            this.panel1.TabIndex = 1;
            // 
            // dgvDataMsg
            // 
            this.dgvDataMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMsg.Location = new System.Drawing.Point(4, 4);
            this.dgvDataMsg.Name = "dgvDataMsg";
            this.dgvDataMsg.Size = new System.Drawing.Size(483, 149);
            this.dgvDataMsg.TabIndex = 0;
            // 
            // btnGetMsg
            // 
            this.btnGetMsg.Location = new System.Drawing.Point(378, 159);
            this.btnGetMsg.Name = "btnGetMsg";
            this.btnGetMsg.Size = new System.Drawing.Size(109, 61);
            this.btnGetMsg.TabIndex = 1;
            this.btnGetMsg.Text = "Obtener Mensajes";
            this.btnGetMsg.UseVisualStyleBackColor = true;
            this.btnGetMsg.Click += new System.EventHandler(this.btnGetMsg_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(219, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Debug";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 182);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Critical";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(120, 161);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Error";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 184);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Warning";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(4, 161);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(45, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Low";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Text Message Sending Application";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMsg)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button btnGetMsg;
        private System.Windows.Forms.DataGridView dgvDataMsg;
    }
}

