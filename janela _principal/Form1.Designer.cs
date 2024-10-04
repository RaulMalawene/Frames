namespace janela__principal
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
            a = new TextBox();
            r = new TextBox();
            b = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(554, 86);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(554, 154);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(554, 229);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // a
            // 
            a.Location = new Point(106, 88);
            a.Name = "a";
            a.Size = new Size(125, 27);
            a.TabIndex = 3;
            // 
            // r
            // 
            r.Location = new Point(106, 229);
            r.Name = "r";
            r.Size = new Size(125, 27);
            r.TabIndex = 4;
            // 
            // b
            // 
            b.Location = new Point(106, 156);
            b.Name = "b";
            b.Size = new Size(125, 27);
            b.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 90);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 6;
            label1.Text = "A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 238);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 7;
            label2.Text = "C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 163);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b);
            Controls.Add(r);
            Controls.Add(a);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "a";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox a;
        private TextBox r;
        private TextBox b;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
