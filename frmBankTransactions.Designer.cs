namespace MyAccountingSystem4
{
    partial class frmBankTransactions
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtISO = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNiceName = new System.Windows.Forms.TextBox();
            this.txtISO3 = new System.Windows.Forms.TextBox();
            this.txtNumCode = new System.Windows.Forms.TextBox();
            this.txtPhoneCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(700, 401);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "&MainMenu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(267, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Bank Transactions";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtISO
            // 
            this.txtISO.Location = new System.Drawing.Point(182, 72);
            this.txtISO.Name = "txtISO";
            this.txtISO.Size = new System.Drawing.Size(64, 20);
            this.txtISO.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtNiceName
            // 
            this.txtNiceName.Location = new System.Drawing.Point(182, 166);
            this.txtNiceName.Name = "txtNiceName";
            this.txtNiceName.Size = new System.Drawing.Size(264, 20);
            this.txtNiceName.TabIndex = 12;
            // 
            // txtISO3
            // 
            this.txtISO3.Location = new System.Drawing.Point(182, 206);
            this.txtISO3.Name = "txtISO3";
            this.txtISO3.Size = new System.Drawing.Size(52, 20);
            this.txtISO3.TabIndex = 13;
            // 
            // txtNumCode
            // 
            this.txtNumCode.Location = new System.Drawing.Point(182, 255);
            this.txtNumCode.Name = "txtNumCode";
            this.txtNumCode.Size = new System.Drawing.Size(52, 20);
            this.txtNumCode.TabIndex = 14;
            // 
            // txtPhoneCode
            // 
            this.txtPhoneCode.Location = new System.Drawing.Point(182, 301);
            this.txtPhoneCode.Name = "txtPhoneCode";
            this.txtPhoneCode.Size = new System.Drawing.Size(52, 20);
            this.txtPhoneCode.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(300, 401);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "&Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ISO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nice Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ISO3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Num Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Phone Code (Area Code):";
            // 
            // frmBankTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhoneCode);
            this.Controls.Add(this.txtNumCode);
            this.Controls.Add(this.txtISO3);
            this.Controls.Add(this.txtNiceName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtISO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmBankTransactions";
            this.Text = "frmBankTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtISO;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNiceName;
        private System.Windows.Forms.TextBox txtISO3;
        private System.Windows.Forms.TextBox txtNumCode;
        private System.Windows.Forms.TextBox txtPhoneCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}