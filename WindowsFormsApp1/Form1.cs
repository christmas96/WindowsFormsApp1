using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string str = "Server=tcp:formobileapp.database.windows.net,1433;Initial Catalog=mydbformobile;Persist Security Info=False;User ID=christmas96;Password=Christmas_96;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet16.Gods". При необходимости она может быть перемещена или удалена.
            this.godsTableAdapter4.Fill(this.database1DataSet16.Gods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet15.Gods". При необходимости она может быть перемещена или удалена.
            this.godsTableAdapter3.Fill(this.database1DataSet15.Gods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet14.Gods". При необходимости она может быть перемещена или удалена.
            this.godsTableAdapter2.Fill(this.database1DataSet14.Gods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet13.Gods". При необходимости она может быть перемещена или удалена.
            this.godsTableAdapter1.Fill(this.database1DataSet13.Gods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet12.SubType". При необходимости она может быть перемещена или удалена.
            this.subTypeTableAdapter2.Fill(this.database1DataSet12.SubType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet11.SubType". При необходимости она может быть перемещена или удалена.
            this.subTypeTableAdapter1.Fill(this.database1DataSet11.SubType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet10.SubCategories". При необходимости она может быть перемещена или удалена.
            this.subCategoriesTableAdapter4.Fill(this.database1DataSet10.SubCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet9.SubCategories". При необходимости она может быть перемещена или удалена.
            this.subCategoriesTableAdapter3.Fill(this.database1DataSet9.SubCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet8.SubCategories". При необходимости она может быть перемещена или удалена.
            this.subCategoriesTableAdapter2.Fill(this.database1DataSet8.SubCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet7.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter2.Fill(this.database1DataSet7.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet6.SubCategories". При необходимости она может быть перемещена или удалена.
            this.subCategoriesTableAdapter1.Fill(this.database1DataSet6.SubCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet5.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter1.Fill(this.database1DataSet5.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet4.SubType". При необходимости она может быть перемещена или удалена.
            this.subTypeTableAdapter.Fill(this.database1DataSet4.SubType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet3.SubCategories". При необходимости она может быть перемещена или удалена.
            this.subCategoriesTableAdapter.Fill(this.database1DataSet3.SubCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.database1DataSet1.Categories);

        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Categories", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayDataForSub()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from SubCategories", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void DisplayDataForType()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from SubType", con);
            adapt.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void UpdateId()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Id from Categories", con);
            adapt.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox2.DataSource = dt;
            con.Close();
        }

        private void UpdateSubId()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Id from SubCategories", con);
            adapt.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox4.DataSource = dt;
            comboBox6.DataSource = dt;
            con.Close();
        }

        private void UpdateTypeId()
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Id from SubType", con);
            adapt.Fill(dt);
            comboBox6.DataSource = dt;
            comboBox7.DataSource = dt;
            comboBox8.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var str = dataGridView1.SelectedRows;
            if (str.Count>0)
            {
                var row = dataGridView1.SelectedRows[0];
                if (row != null)
                {
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    button4.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Select row which you want to delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id_to_del = comboBox1.SelectedValue.ToString();

            int IdToDel = Convert.ToInt32(id_to_del);
            var row = dataGridView1.SelectedRows[0];

            if (IdToDel > 0)
            {
                SqlConnection con = new SqlConnection(str);
                string query = "Delete from Categories where Id= '" + IdToDel + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayData();
                    UpdateId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                label1.Visible = false;
                comboBox1.Visible = false;
                button4.Visible = false;
            }
            else
            {
                MessageBox.Show("Select ID which you want to delete", "User information");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id_to_upt = comboBox2.SelectedValue.ToString();
            int IdToUpt = Convert.ToInt32(id_to_upt);
            string name = textBox1.Text.ToString();

            if (IdToUpt == 0) {
                MessageBox.Show("Виберіть Id для оновлення!");
            }
            else if ((name == "") || (name == null))
            {
                MessageBox.Show("Введіть нову назву!");
            }
            else
            {                
                SqlConnection con = new SqlConnection(str);
                string query = "Update Categories Set category_name=N'"+name+"' Where Id="+IdToUpt+"";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayData();
                    UpdateId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

            label2.Visible = false;
            label3.Visible = false;
            comboBox2.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            comboBox2.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            UpdateId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox2.Visible = true;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string newcat = textBox2.Text.ToString();

            if (newcat != "")
            {
                SqlConnection con = new SqlConnection(str);
                string query = "Insert INTO Categories Values(N'" + newcat + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayData();
                    UpdateId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                label4.Visible = false;
                textBox2.Visible = false;
                button6.Visible = false;
            }
            else
            {
                MessageBox.Show("Введіть назву категорії!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            comboBox3.Visible = true;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string newSubCat = textBox3.Text.ToString();
            string tmp = comboBox3.SelectedValue.ToString();
            int cat_id = Convert.ToInt32(tmp);

            if(newSubCat != "" || cat_id > 0)
            {
                SqlConnection con = new SqlConnection(str);
                string query = "Insert INTO SubCategories Values('" + cat_id + "', N'" + newSubCat + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayDataForSub();
                    UpdateSubId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                label5.Visible = false;
                label6.Visible = false;
                textBox3.Visible = false;
                comboBox3.Visible = false;
                button8.Visible = false;
            }
            else
            {
                MessageBox.Show("Введіть назву Підкатегорії та Id категорії!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            comboBox4.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id_to_upt = comboBox4.SelectedValue.ToString();
            int IdToUpt = Convert.ToInt32(id_to_upt);
            string tmp = textBox4.Text.ToString();
            int cat_id;
            if(tmp == "")
            {
                cat_id = 0;
            }
            else
            {
                cat_id = Convert.ToInt32(tmp);
            }            
            string name = textBox5.Text.ToString();
            string query = "";

            if (IdToUpt == 0)
            {
                MessageBox.Show("Виберіть Id для оновлення!");
            }
            else if ((cat_id < 1 ) && (name == ""))
            {
                MessageBox.Show("Введіть новий Id або нову назву!");
            }
            else
            {
                SqlConnection con = new SqlConnection(str);
                if (cat_id>0)
                {
                    query = "Update SubCategories Set cat_id='" + cat_id + "' Where Id=" + IdToUpt + "";
                }
                if (name!="")
                {
                    query = "Update SubCategories Set gods_name='" + name + "' Where Id=" + IdToUpt + "";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayDataForSub();
                    UpdateSubId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            comboBox4.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var str = dataGridView2.SelectedRows;
            if (str.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                if (row != null)
                {
                    label10.Visible = true;
                    comboBox5.Visible = true;
                    button12.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Select row which you want to delete");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string id_to_del = comboBox5.SelectedValue.ToString();

            int IdToDel = Convert.ToInt32(id_to_del);
            var row = dataGridView2.SelectedRows[0];

            if (IdToDel > 0)
            {
                SqlConnection con = new SqlConnection(str);
                string query = "Delete from SubCategories where Id= '" + IdToDel + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayDataForSub();
                    UpdateSubId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                label10.Visible = false;
                comboBox5.Visible = false;
                button12.Visible = false;
            }
            else
            {
                MessageBox.Show("Select ID which you want to delete", "User information");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label12.Visible = true;
            comboBox6.Visible = true;
            textBox6.Visible = true;
            button14.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string tmp = comboBox6.SelectedValue.ToString();
            int id_sub_cat = Convert.ToInt32(tmp);
            string name = textBox6.Text;

            if (name != "" || id_sub_cat > 0)
            {
                SqlConnection con = new SqlConnection(str);
                string query = "Insert INTO SubType Values('" + id_sub_cat + "', N'" + name + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayDataForType();
                    UpdateTypeId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                label11.Visible = false;
                label12.Visible = false;
                comboBox6.Visible = false;
                textBox6.Visible = false;
                button14.Visible = false;
            }
            else
            {
                MessageBox.Show("Введіть назву розділу та Id підкатегорії!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            comboBox7.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            button16.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string id_to_upt = comboBox7.SelectedValue.ToString();
            int IdToUpt = Convert.ToInt32(id_to_upt);
            string tmp = textBox7.Text.ToString();
            int id_sub_cat;
            if (tmp == "")
            {
                id_sub_cat = 0;
            }
            else
            {
                id_sub_cat = Convert.ToInt32(tmp);
            }
            string name = textBox8.Text.ToString();
            string query = "";

            if (IdToUpt == 0)
            {
                MessageBox.Show("Виберіть Id для оновлення!");
            }
            else if ((id_sub_cat < 1) && (name == ""))
            {
                MessageBox.Show("Введіть новий Id або нову назву!");
            }
            else
            {
                SqlConnection con = new SqlConnection(str);
                if (id_sub_cat > 0)
                {
                    query = "Update SubType Set id_sub_cat='" + id_sub_cat + "' Where Id=" + IdToUpt + "";
                }
                if (name != "")
                {
                    query = "Update SubType Set name='" + name + "' Where Id=" + IdToUpt + "";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayDataForSub();
                    UpdateSubId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            comboBox7.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            button16.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var str = dataGridView3.SelectedRows;
            if (str.Count > 0)
            {
                var row = dataGridView3.SelectedRows[0];
                if (row != null)
                {
                    label16.Visible = true;
                    comboBox8.Visible = true;
                    button18.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Select row which you want to delete");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string id_to_del = comboBox8.SelectedValue.ToString();

            int IdToDel = Convert.ToInt32(id_to_del);
            var row = dataGridView3.SelectedRows[0];

            if (IdToDel > 0)
            {
                SqlConnection con = new SqlConnection(str);
                string query = "Delete from SubType where Id= '" + IdToDel + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();
                    DisplayData();
                    UpdateId();
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                label16.Visible = false;
                comboBox8.Visible = false;
                button18.Visible = false;
            }
            else
            {
                MessageBox.Show("Select ID which you want to delete", "User information");
            }
        }
    }
}
