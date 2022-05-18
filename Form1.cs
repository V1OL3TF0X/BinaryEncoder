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
            encode = encodeRadioButton.Checked;
        }

        private void UpdateCoder()
        {
            if (hammingCoderRadioButton.Checked)
                coder = new HammingCoder();
            else if (polynomialCoderRadioButton.Checked)
                coder = new PolynomialCoder();
        }

        private void doStuffButton_Click(object sender, EventArgs e)
        {
            coder.newMessage(originalMessageTextBox.Text);
            if (encode)
            {
                processedMessageTextBox.Text = coder.EncodeMessage();
            }
            else
            {
                var dec = coder.DecodeMessage();
                switch (dec.errorNo)
                { 
                    case 0:
                        processedMessageTextBox.Text = dec.message;
                        break;
                    case 1:
                        processedMessageTextBox.Text = dec.message;
                        break;
                    default:
                        processedMessageTextBox.Text = "Encountered too many errors, unable to proceed";
                        break;
                }
                errorLabel.Text = $"Errors: {dec.errorNo}" + ((dec.errorPos.Length>0)?$", Error Position: {dec.errorPos} in original message":"");

            }
           
        }
    }
}