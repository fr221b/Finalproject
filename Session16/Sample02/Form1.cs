using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Sample02
{
    public partial class CRUD : Form
    {
        #region [- ctor -]
        public CRUD()
        {
            InitializeComponent();
            Ref_PersonViewModel = new Models.ViewModels.PersonViewModel();
        }
        #endregion

        #region [- props -]
        public Models.ViewModels.PersonViewModel Ref_PersonViewModel { get; set; }
        public int Id { get; set; }
        #endregion

        #region [- Form1_Load -]
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        #endregion

        #region [- BtnRefresh_Click -]
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
            Clear();
        } 
        #endregion

        #region [- FillGrid() -]
        private void FillGrid()
        {
            dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
        }
        #endregion

        #region [-  BtnSave_Click(object sender, EventArgs e) -]
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Save(txtFName.Text, txtLName.Text,txtTelNumber.Text,txtMobileNumber.Text,txtAddress.Text,txtEmail.Text);
            FillGrid();
            Clear();
        }
        #endregion

        #region [-  Clear() -]
        private void Clear()
        {
            MessageBox.Show("Done");
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtTelNumber.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFName.Focus();
        }
        #endregion

        #region [-  BtnDelete_Click_1(object sender, EventArgs e) -]
        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Delete(Id);
            FillGrid();
            Clear();
        }
        #endregion

        #region [-  BtnCancel_Click(object sender, EventArgs e) -]
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FillGrid();
            Clear();
        }


        #endregion

        #region [- BtnEdit_Click -]
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Ref_PersonViewModel.Edit(Id);
            Ref_PersonViewModel.Edit(Id,txtFName.Text,txtLName.Text, txtTelNumber.Text, txtMobileNumber.Text, txtAddress.Text, txtEmail.Text);
           
        } 
        #endregion

        #region [- DgvPerson_CellDoubleClick -]
        private void DgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtFName.Text==null && txtLName.Text == null && txtTelNumber.Text == null && txtMobileNumber.Text == null && txtAddress.Text == null && txtEmail.Text==null)
            {
                Id = System.Convert.ToInt32(dgvPerson.CurrentRow.Cells["Id"].Value);
                txtFName.Text = dgvPerson.CurrentRow.Cells["FName"].Value.ToString();
                txtLName.Text = dgvPerson.CurrentRow.Cells["LName"].Value.ToString();
                txtTelNumber.Text = dgvPerson.CurrentRow.Cells["TelNumber"].Value.ToString();
                txtMobileNumber.Text = dgvPerson.CurrentRow.Cells["MobileNumber"].Value.ToString();
                txtAddress.Text = dgvPerson.CurrentRow.Cells["Addresss"].Value.ToString();
                txtEmail.Text = dgvPerson.CurrentRow.Cells["Email"].Value.ToString();
            }
            else
            {
                Id = System.Convert.ToInt32(dgvPerson.CurrentRow.Cells["Id"].Value);
                txtFName.Text = dgvPerson.CurrentRow.Cells["FName"].Value.ToString();
                txtLName.Text = dgvPerson.CurrentRow.Cells["LName"].Value.ToString();
                txtTelNumber.Text = dgvPerson.CurrentRow.Cells["TelNumber"].Value.ToString();
                txtMobileNumber.Text = dgvPerson.CurrentRow.Cells["MobileNumber"].Value.ToString();
                txtAddress.Text = dgvPerson.CurrentRow.Cells["Addresss"].Value.ToString();
                txtEmail.Text = dgvPerson.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        #endregion

        #region [- TxtFName_KeyPress -]
        private void TxtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters!");
            }

        }
        #endregion

        #region [- TxtLName_KeyPress -]
        private void TxtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters!");
            }
        }
        #endregion

        #region [- TxtTelNumber_KeyPress -]
        private void TxtTelNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid number!");
            }
            if (txtTelNumber.TextLength > 11)
            {
                MessageBox.Show("Please enter valid number!");
            }
        }
        #endregion

        #region [- TxtMobileNumber_KeyPress -]
        private void TxtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid number!");
            }
            if (txtMobileNumber.TextLength>11)
            {
                MessageBox.Show("Please enter valid number!");
            }
        }
        #endregion

        #region [- Valid_Form -]
        private void Valid_Form()
        {
            if (txtFName.Text == null || txtLName.Text == null || txtTelNumber.Text == null || txtMobileNumber.Text == null || txtAddress.Text == null || txtEmail.Text == null)
            {
                MessageBox.Show("Please Complete the form to registering!");
            }

        } 
        #endregion

    }
}
