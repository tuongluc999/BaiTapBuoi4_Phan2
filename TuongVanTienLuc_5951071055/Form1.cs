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

namespace TuongVanTienLuc_5951071055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetStudentRecord();
        }

      

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9OUV00A;Initial Catalog=DemoCRUD2;Integrated Security=True");

        public int StudenID { get; private set; }

        private void GetStudentRecord()
        {   
            //kết nối DB
            //truy vấn DB   
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentsTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            StudentRecordData.DataSource = dt;
        }
        private bool IsValidData()
        {
            if(TxtHName.Text == string.Empty
                || TxtNName.Text == string.Empty
                || TxtAddress.Text == string.Empty
                || string.IsNullOrEmpty(TxtPhone.Text)
                || string.IsNullOrEmpty(TxtRoll.Text))
            {
                MessageBox.Show("Có chỗ chưa nhập dữ liệu !!!",  "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {   
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTb VALUES" + "(@Name, @FatherName, @RollNumber, @Address, @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", TxtHName.Text);
                cmd.Parameters.AddWithValue("@FatherName", TxtNName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", TxtRoll.Text);
                cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", TxtPhone.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
               GetStudentRecord();
            }
        }

        private void StudentRecordData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudenID = Convert.ToInt32(StudentRecordData.Rows[0].Cells[0].Value);
            TxtHName.Text = StudentRecordData.SelectedRows[0].Cells[1].Value.ToString();
            TxtNName.Text = StudentRecordData.SelectedRows[0].Cells[2].Value.ToString();
            TxtRoll.Text = StudentRecordData.SelectedRows[0].Cells[3].Value.ToString();
            TxtAddress.Text = StudentRecordData.SelectedRows[0].Cells[4].Value.ToString();
            TxtPhone.Text = StudentRecordData.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (StudenID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentsTb SET" + " Name = @Name, FatherName = @FatherName," + "RollNumber = @RollNumber, Address = @Address," + "Mobile = @Mobile WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", TxtHName.Text);
                cmd.Parameters.AddWithValue("@FatherName", TxtNName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", TxtRoll.Text);
                cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", TxtPhone.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudenID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                GetStudentRecord();
                ResetData();
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi !!!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetData()
        {
            throw new NotImplementedException();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudenID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTb WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudenID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudentRecord();
                ResetData();
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi !!!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
