namespace Hello_World3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button btnCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(150, 50);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click); // 綁定 btnCount_Click

            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(150, 100);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(41, 12);
            this.labCount.TabIndex = 1;
            this.labCount.Text = "label1";

            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(150, 150);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(41, 12);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "label2";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
