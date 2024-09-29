namespace Points
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label1.Text = File.ReadAllText("info.txt");
        }
    }
}