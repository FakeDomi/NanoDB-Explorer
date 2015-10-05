using domi1819.NanoDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    public partial class MainForm : Form
    {
        private int loadedLine;
        private string loadedKey;
        private NanoDBFile dbFile;
        private bool editMode = false;

        public MainForm(string[] args)
        {
            this.InitializeComponent();

            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    this.OpenFile(args[0]);
                }
            }
        }

        private void HandleOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.dbFile != null)
            {
                this.dbFile.Unbind();
            }

            this.openFileDialog.FileName = "";

            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.OpenFile(this.openFileDialog.FileName);
            }
        }

        private void OpenFile(string path)
        {
            this.editMode = false;

            this.dbFile = new NanoDBFile(path);

            if (this.dbFile.Init())
            {
                this.dbFile.IndexBy(this.dbFile.RecommendedIndex);

                this.dbFile.Bind();

                this.uiDbGridView.Rows.Clear();
                this.uiGridEdit.Rows.Clear();

                this.uiDbGridView.ColumnCount = this.dbFile.Layout.LayoutSize;
                this.uiGridEdit.ColumnCount = this.dbFile.Layout.LayoutSize;

                for (int i = 0; i < this.dbFile.Layout.LayoutSize; i++)
                {
                    if (i == this.dbFile.RecommendedIndex)
                    {
                        this.uiDbGridView.Columns[i].Name = ">> " + this.dbFile.Layout.LayoutElements[i].GetName();
                    }
                    else
                    {
                        this.uiDbGridView.Columns[i].Name = this.dbFile.Layout.LayoutElements[i].GetName();
                    }

                    this.uiDbGridView.Columns[i].Width = 150;
                }

                foreach (var key in this.dbFile.IndexAccess.GetAllIndexes())
                {
                    this.uiDbGridView.Rows.Add(this.Serialize(this.dbFile.GetLine(key)));
                }

                this.uiGridEdit.Rows.Add();

                this.uiResetButton.Enabled = true;
                this.editMode = true;

                // Workaround to reset the selection when started with a parameter
                new Thread(() => { Thread.Sleep(50); this.Invoke((MethodInvoker)(() => this.HandleResetButtonClicked(null, null))); }).Start();
            }
            else
            {
                this.dbFile = null;
                MessageBox.Show("Database doesn't have a proper format!");
            }
        }

        private void HandleNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.dbFile != null)
            {
                this.dbFile.Unbind();
            }

            this.saveFileDialog.FileName = "";

            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.editMode = false;

                this.dbFile = new NanoDBFile(this.saveFileDialog.FileName);

                this.dbFile.Init();

                List<NanoDBElement> list = new List<NanoDBElement>();

                int curLayoutId = 0;

                while (true)
                {
                    ElementDialog dialog = new ElementDialog(curLayoutId);
                    dialog.ShowDialog();


                    list.Add(dialog.ReturnValue);
                    curLayoutId++;

                    if (dialog.Finish || curLayoutId == 256)
                    {
                        break;
                    }
                }

                this.dbFile.CreateNew(new NanoDBLayout(list.ToArray()), 0);

                this.dbFile.Bind();

                this.uiDbGridView.Rows.Clear();
                this.uiGridEdit.Rows.Clear();

                this.uiDbGridView.ColumnCount = this.dbFile.Layout.LayoutSize;
                this.uiGridEdit.ColumnCount = this.dbFile.Layout.LayoutSize;

                for (int i = 0; i < this.dbFile.Layout.LayoutSize; i++)
                {
                    if (i == this.dbFile.RecommendedIndex)
                    {
                        this.uiDbGridView.Columns[i].Name = ">> " + this.dbFile.Layout.LayoutElements[i].GetName();
                    }
                    else
                    {
                        this.uiDbGridView.Columns[i].Name = this.dbFile.Layout.LayoutElements[i].GetName();
                    }

                    this.uiDbGridView.Columns[i].Width = 150;
                }

                this.uiGridEdit.Rows.Add();

                this.uiResetButton.Enabled = true;

                this.HandleResetButtonClicked(null, null);

                this.editMode = true;
            }
        }

        private void HandleExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.dbFile != null)
            {
                this.dbFile.Unbind();
            }

            Application.Exit();
        }

        private void HandleCreateButtonClicked(object sender, EventArgs e)
        {
            object[] dbObjects = new object[this.uiGridEdit.Columns.Count];
            string key = "";

            for (int i = 0; i < this.uiGridEdit.Columns.Count; i++)
            {
                dbObjects[i] = this.dbFile.Layout.LayoutElements[i].Deserialize((string)this.uiGridEdit.Rows[0].Cells[i].Value);

                if (i == this.dbFile.RecommendedIndex)
                {
                    key = (string)dbObjects[i];
                }
            }

            if (!string.IsNullOrEmpty(key) && !this.dbFile.IndexAccess.ContainsKey(key))
            {
                if (this.dbFile.AddLine(dbObjects))
                {
                    this.uiDbGridView.Rows.Add(this.Serialize(this.dbFile.GetLine(key)));

                    this.HandleResetButtonClicked(sender, null);
                }
                else
                {
                    MessageBox.Show("Could not add line to database!");
                }
            }
            else if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Invalid key!");
            }
            else
            {
                MessageBox.Show("Key " + key + " already exists!");
            }
        }

        private void HandleSaveButtonClicked(object sender, EventArgs e)
        {
            object[] objects = new object[this.uiGridEdit.Columns.Count];
            string key = "";

            for (int i = 0; i < this.uiGridEdit.Columns.Count; i++)
            {
                objects[i] = this.dbFile.Layout.LayoutElements[i].Deserialize(this.uiGridEdit.Rows[0].Cells[i].Value.ToString());

                if (i == this.dbFile.RecommendedIndex)
                {
                    key = (string)objects[i];
                }
            }

            if (key == this.loadedKey || (!string.IsNullOrEmpty(key) && !this.dbFile.IndexAccess.ContainsKey(key)))
            {
                this.dbFile.UpdateLine(this.loadedKey, objects);

                this.uiDbGridView.Rows[this.loadedLine].SetValues(this.Serialize(this.dbFile.GetLine(key)));

                this.HandleResetButtonClicked(sender, null);
            }
            else if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Invalid key!");
            }
            else
            {
                MessageBox.Show("Key " + key + " already exists!");
            }
        }

        private void HandleResetButtonClicked(object sender, EventArgs e)
        {
            this.loadedLine = 0;
            this.loadedKey = null;

            this.uiDbGridView.ClearSelection();

            this.uiGridEdit.Rows.RemoveAt(0);
            this.uiGridEdit.Rows.Add();

            this.uiCreateButton.Enabled = true;
            this.uiSaveButton.Enabled = false;
            this.uiDeleteButton.Enabled = false;
        }

        private void HandleDeleteButtonClicked(object sender, EventArgs e)
        {
            this.dbFile.RemoveLine(this.loadedKey);
            this.uiDbGridView.Rows.RemoveAt(this.loadedLine);

            this.HandleResetButtonClicked(sender, null);
        }

        private void HandleFormSizeChanged(object sender, EventArgs args)
        {
            this.uiDbGridView.Size = new Size(this.Size.Width - 14, this.Size.Height - 131);

            this.uiGridEdit.Size = new Size(this.Size.Width - 14, 25);
            this.uiGridEdit.Location = new Point(-1, this.Size.Height - 98);

            this.uiCreateButton.Location = new Point(5, this.Size.Height - 67);
            this.uiSaveButton.Location = new Point(109, this.Size.Height - 67);
            this.uiResetButton.Location = new Point(213, this.Size.Height - 67);
            this.uiDeleteButton.Location = new Point(317, this.Size.Height - 67);
        }

        private void HandleColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            for (int i = 0; i < this.uiDbGridView.Columns.Count; i++)
            {
                this.uiGridEdit.Columns[i].Width = this.uiDbGridView.Columns[i].Width;
            }
        }

        private void HandleScroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                this.uiGridEdit.HorizontalScrollingOffset = this.uiDbGridView.HorizontalScrollingOffset;
            }
        }

        private void HandleSelectionChanged(object sender, EventArgs e)
        {
            if (this.editMode && this.uiDbGridView.SelectedRows.Count > 0)
            {
                int rowIndex = this.uiDbGridView.SelectedRows[0].Index;

                this.loadedLine = rowIndex;
                this.loadedKey = (string)this.uiDbGridView.Rows[rowIndex].Cells[this.dbFile.RecommendedIndex].Value;

                this.uiGridEdit.Rows.RemoveAt(0);

                object[] objects = this.dbFile.GetLine(this.loadedKey);

                this.uiGridEdit.Rows.Add(this.Serialize(objects));

                this.uiCreateButton.Enabled = false;
                this.uiSaveButton.Enabled = true;
                this.uiDeleteButton.Enabled = true;
            }
        }

        private void HandleCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.loadedLine = e.RowIndex;
                this.loadedKey = (string)this.uiDbGridView.Rows[e.RowIndex].Cells[this.dbFile.RecommendedIndex].Value;

                this.uiGridEdit.Rows.RemoveAt(0);

                object[] objects = this.dbFile.GetLine(this.loadedKey);

                this.uiGridEdit.Rows.Add(this.Serialize(objects));

                this.uiCreateButton.Enabled = false;
                this.uiSaveButton.Enabled = true;
                this.uiDeleteButton.Enabled = true;
            }
        }

        private object[] Serialize(object[] objects)
        {
            if (objects.Length == this.dbFile.Layout.LayoutSize)
            {
                for (int i = 0; i < objects.Length; i++)
                {
                    objects[i] = this.dbFile.Layout.LayoutElements[i].Serialize(objects[i]);
                }
            }

            return objects;
        }
    }
}
