namespace Black_Jack
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
            btnSacarCarta = new Button();
            lbUltimaCarta = new Label();
            lbValor = new Label();
            lbNumero = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnSacarCarta
            // 
            btnSacarCarta.Location = new Point(297, 389);
            btnSacarCarta.Name = "btnSacarCarta";
            btnSacarCarta.Size = new Size(107, 49);
            btnSacarCarta.TabIndex = 0;
            btnSacarCarta.Text = "Sacar Carta";
            btnSacarCarta.UseVisualStyleBackColor = true;
            btnSacarCarta.Click += btnSacarCarta_Click;
            // 
            // lbUltimaCarta
            // 
            lbUltimaCarta.AutoSize = true;
            lbUltimaCarta.ForeColor = Color.Red;
            lbUltimaCarta.Location = new Point(250, 324);
            lbUltimaCarta.Name = "lbUltimaCarta";
            lbUltimaCarta.Size = new Size(15, 15);
            lbUltimaCarta.TabIndex = 1;
            lbUltimaCarta.Text = "♥";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(425, 324);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor";
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(326, 324);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(51, 15);
            lbNumero.TabIndex = 3;
            lbNumero.Text = "Numero";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(425, 415);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(lbNumero);
            Controls.Add(lbValor);
            Controls.Add(lbUltimaCarta);
            Controls.Add(btnSacarCarta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacarCarta;
        private Label lbUltimaCarta;
        private Label lbValor;
        private Label lbNumero;
        private Button btnReset;
    }
}
