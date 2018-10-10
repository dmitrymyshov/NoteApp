using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Diagnostics;

namespace NoteAppUi
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.EmailLabel.ForeColor = System.Drawing.Color.Blue;
            this.GitLabel.ForeColor = System.Drawing.Color.Blue;
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
            Process.Start("http://dmitrymyshov@yandex.ru");
        }

        private void GitLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dmitrymyshov/NoteApp");
        }
    }
}
