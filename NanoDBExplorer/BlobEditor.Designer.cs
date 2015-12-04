namespace domi1819.NanoDBExplorer
{
    using System.Windows.Forms;

    partial class BlobEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiEditTextBox = new System.Windows.Forms.TextBox();
            this.uiFormatComboBox = new System.Windows.Forms.ComboBox();
            this.uiOkButton = new System.Windows.Forms.Button();
            this.uiCancelButton = new System.Windows.Forms.Button();
            this.uiSpacesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uiEditTextBox
            // 
            this.uiEditTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uiEditTextBox.Location = new System.Drawing.Point(12, 12);
            this.uiEditTextBox.Multiline = true;
            this.uiEditTextBox.Name = "uiEditTextBox";
            this.uiEditTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiEditTextBox.Size = new System.Drawing.Size(410, 259);
            this.uiEditTextBox.TabIndex = 0;
            this.uiEditTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTextBoxKeyDownEvent);
            // 
            // uiFormatComboBox
            // 
            this.uiFormatComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.uiFormatComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiFormatComboBox.FormattingEnabled = true;
            this.uiFormatComboBox.Items.AddRange(new object[] {
            "Dec",
            "Hex"});
            this.uiFormatComboBox.Location = new System.Drawing.Point(12, 278);
            this.uiFormatComboBox.Name = "uiFormatComboBox";
            this.uiFormatComboBox.Size = new System.Drawing.Size(72, 21);
            this.uiFormatComboBox.TabIndex = 1;
            this.uiFormatComboBox.TabStop = false;
            this.uiFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.FormatComboBoxSelectedIndexChangedEvent);
            // 
            // uiOkButton
            // 
            this.uiOkButton.Location = new System.Drawing.Point(347, 277);
            this.uiOkButton.Name = "uiOkButton";
            this.uiOkButton.Size = new System.Drawing.Size(75, 23);
            this.uiOkButton.TabIndex = 2;
            this.uiOkButton.Text = "OK";
            this.uiOkButton.UseVisualStyleBackColor = true;
            this.uiOkButton.Click += new System.EventHandler(this.OkButtonClickEvent);
            // 
            // uiCancelButton
            // 
            this.uiCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiCancelButton.Location = new System.Drawing.Point(266, 277);
            this.uiCancelButton.Name = "uiCancelButton";
            this.uiCancelButton.Size = new System.Drawing.Size(75, 23);
            this.uiCancelButton.TabIndex = 3;
            this.uiCancelButton.Text = "Cancel";
            this.uiCancelButton.UseVisualStyleBackColor = true;
            this.uiCancelButton.Click += new System.EventHandler(this.CancelButtonClickEvent);
            // 
            // uiSpacesCheckBox
            // 
            this.uiSpacesCheckBox.AutoSize = true;
            this.uiSpacesCheckBox.Checked = true;
            this.uiSpacesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiSpacesCheckBox.Location = new System.Drawing.Point(93, 281);
            this.uiSpacesCheckBox.Name = "uiSpacesCheckBox";
            this.uiSpacesCheckBox.Size = new System.Drawing.Size(134, 17);
            this.uiSpacesCheckBox.TabIndex = 4;
            this.uiSpacesCheckBox.Text = "Spaces between bytes";
            this.uiSpacesCheckBox.UseVisualStyleBackColor = true;
            this.uiSpacesCheckBox.CheckedChanged += new System.EventHandler(this.SpacesCheckBoxCheckedChangedEvent);
            // 
            // BlobEditor
            // 
            this.AcceptButton = this.uiOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uiCancelButton;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.uiSpacesCheckBox);
            this.Controls.Add(this.uiCancelButton);
            this.Controls.Add(this.uiOkButton);
            this.Controls.Add(this.uiEditTextBox);
            this.Controls.Add(this.uiFormatComboBox);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "BlobEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blob Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiEditTextBox;
        private System.Windows.Forms.ComboBox uiFormatComboBox;
        private System.Windows.Forms.Button uiOkButton;
        private Button uiCancelButton;
        private CheckBox uiSpacesCheckBox;
    }
}