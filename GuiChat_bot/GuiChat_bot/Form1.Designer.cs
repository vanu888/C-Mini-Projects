namespace GuiChat_bot
{
    partial class FrmChatBot
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
            this.lblUserInput = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBot = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBotOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserInput
            // 
            this.lblUserInput.AutoSize = true;
            this.lblUserInput.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInput.ForeColor = System.Drawing.Color.Aqua;
            this.lblUserInput.Location = new System.Drawing.Point(22, 148);
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(60, 21);
            this.lblUserInput.TabIndex = 0;
            this.lblUserInput.Text = "You : ";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Brown;
            this.btnSend.Location = new System.Drawing.Point(78, 193);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 32);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(78, 148);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(208, 20);
            this.txtInput.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblWelcome.Location = new System.Drawing.Point(22, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(276, 23);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome, I\'m a chat bot";
            // 
            // lblBot
            // 
            this.lblBot.AutoSize = true;
            this.lblBot.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBot.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblBot.Location = new System.Drawing.Point(23, 65);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(53, 21);
            this.lblBot.TabIndex = 4;
            this.lblBot.Text = "Bot :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(211, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBotOutput
            // 
            this.lblBotOutput.AutoSize = true;
            this.lblBotOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotOutput.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblBotOutput.Location = new System.Drawing.Point(74, 65);
            this.lblBotOutput.Name = "lblBotOutput";
            this.lblBotOutput.Size = new System.Drawing.Size(45, 20);
            this.lblBotOutput.TabIndex = 6;
            this.lblBotOutput.Text = "Hello";
            // 
            // FrmChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.lblBotOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBot);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblUserInput);
            this.Name = "FrmChatBot";
            this.Text = "Chat Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBotOutput;
    }
}

