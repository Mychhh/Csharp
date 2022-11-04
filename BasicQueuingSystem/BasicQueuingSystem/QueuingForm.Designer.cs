namespace BasicQueuingSystem
{
    partial class QueuingForm
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
            this.btnCashier = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblPositionInQueue = new System.Windows.Forms.Label();
            this.lblGetNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCashier
            // 
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Location = new System.Drawing.Point(47, 130);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(193, 155);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(394, 174);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(258, 55);
            this.lblQueue.TabIndex = 1;
            this.lblQueue.Text = "---------------";
            // 
            // lblPositionInQueue
            // 
            this.lblPositionInQueue.AutoSize = true;
            this.lblPositionInQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionInQueue.Location = new System.Drawing.Point(442, 130);
            this.lblPositionInQueue.Name = "lblPositionInQueue";
            this.lblPositionInQueue.Size = new System.Drawing.Size(141, 20);
            this.lblPositionInQueue.TabIndex = 2;
            this.lblPositionInQueue.Text = "Position in Queue";
            // 
            // lblGetNumber
            // 
            this.lblGetNumber.AutoSize = true;
            this.lblGetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetNumber.ForeColor = System.Drawing.Color.Red;
            this.lblGetNumber.Location = new System.Drawing.Point(57, 298);
            this.lblGetNumber.Name = "lblGetNumber";
            this.lblGetNumber.Size = new System.Drawing.Size(174, 20);
            this.lblGetNumber.TabIndex = 3;
            this.lblGetNumber.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGetNumber);
            this.Controls.Add(this.lblPositionInQueue);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.btnCashier);
            this.Name = "QueuingForm";
            this.Text = "QueuingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblPositionInQueue;
        private System.Windows.Forms.Label lblGetNumber;
    }
}

