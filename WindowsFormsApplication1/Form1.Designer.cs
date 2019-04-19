namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Coppy = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.次を検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置換ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行を移動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.すべて選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日付と日時ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.書式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ステータスバーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプhの表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.書式OToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuBar.Name = "menuBar";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateButton,
            this.OpenButton,
            this.Save,
            this.toolStripSeparator2,
            this.PrintButton,
            this.toolStripSeparator1,
            this.QuitButton});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            resources.ApplyResources(this.ファイルToolStripMenuItem, "ファイルToolStripMenuItem");
            // 
            // CreateButton
            // 
            this.CreateButton.Name = "CreateButton";
            resources.ApplyResources(this.CreateButton, "CreateButton");
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Name = "OpenButton";
            resources.ApplyResources(this.OpenButton, "OpenButton");
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            resources.ApplyResources(this.Save, "Save");
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // PrintButton
            // 
            this.PrintButton.Name = "PrintButton";
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // QuitButton
            // 
            this.QuitButton.Name = "QuitButton";
            resources.ApplyResources(this.QuitButton, "QuitButton");
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すToolStripMenuItem,
            this.Paste,
            this.Cut,
            this.Coppy,
            this.delete,
            this.toolStripSeparator3,
            this.検索ToolStripMenuItem,
            this.次を検索ToolStripMenuItem,
            this.置換ToolStripMenuItem,
            this.toolStripSeparator4,
            this.行を移動ToolStripMenuItem,
            this.すべて選択ToolStripMenuItem,
            this.日付と日時ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            resources.ApplyResources(this.編集EToolStripMenuItem, "編集EToolStripMenuItem");
            // 
            // 元に戻すToolStripMenuItem
            // 
            this.元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            resources.ApplyResources(this.元に戻すToolStripMenuItem, "元に戻すToolStripMenuItem");
            this.元に戻すToolStripMenuItem.Click += new System.EventHandler(this.元に戻すToolStripMenuItem_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            resources.ApplyResources(this.Paste, "Paste");
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            resources.ApplyResources(this.Cut, "Cut");
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Coppy
            // 
            this.Coppy.Name = "Coppy";
            resources.ApplyResources(this.Coppy, "Coppy");
            this.Coppy.Click += new System.EventHandler(this.Coppy_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            resources.ApplyResources(this.delete, "delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // 検索ToolStripMenuItem
            // 
            this.検索ToolStripMenuItem.Name = "検索ToolStripMenuItem";
            resources.ApplyResources(this.検索ToolStripMenuItem, "検索ToolStripMenuItem");
            // 
            // 次を検索ToolStripMenuItem
            // 
            this.次を検索ToolStripMenuItem.Name = "次を検索ToolStripMenuItem";
            resources.ApplyResources(this.次を検索ToolStripMenuItem, "次を検索ToolStripMenuItem");
            // 
            // 置換ToolStripMenuItem
            // 
            this.置換ToolStripMenuItem.Name = "置換ToolStripMenuItem";
            resources.ApplyResources(this.置換ToolStripMenuItem, "置換ToolStripMenuItem");
            // 
            // 行を移動ToolStripMenuItem
            // 
            this.行を移動ToolStripMenuItem.Name = "行を移動ToolStripMenuItem";
            resources.ApplyResources(this.行を移動ToolStripMenuItem, "行を移動ToolStripMenuItem");
            // 
            // すべて選択ToolStripMenuItem
            // 
            this.すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem";
            resources.ApplyResources(this.すべて選択ToolStripMenuItem, "すべて選択ToolStripMenuItem");
            // 
            // 日付と日時ToolStripMenuItem
            // 
            this.日付と日時ToolStripMenuItem.Name = "日付と日時ToolStripMenuItem";
            resources.ApplyResources(this.日付と日時ToolStripMenuItem, "日付と日時ToolStripMenuItem");
            // 
            // 書式OToolStripMenuItem
            // 
            this.書式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントToolStripMenuItem});
            this.書式OToolStripMenuItem.Name = "書式OToolStripMenuItem";
            resources.ApplyResources(this.書式OToolStripMenuItem, "書式OToolStripMenuItem");
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            resources.ApplyResources(this.フォントToolStripMenuItem, "フォントToolStripMenuItem");
            this.フォントToolStripMenuItem.Click += new System.EventHandler(this.フォントToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ステータスバーToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            resources.ApplyResources(this.表示VToolStripMenuItem, "表示VToolStripMenuItem");
            // 
            // ステータスバーToolStripMenuItem
            // 
            this.ステータスバーToolStripMenuItem.Name = "ステータスバーToolStripMenuItem";
            resources.ApplyResources(this.ステータスバーToolStripMenuItem, "ステータスバーToolStripMenuItem");
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプhの表示ToolStripMenuItem,
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            resources.ApplyResources(this.ヘルプToolStripMenuItem, "ヘルプToolStripMenuItem");
            // 
            // ヘルプhの表示ToolStripMenuItem
            // 
            this.ヘルプhの表示ToolStripMenuItem.Name = "ヘルプhの表示ToolStripMenuItem";
            resources.ApplyResources(this.ヘルプhの表示ToolStripMenuItem, "ヘルプhの表示ToolStripMenuItem");
            this.ヘルプhの表示ToolStripMenuItem.Click += new System.EventHandler(this.ヘルプhの表示ToolStripMenuItem_Click);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            resources.ApplyResources(this.バージョン情報ToolStripMenuItem, "バージョン情報ToolStripMenuItem");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // TextBox
            // 
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.Name = "TextBox";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.TextBox);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 書式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem CreateButton;
        private System.Windows.Forms.ToolStripMenuItem OpenButton;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PrintButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem QuitButton;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Coppy;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 次を検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置換ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行を移動ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem すべて選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日付と日時ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ステータスバーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプhの表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

