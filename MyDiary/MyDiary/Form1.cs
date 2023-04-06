using MyDiary.Models;

namespace MyDiary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.UtcNow.Date;
            txtDate.Text = today.ToString("dd/MM/yyyy");
        }
        DiaryDBContext context = new DiaryDBContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime myDate = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            try
            {
                bool check = false;
                if(chkHidden.Checked == true)
                {
                    check = true;
                }
                Content c = new Content
                {
                    Date = myDate,
                    Content1 = txtContent.Text,
                    
                };
                context.Add(c);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error " + ex.Message);
                
            }
        }
    }
}