using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class BlobEditor : Form
    {
        public BlobEditor()
        {
            this.InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void HandleTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                this.button1_Click(sender, null);
            }
        }

        private byte[] GetBytes()
        {
            string[] splitInput = this.textBox1.Text.Split(' ', ';', ',', '-', ':');
            List<byte> values = new List<byte>();

            foreach (string value in splitInput)
            {
                byte parseTemp;

                if (this.comboBox1.SelectedIndex == 0 && byte.TryParse(value, out parseTemp) || byte.TryParse(value, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out parseTemp))
                {
                    values.Add(parseTemp);
                }
            }

            return values.ToArray();
        }

        private void LoadBytes(byte[] bytes)
        {
            // TODO
        }
    }
}
