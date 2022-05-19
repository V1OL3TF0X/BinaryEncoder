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
            this.encodeRadioButton = new System.Windows.Forms.RadioButton();
            this.decodeRadioButton = new System.Windows.Forms.RadioButton();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.disruptAndDecodeRadioButton = new System.Windows.Forms.RadioButton();
            this.coderGroupBox = new System.Windows.Forms.GroupBox();
            this.hammingCoderRadioButton = new System.Windows.Forms.RadioButton();
            this.polynomialCoderRadioButton = new System.Windows.Forms.RadioButton();
            this.originalMessageTextBox = new System.Windows.Forms.TextBox();
            this.originalMessageLabel = new System.Windows.Forms.Label();
            this.processedMessageLabel = new System.Windows.Forms.Label();
            this.processedMessageTextBox = new System.Windows.Forms.TextBox();
            this.doStuffButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.panelAuthorsSplitter = new System.Windows.Forms.SplitContainer();
            this.messagesActionsSplitter = new System.Windows.Forms.SplitContainer();
            this.messagesErrorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.messagesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionGroupBox.SuspendLayout();
            this.coderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorsSplitter)).BeginInit();
            this.panelAuthorsSplitter.Panel1.SuspendLayout();
            this.panelAuthorsSplitter.Panel2.SuspendLayout();
            this.panelAuthorsSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesActionsSplitter)).BeginInit();
            this.messagesActionsSplitter.Panel1.SuspendLayout();
            this.messagesActionsSplitter.Panel2.SuspendLayout();
            this.messagesActionsSplitter.SuspendLayout();
            this.messagesErrorTableLayoutPanel.SuspendLayout();
            this.messagesTableLayoutPanel.SuspendLayout();
            this.actionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodeRadioButton
            // 
            this.encodeRadioButton.AutoSize = true;
            this.encodeRadioButton.Checked = true;
            this.encodeRadioButton.Location = new System.Drawing.Point(7, 29);
            this.encodeRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encodeRadioButton.Name = "encodeRadioButton";
            this.encodeRadioButton.Size = new System.Drawing.Size(79, 24);
            this.encodeRadioButton.TabIndex = 0;
            this.encodeRadioButton.TabStop = true;
            this.encodeRadioButton.Text = "Encode";
            this.encodeRadioButton.UseVisualStyleBackColor = true;
            this.encodeRadioButton.CheckedChanged += new System.EventHandler(this.EncodeRadioButton_CheckedChanged);
            // 
            // decodeRadioButton
            // 
            this.decodeRadioButton.AutoSize = true;
            this.decodeRadioButton.Location = new System.Drawing.Point(7, 63);
            this.decodeRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decodeRadioButton.Name = "decodeRadioButton";
            this.decodeRadioButton.Size = new System.Drawing.Size(82, 24);
            this.decodeRadioButton.TabIndex = 1;
            this.decodeRadioButton.Text = "Decode";
            this.decodeRadioButton.UseVisualStyleBackColor = true;
            this.decodeRadioButton.CheckedChanged += new System.EventHandler(this.CodingRadioButton_CheckedChanged);
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.disruptAndDecodeRadioButton);
            this.actionGroupBox.Controls.Add(this.encodeRadioButton);
            this.actionGroupBox.Controls.Add(this.decodeRadioButton);
            this.actionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionGroupBox.Location = new System.Drawing.Point(3, 4);
            this.actionGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actionGroupBox.Size = new System.Drawing.Size(168, 268);
            this.actionGroupBox.TabIndex = 2;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Action";
            // 
            // disruptAndDecodeRadioButton
            // 
            this.disruptAndDecodeRadioButton.AutoSize = true;
            this.disruptAndDecodeRadioButton.Location = new System.Drawing.Point(8, 94);
            this.disruptAndDecodeRadioButton.Name = "disruptAndDecodeRadioButton";
            this.disruptAndDecodeRadioButton.Size = new System.Drawing.Size(163, 24);
            this.disruptAndDecodeRadioButton.TabIndex = 2;
            this.disruptAndDecodeRadioButton.TabStop = true;
            this.disruptAndDecodeRadioButton.Text = "Disrupt and Decode";
            this.disruptAndDecodeRadioButton.UseVisualStyleBackColor = true;
            this.disruptAndDecodeRadioButton.CheckedChanged += new System.EventHandler(this.disruptAndDecodeRadioButton_CheckedChanged);
            // 
            // coderGroupBox
            // 
            this.coderGroupBox.Controls.Add(this.hammingCoderRadioButton);
            this.coderGroupBox.Controls.Add(this.polynomialCoderRadioButton);
            this.coderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coderGroupBox.Location = new System.Drawing.Point(3, 280);
            this.coderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coderGroupBox.Name = "coderGroupBox";
            this.coderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coderGroupBox.Size = new System.Drawing.Size(168, 457);
            this.coderGroupBox.TabIndex = 3;
            this.coderGroupBox.TabStop = false;
            this.coderGroupBox.Text = "Coder";
            // 
            // hammingCoderRadioButton
            // 
            this.hammingCoderRadioButton.AutoSize = true;
            this.hammingCoderRadioButton.Checked = true;
            this.hammingCoderRadioButton.Location = new System.Drawing.Point(8, 28);
            this.hammingCoderRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hammingCoderRadioButton.Name = "hammingCoderRadioButton";
            this.hammingCoderRadioButton.Size = new System.Drawing.Size(96, 24);
            this.hammingCoderRadioButton.TabIndex = 2;
            this.hammingCoderRadioButton.TabStop = true;
            this.hammingCoderRadioButton.Text = "Hamming";
            this.hammingCoderRadioButton.UseVisualStyleBackColor = true;
            this.hammingCoderRadioButton.CheckedChanged += new System.EventHandler(this.HammingCoderRadioButton_CheckedChanged);
            // 
            // polynomialCoderRadioButton
            // 
            this.polynomialCoderRadioButton.AutoSize = true;
            this.polynomialCoderRadioButton.Location = new System.Drawing.Point(8, 61);
            this.polynomialCoderRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.polynomialCoderRadioButton.Name = "polynomialCoderRadioButton";
            this.polynomialCoderRadioButton.Size = new System.Drawing.Size(103, 24);
            this.polynomialCoderRadioButton.TabIndex = 3;
            this.polynomialCoderRadioButton.Text = "Polynomial";
            this.polynomialCoderRadioButton.UseVisualStyleBackColor = true;
            this.polynomialCoderRadioButton.CheckedChanged += new System.EventHandler(this.PolynomialCoderRadioButton_CheckedChanged);
            // 
            // originalMessageTextBox
            // 
            this.originalMessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalMessageTextBox.Location = new System.Drawing.Point(3, 34);
            this.originalMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.originalMessageTextBox.Multiline = true;
            this.originalMessageTextBox.Name = "originalMessageTextBox";
            this.originalMessageTextBox.Size = new System.Drawing.Size(611, 745);
            this.originalMessageTextBox.TabIndex = 4;
            // 
            // originalMessageLabel
            // 
            this.originalMessageLabel.AutoSize = true;
            this.originalMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalMessageLabel.Location = new System.Drawing.Point(3, 0);
            this.originalMessageLabel.Name = "originalMessageLabel";
            this.originalMessageLabel.Size = new System.Drawing.Size(611, 30);
            this.originalMessageLabel.TabIndex = 5;
            this.originalMessageLabel.Text = "Original message";
            // 
            // processedMessageLabel
            // 
            this.processedMessageLabel.AutoSize = true;
            this.processedMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedMessageLabel.Location = new System.Drawing.Point(620, 0);
            this.processedMessageLabel.Name = "processedMessageLabel";
            this.processedMessageLabel.Size = new System.Drawing.Size(611, 30);
            this.processedMessageLabel.TabIndex = 7;
            this.processedMessageLabel.Text = "Processed message";
            // 
            // processedMessageTextBox
            // 
            this.processedMessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedMessageTextBox.Location = new System.Drawing.Point(620, 34);
            this.processedMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processedMessageTextBox.Multiline = true;
            this.processedMessageTextBox.Name = "processedMessageTextBox";
            this.processedMessageTextBox.Size = new System.Drawing.Size(611, 745);
            this.processedMessageTextBox.TabIndex = 6;
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
            this.doStuffButton.Click += new System.EventHandler(this.DoStuffButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(3, 789);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(62, 20);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Errors: 0";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorLabel.Location = new System.Drawing.Point(0, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(375, 20);
            this.authorLabel.TabIndex = 10;
            this.authorLabel.Text = "Autorzy: Mateusz Adamiec, Michał Boruta, Maciej Ejduk";
            // 
            // panelAuthorsSplitter
            // 
            this.panelAuthorsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuthorsSplitter.IsSplitterFixed = true;
            this.panelAuthorsSplitter.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorsSplitter.Name = "panelAuthorsSplitter";
            this.panelAuthorsSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panelAuthorsSplitter.Panel1
            // 
            this.panelAuthorsSplitter.Panel1.Controls.Add(this.messagesActionsSplitter);
            // 
            // panelAuthorsSplitter.Panel2
            // 
            this.panelAuthorsSplitter.Panel2.Controls.Add(this.authorLabel);
            this.panelAuthorsSplitter.Size = new System.Drawing.Size(1418, 870);
            this.panelAuthorsSplitter.SplitterDistance = 831;
            this.panelAuthorsSplitter.TabIndex = 11;
            // 
            // messagesActionsSplitter
            // 
            this.messagesActionsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesActionsSplitter.Location = new System.Drawing.Point(0, 0);
            this.messagesActionsSplitter.Name = "messagesActionsSplitter";
            // 
            // messagesActionsSplitter.Panel1
            // 
            this.messagesActionsSplitter.Panel1.Controls.Add(this.messagesErrorTableLayoutPanel);
            // 
            // messagesActionsSplitter.Panel2
            // 
            this.messagesActionsSplitter.Panel2.Controls.Add(this.actionsTableLayoutPanel);
            this.messagesActionsSplitter.Size = new System.Drawing.Size(1418, 831);
            this.messagesActionsSplitter.SplitterDistance = 1240;
            this.messagesActionsSplitter.TabIndex = 0;
            // 
            // messagesErrorTableLayoutPanel
            // 
            this.messagesErrorTableLayoutPanel.ColumnCount = 1;
            this.messagesErrorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagesErrorTableLayoutPanel.Controls.Add(this.errorLabel, 0, 1);
            this.messagesErrorTableLayoutPanel.Controls.Add(this.messagesTableLayoutPanel, 0, 0);
            this.messagesErrorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesErrorTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.messagesErrorTableLayoutPanel.Name = "messagesErrorTableLayoutPanel";
            this.messagesErrorTableLayoutPanel.RowCount = 2;
            this.messagesErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.messagesErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.messagesErrorTableLayoutPanel.Size = new System.Drawing.Size(1240, 831);
            this.messagesErrorTableLayoutPanel.TabIndex = 10;
            // 
            // messagesTableLayoutPanel
            // 
            this.messagesTableLayoutPanel.ColumnCount = 2;
            this.messagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesTableLayoutPanel.Controls.Add(this.processedMessageLabel, 1, 0);
            this.messagesTableLayoutPanel.Controls.Add(this.originalMessageTextBox, 0, 1);
            this.messagesTableLayoutPanel.Controls.Add(this.originalMessageLabel, 0, 0);
            this.messagesTableLayoutPanel.Controls.Add(this.processedMessageTextBox, 1, 1);
            this.messagesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.messagesTableLayoutPanel.Name = "messagesTableLayoutPanel";
            this.messagesTableLayoutPanel.RowCount = 2;
            this.messagesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.messagesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.messagesTableLayoutPanel.Size = new System.Drawing.Size(1234, 783);
            this.messagesTableLayoutPanel.TabIndex = 10;
            // 
            // actionsTableLayoutPanel
            // 
            this.actionsTableLayoutPanel.ColumnCount = 1;
            this.actionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionsTableLayoutPanel.Controls.Add(this.doStuffButton, 0, 2);
            this.actionsTableLayoutPanel.Controls.Add(this.coderGroupBox, 0, 1);
            this.actionsTableLayoutPanel.Controls.Add(this.actionGroupBox, 0, 0);
            this.actionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.actionsTableLayoutPanel.Name = "actionsTableLayoutPanel";
            this.actionsTableLayoutPanel.RowCount = 3;
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.26791F));
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.73209F));
            this.actionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.actionsTableLayoutPanel.Size = new System.Drawing.Size(174, 831);
            this.actionsTableLayoutPanel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 870);
            this.Controls.Add(this.panelAuthorsSplitter);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Aplikacja do korekcji pojedynczego błędu za pomocą kodowania Hamminga";
            this.actionGroupBox.ResumeLayout(false);
            this.actionGroupBox.PerformLayout();
            this.coderGroupBox.ResumeLayout(false);
            this.coderGroupBox.PerformLayout();
            this.panelAuthorsSplitter.Panel1.ResumeLayout(false);
            this.panelAuthorsSplitter.Panel2.ResumeLayout(false);
            this.panelAuthorsSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorsSplitter)).EndInit();
            this.panelAuthorsSplitter.ResumeLayout(false);
            this.messagesActionsSplitter.Panel1.ResumeLayout(false);
            this.messagesActionsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messagesActionsSplitter)).EndInit();
            this.messagesActionsSplitter.ResumeLayout(false);
            this.messagesErrorTableLayoutPanel.ResumeLayout(false);
            this.messagesErrorTableLayoutPanel.PerformLayout();
            this.messagesTableLayoutPanel.ResumeLayout(false);
            this.messagesTableLayoutPanel.PerformLayout();
            this.actionsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton encodeRadioButton;
        private RadioButton decodeRadioButton;
        private GroupBox actionGroupBox;
        private GroupBox coderGroupBox;
        private RadioButton hammingCoderRadioButton;
        private RadioButton polynomialCoderRadioButton;
        private TextBox originalMessageTextBox;
        private Label originalMessageLabel;
        private Label processedMessageLabel;
        private TextBox processedMessageTextBox;
        private ICoder coder;
        private ActionUser actionUser;
        private Button doStuffButton;
        private Label errorLabel;
        private Label authorLabel;
        private SplitContainer panelAuthorsSplitter;
        private SplitContainer messagesActionsSplitter;
        private TableLayoutPanel messagesErrorTableLayoutPanel;
        private TableLayoutPanel messagesTableLayoutPanel;
        private TableLayoutPanel actionsTableLayoutPanel;
        private RadioButton disruptAndDecodeRadioButton;
    }
}