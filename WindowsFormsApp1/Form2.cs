using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db.PriceList.Load();
            priceListBindingSource.DataSource = db.PriceList.Local.ToBindingList();
        }

        private void priceListBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void priceListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            db.Dispose();
        }
    }
}
