using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Tinker_quest
{
    public partial class Form3 : Form
    {
        Supplier model = new Supplier();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtName1.Text = txtSurname.Text = txtINN.Text = txtCity.Text = txtStreet.Text = txtDKV.Text = txtRemove1.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.IdSupplier = 0;

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кудашкинDataSet.IdProdukts". При необходимости она может быть перемещена или удалена.

            Clear();
            PopulateDataGridView();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Name = txtName1.Text.Trim();
            model.Surname = txtSurname.Text.Trim();
            model.INN = txtINN.Text.Trim();
            model.City = txtCity.Text.Trim();
            model.Street = txtStreet.Text.Trim();
            model.DomAndKV = txtDKV.Text.Trim();
            model.Status = txtRemove1.Text.Trim();

            using (ZakupkaSuria1Entities db = new ZakupkaSuria1Entities())
            {
                if (model.IdSupplier == 0)//Insert
                    db.Supplier.Add(model);
                else //Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }
        void PopulateDataGridView()
        {
            dgvSupplier.AutoGenerateColumns = false;
            using (ZakupkaSuria1Entities db = new ZakupkaSuria1Entities())
            {
                dgvSupplier.DataSource = db.Supplier.ToList<Supplier>();

            }
        }

        private void dgvSupplier_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSupplier.CurrentRow.Index != -1)
            {
                model.IdSupplier = Convert.ToInt32(dgvSupplier.CurrentRow.Cells["IdSupplier"].Value);
                using (ZakupkaSuria1Entities db = new ZakupkaSuria1Entities())
                {
                    model = db.Supplier.Where(x => x.IdSupplier == model.IdSupplier).FirstOrDefault();
                    txtName1.Text = model.Name;
                    txtSurname.Text = model.Surname;
                    txtINN.Text = model.INN;
                    txtCity.Text = model.City;
                    txtStreet.Text = model.Street;
                    txtDKV.Text = model.DomAndKV;
                    txtRemove1.Text = model.Status;

                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ZakupkaSuria1Entities db = new ZakupkaSuria1Entities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Supplier.Attach(model);
                    db.Supplier.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }
    }
}
