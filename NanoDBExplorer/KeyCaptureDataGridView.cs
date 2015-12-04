using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    class KeyCaptureDataGridView : DataGridView
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ((MainForm)this.Parent).GridEditEnterKeyDown();
            }
            else if (keyData == Keys.Up)
            {
                ((MainForm)this.Parent).GridEditUpKeyDown();
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
