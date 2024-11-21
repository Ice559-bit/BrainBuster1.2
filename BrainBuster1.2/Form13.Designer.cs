namespace BrainBuster1._2
{
    partial class Form13
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Stout", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 115);
            label2.Name = "label2";
            label2.Size = new Size(235, 51);
            label2.TabIndex = 5;
            label2.Text = "Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 64);
            label1.Name = "label1";
            label1.Size = new Size(258, 51);
            label1.TabIndex = 4;
            label1.Text = "Total";
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 361);
            button1.Name = "button1";
            button1.Size = new Size(179, 38);
            button1.TabIndex = 3;
            button1.Text = "Play Again";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Stout", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 166);
            label3.Name = "label3";
            label3.Size = new Size(0, 51);
            label3.TabIndex = 6;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 574);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
    }
}