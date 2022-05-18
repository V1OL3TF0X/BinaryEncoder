namespace BinaryEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCoder();
            encode = true;
        }

        private void CodingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            encode = encodeRadioButton.Checked;
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
                if(dec.errorNo > 1)
                {
                    processedMessageTextBox.Text = "Encountered too many errors, unable to proceed";
                }
                else
                {
                    processedMessageTextBox.Text = dec.message;
                }
                errorLabel.Text = $"Errors: {dec.errorNo}" + ((dec.errorPos.Length>0)?$", Error Position: {dec.errorPos} in original message":"");

            }
           
        }
    }
}