using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
            status = true;
        }

        private void loadData2()
        {
            dgDiary.DataSource = d.executeQuery("SELECT [id], [date] ,[content] ,[isSecure], [isFavorite] FROM [Content] WHERE [isSecure] = 1 ORDER BY isFavorite desc");
            this.dgDiary.Columns["content"].Visible = false;
            this.dgDiary.Columns["isSecure"].Visible = false;
            this.dgDiary.Columns["id"].Visible = false;
            status = false;
        }

        private void loadData3()
        {
            dgDiary.DataSource = d.executeQuery("SELECT [id], [date] ,[content] ,[isSecure], [isFavorite] FROM [Content] WHERE [isFavorite] = 1");
            this.dgDiary.Columns["content"].Visible = false;
            this.dgDiary.Columns["id"].Visible = false;
            this.dgDiary.Columns["isSecure"].Visible = true;
        }

        private void loadData()
        {
            dgDiary.DataSource = d.executeQuery("SELECT [id], [date] ,[content] ,[isSecure], [isFavorite] FROM [Content] WHERE [isSecure] = 0 ORDER BY isFavorite desc");
            this.dgDiary.Columns["content"].Visible = false;
            this.dgDiary.Columns["isSecure"].Visible = false;
            this.dgDiary.Columns["id"].Visible = false;
        }

        private void dgDiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtContent.Text = dgDiary.Rows[e.RowIndex].Cells["content"].Value.ToString();
            if (!dgDiary.Rows[e.RowIndex].Cells["date"].Value.Equals(System.DBNull.Value))
            {
                DateTime date = (DateTime)dgDiary.Rows[e.RowIndex].Cells["date"].Value;
                txtDate.Text = date.ToString("dd/MM/yyyy");
            }
            else
            {
                txtDate.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow.Date;
            //txtDate.Text = today.ToString("dd/MM/yyyy");
        }
        Boolean? status = true;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status != null)
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string update = "UPDATE [Content] SET [date] = GETDATE(), [content] = '" + txtContent.Text + "' WHERE id = '" + id + "'";
                    if (d.executeNonQuery(update))
                    {
                        MessageBox.Show("Save success");
                        if (status == true)
                        {
                            loadData();
                        }
                        else
                        {
                            loadData2();
                        }

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save error" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Back to Update");
                loadData();
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string strPass = "SELECT * FROM [Password]";
            IDataReader dr = d.executeQuery2(strPass);
            dr.Read();
            String s = dr.GetString(0);
            dr.Close();
            if (txtPass.Text.Equals(s))
            {
                loadData2();
                status = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
            status = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (status != null)
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells["id"].FormattedValue.ToString();
                    string delete = "DELETE FROM [Content] WHERE id = '" + id + "'";
                    if (d.executeNonQuery(delete))
                    {
                        MessageBox.Show("Delete success");
                        resetText();
                        loadData();
                        status = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete fail" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Back to Delete");
                loadData();
            }

        }

        private void chkHidden_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void resetText()
        {
            txtContent.ResetText();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string secure = "UPDATE [Content] SET [isSecure] = 1 WHERE id = '" + id + "'";
                    if (d.executeNonQuery(secure))
                    {
                        MessageBox.Show("Hide success");
                        resetText();
                        loadData();
                        status = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hide error" + ex.Message);
                }
            }
            else
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string secure = "UPDATE [Content] SET [isSecure] = 0 WHERE id = '" + id + "'";
                    if (d.executeNonQuery(secure))
                    {
                        MessageBox.Show("UnHide success");
                        resetText();
                        loadData2();
                        status = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UnHide error" + ex.Message);
                }
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string secure = "UPDATE [Content] SET [isFavorite] = 1 WHERE id = '" + id + "'";
                    if (d.executeNonQuery(secure))
                    {
                        resetText();
                        loadData();
                        status = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string secure = "UPDATE [Content] SET [isFavorite] = 1 WHERE id = '" + id + "'";
                    if (d.executeNonQuery(secure))
                    {
                        resetText();
                        loadData2();
                        status = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnUnfavorite_Click(object sender, EventArgs e)
        {
            if (status == true || status == null)
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string secure = "UPDATE [Content] SET [isFavorite] = 0 WHERE id = '" + id + "'";
                    if (d.executeNonQuery(secure))
                    {
                        if (status == null)
                        {
                            loadData3();
                        }
                        else
                        {
                            loadData();
                            status = true;
                        }

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
            {
                try
                {
                    string id = dgDiary.Rows[dgDiary.SelectedCells[0].RowIndex].Cells[0].FormattedValue.ToString();
                    string secure = "UPDATE [Content] SET [isFavorite] = 0 WHERE id = '" + id + "'";
                    if (d.executeNonQuery(secure))
                    {
                        if (status == null)
                        {
                            loadData3();
                        }
                        else
                        {
                            loadData2();
                            status = false;
                        }

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnFavoriteView_Click(object sender, EventArgs e)
        {
            loadData3();
            status = null;
        }
    }
}
