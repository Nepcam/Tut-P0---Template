namespace Tut_P0
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
            this.buttonEx1 = new System.Windows.Forms.Button();
            this.buttonEx2 = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonEx1
            // 
            this.buttonEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEx1.Location = new System.Drawing.Point(28, 28);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(236, 63);
            this.buttonEx1.TabIndex = 0;
            this.buttonEx1.Text = "Ex 1";
            this.buttonEx1.UseVisualStyleBackColor = true;
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // buttonEx2
            // 
            this.buttonEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEx2.Location = new System.Drawing.Point(270, 28);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(236, 63);
            this.buttonEx2.TabIndex = 1;
            this.buttonEx2.Text = "Ex 2";
            this.buttonEx2.UseVisualStyleBackColor = true;
            this.buttonEx2.Click += new System.EventHandler(this.buttonEx2_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 24;
            this.listBoxDisplay.Location = new System.Drawing.Point(28, 97);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(478, 340);
            this.listBoxDisplay.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 501);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonEx2);
            this.Controls.Add(this.buttonEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEx1;
        private System.Windows.Forms.Button buttonEx2;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

