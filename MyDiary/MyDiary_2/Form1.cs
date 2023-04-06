
namespace MyDiary_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();
        private void btnGetDate_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow.Date;
            //txtDate.Text = today.ToString("dd/MM/yyyy");
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DateTime myDate = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime date = datePicker.Value;
            try
            {
                string insert = "INSERT INTO [Content] ([date] ,[content] ,[isSecure]) VALUES (GETDATE() ,'" + txtContent.Text +"', 0)";
                if (d.executeNonQuery(insert))
                {
                    MessageBox.Show("Save success");
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);

        }
        public void convertStringToDate()
        {
            {
                string date = "2018-01-01";
                DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                MessageBox.Show(dt.ToString("dd/MM/yyyy"));
            }
        }
        public void convertDateToString()
        {
            {
                DateTime dt = DateTime.ParseExact("01/01/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                MessageBox.Show(dt.ToString("yyyy-MM-dd"));
            }
        }
    }
}