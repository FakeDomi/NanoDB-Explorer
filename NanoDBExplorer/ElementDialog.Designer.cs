using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    partial class ElementDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementDialog));
            this.uiElementComboBox = new System.Windows.Forms.ComboBox();
            this.uiNextButton = new System.Windows.Forms.Button();
            this.uiFinishButton = new System.Windows.Forms.Button();
            this.uiInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiElementComboBox
            // 
            this.uiElementComboBox.FormattingEnabled = true;
            this.uiElementComboBox.Location = new System.Drawing.Point(12, 29);
            this.uiElementComboBox.Name = "uiElementComboBox";
            this.uiElementComboBox.Size = new System.Drawing.Size(253, 21);
            this.uiElementComboBox.TabIndex = 0;
            this.uiElementComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIndexChanged);
            // 
            // uiNextButton
            // 
            this.uiNextButton.Enabled = false;
            this.uiNextButton.Location = new System.Drawing.Point(12, 56);
            this.uiNextButton.Name = "uiNextButton";
            this.uiNextButton.Size = new System.Drawing.Size(150, 23);
            this.uiNextButton.TabIndex = 1;
            this.uiNextButton.Text = "Next";
            this.uiNextButton.UseVisualStyleBackColor = true;
            this.uiNextButton.Click += new System.EventHandler(this.NextButtonClicked);
            // 
            // uiFinishButton
            // 
            this.uiFinishButton.Enabled = false;
            this.uiFinishButton.Location = new System.Drawing.Point(168, 56);
            this.uiFinishButton.Name = "uiFinishButton";
            this.uiFinishButton.Size = new System.Drawing.Size(97, 23);
            this.uiFinishButton.TabIndex = 2;
            this.uiFinishButton.Text = "Finish";
            this.uiFinishButton.UseVisualStyleBackColor = true;
            this.uiFinishButton.Click += new System.EventHandler(this.FinishButtonClicked);
            // 
            // uiInfoLabel
            // 
            this.uiInfoLabel.AutoSize = true;
            this.uiInfoLabel.Location = new System.Drawing.Point(13, 13);
            this.uiInfoLabel.Name = "uiInfoLabel";
            this.uiInfoLabel.Size = new System.Drawing.Size(87, 13);
            this.uiInfoLabel.TabIndex = 3;
            this.uiInfoLabel.Text = "Select DB object";
            // 
            // ElementDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 94);
            this.Controls.Add(this.uiInfoLabel);
            this.Controls.Add(this.uiFinishButton);
            this.Controls.Add(this.uiNextButton);
            this.Controls.Add(this.uiElementComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElementDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select DB object";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiElementComboBox;
        private System.Windows.Forms.Button uiNextButton;
        private System.Windows.Forms.Button uiFinishButton;
        private System.Windows.Forms.Label uiInfoLabel;
    }
}