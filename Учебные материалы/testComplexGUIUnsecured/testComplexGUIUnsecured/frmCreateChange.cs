using System.Windows.Forms;

namespace testComplexGUIUnsecured
{
    public partial class frmCreateChange : Form
    {
        private byte mode;
        private bool flgFinish = false;

        public frmCreateChange(byte mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void btnInput_Click(object sender, System.EventArgs e)
        {
            double.TryParse(txtRe.Text, out mdlData.selected.Re);
            double.TryParse(txtIm.Text, out mdlData.selected.Im);
            flgFinish = true;
            Close();
        }

        private void frmCreateChange_Load(object sender, System.EventArgs e)
        {
            FormClosing += frmCreateChange_FormClosing;
            switch (mode)
            {
                case 0:
                    Text = "Создание нового комплексного числа";
                    btnInput.Text = "Создать";
                    mdlData.colComplex.Add(new clsComplex());
                    mdlData.selected = mdlData.colComplex[mdlData.colComplex.Count - 1];
                    break;
                case 1:
                    Text = "Изменение комплексного числа";
                    btnInput.Text = "Изменить";
                    flgFinish = true;
                    break;
            }

            txtRe.Text = mdlData.selected.Re.ToString();
            txtIm.Text = mdlData.selected.Im.ToString();
        }

        private void frmCreateChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flgFinish)
                mdlData.colComplex.RemoveAt(mdlData.colComplex.Count - 1);
        }
    }
}
