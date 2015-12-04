using domi1819.NanoDB;
using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    public partial class ElementDialog : Form
    {
        public NanoDBElement ReturnValue { get; private set; }
        public bool Finish { get; private set; }

        private bool disableClose = true;

        public ElementDialog(int num)
        {
            this.InitializeComponent();

            if (num == 0)
            {
                this.uiInfoLabel.Text = "Select indexable DB object 0";
            }
            else
            {
                this.uiInfoLabel.Text = "Select DB object " + num;
            }

            if (num > 0)
            {
                this.uiElementComboBox.Items.Add("Boolean");
                this.uiElementComboBox.Items.Add("Byte");
                this.uiElementComboBox.Items.Add("Short");
                this.uiElementComboBox.Items.Add("Integer");
                this.uiElementComboBox.Items.Add("Long");
            }

            this.uiElementComboBox.Items.Add("String8");
            this.uiElementComboBox.Items.Add("String16");
            this.uiElementComboBox.Items.Add("String32");
            this.uiElementComboBox.Items.Add("String64");
            this.uiElementComboBox.Items.Add("String128");
            this.uiElementComboBox.Items.Add("String256");

            if (num > 0)
            {
                this.uiElementComboBox.Items.Add("DataBlob32");
                this.uiElementComboBox.Items.Add("DataBlob64");
                this.uiElementComboBox.Items.Add("DataBlob128");
                this.uiElementComboBox.Items.Add("DataBlob256");
                this.uiElementComboBox.Items.Add("DateTime");
            }
        }

        private void NextButtonClicked(object sender, System.EventArgs e)
        {
            this.GetElement();
            this.disableClose = false;
            this.Close();
        }

        private void FinishButtonClicked(object sender, System.EventArgs e)
        {
            this.GetElement();
            this.Finish = true;
            this.disableClose = false;
            this.Close();
        }

        private void GetElement()
        {
            if (this.uiElementComboBox.SelectedIndex == -1)
            {
                this.ReturnValue = NanoDBElement.String8;
            }

            switch ((string)this.uiElementComboBox.Items[this.uiElementComboBox.SelectedIndex])
            {
                case "Boolean":
                    this.ReturnValue = NanoDBElement.Bool;
                    break;
                case "Byte":
                    this.ReturnValue = NanoDBElement.Byte;
                    break;
                case "Short":
                    this.ReturnValue = NanoDBElement.Short;
                    break;
                case "Integer":
                    this.ReturnValue = NanoDBElement.Int;
                    break;
                case "Long":
                    this.ReturnValue = NanoDBElement.Long;
                    break;
                case "String8":
                    this.ReturnValue = NanoDBElement.String8;
                    break;
                case "String16":
                    this.ReturnValue = NanoDBElement.String16;
                    break;
                case "String32":
                    this.ReturnValue = NanoDBElement.String32;
                    break;
                case "String64":
                    this.ReturnValue = NanoDBElement.String64;
                    break;
                case "String128":
                    this.ReturnValue = NanoDBElement.String128;
                    break;
                case "String256":
                    this.ReturnValue = NanoDBElement.String256;
                    break;
                case "DataBlob32":
                    this.ReturnValue = NanoDBElement.DataBlob32;
                    break;
                case "DataBlob64":
                    this.ReturnValue = NanoDBElement.DataBlob64;
                    break;
                case "DataBlob128":
                    this.ReturnValue = NanoDBElement.DataBlob128;
                    break;
                case "DataBlob256":
                    this.ReturnValue = NanoDBElement.DataBlob256;
                    break;
                case "DateTime":
                    this.ReturnValue = NanoDBElement.DateTime;
                    break;
                default:
                    this.ReturnValue = NanoDBElement.String8;
                    break;
            }
        }

        private void ComboBoxIndexChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty((string)this.uiElementComboBox.Items[this.uiElementComboBox.SelectedIndex]))
            {
                this.uiNextButton.Enabled = false;
                this.uiFinishButton.Enabled = false;
            }
            else
            {
                this.uiNextButton.Enabled = true;
                this.uiFinishButton.Enabled = true;
            }
        }

        private void HandleClosing(object sender, FormClosingEventArgs e)
        {
            if (this.disableClose)
                e.Cancel = true;
        }
    }
}
