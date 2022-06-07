using System.Runtime.InteropServices;

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
            if(decodeRadioButton.Checked)
                actionUser.ChangeAction(Action.decode);
        }

        private void EncodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (encodeRadioButton.Checked)
                actionUser.ChangeAction(Action.encode);
        }

        private void disruptAndDecodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (disruptAndDecodeRadioButton.Checked)
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
            var (message, errors, position) = actionUser.TakeAction(coder);
            processedMessageTextBox.Text = message;
            if (decodeRadioButton.Checked && errors == 1)
            {
                var error_bit = int.Parse(position) - (int)Math.Floor(Math.Log(int.Parse(position),2)) - 2;
                processedMessageTextBox.Text = "";
                RichTextBoxExtensions.AppendText(processedMessageTextBox, message[..error_bit], Color.Black);
                RichTextBoxExtensions.AppendText(processedMessageTextBox, message[error_bit].ToString(), Color.Red);
                RichTextBoxExtensions.AppendText(processedMessageTextBox, message[(error_bit+1)..], Color.Black);
            }
            errorLabel.Text = $"Errors: {errors}" + ((errors == 1) ? "" : $", error corected at possition {position} in original message");
            processedMessageLabel.Text = "Processed message" + (encodeRadioButton.Checked? " (parity bits highlighted in red)" : "");
        }

        private void processedMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (encodeRadioButton.Checked)
            {
                string msg = processedMessageTextBox.Text;
                processedMessageTextBox.Text = "";
                if (coder is HammingCoder)
                {
                    for (int i = 0; i < msg.Length; i++)
                    {
                        if ((i & (i - 1)) == 0)
                            RichTextBoxExtensions.AppendText(processedMessageTextBox, msg[i].ToString(), Color.Red);
                        else
                            RichTextBoxExtensions.AppendText(processedMessageTextBox, msg[i].ToString(), Color.Black);
                    }
                }
                else if(coder is PolynomialCoder coder1)
                {
                    var msgLen = msg.Length - coder1.polyLen + 1;
                    RichTextBoxExtensions.AppendText(processedMessageTextBox, msg[..msgLen], Color.Black);
                    RichTextBoxExtensions.AppendText(processedMessageTextBox, msg[msgLen..], Color.Red);

                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}