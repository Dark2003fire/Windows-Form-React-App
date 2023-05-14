
namespace WindowsFormsRectApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.Breadth = new System.Windows.Forms.TextBox();
            this.RectArea = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Breadth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area of recatangle ";
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(288, 36);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(100, 20);
            this.Length.TabIndex = 3;
            this.Length.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Breadth
            // 
            this.Breadth.Location = new System.Drawing.Point(288, 134);
            this.Breadth.Name = "Breadth";
            this.Breadth.Size = new System.Drawing.Size(109, 20);
            this.Breadth.TabIndex = 4;
            // 
            // RectArea
            // 
            this.RectArea.Location = new System.Drawing.Point(288, 246);
            this.RectArea.Name = "RectArea";
            this.RectArea.ReadOnly = true;
            this.RectArea.Size = new System.Drawing.Size(109, 20);
            this.RectArea.TabIndex = 5;
            this.RectArea.TextChanged += new System.EventHandler(this.RectArea_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(294, 338);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.RectArea);
            this.Controls.Add(this.Breadth);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Breadth;
        private System.Windows.Forms.TextBox RectArea;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
    }
}

