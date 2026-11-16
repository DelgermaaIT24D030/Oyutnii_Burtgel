namespace OyutniiBurtgel
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Компьютерийн ухаан");
            TreeNode treeNode2 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode3 = new TreeNode("Программ хангамж");
            TreeNode treeNode4 = new TreeNode("Математик");
            TreeNode treeNode5 = new TreeNode("Физик");
            TreeNode treeNode6 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode4, treeNode5 });
            textBox1 = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            checkedListBox1 = new CheckedListBox();
            cmbMergejil = new ComboBox();
            txtUtas = new TextBox();
            dtpTursunOgnoo = new DateTimePicker();
            btnBurtgeh = new Button();
            checkedListBox2 = new CheckedListBox();
            pictureBox1 = new PictureBox();
            rtbBurtgel = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.IT24D030";
            textBox1.TextChanged += this.textBox1_TextChanged_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Нийт 1";
            label1.Click += this.label1_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(455, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(3, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += this.checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 72);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 240);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Програмчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(3, 103);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 11;
            checkedListBox1.UseTabStops = false;
            checkedListBox1.SelectedIndexChanged += this.checkedListBox1_SelectedIndexChanged;
            // 
            // cmbMergejil
            // 
            cmbMergejil.FormattingEnabled = true;
            cmbMergejil.Items.AddRange(new object[] { "Мэдээллийн технологи", "Програм хангамж", "Компьютерийн ухаан", "Сүлжээ" });
            cmbMergejil.Location = new Point(501, 164);
            cmbMergejil.Name = "cmbMergejil";
            cmbMergejil.Size = new Size(151, 28);
            cmbMergejil.TabIndex = 12;
            cmbMergejil.SelectedIndexChanged += this.cmbMergejil_SelectedIndexChanged;
            // 
            // txtUtas
            // 
            txtUtas.Location = new Point(2, 273);
            txtUtas.Name = "txtUtas";
            txtUtas.Size = new Size(151, 27);
            txtUtas.TabIndex = 13;
            txtUtas.Text = "9999-9999";
            // 
            // dtpTursunOgnoo
            // 
            dtpTursunOgnoo.Location = new Point(3, 306);
            dtpTursunOgnoo.Name = "dtpTursunOgnoo";
            dtpTursunOgnoo.Size = new Size(150, 27);
            dtpTursunOgnoo.TabIndex = 14;
            dtpTursunOgnoo.ValueChanged += this.dtpTursunOgnoo_ValueChanged;
            // 
            // btnBurtgeh
            // 
            btnBurtgeh.BackColor = SystemColors.ButtonFace;
            btnBurtgeh.ForeColor = SystemColors.HotTrack;
            btnBurtgeh.Location = new Point(17, 369);
            btnBurtgeh.Name = "btnBurtgeh";
            btnBurtgeh.Size = new Size(94, 29);
            btnBurtgeh.TabIndex = 15;
            btnBurtgeh.Text = "Бүртгэх";
            btnBurtgeh.UseVisualStyleBackColor = false;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Монгол ", "Англи", "Орос", "Хятад", "Солонгос" });
            checkedListBox2.Location = new Point(203, 32);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 48);
            checkedListBox2.TabIndex = 16;
            checkedListBox2.SelectedIndexChanged += this.checkedListBox2_SelectedIndexChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8ee429e0_d765_4ab4_a79b_f1c3e17054f41;
            pictureBox1.Location = new Point(203, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // rtbBurtgel
            // 
            rtbBurtgel.ForeColor = Color.Black;
            rtbBurtgel.Location = new Point(203, 223);
            rtbBurtgel.Name = "rtbBurtgel";
            rtbBurtgel.Size = new Size(293, 215);
            rtbBurtgel.TabIndex = 18;
            rtbBurtgel.Text = "ОЮУТНЫ БҮРТГЭЛ\nКод: M.IT24D030\nУтас: 9999-9999\nНас:21\nТөрсөн өдөр:2005-01-28\nСургалт: Өдрийн\nТэнхим: Мэдээлэл технологи\nТэтгэлэг: Тийм\nХичээл: Программчлал, Өгөгдлийн бүтэц\nХэл: Англи";
            rtbBurtgel.TextChanged += this.rtbBurtgel_TextChanged_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone, colAge });
            dataGridView1.Location = new Point(455, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(333, 82);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // colName
            // 
            colName.HeaderText = "Овог нэр";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Утас";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 125;
            // 
            // colAge
            // 
            colAge.HeaderText = "Нас";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            colAge.Width = 125;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(455, 118);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.NodeFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeNode1.Text = "Компьютерийн ухаан";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Мэдээллийн технологи";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Программ хангамж";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Математик";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Физик";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Байгалийн ухааны сургууль";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode6 });
            treeView1.Size = new Size(347, 99);
            treeView1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Controls.Add(dataGridView1);
            Controls.Add(rtbBurtgel);
            Controls.Add(pictureBox1);
            Controls.Add(checkedListBox2);
            Controls.Add(btnBurtgeh);
            Controls.Add(dtpTursunOgnoo);
            Controls.Add(txtUtas);
            Controls.Add(cmbMergejil);
            Controls.Add(checkedListBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "Оюутны бүртгэлийн программ";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private CheckedListBox checkedListBox1;
        private ComboBox cmbMergejil;
        private TextBox txtUtas;
        private DateTimePicker dtpTursunOgnoo;
        private Button btnBurtgeh;
        private CheckedListBox checkedListBox2;
        private PictureBox pictureBox1;
        private RichTextBox rtbBurtgel;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAge;
        private TreeView treeView1;
        private TextBox textBox2;
    }
}
