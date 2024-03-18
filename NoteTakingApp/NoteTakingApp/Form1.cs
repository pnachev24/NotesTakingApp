using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Event handler for when the form is loaded
        private void delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(@"Data Source=LAB109PC19\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True; Encrypt=False;"))
            {
                sq.Open();
                SqlCommand cmd = new SqlCommand("Delete from Notes where title = @title", sq);
                cmd.Parameters.AddWithValue("title", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Note has been deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(@"Data Source=LAB109PC19\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True; Encrypt=False;"))
            {
                sq.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Notes (title, [content], timestamp) VALUES (@title, @content, @timestamp)", sq);
                cmd.Parameters.AddWithValue("title", textBox2.Text);
                cmd.Parameters.AddWithValue("content", textBox1.Text);
                cmd.Parameters.AddWithValue("timeStamp", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Note has been saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Form1 form = new Form1();
                form.ShowDialog();
            }
        }
        private void view_Click(object sender, EventArgs e)
        {

            using (SqlConnection sq = new SqlConnection(@"Data Source=LAB109PC19\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sq.Open();
                    SqlCommand cmd = new SqlCommand("Select [content] from Notes where title = @title", sq);
                    cmd.Parameters.AddWithValue("Title", textBox2.Text);

                    string content = (cmd.ExecuteScalar()).ToString();
                    textBox1.Text = content;

                    cmd = new SqlCommand("Select timestamp from Notes where title = @title", sq);
                    cmd.Parameters.AddWithValue("title", textBox2.Text);
                    content = (cmd.ExecuteScalar()).ToString();
                    dateLabel.Text = content;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Additional code to handle the situation where no title is found
                    textBox1.Text = ""; // Clear content textbox
                    dateLabel.Text = ""; // Clear date label or any other action you want to take
                }

            }

        }
    }
}