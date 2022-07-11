namespace _07_Task_Performance_1___ARG
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PBX_PictureToGuess = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_WordToGuess = new System.Windows.Forms.Label();
            this.LBL_Score = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_PictureToGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess the image ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PBX_PictureToGuess);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(135, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // PBX_PictureToGuess
            // 
            this.PBX_PictureToGuess.Image = global::_07_Task_Performance_1___ARG.Properties.Resources.chad2;
            this.PBX_PictureToGuess.Location = new System.Drawing.Point(28, 35);
            this.PBX_PictureToGuess.Name = "PBX_PictureToGuess";
            this.PBX_PictureToGuess.Size = new System.Drawing.Size(198, 232);
            this.PBX_PictureToGuess.TabIndex = 2;
            this.PBX_PictureToGuess.TabStop = false;
            this.PBX_PictureToGuess.Click += new System.EventHandler(this.PBX_PictureToGuess_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "engk/noice";
            // 
            // LBL_WordToGuess
            // 
            this.LBL_WordToGuess.AutoSize = true;
            this.LBL_WordToGuess.Location = new System.Drawing.Point(242, 410);
            this.LBL_WordToGuess.Name = "LBL_WordToGuess";
            this.LBL_WordToGuess.Size = new System.Drawing.Size(42, 16);
            this.LBL_WordToGuess.TabIndex = 8;
            this.LBL_WordToGuess.Text = "#####";
            this.LBL_WordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_WordToGuess.Click += new System.EventHandler(this.LBL_WordToGuess_Click);
            // 
            // LBL_Score
            // 
            this.LBL_Score.AutoSize = true;
            this.LBL_Score.Location = new System.Drawing.Point(226, 38);
            this.LBL_Score.Name = "LBL_Score";
            this.LBL_Score.Size = new System.Drawing.Size(0, 16);
            this.LBL_Score.TabIndex = 9;
            this.LBL_Score.Click += new System.EventHandler(this.LBL_Score_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 601);
            this.Controls.Add(this.LBL_Score);
            this.Controls.Add(this.LBL_WordToGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_PictureToGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PBX_PictureToGuess;
        private System.Windows.Forms.Label LBL_WordToGuess;
        private System.Windows.Forms.Label LBL_Score;
    }
}

