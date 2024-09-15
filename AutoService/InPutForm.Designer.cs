namespace AutoService
{
    partial class InPutForm
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(97, 83);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(136, 22);
            this.tbNumber.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(286, 83);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 22);
            this.tbName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(97, 61);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 16);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Номер";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(283, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Имя";
            // 
            // InPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 269);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbNumber);
            this.Name = "InPutForm";
            this.Text = "InPutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
    }
}