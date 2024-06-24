namespace testComplexGUI
{
    partial class frmCreateChange
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
            this.lblRe = new System.Windows.Forms.Label();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.lblIm = new System.Windows.Forms.Label();
            this.txtIm = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.Location = new System.Drawing.Point(12, 15);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(24, 13);
            this.lblRe.TabIndex = 0;
            this.lblRe.Text = "Re:";
            // 
            // txtRe
            // 
            this.txtRe.Location = new System.Drawing.Point(42, 12);
            this.txtRe.Name = "txtRe";
            this.txtRe.Size = new System.Drawing.Size(100, 20);
            this.txtRe.TabIndex = 1;
            // 
            // lblIm
            // 
            this.lblIm.AutoSize = true;
            this.lblIm.Location = new System.Drawing.Point(148, 15);
            this.lblIm.Name = "lblIm";
            this.lblIm.Size = new System.Drawing.Size(21, 13);
            this.lblIm.TabIndex = 2;
            this.lblIm.Text = "Im:";
            // 
            // txtIm
            // 
            this.txtIm.Location = new System.Drawing.Point(175, 12);
            this.txtIm.Name = "txtIm";
            this.txtIm.Size = new System.Drawing.Size(100, 20);
            this.txtIm.TabIndex = 3;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(281, 10);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(113, 23);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // frmCreateChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 45);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtIm);
            this.Controls.Add(this.lblIm);
            this.Controls.Add(this.txtRe);
            this.Controls.Add(this.lblRe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreateChange";
            this.Text = "Форма создания / изменения комплексного числа";
            this.Load += new System.EventHandler(this.frmCreateChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.Label lblIm;
        private System.Windows.Forms.TextBox txtIm;
        private System.Windows.Forms.Button btnInput;
    }
}