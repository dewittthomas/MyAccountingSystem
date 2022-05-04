namespace MyAccountingSystem4
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBankAcct = new System.Windows.Forms.Button();
            this.btnBankTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(980, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Accounting System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnBankAcct
            // 
            this.btnBankAcct.Location = new System.Drawing.Point(27, 93);
            this.btnBankAcct.Name = "btnBankAcct";
            this.btnBankAcct.Size = new System.Drawing.Size(139, 31);
            this.btnBankAcct.TabIndex = 3;
            this.btnBankAcct.Text = "&Bank Account";
            this.btnBankAcct.UseVisualStyleBackColor = true;
            this.btnBankAcct.Click += new System.EventHandler(this.btnBankAcct_Click);
            // 
            // btnBankTrans
            // 
            this.btnBankTrans.Location = new System.Drawing.Point(27, 139);
            this.btnBankTrans.Name = "btnBankTrans";
            this.btnBankTrans.Size = new System.Drawing.Size(139, 31);
            this.btnBankTrans.TabIndex = 6;
            this.btnBankTrans.Text = "&Bank Transactions";
            this.btnBankTrans.UseVisualStyleBackColor = true;
            this.btnBankTrans.Click += new System.EventHandler(this.btnBankTrans_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 532);
            this.Controls.Add(this.btnBankTrans);
            this.Controls.Add(this.btnBankAcct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBankAcct;
        private System.Windows.Forms.Button btnBankTrans;
    }
}

