namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadListView()
        {
            listView1.Items.Add("item 1");
            listView1.Items.Add("item 2");
        }
    }
}