namespace testComplexGUI
{
    partial class frmComplexMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNew = new System.Windows.Forms.Button();
            this.lblComplexList = new System.Windows.Forms.Label();
            this.lstComplex = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.frOperations = new System.Windows.Forms.GroupBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.frProperties = new System.Windows.Forms.GroupBox();
            this.btnConj = new System.Windows.Forms.Button();
            this.btnArg = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.frOperations.SuspendLayout();
            this.frProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Новое";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblComplexList
            // 
            this.lblComplexList.AutoSize = true;
            this.lblComplexList.Location = new System.Drawing.Point(12, 44);
            this.lblComplexList.Name = "lblComplexList";
            this.lblComplexList.Size = new System.Drawing.Size(151, 13);
            this.lblComplexList.TabIndex = 1;
            this.lblComplexList.Text = "Список комплексных чисел:";
            // 
            // lstComplex
            // 
            this.lstComplex.FormattingEnabled = true;
            this.lstComplex.Location = new System.Drawing.Point(12, 73);
            this.lstComplex.Name = "lstComplex";
            this.lstComplex.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstComplex.Size = new System.Drawing.Size(156, 95);
            this.lstComplex.TabIndex = 2;
            this.lstComplex.SelectedIndexChanged += new System.EventHandler(this.lstComplex_SelectedIndexChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(93, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frOperations
            // 
            this.frOperations.Controls.Add(this.btnDiv);
            this.frOperations.Controls.Add(this.btnMul);
            this.frOperations.Controls.Add(this.btnSub);
            this.frOperations.Controls.Add(this.btnAdd);
            this.frOperations.Location = new System.Drawing.Point(174, 12);
            this.frOperations.Name = "frOperations";
            this.frOperations.Size = new System.Drawing.Size(170, 79);
            this.frOperations.TabIndex = 4;
            this.frOperations.TabStop = false;
            this.frOperations.Text = "Операции";
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(87, 48);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Разделить";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(6, 48);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "Умножить";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(87, 19);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Вычесть";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Сложить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frProperties
            // 
            this.frProperties.Controls.Add(this.btnConj);
            this.frProperties.Controls.Add(this.btnArg);
            this.frProperties.Controls.Add(this.btnMod);
            this.frProperties.Location = new System.Drawing.Point(174, 97);
            this.frProperties.Name = "frProperties";
            this.frProperties.Size = new System.Drawing.Size(170, 100);
            this.frProperties.TabIndex = 5;
            this.frProperties.TabStop = false;
            this.frProperties.Text = "Свойства";
            // 
            // btnConj
            // 
            this.btnConj.Location = new System.Drawing.Point(6, 48);
            this.btnConj.Name = "btnConj";
            this.btnConj.Size = new System.Drawing.Size(75, 23);
            this.btnConj.TabIndex = 2;
            this.btnConj.Text = "Сопряж.";
            this.btnConj.UseVisualStyleBackColor = true;
            this.btnConj.Click += new System.EventHandler(this.btnConj_Click);
            // 
            // btnArg
            // 
            this.btnArg.Location = new System.Drawing.Point(87, 19);
            this.btnArg.Name = "btnArg";
            this.btnArg.Size = new System.Drawing.Size(75, 23);
            this.btnArg.TabIndex = 1;
            this.btnArg.Text = "Аргумент";
            this.btnArg.UseVisualStyleBackColor = true;
            this.btnArg.Click += new System.EventHandler(this.btnArg_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(6, 19);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 0;
            this.btnMod.Text = "Модуль";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmComplexMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 207);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.frProperties);
            this.Controls.Add(this.frOperations);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lstComplex);
            this.Controls.Add(this.lblComplexList);
            this.Controls.Add(this.btnNew);
            this.Name = "frmComplexMain";
            this.Text = "Комплексные числа (инкапсулированный класс)";
            this.Load += new System.EventHandler(this.frmComplexMain_Load);
            this.frOperations.ResumeLayout(false);
            this.frProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblComplexList;
        private System.Windows.Forms.ListBox lstComplex;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox frOperations;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox frProperties;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConj;
        private System.Windows.Forms.Button btnArg;
    }
}

