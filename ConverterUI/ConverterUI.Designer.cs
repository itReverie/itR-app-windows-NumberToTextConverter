namespace ChequeProgram
{
    partial class ChequeConverterUI
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
            this.btnChequeConverter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUnitTesting = new System.Windows.Forms.TabPage();
            this.lblText = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tabLoadTesting = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabIntegrationTesting = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUnitTesting.SuspendLayout();
            this.tabLoadTesting.SuspendLayout();
            this.tabIntegrationTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChequeConverter
            // 
            this.btnChequeConverter.Location = new System.Drawing.Point(625, 251);
            this.btnChequeConverter.Name = "btnChequeConverter";
            this.btnChequeConverter.Size = new System.Drawing.Size(75, 23);
            this.btnChequeConverter.TabIndex = 0;
            this.btnChequeConverter.Text = "Convert";
            this.btnChequeConverter.UseVisualStyleBackColor = true;
            this.btnChequeConverter.Click += new System.EventHandler(this.btnChequeConverter_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUnitTesting);
            this.tabControl1.Controls.Add(this.tabLoadTesting);
            this.tabControl1.Controls.Add(this.tabIntegrationTesting);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 387);
            this.tabControl1.TabIndex = 1;
            // 
            // tabUnitTesting
            // 
            this.tabUnitTesting.Controls.Add(this.lblText);
            this.tabUnitTesting.Controls.Add(this.btnChequeConverter);
            this.tabUnitTesting.Controls.Add(this.txtNumber);
            this.tabUnitTesting.Controls.Add(this.lblNumber);
            this.tabUnitTesting.Location = new System.Drawing.Point(4, 22);
            this.tabUnitTesting.Name = "tabUnitTesting";
            this.tabUnitTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnitTesting.Size = new System.Drawing.Size(828, 361);
            this.tabUnitTesting.TabIndex = 0;
            this.tabUnitTesting.Text = "Unit Testing";
            this.tabUnitTesting.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(10, 56);
            this.lblText.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(119, 22);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(165, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(7, 25);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // tabLoadTesting
            // 
            this.tabLoadTesting.Controls.Add(this.label2);
            this.tabLoadTesting.Location = new System.Drawing.Point(4, 22);
            this.tabLoadTesting.Name = "tabLoadTesting";
            this.tabLoadTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadTesting.Size = new System.Drawing.Size(430, 132);
            this.tabLoadTesting.TabIndex = 1;
            this.tabLoadTesting.Text = "Load Testing";
            this.tabLoadTesting.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Load a file previosuly preparared to load a large amount of numbers.";
            // 
            // tabIntegrationTesting
            // 
            this.tabIntegrationTesting.Controls.Add(this.label1);
            this.tabIntegrationTesting.Location = new System.Drawing.Point(4, 22);
            this.tabIntegrationTesting.Name = "tabIntegrationTesting";
            this.tabIntegrationTesting.Size = new System.Drawing.Size(430, 132);
            this.tabIntegrationTesting.TabIndex = 2;
            this.tabIntegrationTesting.Text = "Integration Testing";
            this.tabIntegrationTesting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Making a call from a console application or a web request";
            // 
            // ChequeConverterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChequeConverterUI";
            this.Text = "Cheque Program";
            this.tabControl1.ResumeLayout(false);
            this.tabUnitTesting.ResumeLayout(false);
            this.tabUnitTesting.PerformLayout();
            this.tabLoadTesting.ResumeLayout(false);
            this.tabLoadTesting.PerformLayout();
            this.tabIntegrationTesting.ResumeLayout(false);
            this.tabIntegrationTesting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChequeConverter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUnitTesting;
        private System.Windows.Forms.TabPage tabLoadTesting;
        private System.Windows.Forms.TabPage tabIntegrationTesting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblText;
    }
}

