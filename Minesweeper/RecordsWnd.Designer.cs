namespace Minesweeper
{
    partial class RecordsWnd
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
            this.TlbRecords = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TlbRecords
            // 
            this.TlbRecords.ColumnCount = 3;
            this.TlbRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlbRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlbRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlbRecords.Location = new System.Drawing.Point(12, 25);
            this.TlbRecords.Name = "TlbRecords";
            this.TlbRecords.RowCount = 3;
            this.TlbRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlbRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlbRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlbRecords.Size = new System.Drawing.Size(351, 99);
            this.TlbRecords.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(281, 137);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(82, 25);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.TabStop = false;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(22, 137);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(82, 25);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.TabStop = false;
            this.BtnReset.Text = "Reset Scores";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // RecordsWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 174);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TlbRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RecordsWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fastest Mine Sweepers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlbRecords;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnReset;
    }
}