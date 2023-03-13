
namespace HadiCw1Browser
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxHtml = new System.Windows.Forms.TextBox();
            this.favHisTextbox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpwwwgooglecomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbox = new System.Windows.Forms.TextBox();
            this.ShowFavButton = new System.Windows.Forms.Button();
            this.RemoveFavButton = new System.Windows.Forms.Button();
            this.SearchHistoryButton = new System.Windows.Forms.Button();
            this.FavButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.FORWARDButton = new System.Windows.Forms.Button();
            this.BACKWARDButton = new System.Windows.Forms.Button();
            this.SetAsHomeButton = new System.Windows.Forms.Button();
            this.bulkDownload = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(275, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1003, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Text = "Enter URL Here";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBoxHtml
            // 
            this.textBoxHtml.AccessibleName = "html";
            this.textBoxHtml.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHtml.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHtml.Location = new System.Drawing.Point(13, 66);
            this.textBoxHtml.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHtml.Multiline = true;
            this.textBoxHtml.Name = "textBoxHtml";
            this.textBoxHtml.ReadOnly = true;
            this.textBoxHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHtml.Size = new System.Drawing.Size(1499, 967);
            this.textBoxHtml.TabIndex = 6;
            // 
            // favHisTextbox
            // 
            this.favHisTextbox.AccessibleDescription = "history and favs";
            this.favHisTextbox.FormattingEnabled = true;
            this.favHisTextbox.ItemHeight = 20;
            this.favHisTextbox.Location = new System.Drawing.Point(1571, 129);
            this.favHisTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.favHisTextbox.Name = "favHisTextbox";
            this.favHisTextbox.Size = new System.Drawing.Size(340, 904);
            this.favHisTextbox.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHomeToolStripMenuItem,
            this.setHomeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(307, 100);
            // 
            // goHomeToolStripMenuItem
            // 
            this.goHomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpwwwgooglecomToolStripMenuItem,
            this.favouritesToolStripMenuItem});
            this.goHomeToolStripMenuItem.Name = "goHomeToolStripMenuItem";
            this.goHomeToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.goHomeToolStripMenuItem.Text = "goHomeToolStripMenuItem";
            // 
            // httpwwwgooglecomToolStripMenuItem
            // 
            this.httpwwwgooglecomToolStripMenuItem.Name = "httpwwwgooglecomToolStripMenuItem";
            this.httpwwwgooglecomToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.httpwwwgooglecomToolStripMenuItem.Text = "http://www.google.com";
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.favouritesToolStripMenuItem.Text = "Add to favourites";
            // 
            // setHomeToolStripMenuItem
            // 
            this.setHomeToolStripMenuItem.Name = "setHomeToolStripMenuItem";
            this.setHomeToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.setHomeToolStripMenuItem.Text = "setHomeToolStripMenuItem";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(306, 32);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // statusbox
            // 
            this.statusbox.Location = new System.Drawing.Point(692, 0);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(586, 26);
            this.statusbox.TabIndex = 21;
            this.statusbox.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // ShowFavButton
            // 
            this.ShowFavButton.Image = global::HadiCw1Browser.Properties.Resources.favorite;
            this.ShowFavButton.Location = new System.Drawing.Point(1571, 12);
            this.ShowFavButton.Name = "ShowFavButton";
            this.ShowFavButton.Size = new System.Drawing.Size(68, 50);
            this.ShowFavButton.TabIndex = 23;
            this.ShowFavButton.UseVisualStyleBackColor = true;
            this.ShowFavButton.Click += new System.EventHandler(this.ShowFavButton_Click);
            // 
            // RemoveFavButton
            // 
            this.RemoveFavButton.Image = global::HadiCw1Browser.Properties.Resources.remove_favourite_1_;
            this.RemoveFavButton.Location = new System.Drawing.Point(1755, 11);
            this.RemoveFavButton.Name = "RemoveFavButton";
            this.RemoveFavButton.Size = new System.Drawing.Size(65, 50);
            this.RemoveFavButton.TabIndex = 22;
            this.RemoveFavButton.UseVisualStyleBackColor = true;
            this.RemoveFavButton.Click += new System.EventHandler(this.RemoveFavButton_Click_1);
            // 
            // SearchHistoryButton
            // 
            this.SearchHistoryButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_history_24;
            this.SearchHistoryButton.Location = new System.Drawing.Point(1840, 12);
            this.SearchHistoryButton.Name = "SearchHistoryButton";
            this.SearchHistoryButton.Size = new System.Drawing.Size(71, 50);
            this.SearchHistoryButton.TabIndex = 19;
            this.SearchHistoryButton.UseVisualStyleBackColor = true;
            this.SearchHistoryButton.Click += new System.EventHandler(this.SearchHistoryButton_Click);
            // 
            // FavButton
            // 
            this.FavButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_add_to_favorites_30;
            this.FavButton.Location = new System.Drawing.Point(1664, 12);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(67, 50);
            this.FavButton.TabIndex = 18;
            this.FavButton.UseVisualStyleBackColor = true;
            this.FavButton.Click += new System.EventHandler(this.FavButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_search_24;
            this.SearchButton.Location = new System.Drawing.Point(1284, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 50);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_home_24;
            this.HomeButton.Location = new System.Drawing.Point(106, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(76, 49);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_refresh_24;
            this.RefreshButton.Location = new System.Drawing.Point(1374, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 50);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FORWARDButton
            // 
            this.FORWARDButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_forward_30;
            this.FORWARDButton.Location = new System.Drawing.Point(197, 11);
            this.FORWARDButton.Name = "FORWARDButton";
            this.FORWARDButton.Size = new System.Drawing.Size(72, 49);
            this.FORWARDButton.TabIndex = 1;
            this.FORWARDButton.UseVisualStyleBackColor = true;
            this.FORWARDButton.Click += new System.EventHandler(this.FORWARDButton_Click);
            // 
            // BACKWARDButton
            // 
            this.BACKWARDButton.Image = global::HadiCw1Browser.Properties.Resources.icons8_back_30;
            this.BACKWARDButton.Location = new System.Drawing.Point(12, 12);
            this.BACKWARDButton.Name = "BACKWARDButton";
            this.BACKWARDButton.Size = new System.Drawing.Size(69, 49);
            this.BACKWARDButton.TabIndex = 0;
            this.BACKWARDButton.UseVisualStyleBackColor = true;
            this.BACKWARDButton.Click += new System.EventHandler(this.BACKWARDButton_Click);
            // 
            // SetAsHomeButton
            // 
            this.SetAsHomeButton.Location = new System.Drawing.Point(1455, 12);
            this.SetAsHomeButton.Name = "SetAsHomeButton";
            this.SetAsHomeButton.Size = new System.Drawing.Size(110, 50);
            this.SetAsHomeButton.TabIndex = 24;
            this.SetAsHomeButton.Text = "Set Home";
            this.SetAsHomeButton.UseVisualStyleBackColor = true;
            this.SetAsHomeButton.Click += new System.EventHandler(this.SetAsHomeButton_Click);
            // 
            // bulkDownload
            // 
            this.bulkDownload.Location = new System.Drawing.Point(1571, 68);
            this.bulkDownload.Name = "bulkDownload";
            this.bulkDownload.Size = new System.Drawing.Size(340, 53);
            this.bulkDownload.TabIndex = 25;
            this.bulkDownload.Text = "bulk download";
            this.bulkDownload.UseVisualStyleBackColor = true;
            this.bulkDownload.Click += new System.EventHandler(this.bulkDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.bulkDownload);
            this.Controls.Add(this.SetAsHomeButton);
            this.Controls.Add(this.ShowFavButton);
            this.Controls.Add(this.RemoveFavButton);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.SearchHistoryButton);
            this.Controls.Add(this.FavButton);
            this.Controls.Add(this.favHisTextbox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.textBoxHtml);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.FORWARDButton);
            this.Controls.Add(this.BACKWARDButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion








        private System.Windows.Forms.Button BACKWARDButton;
        private System.Windows.Forms.Button FORWARDButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox1;
       
        private System.Windows.Forms.TextBox textBoxHtml;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox favHisTextbox;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button SearchHistoryButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHomeToolStripMenuItem;
        private System.Windows.Forms.TextBox statusbox;
        private System.Windows.Forms.ToolStripMenuItem httpwwwgooglecomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button RemoveFavButton;
        private System.Windows.Forms.Button ShowFavButton;
        private System.Windows.Forms.Button SetAsHomeButton;
        private System.Windows.Forms.Button bulkDownload;
    }
}

