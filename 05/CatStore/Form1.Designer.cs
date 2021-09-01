
namespace CRUD
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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtboxName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtboxWeight = new MetroFramework.Controls.MetroTextBox();
            this.radioMale = new MetroFramework.Controls.MetroRadioButton();
            this.radioFemale = new MetroFramework.Controls.MetroRadioButton();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catDbDataSet = new CRUD.CatDbDataSet();
            this.catBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catTableAdapter = new CRUD.CatDbDataSetTableAdapters.CatTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnRegister);
            this.metroPanel1.Controls.Add(this.radioFemale);
            this.metroPanel1.Controls.Add(this.radioMale);
            this.metroPanel1.Controls.Add(this.txtboxWeight);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.txtboxName);
            this.metroPanel1.Controls.Add(this.btnBrowse);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(444, 75);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(362, 348);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(138, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(33, 153);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtboxName
            // 
            // 
            // 
            // 
            this.txtboxName.CustomButton.Image = null;
            this.txtboxName.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtboxName.CustomButton.Name = "";
            this.txtboxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxName.CustomButton.TabIndex = 1;
            this.txtboxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxName.CustomButton.UseSelectable = true;
            this.txtboxName.CustomButton.Visible = false;
            this.txtboxName.Lines = new string[0];
            this.txtboxName.Location = new System.Drawing.Point(225, 25);
            this.txtboxName.MaxLength = 32767;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.PasswordChar = '\0';
            this.txtboxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxName.SelectedText = "";
            this.txtboxName.SelectionLength = 0;
            this.txtboxName.SelectionStart = 0;
            this.txtboxName.ShortcutsEnabled = true;
            this.txtboxName.Size = new System.Drawing.Size(127, 23);
            this.txtboxName.TabIndex = 4;
            this.txtboxName.UseSelectable = true;
            this.txtboxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 112);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(138, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Weight";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(136, 83);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Gender";
            // 
            // txtboxWeight
            // 
            // 
            // 
            // 
            this.txtboxWeight.CustomButton.Image = null;
            this.txtboxWeight.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtboxWeight.CustomButton.Name = "";
            this.txtboxWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxWeight.CustomButton.TabIndex = 1;
            this.txtboxWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxWeight.CustomButton.UseSelectable = true;
            this.txtboxWeight.CustomButton.Visible = false;
            this.txtboxWeight.Lines = new string[0];
            this.txtboxWeight.Location = new System.Drawing.Point(225, 57);
            this.txtboxWeight.MaxLength = 32767;
            this.txtboxWeight.Name = "txtboxWeight";
            this.txtboxWeight.PasswordChar = '\0';
            this.txtboxWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxWeight.SelectedText = "";
            this.txtboxWeight.SelectionLength = 0;
            this.txtboxWeight.SelectionStart = 0;
            this.txtboxWeight.ShortcutsEnabled = true;
            this.txtboxWeight.Size = new System.Drawing.Size(127, 23);
            this.txtboxWeight.TabIndex = 8;
            this.txtboxWeight.UseSelectable = true;
            this.txtboxWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(225, 87);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(49, 15);
            this.radioMale.TabIndex = 9;
            this.radioMale.Text = "Male";
            this.radioMale.UseSelectable = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(225, 108);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(61, 15);
            this.radioFemale.TabIndex = 10;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseSelectable = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(225, 241);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(377, 275);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // catDbDataSet
            // 
            this.catDbDataSet.DataSetName = "CatDbDataSet";
            this.catDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catBindingSource
            // 
            this.catBindingSource.DataMember = "Cat";
            this.catBindingSource.DataSource = this.catDbDataSet;
            // 
            // catTableAdapter
            // 
            this.catTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CRUD.Cats);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(854, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mtbGrid;
        private MetroFramework.Controls.MetroPanel mtbPanel;
        private MetroFramework.Controls.MetroTextBox mtbName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton mtbBrowse;
        private System.Windows.Forms.PictureBox mtbPicture;
        private MetroFramework.Controls.MetroButton mtbRegister;
        private MetroFramework.Controls.MetroRadioButton mtbFemale;
        private MetroFramework.Controls.MetroRadioButton mtbMale;
        private MetroFramework.Controls.MetroTextBox mtbWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource catsBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtboxName;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton radioFemale;
        private MetroFramework.Controls.MetroRadioButton radioMale;
        private MetroFramework.Controls.MetroTextBox txtboxWeight;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroButton btnRegister;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CatDbDataSet catDbDataSet;
        private System.Windows.Forms.BindingSource catBindingSource;
        private CatDbDataSetTableAdapters.CatTableAdapter catTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}

