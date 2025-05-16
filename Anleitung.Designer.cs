namespace Gamingconsole
{
    partial class Anleitung
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = Properties.Resources.starry_galaxy_5k_5120x2880;
            button1.Location = new Point(895, 60);
            button1.Name = "button1";
            button1.Size = new Size(277, 114);
            button1.TabIndex = 1;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(184, 185);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(618, 288);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Anleitung
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 813);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Anleitung";
            Text = "Anleitung";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private RichTextBox richTextBox1;
    }
}