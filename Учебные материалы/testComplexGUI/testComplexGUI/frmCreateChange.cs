using System.Windows.Forms;

namespace testComplexGUI
{
    public partial class frmCreateChange : Form
    {
        private byte mode;
        private clsComplex val;

        public frmCreateChange(byte mode, clsComplex val)
        {
            InitializeComponent();
            this.mode = mode;
            this.val = val;
        }

        private void btnInput_Click(object sender, System.EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    mdlData.colComplex.Add(new clsComplex(txtRe.Text, txtIm.Text));
                    break;
                case 1:
                    val.Im = txtIm.Text;
                    val.Re = txtRe.Text;
                    break;
            }
            Close();
        }

        private void frmCreateChange_Load(object sender, System.EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    Text = "Создание нового комплексного числа";
                    btnInput.Text = "Создать";
                    break;
                case 1:
                    Text = "Изменение комплексного числа";
                    btnInput.Text = "Изменить";
                    txtIm.Text = val.Im;
                    txtRe.Text = val.Re;
                    break;
            }
        }
    }
}
