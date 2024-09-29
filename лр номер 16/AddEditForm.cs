namespace Points
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm(_Point point)
        {
            InitializeComponent();
            textBox1.Text = point.x.ToString();
            textBox2.Text = point.y.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form1)Owner).AddPoint(new _Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Неправильно введены координаты точки!");
            }
        }
    }
}