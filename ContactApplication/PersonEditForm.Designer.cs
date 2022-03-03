namespace ContactApplication
{
    partial class PersonEditForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label birthdateLabel;
            this.notebookDataSet = new ContactApplication.NotebookDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new ContactApplication.NotebookDataSetTableAdapters.PersonsTableAdapter();
            this.tableAdapterManager = new ContactApplication.NotebookDataSetTableAdapters.TableAdapterManager();
            this.contactsTableAdapter = new ContactApplication.NotebookDataSetTableAdapters.ContactsTableAdapter();
            this.contactTypeTableAdapter = new ContactApplication.NotebookDataSetTableAdapters.ContactTypeTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKContactsPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContactsPersonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(466, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(466, 41);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Surname:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(466, 68);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(52, 13);
            birthdateLabel.TabIndex = 5;
            birthdateLabel.Text = "Birthdate:";
            // 
            // notebookDataSet
            // 
            this.notebookDataSet.DataSetName = "NotebookDataSet";
            this.notebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.notebookDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactsTableAdapter = this.contactsTableAdapter;
            this.tableAdapterManager.ContactTypeTableAdapter = this.contactTypeTableAdapter;
            this.tableAdapterManager.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ContactApplication.NotebookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactTypeTableAdapter
            // 
            this.contactTypeTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(524, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(524, 38);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 4;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(524, 64);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdateDateTimePicker.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn,
            this.contactTypeIdDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKContactsPersonsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 116);
            this.dataGridView1.TabIndex = 7;
            // 
            // contactTypeBindingSource
            // 
            this.contactTypeBindingSource.DataMember = "ContactType";
            this.contactTypeBindingSource.DataSource = this.notebookDataSet;
            // 
            // fKContactsPersonsBindingSource
            // 
            this.fKContactsPersonsBindingSource.DataMember = "FK_Contacts_Persons";
            this.fKContactsPersonsBindingSource.DataSource = this.personsBindingSource;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(469, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(598, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // contactTypeIdDataGridViewTextBoxColumn
            // 
            this.contactTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ContactTypeId";
            this.contactTypeIdDataGridViewTextBoxColumn.DataSource = this.contactTypeBindingSource;
            this.contactTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.contactTypeIdDataGridViewTextBoxColumn.HeaderText = "ContactTypeId";
            this.contactTypeIdDataGridViewTextBoxColumn.Name = "contactTypeIdDataGridViewTextBoxColumn";
            this.contactTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contactTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.contactTypeIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 142);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Name = "PersonEditForm";
            this.Text = "PersonEditForm";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContactsPersonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotebookDataSet notebookDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private NotebookDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private NotebookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NotebookDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKContactsPersonsBindingSource;
        private NotebookDataSetTableAdapters.ContactTypeTableAdapter contactTypeTableAdapter;
        private System.Windows.Forms.BindingSource contactTypeBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn contactTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}