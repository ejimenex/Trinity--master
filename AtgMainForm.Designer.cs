namespace TiT.PTS
{
    partial class AtgMainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._atgControl4 = new TiT.PTS.AtgControl();
            this._atgControl3 = new TiT.PTS.AtgControl();
            this._atgControl2 = new TiT.PTS.AtgControl();
            this._atgControl1 = new TiT.PTS.AtgControl();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 629);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(912, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(912, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "&Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.toolsToolStripMenuItem.Text = "&Configuration";
            this.toolsToolStripMenuItem.Visible = false;
            // 
            // optionsToolStripMenuItem
            /* 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.optionsToolStripMenuItem.Text = "ATG &configuration settings";
            this.optionsToolStripMenuItem.Visible = false;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            */ 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this._atgControl4, 1, 1);
            this.tableLayoutPanel.Controls.Add(this._atgControl3, 0, 1);
            this.tableLayoutPanel.Controls.Add(this._atgControl2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this._atgControl1, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(912, 605);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // atgControl4
            // 
            this._atgControl4.Atg = null;
            this._atgControl4.AtgID = null;
            this._atgControl4.BackColor = System.Drawing.Color.MintCream;
            this._atgControl4.Location = new System.Drawing.Point(459, 305);
            this._atgControl4.Name = "atgControl4";
            this._atgControl4.PTS = null;
            this._atgControl4.Size = new System.Drawing.Size(448, 293);
            this._atgControl4.TabIndex = 7;
            // 
            // atgControl3
            // 
            this._atgControl3.Atg = null;
            this._atgControl3.AtgID = null;
            this._atgControl3.BackColor = System.Drawing.Color.MintCream;
            this._atgControl3.Location = new System.Drawing.Point(3, 305);
            this._atgControl3.Name = "atgControl3";
            this._atgControl3.PTS = null;
            this._atgControl3.Size = new System.Drawing.Size(448, 293);
            this._atgControl3.TabIndex = 6;
            // 
            // atgControl2
            // 
            this._atgControl2.Atg = null;
            this._atgControl2.AtgID = null;
            this._atgControl2.BackColor = System.Drawing.Color.MintCream;
            this._atgControl2.Location = new System.Drawing.Point(459, 3);
            this._atgControl2.Name = "atgControl2";
            this._atgControl2.PTS = null;
            this._atgControl2.Size = new System.Drawing.Size(448, 293);
            this._atgControl2.TabIndex = 5;
            // 
            // atgControl1
            // 
            this._atgControl1.Atg = null;
            this._atgControl1.AtgID = null;
            this._atgControl1.BackColor = System.Drawing.Color.MintCream;
            this._atgControl1.Location = new System.Drawing.Point(3, 3);
            this._atgControl1.Name = "atgControl1";
            this._atgControl1.PTS = null;
            this._atgControl1.Size = new System.Drawing.Size(448, 294);
            this._atgControl1.TabIndex = 4;
            // 
            // AtgMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 651);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "AtgMainForm";
            this.ShowIcon = false;
            this.Text = "ATG measurements";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtgMainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}