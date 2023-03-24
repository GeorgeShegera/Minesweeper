using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bestTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMinesweeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CellsPanel = new System.Windows.Forms.Panel();
            this.OutterPanel = new System.Windows.Forms.Panel();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.BtnSmile = new System.Windows.Forms.PictureBox();
            this.FieldTimer = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerPanel = new Minesweeper.CounterPanel();
            this.FlagsCounterPanel = new Minesweeper.CounterPanel();
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
            this.menuStrip.Size = new System.Drawing.Size(395, 24);
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
            this.toolStripSeparator3,
            this.bestTimesToolStripMenuItem,
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // bestTimesToolStripMenuItem
            // 
            this.bestTimesToolStripMenuItem.Name = "bestTimesToolStripMenuItem";
            this.bestTimesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bestTimesToolStripMenuItem.Text = "Best Times...";
            this.bestTimesToolStripMenuItem.Click += new System.EventHandler(this.bestTimesToolStripMenuItem_Click);
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
            // aboutMinesweeperToolStripMenuItem
            // 
            this.aboutMinesweeperToolStripMenuItem.Name = "aboutMinesweeperToolStripMenuItem";
            this.aboutMinesweeperToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutMinesweeperToolStripMenuItem.Text = "About Minesweeper...";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // CellsPanel
            // 
            this.CellsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CellsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CellsPanel.Location = new System.Drawing.Point(98, 89);
            this.CellsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CellsPanel.Name = "CellsPanel";
            this.CellsPanel.Size = new System.Drawing.Size(198, 203);
            this.CellsPanel.TabIndex = 0;
            this.CellsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerPanel_Paint);
            // 
            // OutterPanel
            // 
            this.OutterPanel.Controls.Add(this.UpperPanel);
            this.OutterPanel.Controls.Add(this.CellsPanel);
            this.OutterPanel.Location = new System.Drawing.Point(12, 24);
            this.OutterPanel.Name = "OutterPanel";
            this.OutterPanel.Size = new System.Drawing.Size(371, 339);
            this.OutterPanel.TabIndex = 2;
            this.OutterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOutter_Paint);
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.BtnSmile);
            this.UpperPanel.Location = new System.Drawing.Point(98, 29);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(198, 38);
            this.UpperPanel.TabIndex = 1;
            this.UpperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerPanel_Paint);
            // 
            // BtnSmile
            // 
            this.BtnSmile.Location = new System.Drawing.Point(78, 6);
            this.BtnSmile.Name = "BtnSmile";
            this.BtnSmile.Size = new System.Drawing.Size(30, 29);
            this.BtnSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSmile.TabIndex = 3;
            this.BtnSmile.TabStop = false;
            this.BtnSmile.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnSmile_Paint);
            this.BtnSmile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSmile_MouseDown);
            this.BtnSmile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSmile_MouseUp);
            // 
            // FieldTimer
            // 
            this.FieldTimer.Interval = 1;
            this.FieldTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // TimerPanel
            // 
            this.TimerPanel.Location = new System.Drawing.Point(0, 0);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Number = 0;
            this.TimerPanel.Size = new System.Drawing.Size(200, 100);
            this.TimerPanel.TabIndex = 0;
            this.TimerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperInnerPanel_Paint);
            // 
            // FlagsCounterPanel
            // 
            this.FlagsCounterPanel.Location = new System.Drawing.Point(0, 0);
            this.FlagsCounterPanel.Name = "FlagsCounterPanel";
            this.FlagsCounterPanel.Number = 0;
            this.FlagsCounterPanel.Size = new System.Drawing.Size(200, 100);
            this.FlagsCounterPanel.TabIndex = 0;
            // 
            // MineSweeperWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(395, 377);
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
        private System.Windows.Forms.Timer FieldTimer;
        private System.Windows.Forms.PictureBox BtnSmile;
        private System.Windows.Forms.ToolStripMenuItem TsiBeginner;
        private System.Windows.Forms.ToolStripMenuItem TsiIntermediate;
        private System.Windows.Forms.ToolStripMenuItem TsiExpert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsiNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TsiExit;
        private System.Windows.Forms.ToolStripMenuItem aboutMinesweeperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.Timer GameTimer;
        private CounterPanel TimerPanel;
        private CounterPanel FlagsCounterPanel;

        private Game game;
        private int CellsPanelBorWidth { get; } = 5;
        private int OutterPanelBorWidth { get; } = 5;
        private int CellBorderWidth { get; } = 4;
        private int CellSize { get; } = 30;
        private int OutterPanelIndent { get; } = 15;
        private int UpperPanelHeight { get; } = 60;
        private int CounterPanelHeight { get; } = 40;
        private int UpperPanelBorder { get; } = 3;
        private int CounterPanelWidth { get => CounterPanelHeight * 23 / 13; }
        private int GetCellsPanelWidth { get => game.Width * CellSize + CellsPanelBorWidth * 2; }
        private int GetCellsPanelHeight { get => game.Height * CellSize + CellsPanelBorWidth * 2; }
        private int UpperPanelIndent { get => (UpperPanelHeight - CounterPanelHeight) / 2; }
        private bool smileBtnDown;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem bestTimesToolStripMenuItem;

        private bool SmileBtnDown
        {
            get => smileBtnDown;
            set
            {
                if (value) BtnSmile.Padding = new Padding(4, 4, 0, 0);
                else BtnSmile.Padding = new Padding(0, 0, 0, 0);
                smileBtnDown = value;
            }
        }
        private PrivateFontCollection MyFonts { get; }
    }
}

