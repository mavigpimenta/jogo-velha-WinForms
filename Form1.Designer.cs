namespace jogo_velha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            btRestart = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 24F);
            button1.Location = new Point(43, 145);
            button1.Name = "button1";
            button1.Size = new Size(118, 112);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 24F);
            button2.Location = new Point(187, 145);
            button2.Name = "button2";
            button2.Size = new Size(118, 112);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Showcard Gothic", 24F);
            button3.Location = new Point(332, 145);
            button3.Name = "button3";
            button3.Size = new Size(118, 112);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 24F);
            button4.Location = new Point(43, 282);
            button4.Name = "button4";
            button4.Size = new Size(118, 112);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Showcard Gothic", 24F);
            button5.Location = new Point(187, 282);
            button5.Name = "button5";
            button5.Size = new Size(118, 112);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Showcard Gothic", 24F);
            button6.Location = new Point(332, 282);
            button6.Name = "button6";
            button6.Size = new Size(118, 112);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Showcard Gothic", 24F);
            button7.Location = new Point(43, 417);
            button7.Name = "button7";
            button7.Size = new Size(118, 112);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Showcard Gothic", 24F);
            button8.Location = new Point(187, 417);
            button8.Name = "button8";
            button8.Size = new Size(118, 112);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Showcard Gothic", 24F);
            button9.Location = new Point(332, 417);
            button9.Name = "button9";
            button9.Size = new Size(118, 112);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(130, 60);
            label1.Name = "label1";
            label1.Size = new Size(255, 40);
            label1.TabIndex = 9;
            label1.Text = "JOGO DA VELHA";
            // 
            // btRestart
            // 
            btRestart.BackColor = SystemColors.ActiveCaptionText;
            btRestart.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btRestart.ForeColor = SystemColors.ButtonHighlight;
            btRestart.Location = new Point(404, 44);
            btRestart.Name = "btRestart";
            btRestart.Size = new Size(62, 69);
            btRestart.TabIndex = 10;
            btRestart.Text = "🔁";
            btRestart.UseVisualStyleBackColor = false;
            btRestart.Click += btRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(494, 564);
            Controls.Add(btRestart);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Velha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button btRestart;
    }
}
