namespace BinaryEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCoder();
            UpdateEncode();
        }

        private void EncodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEncode();
        }

        private void DecodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEncode();
        }

        private void HammingCoderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCoder();
        }

        private void PolynomialCoderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCoder();
        }

        private void UpdateEncode()
        {
            encode = EncodeRadioButton.Checked;
        }

        private void UpdateCoder()
        {
            if (HammingCoderRadioButton.Checked)
                coder = new HammingCoder();
            else if (PolynomialCoderRadioButton.Checked)
                coder = new PolynomialCoder();
        }

        private void doStuffButton_Click(object sender, EventArgs e)
        {
            coder.newMessage(OriginalMessageTextBox.Text);
            if (encode)
            {
                EncodedMessageTextBox.Text = coder.EncodeMessage();
            }
            else
            {
                var dec = coder.DecodeMessage();
                switch (dec.errorNo)
                { 
                    case 0:
                        EncodedMessageTextBox.Text = dec.message;
                        break;
                    case 1:
                        EncodedMessageTextBox.Text = dec.message;
                        break;
                    default:
                        EncodedMessageTextBox.Text = "Encountered too many errors, unable to proceed";
                        break;
                }
                ErrorLabel.Text = $"Errors: {dec.errorNo}";

            }
           
        }
    }
}