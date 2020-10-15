using PharmacyApp.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class PharmacyStore : Form
    {
        PharmacyDBEntities db = new PharmacyDBEntities();
        public PharmacyStore()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicineForm addMed = new AddMedicineForm();
            addMed.ShowDialog();
        }

        public void FillDataMedBuy()
        {
            dtgMedicinesBuy.DataSource = db.Medicines.Select(md => new
            {
                Medicine_Name = md.Name,
                md.Barcode,
                md.Quantity,
                md.Price,
                FirmName = md.Medicine_To_Firms.FirstOrDefault(mdf => mdf.MedicineID == md.Id).Firm.Name,
                IsReceipt = md.WithReceipt ? "Reseptli" : "Reseptsiz",
                md.ProductionDate,
                md.ExperienceDate
            }).ToList();
            for (var i = 0; i < dtgMedicinesBuy.Rows.Count; i++)
            {
                DateTime dtEx = (DateTime)dtgMedicinesBuy.Rows[i].Cells[dtgMedicinesBuy.Columns.Count - 1].Value;
                int quantMed = Convert.ToInt32(dtgMedicinesBuy.Rows[i].Cells[2].Value);
                if (dtEx < DateTime.Now || quantMed<=0)
                {
                    dtgMedicinesBuy.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgMedicinesBuy.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        public void MedicineComboFill()
        {
            cmbByMedicine.Items.AddRange(db.Medicines.Select(m => m.Name).ToArray());
        }
        public void TagsComboFill()
        {
            cmbByTags.Items.AddRange(db.Tags.Select(m => m.Name).ToArray());
        }
        private void PharmacyStore_Load(object sender, EventArgs e)
        {
            MedicineComboFill();
            TagsComboFill();
            FillDataMedBuy();
        }

        public void AddCheckedListFill()
        {
            string tagName = txtBuyMedName.Text + "|" + nmBuyMedCount.Value;
            Medicine selectedMed = db.Medicines.FirstOrDefault(m => m.Name == txtBuyMedName.Text);
            if (!checkedTagList.Items.Contains(tagName) && selectedMed.Quantity>0 
                && selectedMed.ExperienceDate>=DateTime.Now)
            {
                checkedTagList.Items.Add(tagName, true);
            }
        }
        private void dtgMedicinesBuy_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SellMedPanel.Visible = true;
            string medName = dtgMedicinesBuy.Rows[e.RowIndex].Cells[0].Value.ToString();
            Medicine selectedMed = db.Medicines.FirstOrDefault(m => m.Name == medName);
            nmBuyMedCount.Maximum = selectedMed.Quantity;
            txtBuyMedName.Text = medName;
        }

        private void btnBuyMed_Click(object sender, EventArgs e)
        {
            AddCheckedListFill();
        }

        private void btnSellMed_Click(object sender, EventArgs e)
        {
            string buyMedText = "";
            decimal totalPrice = 0;
            for (int i = checkedTagList.Items.Count - 1; i >= 0; i--)
            {
                string buyMedName = checkedTagList.Items[i].ToString();
                int medCount = Convert.ToInt32(buyMedName.Substring(buyMedName.LastIndexOf("|") + 1));
                string medName = buyMedName.Substring(0, buyMedName.LastIndexOf("|"));
                Medicine selectedMed = db.Medicines.First(x => x.Name == medName);
                db.Orders.Add(new Order()
                {
                    MedicineID = selectedMed.Id,
                    Amount = medCount,
                    WorkerID = 1,
                    PurchaseDate = DateTime.Now
                });
                selectedMed.Quantity -= medCount;
                db.SaveChanges();
                buyMedText += string.Format($"{medName} , Count: {medCount}, Price: {selectedMed.Price} AZN \n");
                totalPrice += selectedMed.Price * medCount;
            }
            MessageBox.Show(buyMedText + $" was bought successfully...\n Total price: {totalPrice}", "Buy operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataMedBuy();
        }
    }
}
