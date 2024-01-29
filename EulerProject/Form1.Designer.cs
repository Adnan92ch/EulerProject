namespace EulerProject
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProjektComboBox = new System.Windows.Forms.ComboBox();
            this.codeTextBox = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auswahl";
            // 
            // ProjektComboBox
            // 
            this.ProjektComboBox.FormattingEnabled = true;
            this.ProjektComboBox.Location = new System.Drawing.Point(150, 38);
            this.ProjektComboBox.Name = "ProjektComboBox";
            this.ProjektComboBox.Size = new System.Drawing.Size(583, 24);
            this.ProjektComboBox.TabIndex = 1;
            this.ProjektComboBox.SelectedIndexChanged += new System.EventHandler(this.loadButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(66, 136);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(667, 511);
            this.codeTextBox.TabIndex = 3;
            this.codeTextBox.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(642, 675);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(91, 32);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Starten";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 760);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.ProjektComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjektComboBox;
        private System.Windows.Forms.RichTextBox codeTextBox;
        private System.Windows.Forms.Button StartButton;
    }
}

