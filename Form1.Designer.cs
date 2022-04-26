﻿namespace BinaryEncoder
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
            this.EncodeRadioButton = new System.Windows.Forms.RadioButton();
            this.DecodeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HammingCoderRadioButton = new System.Windows.Forms.RadioButton();
            this.PolynomialCoderRadioButton = new System.Windows.Forms.RadioButton();
            this.OriginalMessageTextBox = new System.Windows.Forms.TextBox();
            this.DecodedMessageLAbel = new System.Windows.Forms.Label();
            this.EncodedMessageLabel = new System.Windows.Forms.Label();
            this.EncodedMessageTextBox = new System.Windows.Forms.TextBox();
            this.doStuffButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodeRadioButton
            // 
            this.EncodeRadioButton.AutoSize = true;
            this.EncodeRadioButton.Checked = true;
            this.EncodeRadioButton.Location = new System.Drawing.Point(6, 22);
            this.EncodeRadioButton.Name = "EncodeRadioButton";
            this.EncodeRadioButton.Size = new System.Drawing.Size(64, 19);
            this.EncodeRadioButton.TabIndex = 0;
            this.EncodeRadioButton.TabStop = true;
            this.EncodeRadioButton.Text = "Encode";
            this.EncodeRadioButton.UseVisualStyleBackColor = true;
            this.EncodeRadioButton.CheckedChanged += new System.EventHandler(this.EncodeRadioButton_CheckedChanged);
            // 
            // DecodeRadioButton
            // 
            this.DecodeRadioButton.AutoSize = true;
            this.DecodeRadioButton.Location = new System.Drawing.Point(6, 47);
            this.DecodeRadioButton.Name = "DecodeRadioButton";
            this.DecodeRadioButton.Size = new System.Drawing.Size(65, 19);
            this.DecodeRadioButton.TabIndex = 1;
            this.DecodeRadioButton.Text = "Decode";
            this.DecodeRadioButton.UseVisualStyleBackColor = true;
            this.DecodeRadioButton.CheckedChanged += new System.EventHandler(this.DecodeRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.EncodeRadioButton);
            this.groupBox1.Controls.Add(this.DecodeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(384, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.HammingCoderRadioButton);
            this.groupBox2.Controls.Add(this.PolynomialCoderRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(384, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coder";
            // 
            // HammingCoderRadioButton
            // 
            this.HammingCoderRadioButton.AutoSize = true;
            this.HammingCoderRadioButton.Checked = true;
            this.HammingCoderRadioButton.Location = new System.Drawing.Point(7, 21);
            this.HammingCoderRadioButton.Name = "HammingCoderRadioButton";
            this.HammingCoderRadioButton.Size = new System.Drawing.Size(79, 19);
            this.HammingCoderRadioButton.TabIndex = 2;
            this.HammingCoderRadioButton.TabStop = true;
            this.HammingCoderRadioButton.Text = "Hamming";
            this.HammingCoderRadioButton.UseVisualStyleBackColor = true;
            this.HammingCoderRadioButton.CheckedChanged += new System.EventHandler(this.HammingCoderRadioButton_CheckedChanged);
            // 
            // PolynomialCoderRadioButton
            // 
            this.PolynomialCoderRadioButton.AutoSize = true;
            this.PolynomialCoderRadioButton.Location = new System.Drawing.Point(7, 46);
            this.PolynomialCoderRadioButton.Name = "PolynomialCoderRadioButton";
            this.PolynomialCoderRadioButton.Size = new System.Drawing.Size(85, 19);
            this.PolynomialCoderRadioButton.TabIndex = 3;
            this.PolynomialCoderRadioButton.Text = "Polynomial";
            this.PolynomialCoderRadioButton.UseVisualStyleBackColor = true;
            this.PolynomialCoderRadioButton.CheckedChanged += new System.EventHandler(this.PolynomialCoderRadioButton_CheckedChanged);
            // 
            // OriginalMessageTextBox
            // 
            this.OriginalMessageTextBox.Location = new System.Drawing.Point(12, 30);
            this.OriginalMessageTextBox.Multiline = true;
            this.OriginalMessageTextBox.Name = "OriginalMessageTextBox";
            this.OriginalMessageTextBox.Size = new System.Drawing.Size(167, 261);
            this.OriginalMessageTextBox.TabIndex = 4;
            this.OriginalMessageTextBox.TextChanged += new System.EventHandler(this.OriginalMessageTextBox_TextChanged);
            // 
            // DecodedMessageLAbel
            // 
            this.DecodedMessageLAbel.AutoSize = true;
            this.DecodedMessageLAbel.Location = new System.Drawing.Point(12, 9);
            this.DecodedMessageLAbel.Name = "DecodedMessageLAbel";
            this.DecodedMessageLAbel.Size = new System.Drawing.Size(98, 15);
            this.DecodedMessageLAbel.TabIndex = 5;
            this.DecodedMessageLAbel.Text = "Original message";
            // 
            // EncodedMessageLabel
            // 
            this.EncodedMessageLabel.AutoSize = true;
            this.EncodedMessageLabel.Location = new System.Drawing.Point(185, 9);
            this.EncodedMessageLabel.Name = "EncodedMessageLabel";
            this.EncodedMessageLabel.Size = new System.Drawing.Size(109, 15);
            this.EncodedMessageLabel.TabIndex = 7;
            this.EncodedMessageLabel.Text = "Processed message";
            // 
            // EncodedMessageTextBox
            // 
            this.EncodedMessageTextBox.Location = new System.Drawing.Point(185, 30);
            this.EncodedMessageTextBox.Multiline = true;
            this.EncodedMessageTextBox.Name = "EncodedMessageTextBox";
            this.EncodedMessageTextBox.Size = new System.Drawing.Size(171, 261);
            this.EncodedMessageTextBox.TabIndex = 6;
            // 
            // doStuffButton
            // 
            this.doStuffButton.Location = new System.Drawing.Point(401, 268);
            this.doStuffButton.Name = "doStuffButton";
            this.doStuffButton.Size = new System.Drawing.Size(75, 23);
            this.doStuffButton.TabIndex = 8;
            this.doStuffButton.Text = "WORK";
            this.doStuffButton.UseVisualStyleBackColor = true;
            this.doStuffButton.Click += new System.EventHandler(this.doStuffButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(14, 294);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(49, 15);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Errors: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 318);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.doStuffButton);
            this.Controls.Add(this.EncodedMessageLabel);
            this.Controls.Add(this.EncodedMessageTextBox);
            this.Controls.Add(this.DecodedMessageLAbel);
            this.Controls.Add(this.OriginalMessageTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton EncodeRadioButton;
        private RadioButton DecodeRadioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton HammingCoderRadioButton;
        private RadioButton PolynomialCoderRadioButton;
        private TextBox OriginalMessageTextBox;
        private Label DecodedMessageLAbel;
        private Label EncodedMessageLabel;
        private TextBox EncodedMessageTextBox;
        private ICoder coder;
        private bool encode;
        private Button doStuffButton;
        private Label ErrorLabel;
    }
}