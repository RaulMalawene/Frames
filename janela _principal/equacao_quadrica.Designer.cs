namespace janela__principal
{
    partial class equacao_quadrica
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
            a = new TextBox();
            b = new TextBox();
            c = new TextBox();
            x1 = new TextBox();
            delta = new TextBox();
            x2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // a
            // 
            a.Location = new Point(101, 43);
            a.Name = "a";
            a.Size = new Size(125, 27);
            a.TabIndex = 0;
            // 
            // b
            // 
            b.Location = new Point(101, 94);
            b.Name = "b";
            b.Size = new Size(125, 27);
            b.TabIndex = 1;
            // 
            // c
            // 
            c.Location = new Point(101, 145);
            c.Name = "c";
            c.Size = new Size(125, 27);
            c.TabIndex = 2;
            // 
            // x1
            // 
            x1.Location = new Point(418, 90);
            x1.Name = "x1";
            x1.Size = new Size(125, 27);
            x1.TabIndex = 4;
            // 
            // delta
            // 
            delta.Location = new Point(418, 43);
            delta.Name = "delta";
            delta.Size = new Size(125, 27);
            delta.TabIndex = 5;
            // 
            // x2
            // 
            x2.Location = new Point(418, 145);
            x2.Name = "x2";
            x2.Size = new Size(125, 27);
            x2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(101, 226);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 226);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 9;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 152);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 10;
            label2.Text = "C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 97);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 11;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 152);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 12;
            label4.Text = "X2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 46);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 14;
            label6.Text = "Delta";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(378, 97);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 16;
            label8.Text = "X1";
            label8.Click += label8_Click;
            // 
            // equacao_quadrica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(x2);
            Controls.Add(delta);
            Controls.Add(x1);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(a);
            Name = "equacao_quadrica";
            Text = "equacao_quadrica";
            Load += equacao_quadrica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox a;
        private TextBox b;
        private TextBox c;
        private TextBox x1;
        private TextBox delta;
        private TextBox x2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
    }
}