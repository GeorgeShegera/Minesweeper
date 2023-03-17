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
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CellsPanel = new System.Windows.Forms.Panel();
            this.OutterPanel = new System.Windows.Forms.Panel();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MinesCounterPanel = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PanelTimer = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.OutterPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(428, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // CellsPanel
            // 
            this.CellsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CellsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CellsPanel.Location = new System.Drawing.Point(59, 119);
            this.CellsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CellsPanel.Name = "CellsPanel";
            this.CellsPanel.Size = new System.Drawing.Size(296, 198);
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
            this.UpperPanel.Controls.Add(this.PanelTimer);
            this.UpperPanel.Controls.Add(this.MinesCounterPanel);
            this.UpperPanel.Location = new System.Drawing.Point(59, 29);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(296, 58);
            this.UpperPanel.TabIndex = 1;
            this.UpperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerPanel_Paint);
            // 
            // MinesCounterPanel
            // 
            this.MinesCounterPanel.Location = new System.Drawing.Point(14, 17);
            this.MinesCounterPanel.Name = "MinesCounterPanel";
            this.MinesCounterPanel.Size = new System.Drawing.Size(72, 29);
            this.MinesCounterPanel.TabIndex = 2;
            this.MinesCounterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperInnerPanel_Paint);
            // 
            // PanelTimer
            // 
            this.PanelTimer.Location = new System.Drawing.Point(186, 17);
            this.PanelTimer.Name = "PanelTimer";
            this.PanelTimer.Size = new System.Drawing.Size(72, 29);
            this.PanelTimer.TabIndex = 2;
            this.PanelTimer.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperInnerPanel_Paint);
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
            this.Name = "MineSweeperWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.MineSweeperWnd_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.OutterPanel.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel CellsPanel;
        private System.Windows.Forms.Panel OutterPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel MinesCounterPanel;
        private System.Windows.Forms.Panel PanelTimer;
    }
}

