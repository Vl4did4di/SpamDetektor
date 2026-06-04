namespace SpamDetektor
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
            lblInput = new Label();
            lblResult = new Label();
            txtMessage = new TextBox();
            panelResult = new Panel();
            btnAnalyze = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(353, 24);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(90, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Unesite poruku:";
            // 
            // lblResult
            // 
            lblResult.Dock = DockStyle.Fill;
            lblResult.Location = new Point(0, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(800, 450);
            lblResult.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(278, 54);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(245, 77);
            txtMessage.TabIndex = 2;
            // 
            // panelResult
            // 
            panelResult.Location = new Point(298, 280);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(200, 100);
            panelResult.TabIndex = 3;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(341, 137);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(111, 39);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Analiziraj poruku";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(341, 182);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Obrisi";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnAnalyze);
            Controls.Add(panelResult);
            Controls.Add(txtMessage);
            Controls.Add(lblResult);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private Label lblResult;
        private TextBox txtMessage;
        private Panel panelResult;
        private Button btnAnalyze;
        private Button btnClear;
    }
}
