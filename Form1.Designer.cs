namespace Movie_database
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchDirector = new System.Windows.Forms.TextBox();
            this.btnSearchDirecror = new System.Windows.Forms.Button();
            this.btnShowAll2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDownSearchYear = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchYear = new System.Windows.Forms.Button();
            this.btnShowAll3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxSearchGenre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.btnShowAll4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditDesc = new System.Windows.Forms.TextBox();
            this.numericUpDownEditRating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEditYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEditGenre = new System.Windows.Forms.ComboBox();
            this.txtEditDirector = new System.Windows.Forms.TextBox();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.btnShowAll5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchYear)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageAdd.Controls.Add(this.numericUpDownRating);
            this.tabPageAdd.Controls.Add(this.numericUpDownYear);
            this.tabPageAdd.Controls.Add(this.pictureBox1);
            this.tabPageAdd.Controls.Add(this.lblDesc);
            this.tabPageAdd.Controls.Add(this.lblRating);
            this.tabPageAdd.Controls.Add(this.lblGenre);
            this.tabPageAdd.Controls.Add(this.lblYear);
            this.tabPageAdd.Controls.Add(this.lblDirector);
            this.tabPageAdd.Controls.Add(this.lblTitle);
            this.tabPageAdd.Controls.Add(this.comboBoxGenre);
            this.tabPageAdd.Controls.Add(this.txtDesc);
            this.tabPageAdd.Controls.Add(this.txtDirector);
            this.tabPageAdd.Controls.Add(this.txtTitle);
            this.tabPageAdd.Controls.Add(this.btnAdd);
            this.tabPageAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tabPageAdd.Location = new System.Drawing.Point(4, 26);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1076, 531);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add New Movie";
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(230, 204);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownRating.TabIndex = 14;
            this.numericUpDownRating.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(230, 144);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownYear.TabIndex = 5;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Movie_database.Properties.Resources.movies;
            this.pictureBox1.Location = new System.Drawing.Point(538, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(143, 237);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(78, 17);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(143, 206);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(49, 17);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Rating:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(143, 175);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 17);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(143, 144);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 17);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(143, 113);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(58, 17);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Director:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(143, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Sci-Fi",
            "Crime",
            "Biografy",
            "Documentary"});
            this.comboBoxGenre.Location = new System.Drawing.Point(229, 172);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 25);
            this.comboBoxGenre.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(229, 234);
            this.txtDesc.MaxLength = 250;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(279, 170);
            this.txtDesc.TabIndex = 11;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(229, 110);
            this.txtDirector.MaxLength = 50;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(279, 25);
            this.txtDirector.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(229, 79);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(279, 25);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(229, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dgMovies);
            this.tabPageSearch.Controls.Add(this.tabControl2);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 26);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1076, 531);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search / Edit Movie";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // dgMovies
            // 
            this.dgMovies.AllowUserToAddRows = false;
            this.dgMovies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMovies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgMovies.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgMovies.Location = new System.Drawing.Point(3, 223);
            this.dgMovies.MultiSelect = false;
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgMovies.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMovies.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dgMovies.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Tan;
            this.dgMovies.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMovies.Size = new System.Drawing.Size(1070, 305);
            this.dgMovies.TabIndex = 0;
            this.dgMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovies_CellClick);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1070, 218);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtSearchTitle);
            this.tabPage1.Controls.Add(this.btnSearchTitle);
            this.tabPage1.Controls.Add(this.btnShowAll);
            this.tabPage1.ForeColor = System.Drawing.Color.IndianRed;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search by title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(351, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Title:";
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(392, 82);
            this.txtSearchTitle.MaxLength = 50;
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(279, 25);
            this.txtSearchTitle.TabIndex = 3;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchTitle.Location = new System.Drawing.Point(392, 130);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(135, 40);
            this.btnSearchTitle.TabIndex = 1;
            this.btnSearchTitle.Text = "Search";
            this.btnSearchTitle.UseVisualStyleBackColor = true;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShowAll.Location = new System.Drawing.Point(6, 6);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(135, 40);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All Movies";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSearchDirector);
            this.tabPage2.Controls.Add(this.btnSearchDirecror);
            this.tabPage2.Controls.Add(this.btnShowAll2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 188);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search by director";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(328, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Director:";
            // 
            // txtSearchDirector
            // 
            this.txtSearchDirector.Location = new System.Drawing.Point(392, 82);
            this.txtSearchDirector.MaxLength = 50;
            this.txtSearchDirector.Name = "txtSearchDirector";
            this.txtSearchDirector.Size = new System.Drawing.Size(279, 25);
            this.txtSearchDirector.TabIndex = 6;
            // 
            // btnSearchDirecror
            // 
            this.btnSearchDirecror.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchDirecror.Location = new System.Drawing.Point(392, 130);
            this.btnSearchDirecror.Name = "btnSearchDirecror";
            this.btnSearchDirecror.Size = new System.Drawing.Size(135, 40);
            this.btnSearchDirecror.TabIndex = 4;
            this.btnSearchDirecror.Text = "Search";
            this.btnSearchDirecror.UseVisualStyleBackColor = true;
            this.btnSearchDirecror.Click += new System.EventHandler(this.btnSearchDirecror_Click);
            // 
            // btnShowAll2
            // 
            this.btnShowAll2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShowAll2.Location = new System.Drawing.Point(6, 6);
            this.btnShowAll2.Name = "btnShowAll2";
            this.btnShowAll2.Size = new System.Drawing.Size(135, 40);
            this.btnShowAll2.TabIndex = 1;
            this.btnShowAll2.Text = "Show All Movies";
            this.btnShowAll2.UseVisualStyleBackColor = true;
            this.btnShowAll2.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.numericUpDownSearchYear);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnSearchYear);
            this.tabPage3.Controls.Add(this.btnShowAll3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1062, 188);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search by year";
            // 
            // numericUpDownSearchYear
            // 
            this.numericUpDownSearchYear.Location = new System.Drawing.Point(392, 83);
            this.numericUpDownSearchYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownSearchYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownSearchYear.Name = "numericUpDownSearchYear";
            this.numericUpDownSearchYear.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownSearchYear.TabIndex = 9;
            this.numericUpDownSearchYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(349, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Year:";
            // 
            // btnSearchYear
            // 
            this.btnSearchYear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchYear.Location = new System.Drawing.Point(392, 130);
            this.btnSearchYear.Name = "btnSearchYear";
            this.btnSearchYear.Size = new System.Drawing.Size(135, 40);
            this.btnSearchYear.TabIndex = 7;
            this.btnSearchYear.Text = "Search";
            this.btnSearchYear.UseVisualStyleBackColor = true;
            this.btnSearchYear.Click += new System.EventHandler(this.btnSearchYear_Click);
            // 
            // btnShowAll3
            // 
            this.btnShowAll3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShowAll3.Location = new System.Drawing.Point(6, 6);
            this.btnShowAll3.Name = "btnShowAll3";
            this.btnShowAll3.Size = new System.Drawing.Size(135, 40);
            this.btnShowAll3.TabIndex = 1;
            this.btnShowAll3.Text = "Show All Movies";
            this.btnShowAll3.UseVisualStyleBackColor = true;
            this.btnShowAll3.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.comboBoxSearchGenre);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnSearchGenre);
            this.tabPage4.Controls.Add(this.btnShowAll4);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1062, 188);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search by genre";
            // 
            // comboBoxSearchGenre
            // 
            this.comboBoxSearchGenre.FormattingEnabled = true;
            this.comboBoxSearchGenre.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Sci-Fi",
            "Crime",
            "Biografy",
            "Documentary"});
            this.comboBoxSearchGenre.Location = new System.Drawing.Point(392, 82);
            this.comboBoxSearchGenre.Name = "comboBoxSearchGenre";
            this.comboBoxSearchGenre.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSearchGenre.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(339, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Genre:";
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchGenre.Location = new System.Drawing.Point(392, 129);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(135, 40);
            this.btnSearchGenre.TabIndex = 7;
            this.btnSearchGenre.Text = "Search";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // btnShowAll4
            // 
            this.btnShowAll4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShowAll4.Location = new System.Drawing.Point(6, 6);
            this.btnShowAll4.Name = "btnShowAll4";
            this.btnShowAll4.Size = new System.Drawing.Size(135, 40);
            this.btnShowAll4.TabIndex = 1;
            this.btnShowAll4.Text = "Show All Movies";
            this.btnShowAll4.UseVisualStyleBackColor = true;
            this.btnShowAll4.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage5.Controls.Add(this.lblIdValue);
            this.tabPage5.Controls.Add(this.lblId);
            this.tabPage5.Controls.Add(this.btnDelete);
            this.tabPage5.Controls.Add(this.btnChange);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.txtEditDesc);
            this.tabPage5.Controls.Add(this.numericUpDownEditRating);
            this.tabPage5.Controls.Add(this.numericUpDownEditYear);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.comboBoxEditGenre);
            this.tabPage5.Controls.Add(this.txtEditDirector);
            this.tabPage5.Controls.Add(this.txtEditTitle);
            this.tabPage5.Controls.Add(this.btnShowAll5);
            this.tabPage5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1062, 188);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Edit / Delete Movie";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(930, 12);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(0, 17);
            this.lblIdValue.TabIndex = 16;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(900, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 17);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(907, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Movie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnChange.Location = new System.Drawing.Point(6, 119);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 40);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Apply Changes";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // txtEditDesc
            // 
            this.txtEditDesc.Location = new System.Drawing.Point(616, 12);
            this.txtEditDesc.MaxLength = 250;
            this.txtEditDesc.Multiline = true;
            this.txtEditDesc.Name = "txtEditDesc";
            this.txtEditDesc.Size = new System.Drawing.Size(276, 153);
            this.txtEditDesc.TabIndex = 12;
            // 
            // numericUpDownEditRating
            // 
            this.numericUpDownEditRating.Location = new System.Drawing.Point(241, 140);
            this.numericUpDownEditRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownEditRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditRating.Name = "numericUpDownEditRating";
            this.numericUpDownEditRating.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownEditRating.TabIndex = 10;
            this.numericUpDownEditRating.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownEditYear
            // 
            this.numericUpDownEditYear.Location = new System.Drawing.Point(241, 80);
            this.numericUpDownEditYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownEditYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownEditYear.Name = "numericUpDownEditYear";
            this.numericUpDownEditYear.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownEditYear.TabIndex = 6;
            this.numericUpDownEditYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rating:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title:";
            // 
            // comboBoxEditGenre
            // 
            this.comboBoxEditGenre.FormattingEnabled = true;
            this.comboBoxEditGenre.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Sci-Fi",
            "Crime",
            "Biografy",
            "Documentary"});
            this.comboBoxEditGenre.Location = new System.Drawing.Point(240, 108);
            this.comboBoxEditGenre.Name = "comboBoxEditGenre";
            this.comboBoxEditGenre.Size = new System.Drawing.Size(121, 25);
            this.comboBoxEditGenre.TabIndex = 8;
            // 
            // txtEditDirector
            // 
            this.txtEditDirector.Location = new System.Drawing.Point(240, 46);
            this.txtEditDirector.MaxLength = 50;
            this.txtEditDirector.Name = "txtEditDirector";
            this.txtEditDirector.Size = new System.Drawing.Size(279, 25);
            this.txtEditDirector.TabIndex = 4;
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.Location = new System.Drawing.Point(240, 15);
            this.txtEditTitle.MaxLength = 50;
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(279, 25);
            this.txtEditTitle.TabIndex = 2;
            // 
            // btnShowAll5
            // 
            this.btnShowAll5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShowAll5.Location = new System.Drawing.Point(6, 6);
            this.btnShowAll5.Name = "btnShowAll5";
            this.btnShowAll5.Size = new System.Drawing.Size(135, 40);
            this.btnShowAll5.TabIndex = 0;
            this.btnShowAll5.Text = "Show All Movies";
            this.btnShowAll5.UseVisualStyleBackColor = true;
            this.btnShowAll5.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Movies";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchYear)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgMovies;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnShowAll2;
        private System.Windows.Forms.Button btnShowAll3;
        private System.Windows.Forms.Button btnShowAll4;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnShowAll5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditDesc;
        private System.Windows.Forms.NumericUpDown numericUpDownEditRating;
        private System.Windows.Forms.NumericUpDown numericUpDownEditYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEditGenre;
        private System.Windows.Forms.TextBox txtEditDirector;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchDirector;
        private System.Windows.Forms.Button btnSearchDirecror;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchYear;
        private System.Windows.Forms.ComboBox comboBoxSearchGenre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.NumericUpDown numericUpDownSearchYear;
    }
}

