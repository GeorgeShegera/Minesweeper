namespace Minesweeper
{
    partial class NewRecordWnd
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.LbText = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOk.Location = new System.Drawing.Point(112, 136);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(57, 28);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LbText
            // 
            this.LbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbText.Location = new System.Drawing.Point(12, 18);
            this.LbText.Name = "LbText";
            this.LbText.Size = new System.Drawing.Size(261, 65);
            this.LbText.TabIndex = 1;
            this.LbText.Text = "Text";
            this.LbText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbName
            // 
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbName.Location = new System.Drawing.Point(49, 97);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(183, 24);
            this.TbName.TabIndex = 2;
            // 
            // NewRecordWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 191);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LbText);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewRecordWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NewRecordWnd_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LbText;
        private System.Windows.Forms.TextBox TbName;
    }
}