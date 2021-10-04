
namespace WinUI
{
    partial class UserListForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grdBtnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grdBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearchStatus = new System.Windows.Forms.ComboBox();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.cbxSearchGender = new System.Windows.Forms.ComboBox();
            this.lblSearchGender = new System.Windows.Forms.Label();
            this.txtSearchEMail = new System.Windows.Forms.TextBox();
            this.lblSearchEMail = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.cbxPaging = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grbSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdBtnUpdate,
            this.grdBtnDelete,
            this.id,
            this.name,
            this.email,
            this.gender,
            this.status});
            this.dgvUsers.Location = new System.Drawing.Point(12, 162);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(554, 222);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // grdBtnUpdate
            // 
            this.grdBtnUpdate.HeaderText = "";
            this.grdBtnUpdate.Name = "grdBtnUpdate";
            this.grdBtnUpdate.ReadOnly = true;
            this.grdBtnUpdate.Text = "Update";
            this.grdBtnUpdate.UseColumnTextForButtonValue = true;
            // 
            // grdBtnDelete
            // 
            this.grdBtnDelete.HeaderText = "";
            this.grdBtnDelete.Name = "grdBtnDelete";
            this.grdBtnDelete.ReadOnly = true;
            this.grdBtnDelete.Text = "Delete";
            this.grdBtnDelete.UseColumnTextForButtonValue = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // grbSearchCriteria
            // 
            this.grbSearchCriteria.Controls.Add(this.btnSearch);
            this.grbSearchCriteria.Controls.Add(this.cbxSearchStatus);
            this.grbSearchCriteria.Controls.Add(this.lblSearchStatus);
            this.grbSearchCriteria.Controls.Add(this.cbxSearchGender);
            this.grbSearchCriteria.Controls.Add(this.lblSearchGender);
            this.grbSearchCriteria.Controls.Add(this.txtSearchEMail);
            this.grbSearchCriteria.Controls.Add(this.lblSearchEMail);
            this.grbSearchCriteria.Controls.Add(this.txtSearchName);
            this.grbSearchCriteria.Controls.Add(this.lblSearchName);
            this.grbSearchCriteria.Location = new System.Drawing.Point(12, 12);
            this.grbSearchCriteria.Name = "grbSearchCriteria";
            this.grbSearchCriteria.Size = new System.Drawing.Size(554, 109);
            this.grbSearchCriteria.TabIndex = 1;
            this.grbSearchCriteria.TabStop = false;
            this.grbSearchCriteria.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(71, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearchStatus
            // 
            this.cbxSearchStatus.FormattingEnabled = true;
            this.cbxSearchStatus.Location = new System.Drawing.Point(350, 48);
            this.cbxSearchStatus.Name = "cbxSearchStatus";
            this.cbxSearchStatus.Size = new System.Drawing.Size(173, 23);
            this.cbxSearchStatus.TabIndex = 7;
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Location = new System.Drawing.Point(275, 51);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(39, 15);
            this.lblSearchStatus.TabIndex = 6;
            this.lblSearchStatus.Text = "Status";
            // 
            // cbxSearchGender
            // 
            this.cbxSearchGender.FormattingEnabled = true;
            this.cbxSearchGender.Location = new System.Drawing.Point(350, 16);
            this.cbxSearchGender.Name = "cbxSearchGender";
            this.cbxSearchGender.Size = new System.Drawing.Size(173, 23);
            this.cbxSearchGender.TabIndex = 5;
            // 
            // lblSearchGender
            // 
            this.lblSearchGender.AutoSize = true;
            this.lblSearchGender.Location = new System.Drawing.Point(275, 19);
            this.lblSearchGender.Name = "lblSearchGender";
            this.lblSearchGender.Size = new System.Drawing.Size(45, 15);
            this.lblSearchGender.TabIndex = 4;
            this.lblSearchGender.Text = "Gender";
            // 
            // txtSearchEMail
            // 
            this.txtSearchEMail.Location = new System.Drawing.Point(71, 48);
            this.txtSearchEMail.Name = "txtSearchEMail";
            this.txtSearchEMail.Size = new System.Drawing.Size(173, 23);
            this.txtSearchEMail.TabIndex = 3;
            // 
            // lblSearchEMail
            // 
            this.lblSearchEMail.AutoSize = true;
            this.lblSearchEMail.Location = new System.Drawing.Point(6, 51);
            this.lblSearchEMail.Name = "lblSearchEMail";
            this.lblSearchEMail.Size = new System.Drawing.Size(41, 15);
            this.lblSearchEMail.TabIndex = 2;
            this.lblSearchEMail.Text = "E-Mail";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(71, 16);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(173, 23);
            this.txtSearchName.TabIndex = 1;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(6, 19);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(39, 15);
            this.lblSearchName.TabIndex = 0;
            this.lblSearchName.Text = "Name";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(13, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(27, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "|<";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(46, 391);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(27, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(144, 391);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(177, 391);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(27, 23);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = ">|";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // cbxPaging
            // 
            this.cbxPaging.Enabled = false;
            this.cbxPaging.FormattingEnabled = true;
            this.cbxPaging.Location = new System.Drawing.Point(79, 391);
            this.cbxPaging.Name = "cbxPaging";
            this.cbxPaging.Size = new System.Drawing.Size(59, 23);
            this.cbxPaging.TabIndex = 6;
            this.cbxPaging.SelectedIndexChanged += new System.EventHandler(this.cbxPaging_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(13, 130);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 421);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cbxPaging);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grbSearchCriteria);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grbSearchCriteria.ResumeLayout(false);
            this.grbSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grbSearchCriteria;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxSearchStatus;
        private System.Windows.Forms.Label lblSearchStatus;
        private System.Windows.Forms.ComboBox cbxSearchGender;
        private System.Windows.Forms.Label lblSearchGender;
        private System.Windows.Forms.TextBox txtSearchEMail;
        private System.Windows.Forms.Label lblSearchEMail;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ComboBox cbxPaging;
        private System.Windows.Forms.DataGridViewButtonColumn grdBtnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn grdBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnAddUser;
    }
}

