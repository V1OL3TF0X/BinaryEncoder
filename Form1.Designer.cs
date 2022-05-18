namespace BinaryEncoder
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
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodeRadioButton
            // 
            this.EncodeRadioButton.AutoSize = true;
            this.EncodeRadioButton.Checked = true;
            this.EncodeRadioButton.Location = new System.Drawing.Point(7, 29);
            this.EncodeRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncodeRadioButton.Name = "EncodeRadioButton";
            this.EncodeRadioButton.Size = new System.Drawing.Size(79, 24);
            this.EncodeRadioButton.TabIndex = 0;
            this.EncodeRadioButton.TabStop = true;
            this.EncodeRadioButton.Text = "Encode";
            this.EncodeRadioButton.UseVisualStyleBackColor = true;
            this.EncodeRadioButton.CheckedChanged += new System.EventHandler(this.EncodeRadioButton_CheckedChanged);
            // 
            // DecodeRadioButton
            // 
            this.DecodeRadioButton.AutoSize = true;
            this.DecodeRadioButton.Location = new System.Drawing.Point(7, 63);
            this.DecodeRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecodeRadioButton.Name = "DecodeRadioButton";
            this.DecodeRadioButton.Size = new System.Drawing.Size(82, 24);
            this.DecodeRadioButton.TabIndex = 1;
            this.DecodeRadioButton.Text = "Decode";
            this.DecodeRadioButton.UseVisualStyleBackColor = true;
            this.DecodeRadioButton.CheckedChanged += new System.EventHandler(this.DecodeRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EncodeRadioButton);
            this.groupBox1.Controls.Add(this.DecodeRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(168, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HammingCoderRadioButton);
            this.groupBox2.Controls.Add(this.PolynomialCoderRadioButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(168, 457);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coder";
            // 
            // HammingCoderRadioButton
            // 
            this.HammingCoderRadioButton.AutoSize = true;
            this.HammingCoderRadioButton.Checked = true;
            this.HammingCoderRadioButton.Location = new System.Drawing.Point(8, 28);
            this.HammingCoderRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HammingCoderRadioButton.Name = "HammingCoderRadioButton";
            this.HammingCoderRadioButton.Size = new System.Drawing.Size(96, 24);
            this.HammingCoderRadioButton.TabIndex = 2;
            this.HammingCoderRadioButton.TabStop = true;
            this.HammingCoderRadioButton.Text = "Hamming";
            this.HammingCoderRadioButton.UseVisualStyleBackColor = true;
            this.HammingCoderRadioButton.CheckedChanged += new System.EventHandler(this.HammingCoderRadioButton_CheckedChanged);
            // 
            // PolynomialCoderRadioButton
            // 
            this.PolynomialCoderRadioButton.AutoSize = true;
            this.PolynomialCoderRadioButton.Location = new System.Drawing.Point(8, 61);
            this.PolynomialCoderRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PolynomialCoderRadioButton.Name = "PolynomialCoderRadioButton";
            this.PolynomialCoderRadioButton.Size = new System.Drawing.Size(103, 24);
            this.PolynomialCoderRadioButton.TabIndex = 3;
            this.PolynomialCoderRadioButton.Text = "Polynomial";
            this.PolynomialCoderRadioButton.UseVisualStyleBackColor = true;
            this.PolynomialCoderRadioButton.CheckedChanged += new System.EventHandler(this.PolynomialCoderRadioButton_CheckedChanged);
            // 
            // OriginalMessageTextBox
            // 
            this.OriginalMessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalMessageTextBox.Location = new System.Drawing.Point(3, 34);
            this.OriginalMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriginalMessageTextBox.Multiline = true;
            this.OriginalMessageTextBox.Name = "OriginalMessageTextBox";
            this.OriginalMessageTextBox.Size = new System.Drawing.Size(611, 745);
            this.OriginalMessageTextBox.TabIndex = 4;
            // 
            // DecodedMessageLAbel
            // 
            this.DecodedMessageLAbel.AutoSize = true;
            this.DecodedMessageLAbel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecodedMessageLAbel.Location = new System.Drawing.Point(3, 0);
            this.DecodedMessageLAbel.Name = "DecodedMessageLAbel";
            this.DecodedMessageLAbel.Size = new System.Drawing.Size(611, 30);
            this.DecodedMessageLAbel.TabIndex = 5;
            this.DecodedMessageLAbel.Text = "Original message";
            // 
            // EncodedMessageLabel
            // 
            this.EncodedMessageLabel.AutoSize = true;
            this.EncodedMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodedMessageLabel.Location = new System.Drawing.Point(620, 0);
            this.EncodedMessageLabel.Name = "EncodedMessageLabel";
            this.EncodedMessageLabel.Size = new System.Drawing.Size(611, 30);
            this.EncodedMessageLabel.TabIndex = 7;
            this.EncodedMessageLabel.Text = "Processed message";
            // 
            // EncodedMessageTextBox
            // 
            this.EncodedMessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodedMessageTextBox.Location = new System.Drawing.Point(620, 34);
            this.EncodedMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncodedMessageTextBox.Multiline = true;
            this.EncodedMessageTextBox.Name = "EncodedMessageTextBox";
            this.EncodedMessageTextBox.Size = new System.Drawing.Size(611, 745);
            this.EncodedMessageTextBox.TabIndex = 6;
            // 
            // doStuffButton
            // 
            this.doStuffButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doStuffButton.Location = new System.Drawing.Point(3, 745);
            this.doStuffButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doStuffButton.Name = "doStuffButton";
            this.doStuffButton.Size = new System.Drawing.Size(168, 82);
            this.doStuffButton.TabIndex = 8;
            this.doStuffButton.Text = "WORK";
            this.doStuffButton.UseVisualStyleBackColor = true;
            this.doStuffButton.Click += new System.EventHandler(this.doStuffButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(3, 789);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(62, 20);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Errors: 0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorLabel.Location = new System.Drawing.Point(0, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(375, 20);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Autorzy: Mateusz Adamiec, Michał Boruta, Maciej Ejduk";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AuthorLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1418, 870);
            this.splitContainer1.SplitterDistance = 831;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1418, 831);
            this.splitContainer2.SplitterDistance = 1240;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ErrorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1240, 831);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.EncodedMessageLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OriginalMessageTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DecodedMessageLAbel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.EncodedMessageTextBox, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1234, 783);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.doStuffButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.26791F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.73209F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 831);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 870);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Aplikacja do korekcji pojedynczego błędu za pomocą kodowania Hamminga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Label AuthorLabel;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}