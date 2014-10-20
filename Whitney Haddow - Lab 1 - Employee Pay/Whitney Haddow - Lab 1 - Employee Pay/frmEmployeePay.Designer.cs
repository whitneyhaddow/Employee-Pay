namespace Whitney_Haddow___Lab_1___Employee_Pay
{
    partial class frmEmployeePay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeePay));
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRegularPay = new System.Windows.Forms.Label();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(218, 110);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(167, 20);
            this.txtHours.TabIndex = 0;
            //this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(218, 155);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(167, 20);
            this.txtRate.TabIndex = 1;
            // 
            // lblRegularPay
            // 
            this.lblRegularPay.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegularPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegularPay.Location = new System.Drawing.Point(218, 260);
            this.lblRegularPay.Name = "lblRegularPay";
            this.lblRegularPay.Size = new System.Drawing.Size(167, 23);
            this.lblRegularPay.TabIndex = 2;
            // 
            // lblOvertime
            // 
            this.lblOvertime.BackColor = System.Drawing.SystemColors.Control;
            this.lblOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOvertime.Location = new System.Drawing.Point(218, 310);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(167, 23);
            this.lblOvertime.TabIndex = 3;
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPay.Location = new System.Drawing.Point(218, 357);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(167, 23);
            this.lblTotalPay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hours worked this week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pay rate/Hour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pay for regular hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pay for overtime hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total pay for employee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "Please enter the number of hours worked by your \r\nemployee for the week and their" +
    " pay rate per hour \r\nto calculate total pay.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(138, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 27);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(45, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 27);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(238, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 27);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmployeePay
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(428, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lblOvertime);
            this.Controls.Add(this.lblRegularPay);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeePay";
            this.Text = "Weekly Pay for Employee";
            this.Load += new System.EventHandler(this.frmEmployeePay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRegularPay;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

