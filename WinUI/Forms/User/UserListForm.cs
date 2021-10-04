using Business.Abstract.User;
using Core.Infrastructure.Data.PagedList;
using Entities.Containers.Request.User;
using Entities.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinUI.Forms.User;

namespace WinUI
{
    public partial class UserListForm : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private pagination _pageInfo;
        public UserListForm(IServiceProvider serviceProvider, IUserService userService)
        {
            InitializeComponent();

            _userService = userService;
            _serviceProvider = serviceProvider;
            _pageInfo = new pagination();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillSearchComboBoxes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetUserList(true);
        }

        private async void GetUserList(bool reFillPagingCombobox = false)
        {
            var request = new RequestGetUserPagedList
            {
                page = _pageInfo.page
            };

            if (!string.IsNullOrEmpty(txtSearchEMail.Text))
                request.email = txtSearchEMail.Text;

            if (!string.IsNullOrEmpty(txtSearchName.Text))
                request.name = txtSearchName.Text;

            if (cbxSearchStatus.SelectedValue != null &&
                !string.IsNullOrEmpty(cbxSearchStatus.SelectedValue.ToString()))
                request.status = (EnumStatus)Convert.ToInt32(cbxSearchStatus.SelectedValue);

            if (cbxSearchGender.SelectedValue != null &&
                !string.IsNullOrEmpty(cbxSearchGender.SelectedValue.ToString()))
                request.gender = (EnumGender)Convert.ToInt32(cbxSearchGender.SelectedValue);

            if (!string.IsNullOrEmpty(txtSearchEMail.Text))
                request.email = txtSearchEMail.Text;

            var userList = await _userService.GetUserPagedListbyRequest(request);

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = userList.data;

            _pageInfo = userList.meta.pagination;

            btnStart.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnEnd.Enabled = cbxPaging.Enabled = _pageInfo.pages > 0;

            if (reFillPagingCombobox)
                FillPagingCombobox();
        }
        #region Form Load

        private void FillSearchComboBoxes()
        {
            cbxSearchStatus.DataSource = new List<object>
            {
                new
                {
                    Text = "all",
                    Value = ""
                },
                new
                {
                    Text = EnumStatus.active.ToString(),
                    Value = EnumStatus.active.GetHashCode().ToString()
                },
                 new
                {
                    Text = EnumStatus.inactive.ToString(),
                    Value = EnumStatus.inactive.GetHashCode().ToString()
                },
            };
            cbxSearchStatus.DisplayMember = "Text";
            cbxSearchStatus.ValueMember = "Value";

            cbxSearchGender.DataSource = new List<object>
            {
                new
                {
                    Text = "all",
                    Value = ""
                },
                new
                {
                    Text = EnumGender.male.ToString(),
                    Value = EnumGender.male.GetHashCode().ToString()
                },
                 new
                {
                    Text = EnumGender.female.ToString(),
                    Value = EnumGender.female.GetHashCode().ToString()
                },
            };
            cbxSearchGender.DisplayMember = "Text";
            cbxSearchGender.ValueMember = "Value";
        }

        #endregion

        #region Paging

        private void FillPagingCombobox()
        {
            cbxPaging.Items.Clear();
            if (_pageInfo.total > 0)
            {
                for (int i = 1; i <= _pageInfo.pages; i++)
                {
                    cbxPaging.Items.Add(i);
                }
                cbxPaging.SelectedIndex = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _pageInfo.page = 1;
            cbxPaging.SelectedIndex = _pageInfo.page - 1;
            //GetUserList();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_pageInfo.page > 1)
            {
                _pageInfo.page--;
                cbxPaging.SelectedIndex = _pageInfo.page - 1;
                //GetUserList();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_pageInfo.page < _pageInfo.pages)
            {
                _pageInfo.page++;
                cbxPaging.SelectedIndex = _pageInfo.page - 1;
            }
            //GetUserList();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _pageInfo.page = _pageInfo.pages;
            cbxPaging.SelectedIndex = _pageInfo.page - 1;
            //GetUserList();
        }

        private void cbxPaging_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaging.SelectedItem != null)
            {
                _pageInfo.page = Convert.ToInt32(cbxPaging.SelectedItem.ToString());
                GetUserList();
            }
        }
        #endregion

        private async void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderDgv = (DataGridView)sender;

            if (senderDgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["id"].Value.ToString());
                if (senderDgv.Columns[e.ColumnIndex].Name == "grdBtnUpdate")
                {
                    var user = await _userService.GetUserbyId(id);
                    var saveUserForm = _serviceProvider.GetRequiredService<SaveUserForm>();
                    saveUserForm._model = new Model.User.SaveUserModel
                    {
                        id = user.id,
                        email = user.email,
                        name = user.name,
                        gender = (EnumGender)Enum.Parse(typeof(EnumGender), user.gender),
                        status = (EnumStatus)Enum.Parse(typeof(EnumStatus), user.status)
                    };
                    saveUserForm.PrepareInputFromModel();
                    saveUserForm.ShowDialog(this);
                }
                else if (senderDgv.Columns[e.ColumnIndex].Name == "grdBtnDelete")
                {
                    var dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        await _userService.DeleteUserbyRequest(new Entities.Containers.Requests.User.RequestDeleteUser
                        {
                            id = id
                        });
                        MessageBox.Show("Record deleted");
                        GetUserList();
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var saveUserForm = _serviceProvider.GetRequiredService<SaveUserForm>();
            saveUserForm.ShowDialog(this);
        }
    }
}
