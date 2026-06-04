namespace SpamDetektor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show(
                    "Molimo unesite poruku za analizu.",
                    "Unos je obavezan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var sampleData = new MLModel1.ModelInput()
            {
                Col1 = txtMessage.Text,
            };

            var result = MLModel1.Predict(sampleData);

            bool isSpam = result.PredictedLabel == "spam";

            string poruka = "📨 Poruka: " + sampleData.Col1 + "\n\n";
            string oznaka = isSpam
                              ? "⚠️  Oznaka: SPAM\n"
                              : "✅  Oznaka: HAM (legitimna poruka)\n";
            string skorSpam = "Spam skor: "
                              + (result.Score[1] * 100).ToString("0.00") + "%\n";
            string skorHam = "Ham skor:  "
                              + (result.Score[0] * 100).ToString("0.00") + "%";

            lblResult.Text = poruka + oznaka + skorSpam + skorHam;

            panelResult.BackColor = isSpam
                                    ? Color.FromArgb(255, 220, 220)
                                    : Color.FromArgb(220, 255, 220);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            lblResult.Text = string.Empty;
            panelResult.BackColor = SystemColors.Control;
        }
    }

}
