using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Client
{
    public partial class mainForm : Form
    {
        private NetClientManager netCM;
        public mainForm()
        {
            InitializeComponent();
            netCM = new NetClientManager();
            netCM.Connected += netCM_Connected;
            netCM.Disconnected += netCM_Disconnected;
            netCM.ServerError += netCM_ServerError;
            netCM.MessageSent += netCM_MessageSent;
            netCM.NoMessages += netCM_NoMessages;
            netCM.MessagesReceived += netCM_MessagesReceived;
            rbBajo.Select();
        }

        void netCM_MessagesReceived(object sender, DictionaryEventArgs e)
        {
            dgvDataMsg.DataSource = e.Messages.Values;            
        }

        void netCM_NoMessages(object sender, EventArgs e)
        {
            MessageBox.Show("No hay mensajes disponibles", "Message sending application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void netCM_MessageSent(object sender, MessageEventArgs e)
        {
            MessageBox.Show("¡Mensaje entregado al servidor!", "Message sending application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMensaje.Text = "";
            rbBajo.Select();
        }

        void netCM_ServerError(object sender, EventArgs e)
        {
            MessageBox.Show("Ocurrió un error en la aplicación", "Message sending application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void netCM_Disconnected(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha perdido la comunicación con el servidor", "Message sending application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        void netCM_Connected(object sender, EventArgs e)
        {
            MessageBox.Show("Conexión exitosa", "Message sending application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                var checkedButton = mainPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                if (txtMensaje.Text == "")
                {
                    MessageBox.Show("No se puede enviar un mensaje vacío", "Message sending application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Library.Message newM = new Library.Message();
                    newM.Content = txtMensaje.Text;
                    newM.Importance = (Level)Enum.Parse(typeof(Level), checkedButton.Text);
                    netCM.SendMessage(newM);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnGetMsg_Click(object sender, EventArgs e)
        {
            try
            {

                var checkedButton = mainPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                //Library.Message newM = new Library.Message();
                //newM.Content = txtMensaje.Text;
                //newM.Importance = (Level)Enum.Parse(typeof(Level), checkedButton.Text);
                netCM.GetMessagesByType((Level)Enum.Parse(typeof(Level), checkedButton.Text));                
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
