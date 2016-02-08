using System.Windows.Forms;

namespace domi1819.NanoDBExplorer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiDbGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiCreateButton = new System.Windows.Forms.Button();
            this.uiSaveButton = new System.Windows.Forms.Button();
            this.uiResetButton = new System.Windows.Forms.Button();
            this.uiDeleteButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uiGridEdit = new domi1819.NanoDBExplorer.KeyCaptureDataGridView();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBCleanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.uiDbGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGridEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDbGridView
            // 
            this.uiDbGridView.AllowDrop = true;
            this.uiDbGridView.AllowUserToAddRows = false;
            this.uiDbGridView.AllowUserToDeleteRows = false;
            this.uiDbGridView.AllowUserToResizeRows = false;
            this.uiDbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDbGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.uiDbGridView.Location = new System.Drawing.Point(-1, 27);
            this.uiDbGridView.MultiSelect = false;
            this.uiDbGridView.Name = "uiDbGridView";
            this.uiDbGridView.RowHeadersVisible = false;
            this.uiDbGridView.RowTemplate.ReadOnly = true;
            this.uiDbGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDbGridView.Size = new System.Drawing.Size(725, 383);
            this.uiDbGridView.TabIndex = 1000;
            this.uiDbGridView.TabStop = false;
            this.uiDbGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.HandleColumnWidthChanged);
            this.uiDbGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleScroll);
            this.uiDbGridView.SelectionChanged += new System.EventHandler(this.HandleSelectionChanged);
            this.uiDbGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.HandleDropFile);
            this.uiDbGridView.DragOver += new System.Windows.Forms.DragEventHandler(this.HandleDragFile);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.HandleNewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem1.Text = "Open...";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.HandleOpenToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.HandleExitToolStripMenuItemClick);
            // 
            // uiCreateButton
            // 
            this.uiCreateButton.Enabled = false;
            this.uiCreateButton.Location = new System.Drawing.Point(5, 447);
            this.uiCreateButton.Name = "uiCreateButton";
            this.uiCreateButton.Size = new System.Drawing.Size(98, 23);
            this.uiCreateButton.TabIndex = 1;
            this.uiCreateButton.Text = "Create";
            this.uiCreateButton.UseVisualStyleBackColor = true;
            this.uiCreateButton.Click += new System.EventHandler(this.HandleCreateButtonClicked);
            // 
            // uiSaveButton
            // 
            this.uiSaveButton.Enabled = false;
            this.uiSaveButton.Location = new System.Drawing.Point(109, 447);
            this.uiSaveButton.Name = "uiSaveButton";
            this.uiSaveButton.Size = new System.Drawing.Size(98, 23);
            this.uiSaveButton.TabIndex = 2;
            this.uiSaveButton.Text = "Save";
            this.uiSaveButton.UseVisualStyleBackColor = true;
            this.uiSaveButton.Click += new System.EventHandler(this.HandleSaveButtonClicked);
            // 
            // uiResetButton
            // 
            this.uiResetButton.Enabled = false;
            this.uiResetButton.Location = new System.Drawing.Point(213, 447);
            this.uiResetButton.Name = "uiResetButton";
            this.uiResetButton.Size = new System.Drawing.Size(98, 23);
            this.uiResetButton.TabIndex = 3;
            this.uiResetButton.Text = "Reset";
            this.uiResetButton.UseVisualStyleBackColor = true;
            this.uiResetButton.Click += new System.EventHandler(this.HandleResetButtonClicked);
            // 
            // uiDeleteButton
            // 
            this.uiDeleteButton.Enabled = false;
            this.uiDeleteButton.Location = new System.Drawing.Point(317, 447);
            this.uiDeleteButton.Name = "uiDeleteButton";
            this.uiDeleteButton.Size = new System.Drawing.Size(98, 23);
            this.uiDeleteButton.TabIndex = 4;
            this.uiDeleteButton.Text = "Delete";
            this.uiDeleteButton.UseVisualStyleBackColor = true;
            this.uiDeleteButton.Click += new System.EventHandler(this.HandleDeleteButtonClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "NanoDB files|*.nano|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "NanoDB files|*.nano|All files|*.*";
            // 
            // uiGridEdit
            // 
            this.uiGridEdit.AllowUserToAddRows = false;
            this.uiGridEdit.AllowUserToDeleteRows = false;
            this.uiGridEdit.AllowUserToResizeColumns = false;
            this.uiGridEdit.AllowUserToResizeRows = false;
            this.uiGridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiGridEdit.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiGridEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.uiGridEdit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.uiGridEdit.Location = new System.Drawing.Point(-1, 416);
            this.uiGridEdit.Name = "uiGridEdit";
            this.uiGridEdit.RowHeadersVisible = false;
            this.uiGridEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uiGridEdit.Size = new System.Drawing.Size(725, 25);
            this.uiGridEdit.TabIndex = 0;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBCleanerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // dBCleanerToolStripMenuItem
            // 
            this.dBCleanerToolStripMenuItem.Name = "dBCleanerToolStripMenuItem";
            this.dBCleanerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dBCleanerToolStripMenuItem.Text = "DBCleaner";
            this.dBCleanerToolStripMenuItem.Click += new System.EventHandler(this.HandleDbCleanerToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.uiDeleteButton);
            this.Controls.Add(this.uiResetButton);
            this.Controls.Add(this.uiSaveButton);
            this.Controls.Add(this.uiCreateButton);
            this.Controls.Add(this.uiGridEdit);
            this.Controls.Add(this.uiDbGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(438, 261);
            this.Name = "MainForm";
            this.Text = "NanoDBExplorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uiDbGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGridEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uiDbGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private KeyCaptureDataGridView uiGridEdit;
        private Button uiCreateButton;
        private Button uiSaveButton;
        private Button uiResetButton;
        private Button uiDeleteButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem dBCleanerToolStripMenuItem;
    }
}

