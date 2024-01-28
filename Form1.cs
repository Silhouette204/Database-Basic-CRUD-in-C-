using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MachineProblem12
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2ND YEAR 1ST SEM\Objected Oriented Programming\FINAL TERM\ACTIVITIES AND QUIZZES\MP_12\MachineProblem12\MachineProblem12\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tblStudent VALUES('" + txtId.Text + "','" + txtFn.Text + "','" + txtLn.Text + "')";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added");

            }
            catch
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblStudent";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblStudent WHERE Id='" + txtId.Text + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlDataReader read = cmd.ExecuteReader();
                read.Read();

                txtFn.Text = (read["First Name"].ToString());
                txtLn.Text = (read["Last Name"].ToString());

                con.Close();

            }
            catch
            {
                MessageBox.Show("Error Occured");
            }
        }


        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\MP_12\\MachineProblem12\\MachineProblem12\\Database1.mdf\";Integrated Security=True"))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblStudent";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        private void display()
        {

            dataGridView1.DataSource = GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tblStudent WHERE Id='" + txtId.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Deleted");
                con.Close();
                display();

            }
            catch
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE tblStudent SET First Name='" + txtFn.Text + "',Last Name='" + txtLn.Text + "'WHERE Id='" + txtId.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated");
                con.Close();
                display();

            }
            catch
            {
                MessageBox.Show("Error Occured");
            }
        }
    }
}