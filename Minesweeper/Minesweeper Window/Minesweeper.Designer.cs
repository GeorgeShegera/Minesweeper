namespace Minesweeper
{
    partial class MineSweeperWnd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineSweeperWnd));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TsmiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsiBeginner = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiIntermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CellsPanel = new System.Windows.Forms.Panel();
            this.OutterPanel = new System.Windows.Forms.Panel();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.BtnSmile = new System.Windows.Forms.PictureBox();
            this.PanelTimer = new System.Windows.Forms.Panel();
            this.MinesCounterPanel = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.aboutMinesweeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.OutterPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSmile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiGame,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(428, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // TsmiGame
            // 
            this.TsmiGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiNew,
            this.toolStripSeparator1,
            this.TsiBeginner,
            this.TsiIntermediate,
            this.TsiExpert,
            this.toolStripSeparator2,
            this.TsiExit});
            this.TsmiGame.Name = "TsmiGame";
            this.TsmiGame.Size = new System.Drawing.Size(50, 20);
            this.TsmiGame.Text = "Game";
            // 
            // TsiNew
            // 
            this.TsiNew.Name = "TsiNew";
            this.TsiNew.ShortcutKeyDisplayString = "F2";
            this.TsiNew.Size = new System.Drawing.Size(180, 22);
            this.TsiNew.Text = "New";
            this.TsiNew.Click += new System.EventHandler(this.TsiNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TsiBeginner
            // 
            this.TsiBeginner.Name = "TsiBeginner";
            this.TsiBeginner.Size = new System.Drawing.Size(180, 22);
            this.TsiBeginner.Text = "Beginner";
            this.TsiBeginner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TsiBeginner_MouseDown);
            // 
            // TsiIntermediate
            // 
            this.TsiIntermediate.Name = "TsiIntermediate";
            this.TsiIntermediate.Size = new System.Drawing.Size(180, 22);
            this.TsiIntermediate.Text = "Intermediate";
            this.TsiIntermediate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TsiBeginner_MouseDown);
            // 
            // TsiExpert
            // 
            this.TsiExpert.Name = "TsiExpert";
            this.TsiExpert.Size = new System.Drawing.Size(180, 22);
            this.TsiExpert.Text = "Expert";
            this.TsiExpert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TsiBeginner_MouseDown);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // TsiExit
            // 
            this.TsiExit.Name = "TsiExit";
            this.TsiExit.Size = new System.Drawing.Size(180, 22);
            this.TsiExit.Text = "Exit";
            this.TsiExit.Click += new System.EventHandler(this.TsiExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMinesweeperToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // CellsPanel
            // 
            this.CellsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CellsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CellsPanel.Location = new System.Drawing.Point(59, 114);
            this.CellsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CellsPanel.Name = "CellsPanel";
            this.CellsPanel.Size = new System.Drawing.Size(296, 203);
            this.CellsPanel.TabIndex = 0;
            this.CellsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerPanel_Paint);
            // 
            // OutterPanel
            // 
            this.OutterPanel.Controls.Add(this.UpperPanel);
            this.OutterPanel.Controls.Add(this.CellsPanel);
            this.OutterPanel.Location = new System.Drawing.Point(12, 43);
            this.OutterPanel.Name = "OutterPanel";
            this.OutterPanel.Size = new System.Drawing.Size(404, 332);
            this.OutterPanel.TabIndex = 2;
            this.OutterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOutter_Paint);
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.BtnSmile);
            this.UpperPanel.Controls.Add(this.PanelTimer);
            this.UpperPanel.Controls.Add(this.MinesCounterPanel);
            this.UpperPanel.Location = new System.Drawing.Point(59, 29);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(296, 58);
            this.UpperPanel.TabIndex = 1;
            this.UpperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerPanel_Paint);
            // 
            // BtnSmile
            // 
            this.BtnSmile.Location = new System.Drawing.Point(118, 17);
            this.BtnSmile.Name = "BtnSmile";
            this.BtnSmile.Size = new System.Drawing.Size(30, 29);
            this.BtnSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSmile.TabIndex = 3;
            this.BtnSmile.TabStop = false;
            this.BtnSmile.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnSmile_Paint);
            this.BtnSmile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSmile_MouseDown);
            this.BtnSmile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSmile_MouseUp);
            // 
            // PanelTimer
            // 
            this.PanelTimer.Location = new System.Drawing.Point(186, 17);
            this.PanelTimer.Name = "PanelTimer";
            this.PanelTimer.Size = new System.Drawing.Size(72, 29);
            this.PanelTimer.TabIndex = 2;
            this.PanelTimer.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperInnerPanel_Paint);
            // 
            // MinesCounterPanel
            // 
            this.MinesCounterPanel.Location = new System.Drawing.Point(14, 17);
            this.MinesCounterPanel.Name = "MinesCounterPanel";
            this.MinesCounterPanel.Size = new System.Drawing.Size(72, 29);
            this.MinesCounterPanel.TabIndex = 2;
            this.MinesCounterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperInnerPanel_Paint);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // aboutMinesweeperToolStripMenuItem
            // 
            this.aboutMinesweeperToolStripMenuItem.Name = "aboutMinesweeperToolStripMenuItem";
            this.aboutMinesweeperToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutMinesweeperToolStripMenuItem.Text = "About Minesweeper...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // MineSweeperWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(428, 389);
            this.Controls.Add(this.OutterPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MineSweeperWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.MineSweeperWnd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MineSweeperWnd_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.OutterPanel.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSmile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem TsmiGame;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel CellsPanel;
        private System.Windows.Forms.Panel OutterPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel MinesCounterPanel;
        private System.Windows.Forms.Panel PanelTimer;
        private System.Windows.Forms.PictureBox BtnSmile;
        private System.Windows.Forms.ToolStripMenuItem TsiBeginner;
        private System.Windows.Forms.ToolStripMenuItem TsiIntermediate;
        private System.Windows.Forms.ToolStripMenuItem TsiExpert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsiNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TsiExit;
        private System.Windows.Forms.ToolStripMenuItem aboutMinesweeperToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    }
}

