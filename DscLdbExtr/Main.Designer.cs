
namespace DscLdbExtr
{
    partial class DscLdbExtr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.dropText = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Tokens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dropPanel.Controls.Add(this.dropText);
            this.dropPanel.Location = new System.Drawing.Point(2, 2);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(518, 90);
            this.dropPanel.TabIndex = 0;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            this.dropPanel.DragLeave += new System.EventHandler(this.dropPanel_DragLeave);
            // 
            // dropText
            // 
            this.dropText.AutoSize = true;
            this.dropText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dropText.Location = new System.Drawing.Point(135, 25);
            this.dropText.Name = "dropText";
            this.dropText.Size = new System.Drawing.Size(242, 39);
            this.dropText.TabIndex = 0;
            this.dropText.Text = "Drop files here";
            // 
            // colorPanel
            // 
            this.colorPanel.AllowDrop = true;
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.colorPanel.Controls.Add(this.dropPanel);
            this.colorPanel.Location = new System.Drawing.Point(10, 8);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(522, 94);
            this.colorPanel.TabIndex = 1;
            // 
            // gridView
            // 
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.ColumnHeadersVisible = false;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tokens});
            this.gridView.Location = new System.Drawing.Point(10, 106);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 25;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.Size = new System.Drawing.Size(522, 150);
            this.gridView.TabIndex = 5;
            // 
            // Tokens
            // 
            this.Tokens.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tokens.HeaderText = "";
            this.Tokens.Name = "Tokens";
            this.Tokens.ReadOnly = true;
            this.Tokens.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DscLdbExtr
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(542, 266);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.colorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DscLdbExtr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord LevelDB Extractor";
            this.TopMost = true;
            this.dropPanel.ResumeLayout(false);
            this.dropPanel.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label dropText;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tokens;
    }
}

