namespace BMICalculatorApp
{
    partial class MainForm
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalcBmi = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.gbMsmtSys = new System.Windows.Forms.GroupBox();
            this.radioBtnImperial = new System.Windows.Forms.RadioButton();
            this.radioBtnMetric = new System.Windows.Forms.RadioButton();
            this.gbMsmtSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(39, 126);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(54, 20);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(112, 123);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(182, 27);
            this.txtHeight.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(112, 172);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(182, 27);
            this.txtWeight.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(39, 175);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(112, 261);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(232, 27);
            this.txtResult.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(39, 264);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "BMI";
            // 
            // btnCalcBmi
            // 
            this.btnCalcBmi.Location = new System.Drawing.Point(39, 217);
            this.btnCalcBmi.Name = "btnCalcBmi";
            this.btnCalcBmi.Size = new System.Drawing.Size(116, 29);
            this.btnCalcBmi.TabIndex = 6;
            this.btnCalcBmi.Text = "Calculate BMI";
            this.btnCalcBmi.UseVisualStyleBackColor = true;
            this.btnCalcBmi.Click += new System.EventHandler(this.btnCalcBmi_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(112, 314);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(232, 27);
            this.txtStatus.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(39, 317);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(39, 374);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(160, 20);
            this.lblErrorMsg.TabIndex = 9;
            this.lblErrorMsg.Text = "Error msg place holder";
            // 
            // gbMsmtSys
            // 
            this.gbMsmtSys.Controls.Add(this.radioBtnImperial);
            this.gbMsmtSys.Controls.Add(this.radioBtnMetric);
            this.gbMsmtSys.Location = new System.Drawing.Point(39, 33);
            this.gbMsmtSys.Name = "gbMsmtSys";
            this.gbMsmtSys.Size = new System.Drawing.Size(305, 64);
            this.gbMsmtSys.TabIndex = 10;
            this.gbMsmtSys.TabStop = false;
            this.gbMsmtSys.Text = "Measurement System";
            // 
            // radioBtnImperial
            // 
            this.radioBtnImperial.AutoSize = true;
            this.radioBtnImperial.Location = new System.Drawing.Point(181, 26);
            this.radioBtnImperial.Name = "radioBtnImperial";
            this.radioBtnImperial.Size = new System.Drawing.Size(85, 24);
            this.radioBtnImperial.TabIndex = 1;
            this.radioBtnImperial.Text = "Imperial";
            this.radioBtnImperial.UseVisualStyleBackColor = true;
            this.radioBtnImperial.CheckedChanged += new System.EventHandler(this.HandleMeasurementSystemChange);
            // 
            // radioBtnMetric
            // 
            this.radioBtnMetric.AutoSize = true;
            this.radioBtnMetric.Checked = true;
            this.radioBtnMetric.Location = new System.Drawing.Point(44, 26);
            this.radioBtnMetric.Name = "radioBtnMetric";
            this.radioBtnMetric.Size = new System.Drawing.Size(72, 24);
            this.radioBtnMetric.TabIndex = 0;
            this.radioBtnMetric.TabStop = true;
            this.radioBtnMetric.Text = "Metric";
            this.radioBtnMetric.UseVisualStyleBackColor = true;
            this.radioBtnMetric.CheckedChanged += new System.EventHandler(this.HandleMeasurementSystemChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 446);
            this.Controls.Add(this.gbMsmtSys);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCalcBmi);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Name = "MainForm";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbMsmtSys.ResumeLayout(false);
            this.gbMsmtSys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeight;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblWeight;
        private TextBox txtResult;
        private Label lblResult;
        private Button btnCalcBmi;
        private TextBox txtStatus;
        private Label lblStatus;
        private Label lblErrorMsg;
        private GroupBox gbMsmtSys;
        private RadioButton radioBtnImperial;
        private RadioButton radioBtnMetric;
    }
}