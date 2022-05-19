namespace BinaryEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCoder();
            actionUser = new();
        }

        private void CodingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            actionUser.ChangeAction(Action.decode);
        }

        private void EncodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            actionUser.ChangeAction(Action.encode);
        }

        private void disruptAndDecodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            actionUser.ChangeAction(Action.disrupt_and_decode);
        }

        private void HammingCoderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCoder();
        }

        private void PolynomialCoderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCoder();
        }

        private void UpdateCoder()
        {
            if (hammingCoderRadioButton.Checked)
                coder = new HammingCoder();
            else if (polynomialCoderRadioButton.Checked)
                coder = new PolynomialCoder();
        }

        private void DoStuffButton_Click(object sender, EventArgs e)
        {
            coder.newMessage(originalMessageTextBox.Text);
            var x = actionUser.TakeAction(coder);
            processedMessageTextBox.Text = x.message;
            errorLabel.Text = $"Errors: {x.errors}" + ((x.errors == 0) ? $", error corected at possition {x.position} in original message" : "");
        }
    }
}