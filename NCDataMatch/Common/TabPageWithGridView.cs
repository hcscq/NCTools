using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCDataMatch.Common
{
    class TabPageWithGridView: TabPage
    {
        public DataGridView dataGridView=new DataGridView();
        public TabPageWithGridView(string name, System.Drawing.Size size,DataTable dataTable =null)
        {
            this.Controls.Add(dataGridView);
            dataGridView.Margin = new Padding(3,3,3,3);
            if (dataTable != null)
                dataGridView.DataSource = dataTable;
            this.Size = size;
            dataGridView.Size = this.Size;
            this.Text = name;
        }
    }
}
