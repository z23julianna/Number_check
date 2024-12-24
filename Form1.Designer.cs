namespace Угадайка
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
            label1 = new Label();
            userinpuTextBox = new TextBox();
            button1 = new Button();
            verdictLAbel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 53);
            label1.Name = "label1";
            label1.Size = new Size(227, 35);
            label1.TabIndex = 0;
            label1.Text = "Угадай число";
            // 
            // userinpuTextBox
            // 
            userinpuTextBox.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userinpuTextBox.Location = new Point(140, 357);
            userinpuTextBox.Name = "userinpuTextBox";
            userinpuTextBox.Size = new Size(145, 40);
            userinpuTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold);
            button1.Location = new Point(381, 352);
            button1.Name = "button1";
            button1.Size = new Size(203, 48);
            button1.TabIndex = 2;
            button1.Text = "Угадать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // verdictLAbel
            // 
            verdictLAbel.AutoSize = true;
            verdictLAbel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verdictLAbel.Location = new Point(217, 219);
            verdictLAbel.Name = "verdictLAbel";
            verdictLAbel.Size = new Size(0, 35);
            verdictLAbel.TabIndex = 3;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(verdictLAbel);
            Controls.Add(button1);
            Controls.Add(userinpuTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Простое число";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userinpuTextBox;
        private Button button1;
        private Label verdictLAbel;
    }
}
