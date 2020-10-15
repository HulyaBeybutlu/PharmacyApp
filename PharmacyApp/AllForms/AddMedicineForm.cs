using PharmacyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddMedicineForm : Form
    {
        PharmacyDBEntities db = new PharmacyDBEntities();
        public AddMedicineForm()
        {
            InitializeComponent();
        }

        public void FillFirmsCombo()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(x => x.Name).ToArray());
        }
        public void FillTagsCombo()
        {
            cmbTags.Items.AddRange(db.Tags.Select(x => x.Name).ToArray());
        }

        public void FillDataGridMed()
        {
            dtgAddMedicines.DataSource = db.Medicines.Select(md => new
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
            for (var i = 0; i < dtgAddMedicines.Rows.Count; i++)
            {
                DateTime dtEx = (DateTime)dtgAddMedicines.Rows[i].Cells[dtgAddMedicines.Columns.Count - 1].Value;
                if (dtEx<DateTime.Now)
                {
                    dtgAddMedicines.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgAddMedicines.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            FillFirmsCombo();
            FillTagsCombo();
            FillDataGridMed();
        }

        public int HaveFirms(string frm)
        {
            Firm hasFirm = db.Firms.FirstOrDefault(x => x.Name == frm);
            if (hasFirm==null)
            {
                Firm newFirm = new Firm()
                {
                    Name = frm
                };
                db.Firms.Add(newFirm);
                db.SaveChanges();
                return newFirm.ID;
            }
            return hasFirm.ID;
        }
       public void AddMedWithTag(int medId)
        {
            for (int i= checkedTagsList.Items.Count-1; i>=0 ;i--)
            {
                string tagname = checkedTagsList.Items[i].ToString();
                Tag selectedTag = db.Tags.FirstOrDefault(tg => tg.Name == tagname);
                int tagId;
                if (selectedTag==null)
                {
                    Tag newTag = new Tag()
                    {
                        Name = tagname
                    };
                    db.Tags.Add(newTag);
                    db.SaveChanges();
                    tagId = newTag.ID;
                }
                else
                {
                    tagId = selectedTag.ID;
                }
                db.Medicine_To_Tags.Add(new Medicine_To_Tags()
                {
                    MedicineID=medId,
                    TagID=tagId
                });
                db.SaveChanges();
            }
        }
        public void ClearAllData()
        {
            foreach (var con in Controls)
            {
                if (con is TextBox)
                {
                    TextBox txt = (TextBox)con;
                    txt.Text = "";
                }
                else if(con is ComboBox)
                {
                    ComboBox cmb = (ComboBox)con;
                    cmb.Text = "";
                }
                else if(con is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)con;
                    nm.Value = 0;
                }
                else if(con is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)con;
                    dtp.Value = DateTime.Now;
                }
                else if(con is CheckBox)
                {
                    CheckBox ch = (CheckBox)con;
                    ch.Checked = false;
                }
                else if (con is CheckedListBox)
                {
                    CheckedListBox chb = (CheckedListBox)con;
                    chb.Items.Clear();
                }
            }
        }
        private void btnAddMed_Click(object sender, EventArgs e)
        {
            string firmName = cmbFirms.Text;
            int firmId = HaveFirms(firmName);
            string medname = txtMedName.Text;
            string barcode = txtBarcode.Text;
            decimal price = nmPrice.Value;
            string count = txtCount.Text;
            DateTime proDate = dtProDate.Value;
            DateTime expDate = dtExpDate.Value;
            string desc = rcDesc.Text;
            string[] myArr = new string[] { firmName, medname, barcode, count, desc };
            if (Extensions.IsEmpty(myArr,string.Empty))
            {
                if (expDate>=DateTime.Now)
                {
                    Medicine newMed = new Medicine()
                    {
                        Name = medname,
                        Barcode = Convert.ToInt32(barcode),
                        Price = price,
                        Description = desc,
                        Quantity = Convert.ToInt32(count),
                        ProductionDate = proDate,
                        ExperienceDate = expDate,
                        WithReceipt = chIsRec.Checked ? true : false
                    };
                    db.Medicines.Add(newMed);
                    db.SaveChanges();
                    db.Medicine_To_Firms.Add(new Medicine_To_Firms()
                    {
                        MedicineID=newMed.Id,
                        FirmID=firmId
                    });
                    db.SaveChanges();
                    AddMedWithTag(newMed.Id);
                    MessageBox.Show(medname + " was added successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearAllData();
                }
                else
                {
                    lblError.Text = "This medicine is out of date...";
                    lblError.Visible = true;
                }

            }
            else
            {
                lblError.Text = "Fill all the field!!!";
                lblError.Visible = true;
            }
        }

        private void cmbTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string tagName = cmbTags.Text;
                if (!checkedTagsList.Items.Contains(tagName))
                {
                    checkedTagsList.Items.Add(tagName, true);
                }
                cmbTags.Text = "";
            }
        }

        private void textOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Name == "txtCount")
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57 || txtCount.Text.Length>=5) && e.KeyChar!=8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57 || txtBarcode.Text.Length >= 8) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void checkedTagsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkedTagsList.SelectedIndex;
            if (selected!=-1)
            {
                checkedTagsList.Items.RemoveAt(selected);
            }
        }
    }
}
