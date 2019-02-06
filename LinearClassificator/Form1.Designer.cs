namespace LinearClassificator
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
            this.DrawPoints = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.PictureBox();
            this.Train = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPoints
            // 
            this.DrawPoints.Location = new System.Drawing.Point(619, 13);
            this.DrawPoints.Name = "DrawPoints";
            this.DrawPoints.Size = new System.Drawing.Size(75, 23);
            this.DrawPoints.TabIndex = 0;
            this.DrawPoints.Text = "DrawPoints";
            this.DrawPoints.UseVisualStyleBackColor = true;
            this.DrawPoints.Click += new System.EventHandler(this.DrawPoints_Click);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(13, 13);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(600, 600);
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(619, 42);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(75, 23);
            this.Train.TabIndex = 2;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 614);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.DrawPoints);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawPoints;
        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Button Train;
    }
}

