namespace Points
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonClear = new Button();
            VectorModule = new Button();
            VectorAngle = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 394);
            listBox1.TabIndex = 0;
            listBox1.KeyDown += Form1_KeyDown;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 415);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(93, 415);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(174, 415);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(255, 415);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // VectorModule
            // 
            VectorModule.Location = new Point(689, 415);
            VectorModule.Name = "VectorModule";
            VectorModule.Size = new Size(99, 23);
            VectorModule.TabIndex = 5;
            VectorModule.Text = "Vector module";
            VectorModule.UseVisualStyleBackColor = true;
            VectorModule.Click += VectorModule_Click;
            // 
            // VectorAngle
            // 
            VectorAngle.Location = new Point(596, 415);
            VectorAngle.Name = "VectorAngle";
            VectorAngle.Size = new Size(87, 23);
            VectorAngle.TabIndex = 6;
            VectorAngle.Text = "Vector angle";
            VectorAngle.UseVisualStyleBackColor = true;
            VectorAngle.Click += VectorAngle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VectorAngle);
            Controls.Add(VectorModule);
            Controls.Add(buttonClear);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Задание №16 выполнил: Кругликов Е.А.  Номер варианта: 11 Дата выполнения: 20/09/2024";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonClear;
        private Button VectorModule;
        private Button VectorAngle;
    }
}
