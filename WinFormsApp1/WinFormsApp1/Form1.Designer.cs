namespace WinFormsApp1
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
            primerNumero = new Label();
            numeroA = new TextBox();
            button1 = new Button();
            numeroB = new TextBox();
            numeroC = new TextBox();
            segundoNumero = new Label();
            tercerNumero = new Label();
            SuspendLayout();
            // 
            // primerNumero
            // 
            primerNumero.AutoSize = true;
            primerNumero.Location = new Point(93, 63);
            primerNumero.Name = "primerNumero";
            primerNumero.Size = new Size(87, 15);
            primerNumero.TabIndex = 0;
            primerNumero.Text = "Primer numero";
            primerNumero.Click += txt1_Click;
            // 
            // numeroA
            // 
            numeroA.Location = new Point(192, 60);
            numeroA.Name = "numeroA";
            numeroA.Size = new Size(100, 23);
            numeroA.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(203, 193);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numeroB
            // 
            numeroB.Location = new Point(192, 102);
            numeroB.Name = "numeroB";
            numeroB.Size = new Size(100, 23);
            numeroB.TabIndex = 3;
            // 
            // numeroC
            // 
            numeroC.Location = new Point(192, 140);
            numeroC.Name = "numeroC";
            numeroC.Size = new Size(100, 23);
            numeroC.TabIndex = 4;
            // 
            // segundoNumero
            // 
            segundoNumero.AutoSize = true;
            segundoNumero.Location = new Point(88, 105);
            segundoNumero.Name = "segundoNumero";
            segundoNumero.Size = new Size(99, 15);
            segundoNumero.TabIndex = 5;
            segundoNumero.Text = "Segundo numero";
            // 
            // tercerNumero
            // 
            tercerNumero.AutoSize = true;
            tercerNumero.Location = new Point(97, 143);
            tercerNumero.Name = "tercerNumero";
            tercerNumero.Size = new Size(83, 15);
            tercerNumero.TabIndex = 6;
            tercerNumero.Text = "Tercer numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tercerNumero);
            Controls.Add(segundoNumero);
            Controls.Add(numeroC);
            Controls.Add(numeroB);
            Controls.Add(button1);
            Controls.Add(numeroA);
            Controls.Add(primerNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label primerNumero;
        private TextBox numeroA;
        private Button button1;
        private TextBox numeroB;
        private TextBox numeroC;
        private Label segundoNumero;
        private Label tercerNumero;
    }
}
