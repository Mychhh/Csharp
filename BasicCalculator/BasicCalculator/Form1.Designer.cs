namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.lbl_BasicCalculator = new System.Windows.Forms.Label();
            this.txtBox_number1 = new System.Windows.Forms.TextBox();
            this.txtBox_number2 = new System.Windows.Forms.TextBox();
            this.txtBox_Results = new System.Windows.Forms.TextBox();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_BasicCalculator
            // 
            this.lbl_BasicCalculator.AutoSize = true;
            this.lbl_BasicCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BasicCalculator.Location = new System.Drawing.Point(30, 51);
            this.lbl_BasicCalculator.Name = "lbl_BasicCalculator";
            this.lbl_BasicCalculator.Size = new System.Drawing.Size(236, 32);
            this.lbl_BasicCalculator.TabIndex = 0;
            this.lbl_BasicCalculator.Text = "Basic Calculator";
            // 
            // txtBox_number1
            // 
            this.txtBox_number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_number1.Location = new System.Drawing.Point(41, 110);
            this.txtBox_number1.Multiline = true;
            this.txtBox_number1.Name = "txtBox_number1";
            this.txtBox_number1.Size = new System.Drawing.Size(342, 51);
            this.txtBox_number1.TabIndex = 1;
            this.txtBox_number1.Text = "0";
            // 
            // txtBox_number2
            // 
            this.txtBox_number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_number2.Location = new System.Drawing.Point(41, 227);
            this.txtBox_number2.Multiline = true;
            this.txtBox_number2.Name = "txtBox_number2";
            this.txtBox_number2.Size = new System.Drawing.Size(342, 51);
            this.txtBox_number2.TabIndex = 2;
            this.txtBox_number2.Text = "0";
            // 
            // txtBox_Results
            // 
            this.txtBox_Results.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBox_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBox_Results.Location = new System.Drawing.Point(41, 308);
            this.txtBox_Results.Multiline = true;
            this.txtBox_Results.Name = "txtBox_Results";
            this.txtBox_Results.Size = new System.Drawing.Size(342, 108);
            this.txtBox_Results.TabIndex = 3;
            // 
            // btn_Compute
            // 
            this.btn_Compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compute.Location = new System.Drawing.Point(134, 436);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(152, 47);
            this.btn_Compute.TabIndex = 4;
            this.btn_Compute.Text = "Compute";
            this.btn_Compute.UseVisualStyleBackColor = true;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(262, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 5;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 504);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.txtBox_Results);
            this.Controls.Add(this.txtBox_number2);
            this.Controls.Add(this.txtBox_number1);
            this.Controls.Add(this.lbl_BasicCalculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBasicCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BasicCalculator;
        private System.Windows.Forms.TextBox txtBox_number1;
        private System.Windows.Forms.TextBox txtBox_number2;
        private System.Windows.Forms.TextBox txtBox_Results;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

