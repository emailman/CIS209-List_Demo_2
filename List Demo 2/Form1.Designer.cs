namespace List_Demo_2
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
            this.lbxNewCars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxUsedCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxNewCars
            // 
            this.lbxNewCars.FormattingEnabled = true;
            this.lbxNewCars.Location = new System.Drawing.Point(75, 51);
            this.lbxNewCars.Name = "lbxNewCars";
            this.lbxNewCars.Size = new System.Drawing.Size(120, 95);
            this.lbxNewCars.TabIndex = 0;
            this.lbxNewCars.SelectedIndexChanged += new System.EventHandler(this.lbxNewCars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Cars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(236, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Used Cars";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxUsedCars
            // 
            this.lbxUsedCars.FormattingEnabled = true;
            this.lbxUsedCars.Location = new System.Drawing.Point(239, 51);
            this.lbxUsedCars.Name = "lbxUsedCars";
            this.lbxUsedCars.Size = new System.Drawing.Size(120, 95);
            this.lbxUsedCars.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxUsedCars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxNewCars);
            this.Name = "Form1";
            this.Text = "Honda Auto Land";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNewCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxUsedCars;
    }
}

