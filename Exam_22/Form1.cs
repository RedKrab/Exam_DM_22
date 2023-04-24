namespace Exam_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<RiClients> riClientsL = new List<RiClients>();
         
            riClientsL = new List<RiClients>();
            {
                new RiClients("Tom");
                new RiClients("Bill");
                new RiClients("Jim");
                new RiClients("Silver");
            }

            dataGridView1.DataSource = riClientsL;
        }
        public class RiClients
        {
            public string _name;
            private RiClients _client;
            public string ClientName
            {
                get => _name;
                private set => _name = value;
            }
            private RiClients Clients
            { 
                 get=> _client;
            }
            public RiClients(string name)
            { 
                name = _name;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //команды Git = git commit - git push
    }
}