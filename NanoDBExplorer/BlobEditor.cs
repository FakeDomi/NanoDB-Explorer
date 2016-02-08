using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    public partial class BlobEditor : Form
    {
        private readonly string baseValue;
        private bool cancelled = true;
        
        public BlobEditor(string baseValue)
        {
            this.InitializeComponent();
            this.uiFormatComboBox.SelectedIndex = 0;
            this.uiEditTextBox.Text = baseValue;
            this.baseValue = baseValue;

            this.Resize += this.ResizeEvent;
        }

        public string GetResult(IWin32Window parent)
        {
            this.ShowDialog(parent);

            if (this.cancelled)
            {
                return this.baseValue;
            }

            bool dec = this.uiFormatComboBox.SelectedIndex == 0;
            bool spaces = this.uiSpacesCheckBox.Checked;

            return LoadBytes(GetBytes(dec, spaces, this.uiEditTextBox.Text), true, true);
        }

        private void FormatComboBoxSelectedIndexChangedEvent(object sender, EventArgs e)
        {
            bool dec = this.uiFormatComboBox.SelectedIndex == 0;
            bool spaces = this.uiSpacesCheckBox.Checked;

            this.uiEditTextBox.Text = LoadBytes(GetBytes(!dec, spaces, this.uiEditTextBox.Text), dec, spaces);
        }

        private void SpacesCheckBoxCheckedChangedEvent(object sender, EventArgs e)
        {
            bool dec = this.uiFormatComboBox.SelectedIndex == 0;
            bool spaces = this.uiSpacesCheckBox.Checked;

            this.uiEditTextBox.Text = LoadBytes(GetBytes(dec, !spaces, this.uiEditTextBox.Text), dec, spaces);
        }

        private void OkButtonClickEvent(object sender, EventArgs e)
        {
            this.cancelled = false;
            this.Close();
        }

        private void CancelButtonClickEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            int height = this.Height, width = this.Width;

            this.uiEditTextBox.Size = new Size(width - 40, height - 91);

            this.uiFormatComboBox.Location = new Point(12, height - 72);
            this.uiSpacesCheckBox.Location = new Point(93, height - 69);

            this.uiOkButton.Location = new Point(width - 103, height - 73);
            this.uiCancelButton.Location = new Point(width - 184, height - 73);
        }

        private void EditTextBoxKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                this.OkButtonClickEvent(sender, null);
            }
        }

        private static byte[] GetBytes(bool dec, bool spaces, string text)
        {
            if (!dec && !spaces)
            {
                text = text.Replace(" ", "");
            }

            string[] splitInput = text.Split(' ', ';', ',', '-', ':');
            List<byte> values = new List<byte>();

            foreach (string value in splitInput)
            {
                byte parseTemp = 0;

                if (dec)
                {
                    if (byte.TryParse(value, out parseTemp))
                    {
                        values.Add(parseTemp);
                    }
                }
                else
                {
                    if (spaces)
                    {
                        if (byte.TryParse(value, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out parseTemp))
                        {
                            values.Add(parseTemp);
                        }
                    }
                    else
                    {
                        values.AddRange(from val in SplitString(value, 2) where byte.TryParse(val, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out parseTemp) select parseTemp);
                    }
                }
            }

            return values.ToArray();
        }

        private static string LoadBytes(byte[] bytes, bool dec, bool spaces)
        {
            return dec ? string.Join(spaces ? " " : ";", bytes) : BitConverter.ToString(bytes).Replace("-", spaces ? " " : "");
        }

        private static IEnumerable<string> SplitString(string s, int partLength)
        {
            for (int i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }
    }
}
