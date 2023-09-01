namespace SnakeGame
{
    partial class GameOverScreen
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Lime;
            label1.Location = new System.Drawing.Point(62, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 39);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(62, 242);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(485, 30);
            label2.TabIndex = 1;
            label2.Text = "To start a new game, press restart";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(235, 305);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(102, 56);
            button1.TabIndex = 2;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GameOverScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(594, 412);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GameOverScreen";
            Text = "GameOver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}