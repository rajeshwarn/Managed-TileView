﻿namespace SampleForm
{
    partial class Form1
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
            this.MarginTextBox = new System.Windows.Forms.TextBox();
            this.MarginUILabel = new System.Windows.Forms.Label();
            this.PaddingUILabel1 = new System.Windows.Forms.Label();
            this.PaddingLeftTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaddingTopTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaddingRightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaddingBottomTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BorderTextBox = new System.Windows.Forms.TextBox();
            this.BorderUILabel = new System.Windows.Forms.Label();
            this.TileSizeTextBox = new System.Windows.Forms.TextBox();
            this.TileSizeUILabel = new System.Windows.Forms.Label();
            this.tileViewControl1 = new TileView.TileViewControl();
            this.VirtualItemsTextBox = new System.Windows.Forms.TextBox();
            this.VirtualItemsUILabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarginTextBox
            // 
            this.MarginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MarginTextBox.Location = new System.Drawing.Point(114, 374);
            this.MarginTextBox.Name = "MarginTextBox";
            this.MarginTextBox.Size = new System.Drawing.Size(100, 22);
            this.MarginTextBox.TabIndex = 1;
            // 
            // MarginUILabel
            // 
            this.MarginUILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MarginUILabel.AutoSize = true;
            this.MarginUILabel.Location = new System.Drawing.Point(12, 377);
            this.MarginUILabel.Name = "MarginUILabel";
            this.MarginUILabel.Size = new System.Drawing.Size(51, 17);
            this.MarginUILabel.TabIndex = 2;
            this.MarginUILabel.Text = "Margin";
            // 
            // PaddingUILabel1
            // 
            this.PaddingUILabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaddingUILabel1.AutoSize = true;
            this.PaddingUILabel1.Location = new System.Drawing.Point(245, 377);
            this.PaddingUILabel1.Name = "PaddingUILabel1";
            this.PaddingUILabel1.Size = new System.Drawing.Size(88, 17);
            this.PaddingUILabel1.TabIndex = 3;
            this.PaddingUILabel1.Text = "Padding Left";
            // 
            // PaddingLeftTextBox
            // 
            this.PaddingLeftTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaddingLeftTextBox.Location = new System.Drawing.Point(347, 374);
            this.PaddingLeftTextBox.Name = "PaddingLeftTextBox";
            this.PaddingLeftTextBox.Size = new System.Drawing.Size(100, 22);
            this.PaddingLeftTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Padding Top";
            // 
            // PaddingTopTextBox
            // 
            this.PaddingTopTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaddingTopTextBox.Location = new System.Drawing.Point(347, 402);
            this.PaddingTopTextBox.Name = "PaddingTopTextBox";
            this.PaddingTopTextBox.Size = new System.Drawing.Size(100, 22);
            this.PaddingTopTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Padding Right";
            // 
            // PaddingRightTextBox
            // 
            this.PaddingRightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaddingRightTextBox.Location = new System.Drawing.Point(347, 430);
            this.PaddingRightTextBox.Name = "PaddingRightTextBox";
            this.PaddingRightTextBox.Size = new System.Drawing.Size(100, 22);
            this.PaddingRightTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Padding Bottom";
            // 
            // PaddingBottomTextBox
            // 
            this.PaddingBottomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaddingBottomTextBox.Location = new System.Drawing.Point(347, 458);
            this.PaddingBottomTextBox.Name = "PaddingBottomTextBox";
            this.PaddingBottomTextBox.Size = new System.Drawing.Size(100, 22);
            this.PaddingBottomTextBox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItem1.Text = "Show name";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BorderTextBox
            // 
            this.BorderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BorderTextBox.Location = new System.Drawing.Point(114, 402);
            this.BorderTextBox.Name = "BorderTextBox";
            this.BorderTextBox.Size = new System.Drawing.Size(100, 22);
            this.BorderTextBox.TabIndex = 6;
            // 
            // BorderUILabel
            // 
            this.BorderUILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BorderUILabel.AutoSize = true;
            this.BorderUILabel.Location = new System.Drawing.Point(12, 405);
            this.BorderUILabel.Name = "BorderUILabel";
            this.BorderUILabel.Size = new System.Drawing.Size(91, 17);
            this.BorderUILabel.TabIndex = 5;
            this.BorderUILabel.Text = "Border Width";
            // 
            // TileSizeTextBox
            // 
            this.TileSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TileSizeTextBox.Location = new System.Drawing.Point(114, 430);
            this.TileSizeTextBox.Name = "TileSizeTextBox";
            this.TileSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.TileSizeTextBox.TabIndex = 8;
            // 
            // TileSizeUILabel
            // 
            this.TileSizeUILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TileSizeUILabel.AutoSize = true;
            this.TileSizeUILabel.Location = new System.Drawing.Point(12, 433);
            this.TileSizeUILabel.Name = "TileSizeUILabel";
            this.TileSizeUILabel.Size = new System.Drawing.Size(62, 17);
            this.TileSizeUILabel.TabIndex = 7;
            this.TileSizeUILabel.Text = "Tile Size";
            // 
            // tileViewControl1
            // 
            this.tileViewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileViewControl1.AutoScroll = true;
            this.tileViewControl1.TileBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileViewControl1.TileBorderWidth = 1F;
            this.tileViewControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tileViewControl1.FocusIndex = -1;
            this.tileViewControl1.Location = new System.Drawing.Point(0, 0);
            this.tileViewControl1.Name = "tileViewControl1";
            this.tileViewControl1.Size = new System.Drawing.Size(1100, 368);
            this.tileViewControl1.TabIndex = 0;
            this.tileViewControl1.Text = "tileViewControl1";
            this.tileViewControl1.TileMargin = new System.Windows.Forms.Padding(2);
            this.tileViewControl1.TilePadding = new System.Windows.Forms.Padding(2, 2, 2, 45);
            this.tileViewControl1.TileSize = new System.Drawing.Size(256, 256);
            this.tileViewControl1.VirtualListSize = 10;
            // 
            // VirtualItemsTextBox
            // 
            this.VirtualItemsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VirtualItemsTextBox.Location = new System.Drawing.Point(114, 458);
            this.VirtualItemsTextBox.Name = "VirtualItemsTextBox";
            this.VirtualItemsTextBox.Size = new System.Drawing.Size(100, 22);
            this.VirtualItemsTextBox.TabIndex = 10;
            // 
            // VirtualItemsUILabel
            // 
            this.VirtualItemsUILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VirtualItemsUILabel.AutoSize = true;
            this.VirtualItemsUILabel.Location = new System.Drawing.Point(12, 461);
            this.VirtualItemsUILabel.Name = "VirtualItemsUILabel";
            this.VirtualItemsUILabel.Size = new System.Drawing.Size(85, 17);
            this.VirtualItemsUILabel.TabIndex = 9;
            this.VirtualItemsUILabel.Text = "Virtual Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 528);
            this.Controls.Add(this.VirtualItemsTextBox);
            this.Controls.Add(this.VirtualItemsUILabel);
            this.Controls.Add(this.TileSizeTextBox);
            this.Controls.Add(this.TileSizeUILabel);
            this.Controls.Add(this.BorderTextBox);
            this.Controls.Add(this.BorderUILabel);
            this.Controls.Add(this.PaddingBottomTextBox);
            this.Controls.Add(this.PaddingTopTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaddingRightTextBox);
            this.Controls.Add(this.PaddingLeftTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaddingUILabel1);
            this.Controls.Add(this.MarginUILabel);
            this.Controls.Add(this.MarginTextBox);
            this.Controls.Add(this.tileViewControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TileView.TileViewControl tileViewControl1;
        private System.Windows.Forms.TextBox MarginTextBox;
        private System.Windows.Forms.Label MarginUILabel;
        private System.Windows.Forms.Label PaddingUILabel1;
        private System.Windows.Forms.TextBox PaddingLeftTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaddingTopTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaddingRightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PaddingBottomTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox BorderTextBox;
        private System.Windows.Forms.Label BorderUILabel;
        private System.Windows.Forms.TextBox TileSizeTextBox;
        private System.Windows.Forms.Label TileSizeUILabel;
        private System.Windows.Forms.TextBox VirtualItemsTextBox;
        private System.Windows.Forms.Label VirtualItemsUILabel;
    }
}

