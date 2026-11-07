namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBasicCalculator = new Label();
            txtboxNum1 = new TextBox();
            cmbOperators = new ComboBox();
            txtboxNum2 = new TextBox();
            btnCompute = new Button();
            panel1 = new Panel();
            lblAnswer = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBasicCalculator
            // 
            lblBasicCalculator.AutoSize = true;
            lblBasicCalculator.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasicCalculator.Location = new Point(12, 9);
            lblBasicCalculator.Name = "lblBasicCalculator";
            lblBasicCalculator.Size = new Size(134, 19);
            lblBasicCalculator.TabIndex = 0;
            lblBasicCalculator.Text = "Basic Calculator";
            // 
            // txtboxNum1
            // 
            txtboxNum1.BackColor = Color.White;
            txtboxNum1.BorderStyle = BorderStyle.FixedSingle;
            txtboxNum1.Location = new Point(12, 41);
            txtboxNum1.Name = "txtboxNum1";
            txtboxNum1.Size = new Size(215, 26);
            txtboxNum1.TabIndex = 1;
            // 
            // cmbOperators
            // 
            cmbOperators.FormattingEnabled = true;
            cmbOperators.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperators.Location = new Point(96, 73);
            cmbOperators.Name = "cmbOperators";
            cmbOperators.Size = new Size(50, 26);
            cmbOperators.TabIndex = 2;
            // 
            // txtboxNum2
            // 
            txtboxNum2.BackColor = Color.White;
            txtboxNum2.BorderStyle = BorderStyle.FixedSingle;
            txtboxNum2.Location = new Point(12, 105);
            txtboxNum2.Name = "txtboxNum2";
            txtboxNum2.Size = new Size(215, 26);
            txtboxNum2.TabIndex = 3;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(77, 223);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(85, 28);
            btnCompute.TabIndex = 4;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lblAnswer);
            panel1.Controls.Add(lblTotal);
            panel1.ForeColor = Color.Green;
            panel1.Location = new Point(12, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 71);
            panel1.TabIndex = 5;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(3, 35);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(82, 24);
            lblAnswer.TabIndex = 1;
            lblAnswer.Text = "000000";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(3, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 17);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total:";
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(239, 260);
            Controls.Add(panel1);
            Controls.Add(btnCompute);
            Controls.Add(txtboxNum2);
            Controls.Add(cmbOperators);
            Controls.Add(txtboxNum1);
            Controls.Add(lblBasicCalculator);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmBasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBasicCalculator";
            Load += FrmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBasicCalculator;
        private TextBox txtboxNum1;
        private ComboBox cmbOperators;
        private TextBox txtboxNum2;
        private Button btnCompute;
        private Panel panel1;
        private Label lblTotal;
        private Label lblAnswer;
    }
}
