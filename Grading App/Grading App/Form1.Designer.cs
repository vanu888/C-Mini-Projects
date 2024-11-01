namespace Grading_App
{
    partial class FrmGradeApp
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
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAvarage = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(45, 39);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(36, 13);
            this.lblMaths.TabIndex = 0;
            this.lblMaths.Text = "Maths";
            this.lblMaths.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(45, 78);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(46, 13);
            this.lblScience.TabIndex = 1;
            this.lblScience.Text = "Science";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculate.Location = new System.Drawing.Point(48, 153);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 49);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReset.ForeColor = System.Drawing.Color.DarkRed;
            this.btnReset.Location = new System.Drawing.Point(234, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 49);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(142, 32);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(178, 20);
            this.txtMaths.TabIndex = 4;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(142, 71);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(178, 20);
            this.txtScience.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(45, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblAvarage
            // 
            this.lblAvarage.AutoSize = true;
            this.lblAvarage.Location = new System.Drawing.Point(231, 227);
            this.lblAvarage.Name = "lblAvarage";
            this.lblAvarage.Size = new System.Drawing.Size(47, 13);
            this.lblAvarage.TabIndex = 7;
            this.lblAvarage.Text = "Avarage";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(137, 272);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(80, 29);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade";
            // 
            // FrmGradeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAvarage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtScience);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.lblMaths);
            this.Name = "FrmGradeApp";
            this.Text = "Grade App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAvarage;
        private System.Windows.Forms.Label lblGrade;
    }
}

