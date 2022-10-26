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

namespace Ditec
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=JEYAPRABAKAR-04;Initial Catalog=Project;Integrated Security=True");

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtfname.Clear();
            txttelno.Clear();
            txtemail.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmbcourse.SelectedIndex = 0;
            txtsearch.Clear();



        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string fname = txtfname.Text;
                int tel = int.Parse(txttelno.Text);
                string email = txtemail.Text;
                string gender;
                if (rbmale.Checked)
                {
                    gender = "Male";
               }
                else
               {
                    gender = "female";
                }
                string course = cmbcourse.Text;

                string query_update = "Insert into Student values ('" + id + "','" + fname + "','" + tel + "','" + email + "','" + gender + "','" + course + "')";


                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

               }
               catch (Exception ex)
             {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                //con.Close();
           }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);

                string query_update = "Delete from Student where studentID='" + id + "'";
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Deleting" + ex);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int IdSearch = int.Parse(txtsearch.Text);
                string query_search = "Select from student where StudentID = '" + IdSearch + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    txtId.Text = r[0].ToString();
                    txtfname.Text = r[1].ToString();
                    txttelno.Text = r[2].ToString();
                    txtemail.Text = r[3].ToString();
                    string gender = r[4].ToString();
                    if (gender == "Male")
                    {
                        rbmale.Checked = true;
                    }
                    else
                    {
                        rbfemale.Checked = true;
                    }
                    cmbcourse.Text = r[5].ToString();
                }


            }
             catch (Exception ex)
            {
                 MessageBox.Show("Error While Searching" + ex);
            }
            finally
            {
            con.Close();
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string fname = txtfname.Text;
                int tel = int.Parse(txttelno.Text);
                string email = txtemail.Text;
                string gender;
                if (rbmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "female";
                }
                string course = cmbcourse.Text;

                string query_update = "Update Student set firstName='" + fname + "',tp= '" + tel + "',email='" + email + "',gender='" + gender + "',course='" + course + "'where student ID= '" + id + "'";


                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating" + ex);
            }
            finally
            {
                con.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
