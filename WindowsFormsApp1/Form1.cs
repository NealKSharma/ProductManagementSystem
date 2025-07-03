/*
 * Author: Neal Kaushik Sharma
 * GitHub: https://github.com/YOUR_GITHUB_USERNAME
 * Project: Product Management System
 * Description: A Windows Forms application for managing product information using SQL Server.
 */

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DellG3\\MSSQLSERVER01;Initial Catalog=\"TCS Training\";Integrated Security=True;Encrypt=False"); // Add data source details here.
        public Form1()
        {
            InitializeComponent();
        }

        // Load event to populate the DataGridView when the form opens
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        // INSERT operation - triggered when 'Insert' button (button1) is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Create and parameterize the SQL insert command
            SqlCommand command = new SqlCommand("INSERT INTO ProductInfo_tab VALUES (" + int.Parse(textBox1.Text) + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "', getdate(), getdate())", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            connection.Close();
            BindData(); // Refresh the DataGridView
        }

        // Binds all data from ProductInfo_tab to the DataGridView
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // UPDATE operation - triggered when 'Update' button (button2) is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update ProductInfo_tab set ItemName = '"+textBox2.Text+"', Design = '" + textBox3.Text + "', Color = '"+comboBox1.Text+"', UpdateDate = '"+DateTime.Parse(dateTimePicker1.Text).ToString("MM-dd-yyyy") + "' where ProductID = '"+int.Parse(textBox1.Text)+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully Updated.");
            BindData();
        }

        // DELETE operation - triggered when 'Delete' button (button3) is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            // Ensure a ProductID has been entered
            if (textBox1.Text != "") {
                // Confirm deletion
                if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete ProductInfo_Tab where ProductID = '" + int.Parse(textBox1.Text) + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Successfully Deleted.");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Enter a ProductID");
            }
        }

        // SEARCH operation - triggered when 'Search' button (button4) is clicked
        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab where ProductID = '" + int.Parse(textBox1.Text) + "'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt; // Show result in grid
        }

        private void label2_Click_1(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
