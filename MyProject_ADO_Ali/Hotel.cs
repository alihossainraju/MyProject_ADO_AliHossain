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
    public partial class Hotel : Form
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
                adapter = new SqlDataAdapter("SELECT * FROM Hotel", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgHotel.DataSource = dt;
            }
        }

        public void ClearAllData()
        {
            txtName.Text = "";
            txtRoom.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";


        }

        InsertTourist obInsert = new InsertTourist();

        UpdateTourist obUpdate = new UpdateTourist();

        DeleteTourist obDelete = new DeleteTourist();

        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            obInsert.InsertData("Insert Into Hotel Values('" + txtName.Text + "','" + txtRoom.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "')");
            MessageBox.Show("Data Inserted Successfully");
            RefreshData();
            ClearAllData();
        }

        private void dgHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = this.dgHotel.CurrentRow.Cells["HotelName"].Value.ToString();
            txtRoom.Text = this.dgHotel.CurrentRow.Cells["HotelRoomType"].Value.ToString();
            txtAddress.Text = this.dgHotel.CurrentRow.Cells["HotelAddress"].Value.ToString();
            txtPhone.Text = this.dgHotel.CurrentRow.Cells["HotelPhoneNumber"].Value.ToString();
            lblHoID.Text = this.dgHotel.CurrentRow.Cells["HotelID"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            obUpdate.UpdateData("Update Hotel Set HotelName= '" + txtName.Text + "', HotelRoomType= '" + txtRoom.Text + "', HotelAddress= '" + txtAddress.Text + "', HotelPhoneNumber= '" + txtPhone.Text  + "' Where HotelID='" + lblHoID.Text + "'");
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
            obDelete.DeleteData("Delete Hotel Where HotelID='" + lblHoID.Text + "'");
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

        private void dgHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = this.dgHotel.CurrentRow.Cells["HotelName"].Value.ToString();
            txtRoom.Text = this.dgHotel.CurrentRow.Cells["HotelRoomType"].Value.ToString();
            txtAddress.Text = this.dgHotel.CurrentRow.Cells["HotelAddress"].Value.ToString();
            txtPhone.Text = this.dgHotel.CurrentRow.Cells["HotelPhoneNumber"].Value.ToString();
            lblHoID.Text = this.dgHotel.CurrentRow.Cells["HotelID"].Value.ToString();
            btnAdd.Hide();
            btnDelete.Show();
            btnUpdate.Show();
            btnCancel.Show();
            lblHoID.Hide();
        }
    }
}
