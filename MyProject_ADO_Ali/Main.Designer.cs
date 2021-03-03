namespace MyProject_ADO_Ali
{
    partial class Main
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
            this.lblHotelID = new System.Windows.Forms.Label();
            this.btnTourist = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Location = new System.Drawing.Point(37, 540);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(0, 13);
            this.lblHotelID.TabIndex = 13;
            // 
            // btnTourist
            // 
            this.btnTourist.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourist.Location = new System.Drawing.Point(245, 180);
            this.btnTourist.Name = "btnTourist";
            this.btnTourist.Size = new System.Drawing.Size(226, 64);
            this.btnTourist.TabIndex = 14;
            this.btnTourist.Text = "Tourist";
            this.btnTourist.UseVisualStyleBackColor = true;
            this.btnTourist.Click += new System.EventHandler(this.btnTourist_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.Location = new System.Drawing.Point(531, 180);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(226, 64);
            this.btnHotel.TabIndex = 15;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tourist And Hospitality Management";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MistyRose;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(824, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 53);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(390, 303);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(226, 64);
            this.btnReport.TabIndex = 32;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 474);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnTourist);
            this.Controls.Add(this.lblHotelID);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.Button btnTourist;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
    }
}

