namespace DriversGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDiverName = new System.Windows.Forms.ComboBox();
            this.cmbDiveNumber = new System.Windows.Forms.ComboBox();
            this.txtDiveScore = new System.Windows.Forms.TextBox();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.btnDiveScore = new System.Windows.Forms.Button();
            this.btnTotalScore = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diver Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diver Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dive Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Score Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dive Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Score:";
            // 
            // cmbDiverName
            // 
            this.cmbDiverName.FormattingEnabled = true;
            this.cmbDiverName.Location = new System.Drawing.Point(197, 97);
            this.cmbDiverName.Name = "cmbDiverName";
            this.cmbDiverName.Size = new System.Drawing.Size(343, 36);
            this.cmbDiverName.TabIndex = 1;
            // 
            // cmbDiveNumber
            // 
            this.cmbDiveNumber.FormattingEnabled = true;
            this.cmbDiveNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbDiveNumber.Location = new System.Drawing.Point(197, 170);
            this.cmbDiveNumber.Name = "cmbDiveNumber";
            this.cmbDiveNumber.Size = new System.Drawing.Size(215, 36);
            this.cmbDiveNumber.TabIndex = 1;
            // 
            // txtDiveScore
            // 
            this.txtDiveScore.Enabled = false;
            this.txtDiveScore.Location = new System.Drawing.Point(719, 97);
            this.txtDiveScore.Name = "txtDiveScore";
            this.txtDiveScore.Size = new System.Drawing.Size(220, 39);
            this.txtDiveScore.TabIndex = 2;
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Enabled = false;
            this.txtTotalScore.Location = new System.Drawing.Point(719, 170);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(220, 39);
            this.txtTotalScore.TabIndex = 2;
            // 
            // btnDiveScore
            // 
            this.btnDiveScore.Location = new System.Drawing.Point(28, 288);
            this.btnDiveScore.Name = "btnDiveScore";
            this.btnDiveScore.Size = new System.Drawing.Size(139, 48);
            this.btnDiveScore.TabIndex = 3;
            this.btnDiveScore.Text = "Dive Score";
            this.btnDiveScore.UseVisualStyleBackColor = true;
            this.btnDiveScore.Click += new System.EventHandler(this.btnDiveScore_Click);
            // 
            // btnTotalScore
            // 
            this.btnTotalScore.Location = new System.Drawing.Point(217, 288);
            this.btnTotalScore.Name = "btnTotalScore";
            this.btnTotalScore.Size = new System.Drawing.Size(139, 48);
            this.btnTotalScore.TabIndex = 4;
            this.btnTotalScore.Text = "Total Score";
            this.btnTotalScore.UseVisualStyleBackColor = true;
            this.btnTotalScore.Click += new System.EventHandler(this.btnTotalScore_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(406, 288);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(139, 48);
            this.btnPrintReport.TabIndex = 5;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(595, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 48);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(784, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(969, 397);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnTotalScore);
            this.Controls.Add(this.btnDiveScore);
            this.Controls.Add(this.txtTotalScore);
            this.Controls.Add(this.txtDiveScore);
            this.Controls.Add(this.cmbDiveNumber);
            this.Controls.Add(this.cmbDiverName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver Information and Reports";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDiverName;
        private System.Windows.Forms.ComboBox cmbDiveNumber;
        private System.Windows.Forms.TextBox txtDiveScore;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.Button btnDiveScore;
        private System.Windows.Forms.Button btnTotalScore;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

