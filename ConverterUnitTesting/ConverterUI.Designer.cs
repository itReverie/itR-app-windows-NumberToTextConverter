namespace ConverterUnitTesting
{
    partial class ConverterUI
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnChequeConverter = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(61, 100);
            this.lblText.MaximumSize = new System.Drawing.Size(1800, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 6;
            // 
            // btnChequeConverter
            // 
            this.btnChequeConverter.Location = new System.Drawing.Point(676, 295);
            this.btnChequeConverter.Name = "btnChequeConverter";
            this.btnChequeConverter.Size = new System.Drawing.Size(75, 23);
            this.btnChequeConverter.TabIndex = 3;
            this.btnChequeConverter.Text = "Convert";
            this.btnChequeConverter.UseVisualStyleBackColor = true;
            this.btnChequeConverter.Click += new System.EventHandler(this.btnChequeConverter_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(170, 66);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(165, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(58, 69);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Number:";
            // 
            // ConverterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 385);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnChequeConverter);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "ConverterUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnChequeConverter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
    }
}