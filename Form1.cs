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
            var x = actionUser.TakeAction(coder);
            processedMessageTextBox.Text = x.message;
            errorLabel.Text = $"Errors: {x.errors}" + ((x.errors == 0) ? "" : $", error corected at possition {x.position} in original message");
            processedMessageLabel.Text = "Processed message" + (encodeRadioButton.Checked? " (parity bits highlighted in red)" : "");
        }

        private void processedMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if(encodeRadioButton.Checked)
            {
                if(coder is HammingCoder)
                {
                    string msg = processedMessageTextBox.Text;
                    processedMessageTextBox.Text = "";
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
                    string msg = processedMessageTextBox.Text;
                    processedMessageTextBox.Text = "";
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