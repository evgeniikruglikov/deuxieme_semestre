namespace Points
{
    public partial class Form1 : Form
    {
        _Point[] points = new _Point[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddPoint(new _Point(0, 1));
            AddPoint(new _Point(1, 0));
            AddPoint(new _Point(1, 1));
            AddPoint(new _Point(2, 3));
            listBox1.DataSource = points;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddEditForm().ShowDialog(this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                points = points.Except([(_Point)listBox1.SelectedItem]).ToArray();
                new AddEditForm((_Point)listBox1.SelectedItem).ShowDialog(this);

                listBox1.DataSource = null;
                listBox1.DataSource = points;
            }
            else
                MessageBox.Show("Не выбрана точка для редактирования!");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                points = points.Except([(_Point)listBox1.SelectedItem]).ToArray();
            }

            listBox1.DataSource = null;
            listBox1.DataSource = points;
        }

        public void AddPoint(_Point point)
        {
            Array.Resize(ref points, points.Length + 1);
            points[points.Length - 1] = point;
            listBox1.DataSource = null;
            listBox1.DataSource = points;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                new About().ShowDialog(this);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            points = new _Point[0];
            listBox1.DataSource = null;
            listBox1.DataSource = points;
        }

        private void VectorModule_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                _Point p = (_Point)listBox1.SelectedValue;
                MessageBox.Show($"{p.VectorModule}", "Vector module");
            }
            else
                MessageBox.Show("Не выбрана точка!");
        }

        private void VectorAngle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                _Point p = (_Point)listBox1.SelectedValue;
                MessageBox.Show($"{p.VectorAngle}", "Vector angle");
            }
            else
                MessageBox.Show("Не выбрана точка!");
        }
    }

    public class _Point
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public double VectorModule { get => Math.Sqrt(x * x + y * y); }
        public double VectorAngle { get => Math.Round(Math.Acos(x / VectorModule) * (180 / Math.PI), 2); }

        public _Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}; {y})";
        }
    }
}