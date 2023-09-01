namespace SnakeGame
{
    partial class Menu
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
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.WhiteSmoke;
            button2.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Lime;
            button2.Location = new System.Drawing.Point(227, 378);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(133, 45);
            button2.TabIndex = 1;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(18, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(573, 92);
            label1.TabIndex = 2;
            label1.Text = "choose from the 2 buttons on the lower side of the screen\r\nFor 1 player - press 1 Player button\r\nFor 2 players - press 2 Player button\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.Highlight;
            label2.Location = new System.Drawing.Point(184, 297);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(212, 19);
            label2.TabIndex = 3;
            label2.Text = "BLUE FOOD = 1 POINT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(188, 316);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(206, 19);
            label3.TabIndex = 4;
            label3.Text = "RED FOOD = -1 POINT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(255, 128, 255);
            label4.Location = new System.Drawing.Point(174, 274);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(239, 19);
            label4.TabIndex = 5;
            label4.Text = "PINK FOOD = 25 POINTS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(12, 356);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(592, 19);
            label5.TabIndex = 6;
            label5.Text = "BLACK BOMB = -25 POINTS AND GAME OVER FOR THE PLAYER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            label6.Location = new System.Drawing.Point(128, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(342, 30);
            label6.TabIndex = 7;
            label6.Text = "Snake Game Instructions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            label7.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Green;
            label7.Location = new System.Drawing.Point(71, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(478, 19);
            label7.TabIndex = 8;
            label7.Text = "Player1: UP = I ; DOWN = K ; RIGHT = L ; LEFT = J\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            label8.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Yellow;
            label8.Location = new System.Drawing.Point(68, 220);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(491, 19);
            label8.TabIndex = 9;
            label8.Text = "Player2: UP = W ; DOWN = S ; RIGHT = D ; LEFT = A";
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(601, 444);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}