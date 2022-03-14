using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class Form1 : Form
    {
        private List<string> paths = new List<string>();
        private List<bool> saveStatus = new List<bool>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createNewPage();
        }

        /// <summary>
        /// Обработка event клика создания нового файла, т.е.
        /// вкладки в этом окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tabControl1.TabPages.Count < 5)
            {
                tabControl1.TabPages.Add("*New Page");
                tabControl1.TabPages[^1].Controls.Add(new RichTextBox()
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right 
                    | AnchorStyles.Bottom | AnchorStyles.Top,
                    Dock = DockStyle.Fill,
                    Name = "New Page"
                });
                saveStatus.Add(false);
            }
            else 
            {
                var res = MessageBox.Show(this, "Вкладок слишком много! " +
                    "Закройте какую-то вкладку, либо откройте новое окно.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработка event клика закрытия вкладки. Если зыкрывают несохраненный файл,
        /// идет запрос на его сохранение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                if (tabControl1.SelectedTab.Text.Contains("*")) 
                {
                    var res = MessageBox.Show(this, "Сохранить изменения перед закрытием?",
                        "Закрыть вкладку", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, 
                        MessageBoxDefaultButton.Button3);
                    if (res == DialogResult.Yes)
                    {

                    }
                    else if (res == DialogResult.No)
                    {
                        tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                    }
                }
                
            }
            else 
            {
                var res = MessageBox.Show(this, "Больше нет вкладкок, которые можно закрыть!", "Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void createNewPage() 
        {
            tabControl1.TabPages.Add("*New Page");
            tabControl1.TabPages[^1].Controls.Add(new RichTextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top,
                Dock = DockStyle.Fill,
                Name = "New Page"
            });
        }

        private void saveAsDocument() 
        {

        }

        private void saveDocument() 
        {
                    
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whiteThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blackThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }
    }
}
