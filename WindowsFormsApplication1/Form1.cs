using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ヘルプhの表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "ゴミ.txt"; //はじめにファイル名で表示される文字
            sfd.InitialDirectory = @"C:\";//はじめに表示されるディレクトリ
            sfd.Filter = "TXTファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";//フィルターの設定
            sfd.FilterIndex = 2;//はじめに選択されるフィルター
            sfd.Title = "保存先のファイルを設定してください";//title
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextBox.SaveFile(sfd.FileName,RichTextBoxStreamType.PlainText);
                this.Text = sfd.FileName + " - ゴミ帳";
            }


        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog lfd = new OpenFileDialog();
            lfd.FileName = "ゴミ.txt"; //はじめにファイル名で表示される文字
            lfd.InitialDirectory = @"C:\";//はじめに表示されるディレクトリ
            lfd.Filter = "TXTファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";//フィルターの設定
            lfd.FilterIndex = 2;//はじめに選択されるフィルター
            lfd.Title = "読み込み先のファイルを設定してください";//title
            lfd.RestoreDirectory = true;
            lfd.CheckPathExists = true;

            if (lfd.ShowDialog() == DialogResult.OK)
            {
                TextBox.LoadFile(lfd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = lfd.FileName + " - ゴミ帳";
            }

        }

        private void フォントToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = TextBox.Font;//初期選択
            fd.Color = TextBox.ForeColor;//初期選択
            fd.MaxSize = 125;//
            fd.MinSize = 10;//フォントの最大、最小サイズ
            fd.FontMustExist = true;//エラーメッセージの表示
            fd.AllowVerticalFonts = false;
            fd.ShowColor = true;
            
            if(fd.ShowDialog() != DialogResult.Cancel)
            {
                TextBox.Font = fd.Font;
                TextBox.ForeColor = fd.Color;
            }

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.Print();
        }

        private void pd_PrintPage(object seender,PrintPageEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(TextBox.Text, TextBox.Font, brush, new PointF(20, 20));

            Pen p = new Pen(Color.Black);
            e.Graphics.DrawRectangle(p, new Rectangle(20, 100, 200, 100));
        }

        private void 元に戻すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        private void Coppy_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }
    }
}
