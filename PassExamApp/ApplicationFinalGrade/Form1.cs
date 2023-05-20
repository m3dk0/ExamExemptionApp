using System.Windows.Forms;
namespace ApplicationFinalGrade
{
    public partial class Form1 : Form
    {
        private List<User> userlist;
        public Form1()
        {
            InitializeComponent();
            userlist = new List<User>();
        }
        Tools tool1 = new Tools();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid username or password!");
            }
            else
            {
                User user = userlist.Find(u => u.Username == username && u.Password == password);
                MessageBox.Show("Successful Login");
                tool1.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required!");
            }
            else
            {
                User newUser = new User(username, password);
                userlist.Add(newUser);
                MessageBox.Show("Successful registration!");
            }


        }
    }
}