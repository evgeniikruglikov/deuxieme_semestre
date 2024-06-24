using System;
using System.Windows.Forms;

namespace testComplexGUIUnsecured
{
    public partial class frmComplexMain : Form
    {
        public frmComplexMain() => InitializeComponent();

        private void btnNew_Click(object sender, EventArgs e) => ShowChildForm(0);

        private void ShowChildForm(byte mode)
        {
            frmCreateChange frm = new frmCreateChange(mode);
            frm.ShowDialog(this);
            frm.Dispose();
            InitState();
        }

        private void InitState(bool flgUpdList = true)
        {
            if (mdlData.colComplex.Count > 0)
            {
                lblComplexList.Visible = true;
                btnChange.Visible = lstComplex.SelectedItems.Count == 1;
                btnClear.Visible = true;
                lstComplex.Visible = true;

                if (flgUpdList)
                    FillList();

                frOperations.Visible = lstComplex.SelectedItems.Count == 2;
                frProperties.Visible = lstComplex.SelectedItems.Count == 1;
            }
            else 
            {
                lblComplexList.Visible = false;
                btnChange.Visible = false;
                btnClear.Visible = false;
                lstComplex.Visible = false;
                frOperations.Visible = false;
                frProperties.Visible = false;
            }
        }

        private void FillList()
        {
            lstComplex.Items.Clear();
            foreach (clsComplex cmp in mdlData.colComplex)
                lstComplex.Items.Add(cmp);
        }

        private void frmComplexMain_Load(object sender, EventArgs e) => InitState();

        private void btnChange_Click(object sender, EventArgs e) => ShowChildForm(1);

        private void btnClear_Click(object sender, EventArgs e)
        {
            mdlData.colComplex.Clear();
            InitState();
        }

        private void lstComplex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstComplex.SelectedItems.Count == 1)
                mdlData.selected = (clsComplex)lstComplex.SelectedItems[0];
            else
                mdlData.selected = null;

            InitState(false);
        }

        private void ShowResult(clsComplex Result, string Operation, string Caption) =>
            MessageBox.Show(this, $"{Operation}: {Result}", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowResult(double Result, string Operation, string Caption) =>
            MessageBox.Show(this, $"{Operation}: {Result}", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void btnConj_Click(object sender, EventArgs e) =>
            ShowResult(mdlData.colComplex[lstComplex.SelectedIndex].Conjugate(), "Комплексно сопряжённое", "Сопряжённое");

        private void btnArg_Click(object sender, EventArgs e) =>
            ShowResult(mdlData.colComplex[lstComplex.SelectedIndex].Argument(), "Аргумент", "Аргумент");

        private void btnMod_Click(object sender, EventArgs e) =>
            ShowResult(mdlData.colComplex[lstComplex.SelectedIndex].Module(), "Модуль", "Модуль");

        private void btnAdd_Click(object sender, EventArgs e) =>
            ShowResult((clsComplex)lstComplex.SelectedItems[0] + (clsComplex)lstComplex.SelectedItems[1], "Сумма", "Сложение");

        private void btnSub_Click(object sender, EventArgs e) =>
            ShowResult((clsComplex)lstComplex.SelectedItems[0] - (clsComplex)lstComplex.SelectedItems[1], "Разность", "Вычитание");

        private void btnMul_Click(object sender, EventArgs e) =>
            ShowResult((clsComplex) lstComplex.SelectedItems[0] * (clsComplex) lstComplex.SelectedItems[1], "Произведение", "Умножение");

        private void btnDiv_Click(object sender, EventArgs e) =>
            ShowResult((clsComplex) lstComplex.SelectedItems[0] / (clsComplex) lstComplex.SelectedItems[1], "Частное", "Деление");
    }
}
