using FirstEF.Model;
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

namespace FirstEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EFContext db = new EFContext();
        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                db.SaveChanges();
                MessageBox.Show("Berhasil disimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Product.Load();
            productDataGridView.DataSource = db.Product.Local.ToBindingList();

        }
    }
}
