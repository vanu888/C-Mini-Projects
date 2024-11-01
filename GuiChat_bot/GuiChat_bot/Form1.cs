using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiChat_bot
{
    public partial class FrmChatBot : Form
    {
        public FrmChatBot()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblBotOutput.Text = Convert.ToString("Hello");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String UserInput = txtInput.Text;
            if (String.IsNullOrEmpty(UserInput))
            {
                MessageBox.Show("Please send a message");
            }
            else
            {
                if (UserInput == "hi")
                {
                    lblBotOutput.Text = Convert.ToString("Hi, How can I assist you today?");
                    txtInput.Clear();

                }
                else if (UserInput == "how are you?")
                {
                    lblBotOutput.Text = Convert.ToString("I'm fine, and you?");
                    txtInput.Clear();
                }
                else if (UserInput == "bye" || UserInput == "exit")
                {
                    System.Windows.Forms.Application.Exit();

                }
                else
                {
                    lblBotOutput.Text = Convert.ToString("Sorry, I didn't understand that ;(");
                    txtInput.Clear();

                }
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     }
}
