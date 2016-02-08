using System.IO;
using System.Windows.Forms;
using domi1819.NanoDB;

namespace domi1819.NanoDBExplorer
{
    public partial class DbCleaner : Form
    {
        public string ReopenPath { get; private set; }

        private readonly NanoDBFile dbFile;

        public DbCleaner(NanoDBFile dbFile)
        {
            this.InitializeComponent();

            this.textBox1.Text = dbFile.TotalLines.ToString();
            this.textBox2.Text = (dbFile.TotalLines - dbFile.EmptyLines).ToString();
            this.textBox3.Text = (int)(dbFile.StorageEfficiency * 100 + 0.5) + "%";

            this.dbFile = dbFile;
        }

        private void HandleCleanupButtonClick(object sender, System.EventArgs e)
        {
            this.dbFile.Unbind();

            File.Move(this.dbFile.Path, "tmpdb.nano");

            using (FileStream inFile = new FileStream("tmpdb.nano", FileMode.Open, FileAccess.Read))
            using (FileStream outFile = new FileStream(this.dbFile.Path, FileMode.Create, FileAccess.Write))
            {
                byte[] header = new byte[this.dbFile.Layout.HeaderSize];

                inFile.Read(header, 0, header.Length);
                outFile.Write(header, 0, header.Length);

                byte[] line = new byte[this.dbFile.Layout.RowSize];

                while (inFile.Read(line, 0, line.Length) == line.Length)
                {
                    if (line[0] != NanoDBConstants.LineFlagInactive)
                    {
                        outFile.Write(line, 0, line.Length);
                    }
                }
            }

            File.Delete("tmpdb.nano");
            MessageBox.Show("Completed!");

            this.ReopenPath = this.dbFile.Path;
            this.Close();
        }
    }
}
