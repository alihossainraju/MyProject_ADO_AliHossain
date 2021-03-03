using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MyProject_ADO_Ali
{
    public partial class Tourist : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void RefreshData()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Tourist", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public void ClearAllData()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtNationlity.Text = "";
            txtImageLink.Text = "";
            comBoxHotelID.Text = "";
            ImageBox.Image = null;

        }

        InsertTourist obInsert = new InsertTourist();

        UpdateTourist obUpdate = new UpdateTourist();

        DeleteTourist obDelete = new DeleteTourist();
        public Tourist()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "image Files(*jpg; *jpeg; *gif; *bmp; *png;)|*jpg; *jpeg; *gif; *bmp; *png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImageLink.Text = open.FileName;
                ImageBox.Image = new Bitmap(open.FileName);

            }
        }

        private void Tourist_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            File.Copy(txtImageLink.Text, Path.Combine(@"C:\Users\IDB_C#\Desktop\1257170\MyProject_ADO_Ali\MyProject_ADO_Ali\Image", Path.GetFileName(txtImageLink.Text)), true);

            obInsert.InsertData("Insert Into Tourist Values('" + txtName.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + txtNationlity.Text + "','" + txtImageLink.Text + "','" + comBoxHotelID.Text + "')");
            MessageBox.Show("Data Inserted Successfully");
            RefreshData();
            ClearAllData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTouristID.Text = this.dataGridView1.CurrentRow.Cells["TouristID"].Value.ToString();
            txtName.Text = this.dataGridView1.CurrentRow.Cells["TouristName"].Value.ToString();
            txtPhone.Text = this.dataGridView1.CurrentRow.Cells["TouristPhoneNumber"].Value.ToString();
            txtAddress.Text = this.dataGridView1.CurrentRow.Cells["TouristAddress"].Value.ToString();
            txtNationlity.Text = this.dataGridView1.CurrentRow.Cells["Nationlity"].Value.ToString();
            txtImageLink.Text = this.dataGridView1.CurrentRow.Cells["image"].Value.ToString();           
            comBoxHotelID.Text = this.dataGridView1.CurrentRow.Cells["HotelID"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            obUpdate.UpdateData("Update Tourist Set TouristName= '" + txtName.Text + "', TouristPhoneNumber= '" + txtPhone.Text + "', TouristAddress= '" + txtAddress.Text + "', Nationlity= '" + txtNationlity.Text + "',image= '" + txtImageLink.Text + "' Where TouristID='" + lblTouristID.Text + "'");

            MessageBox.Show("Data Updated Successfully");
            RefreshData();
            ClearAllData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            obDelete.DeleteData("Delete Tourist Where TouristID='" + lblTouristID.Text + "'");
            MessageBox.Show("Data Deleted Successfully");
            RefreshData();
            ClearAllData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTouristID.Text = this.dataGridView1.CurrentRow.Cells["TouristID"].Value.ToString();
            txtName.Text = this.dataGridView1.CurrentRow.Cells["TouristName"].Value.ToString();
            txtPhone.Text = this.dataGridView1.CurrentRow.Cells["TouristPhoneNumber"].Value.ToString();
            txtAddress.Text = this.dataGridView1.CurrentRow.Cells["TouristAddress"].Value.ToString();
            txtNationlity.Text = this.dataGridView1.CurrentRow.Cells["Nationlity"].Value.ToString();
            txtImageLink.Text = this.dataGridView1.CurrentRow.Cells["image"].Value.ToString();
            comBoxHotelID.Text = this.dataGridView1.CurrentRow.Cells["HotelID"].Value.ToString();
            btnAdd.Hide();
            btnDelete.Show();
            btnUpdate.Show();
            btnCancel.Show();
            lblTouristID.Hide();
        }
    }
}
