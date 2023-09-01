using System.Windows.Forms;

namespace SnakeGame
{
    partial class Snake_
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
            components = new System.ComponentModel.Container();
            PicCanvas = new PictureBox();
            S1Score = new Label();
            S2Score = new Label();
            button1 = new Button();
            GameTimer = new Timer(components);
            button1player = new Button();
            button2player = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)PicCanvas).BeginInit();
            SuspendLayout();
            // 
            // PicCanvas
            // 
            PicCanvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            PicCanvas.Location = new System.Drawing.Point(3, 3);
            PicCanvas.Margin = new Padding(3, 4, 3, 4);
            PicCanvas.Name = "PicCanvas";
            PicCanvas.Size = new System.Drawing.Size(662, 667);
            PicCanvas.TabIndex = 0;
            PicCanvas.TabStop = false;
            PicCanvas.Paint += UpdateGrapichs;
            // 
            // S1Score
            //
            //
            //Snake picture

            //
            S1Score.AutoSize = true;
            S1Score.BackColor = System.Drawing.Color.Black;
            S1Score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S1Score.ForeColor = System.Drawing.Color.Green;
            S1Score.Location = new System.Drawing.Point(32, 672);
            S1Score.Name = "S1Score";
            S1Score.Size = new System.Drawing.Size(81, 28);
            S1Score.TabIndex = 1;
            S1Score.Text = "Score: 0";
            // 
            // S2Score
            // 
            S2Score.AutoSize = true;
            S2Score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            S2Score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            S2Score.ForeColor = System.Drawing.Color.Yellow;
            S2Score.Location = new System.Drawing.Point(179, 672);
            S2Score.Name = "S2Score";
            S2Score.Size = new System.Drawing.Size(81, 28);
            S2Score.TabIndex = 1;
            S2Score.Text = "Score: 0";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(555, 677);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 31);
            button1.TabIndex = 2;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 50;
            GameTimer.Tick += GameTimerEvent;
            // 
            // button1player
            // 
            button1player.BackColor = System.Drawing.Color.DarkGreen;
            button1player.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1player.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1player.Location = new System.Drawing.Point(3, 704);
            button1player.Margin = new Padding(3, 4, 3, 4);
            button1player.Name = "button1player";
            button1player.Size = new System.Drawing.Size(136, 39);
            button1player.TabIndex = 2;
            button1player.Text = "1 Player";
            button1player.UseVisualStyleBackColor = false;
            button1player.Click += OnePlayer;
            // 
            // button2player
            // 
            button2player.BackColor = System.Drawing.Color.Yellow;
            button2player.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2player.Location = new System.Drawing.Point(154, 705);
            button2player.Margin = new Padding(3, 4, 3, 4);
            button2player.Name = "button2player";
            button2player.Size = new System.Drawing.Size(138, 39);
            button2player.TabIndex = 2;
            button2player.Text = "2 Player";
            button2player.UseVisualStyleBackColor = false;
            button2player.Click += TwoPlayers;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(556, 714);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(93, 27);
            button2.TabIndex = 3;
            button2.Text = "LOAD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Snake_
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(667, 748);
            Controls.Add(button2);
            Controls.Add(button2player);
            Controls.Add(button1player);
            Controls.Add(button1);
            Controls.Add(S2Score);
            Controls.Add(S1Score);
            Controls.Add(PicCanvas);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Snake_";
            Text = "Snake!";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)PicCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox PicCanvas;
        private System.Windows.Forms.Label S1Score;
        private System.Windows.Forms.Label S2Score;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button button1player;
        private System.Windows.Forms.Button button2player;
        private System.Windows.Forms.Button button1;
        private Button button2;
    }
}