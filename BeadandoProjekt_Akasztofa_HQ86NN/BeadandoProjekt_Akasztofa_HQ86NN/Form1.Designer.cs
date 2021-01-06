namespace BeadandoProjekt_Akasztofa_HQ86NN
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
            this.ujjatek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ujjatek
            // 
            this.ujjatek.Location = new System.Drawing.Point(12, 12);
            this.ujjatek.Name = "ujjatek";
            this.ujjatek.Size = new System.Drawing.Size(89, 39);
            this.ujjatek.TabIndex = 0;
            this.ujjatek.Text = "új játék";
            this.ujjatek.UseVisualStyleBackColor = true;
            this.ujjatek.Click += new System.EventHandler(this.ujjatek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ujjatek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ujjatek;
    }
}

