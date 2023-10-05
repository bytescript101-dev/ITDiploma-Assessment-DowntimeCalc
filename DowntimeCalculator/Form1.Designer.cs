namespace DowntimeCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDt1 = new System.Windows.Forms.Label();
            this.lblDt2 = new System.Windows.Forms.Label();
            this.lblDt3 = new System.Windows.Forms.Label();
            this.lblDt4 = new System.Windows.Forms.Label();
            this.lblDt5 = new System.Windows.Forms.Label();
            this.btnAvgDowntime = new System.Windows.Forms.Button();
            this.createDowntimeArray = new System.Windows.Forms.Button();
            this.txtDowntime1 = new System.Windows.Forms.TextBox();
            this.txtDowntime5 = new System.Windows.Forms.TextBox();
            this.txtDowntime4 = new System.Windows.Forms.TextBox();
            this.txtDowntime3 = new System.Windows.Forms.TextBox();
            this.txtDowntime2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.outputAvgDowntime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downtime Calculator";
            // 
            // lblDt1
            // 
            this.lblDt1.AutoSize = true;
            this.lblDt1.Location = new System.Drawing.Point(64, 110);
            this.lblDt1.Name = "lblDt1";
            this.lblDt1.Size = new System.Drawing.Size(63, 13);
            this.lblDt1.TabIndex = 1;
            this.lblDt1.Text = "Downtime 1";
            // 
            // lblDt2
            // 
            this.lblDt2.AutoSize = true;
            this.lblDt2.Location = new System.Drawing.Point(64, 151);
            this.lblDt2.Name = "lblDt2";
            this.lblDt2.Size = new System.Drawing.Size(63, 13);
            this.lblDt2.TabIndex = 2;
            this.lblDt2.Text = "Downtime 2";
            // 
            // lblDt3
            // 
            this.lblDt3.AutoSize = true;
            this.lblDt3.Location = new System.Drawing.Point(64, 205);
            this.lblDt3.Name = "lblDt3";
            this.lblDt3.Size = new System.Drawing.Size(63, 13);
            this.lblDt3.TabIndex = 3;
            this.lblDt3.Text = "Downtime 3";
            // 
            // lblDt4
            // 
            this.lblDt4.AutoSize = true;
            this.lblDt4.Location = new System.Drawing.Point(64, 269);
            this.lblDt4.Name = "lblDt4";
            this.lblDt4.Size = new System.Drawing.Size(63, 13);
            this.lblDt4.TabIndex = 4;
            this.lblDt4.Text = "Downtime 4";
            // 
            // lblDt5
            // 
            this.lblDt5.AutoSize = true;
            this.lblDt5.Location = new System.Drawing.Point(64, 329);
            this.lblDt5.Name = "lblDt5";
            this.lblDt5.Size = new System.Drawing.Size(63, 13);
            this.lblDt5.TabIndex = 5;
            this.lblDt5.Text = "Downtime 5";
            // 
            // btnAvgDowntime
            // 
            this.btnAvgDowntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgDowntime.Location = new System.Drawing.Point(492, 50);
            this.btnAvgDowntime.Name = "btnAvgDowntime";
            this.btnAvgDowntime.Size = new System.Drawing.Size(210, 24);
            this.btnAvgDowntime.TabIndex = 6;
            this.btnAvgDowntime.Text = "Display Average Downtime";
            this.btnAvgDowntime.UseVisualStyleBackColor = true;
            this.btnAvgDowntime.Click += new System.EventHandler(this.btnAvgDowntime_Click);
            // 
            // createDowntimeArray
            // 
            this.createDowntimeArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDowntimeArray.Location = new System.Drawing.Point(84, 370);
            this.createDowntimeArray.Name = "createDowntimeArray";
            this.createDowntimeArray.Size = new System.Drawing.Size(203, 23);
            this.createDowntimeArray.TabIndex = 7;
            this.createDowntimeArray.Text = "Create Downtime Array";
            this.createDowntimeArray.UseVisualStyleBackColor = true;
            this.createDowntimeArray.Click += new System.EventHandler(this.createDowntimeArray_Click);
            // 
            // txtDowntime1
            // 
            this.txtDowntime1.Location = new System.Drawing.Point(138, 110);
            this.txtDowntime1.Name = "txtDowntime1";
            this.txtDowntime1.Size = new System.Drawing.Size(100, 20);
            this.txtDowntime1.TabIndex = 8;
            // 
            // txtDowntime5
            // 
            this.txtDowntime5.Location = new System.Drawing.Point(138, 329);
            this.txtDowntime5.Name = "txtDowntime5";
            this.txtDowntime5.Size = new System.Drawing.Size(100, 20);
            this.txtDowntime5.TabIndex = 9;
            // 
            // txtDowntime4
            // 
            this.txtDowntime4.Location = new System.Drawing.Point(138, 269);
            this.txtDowntime4.Name = "txtDowntime4";
            this.txtDowntime4.Size = new System.Drawing.Size(100, 20);
            this.txtDowntime4.TabIndex = 10;
            // 
            // txtDowntime3
            // 
            this.txtDowntime3.Location = new System.Drawing.Point(138, 205);
            this.txtDowntime3.Name = "txtDowntime3";
            this.txtDowntime3.Size = new System.Drawing.Size(100, 20);
            this.txtDowntime3.TabIndex = 11;
            // 
            // txtDowntime2
            // 
            this.txtDowntime2.Location = new System.Drawing.Point(138, 151);
            this.txtDowntime2.Name = "txtDowntime2";
            this.txtDowntime2.Size = new System.Drawing.Size(100, 20);
            this.txtDowntime2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Output";
            // 
            // outputAvgDowntime
            // 
            this.outputAvgDowntime.Location = new System.Drawing.Point(460, 133);
            this.outputAvgDowntime.Multiline = true;
            this.outputAvgDowntime.Name = "outputAvgDowntime";
            this.outputAvgDowntime.ReadOnly = true;
            this.outputAvgDowntime.Size = new System.Drawing.Size(252, 236);
            this.outputAvgDowntime.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.outputAvgDowntime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDowntime2);
            this.Controls.Add(this.txtDowntime3);
            this.Controls.Add(this.txtDowntime4);
            this.Controls.Add(this.txtDowntime5);
            this.Controls.Add(this.txtDowntime1);
            this.Controls.Add(this.createDowntimeArray);
            this.Controls.Add(this.btnAvgDowntime);
            this.Controls.Add(this.lblDt5);
            this.Controls.Add(this.lblDt4);
            this.Controls.Add(this.lblDt3);
            this.Controls.Add(this.lblDt2);
            this.Controls.Add(this.lblDt1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDt1;
        private System.Windows.Forms.Label lblDt2;
        private System.Windows.Forms.Label lblDt3;
        private System.Windows.Forms.Label lblDt4;
        private System.Windows.Forms.Label lblDt5;
        private System.Windows.Forms.Button btnAvgDowntime;
        private System.Windows.Forms.Button createDowntimeArray;
        private System.Windows.Forms.TextBox txtDowntime1;
        private System.Windows.Forms.TextBox txtDowntime5;
        private System.Windows.Forms.TextBox txtDowntime4;
        private System.Windows.Forms.TextBox txtDowntime3;
        private System.Windows.Forms.TextBox txtDowntime2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox outputAvgDowntime;
    }
}

