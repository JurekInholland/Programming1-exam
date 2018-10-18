namespace Assignment5
{
    partial class Form1
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
            this.rdb5km = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdb10km = new System.Windows.Forms.RadioButton();
            this.rdb21km = new System.Windows.Forms.RadioButton();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdb5km
            // 
            this.rdb5km.AutoSize = true;
            this.rdb5km.Location = new System.Drawing.Point(26, 29);
            this.rdb5km.Name = "rdb5km";
            this.rdb5km.Size = new System.Drawing.Size(48, 17);
            this.rdb5km.TabIndex = 0;
            this.rdb5km.TabStop = true;
            this.rdb5km.Text = "5 km";
            this.rdb5km.UseVisualStyleBackColor = true;
            this.rdb5km.CheckedChanged += new System.EventHandler(this.rdb5km_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "hh:mm:ss";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(90, 69);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(44, 20);
            this.txtHours.TabIndex = 2;
            this.txtHours.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(26, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(208, 34);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed (km/hr)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(112, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // rdb10km
            // 
            this.rdb10km.AutoSize = true;
            this.rdb10km.Location = new System.Drawing.Point(103, 29);
            this.rdb10km.Name = "rdb10km";
            this.rdb10km.Size = new System.Drawing.Size(54, 17);
            this.rdb10km.TabIndex = 6;
            this.rdb10km.TabStop = true;
            this.rdb10km.Text = "10 km";
            this.rdb10km.UseVisualStyleBackColor = true;
            this.rdb10km.CheckedChanged += new System.EventHandler(this.rdb10km_CheckedChanged);
            // 
            // rdb21km
            // 
            this.rdb21km.AutoSize = true;
            this.rdb21km.Location = new System.Drawing.Point(180, 29);
            this.rdb21km.Name = "rdb21km";
            this.rdb21km.Size = new System.Drawing.Size(54, 17);
            this.rdb21km.TabIndex = 7;
            this.rdb21km.TabStop = true;
            this.rdb21km.Text = "21 km";
            this.rdb21km.UseVisualStyleBackColor = true;
            this.rdb21km.CheckedChanged += new System.EventHandler(this.rdb21km_CheckedChanged);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(140, 69);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(44, 20);
            this.txtMinutes.TabIndex = 8;
            this.txtMinutes.Text = "0";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(190, 69);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(44, 20);
            this.txtSeconds.TabIndex = 9;
            this.txtSeconds.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 208);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.rdb21km);
            this.Controls.Add(this.rdb10km);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb5km);
            this.Name = "Form1";
            this.Text = "Assignemnt 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb5km;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdb10km;
        private System.Windows.Forms.RadioButton rdb21km;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
    }
}

