namespace Slumpat_Tal_Grafiskt
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Gissa_talet = new System.Windows.Forms.Label();
            this.Försök = new System.Windows.Forms.Label();
            this.high_low = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(319, 204);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(142, 20);
            this.Input.TabIndex = 1;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Gissa_talet
            // 
            this.Gissa_talet.AutoSize = true;
            this.Gissa_talet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Gissa_talet.Location = new System.Drawing.Point(211, 134);
            this.Gissa_talet.Name = "Gissa_talet";
            this.Gissa_talet.Size = new System.Drawing.Size(354, 31);
            this.Gissa_talet.TabIndex = 2;
            this.Gissa_talet.Text = "Gissa talet mellan 1 och 100";
            // 
            // Försök
            // 
            this.Försök.AutoSize = true;
            this.Försök.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Försök.Location = new System.Drawing.Point(315, 296);
            this.Försök.Name = "Försök";
            this.Försök.Size = new System.Drawing.Size(0, 20);
            this.Försök.TabIndex = 3;
            // 
            // high_low
            // 
            this.high_low.AutoSize = true;
            this.high_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.high_low.Location = new System.Drawing.Point(315, 248);
            this.high_low.Name = "high_low";
            this.high_low.Size = new System.Drawing.Size(0, 20);
            this.high_low.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.high_low);
            this.Controls.Add(this.Försök);
            this.Controls.Add(this.Gissa_talet);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Gissa Talet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Gissa_talet;
        private System.Windows.Forms.Label Försök;
        private System.Windows.Forms.Label high_low;
    }
}

