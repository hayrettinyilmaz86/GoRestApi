using Business.Abstract.User;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinUI.Model.User;

namespace WinUI.Forms.User
{
    public partial class SaveUserForm : Form
    {
        private readonly IUserService _userService;
        public SaveUserModel _model;
        public SaveUserForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            ClearFields();
        }

        private void SaveUserForm_Load(object sender, EventArgs e)
        {
            FillSearchComboBoxes();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            PrepareModelFromInputs();
            if (_model.id.HasValue &&
                _model.id.Value > 0)
            {
                var responseUpdate = await _userService.UpdateUserbyRequest(new Entities.Containers.Requests.User.RequestUpdateUser
                {
                    id = _model.id.Value,
                    email = _model.email,
                    _gender = _model.gender,
                    name = _model.name,
                    _status = _model.status
                });
                MessageBox.Show($"User updated. id:{responseUpdate.data.id}");
            }
            else
            {
                var responseCreate = await _userService.CreateUserbyRequest(new Entities.Containers.Requests.User.RequestCreateUser
                {
                    email = _model.email,
                    _gender = _model.gender,
                    name = _model.name,
                    _status = _model.status
                });
                MessageBox.Show($"User created. id:{responseCreate.data.id}");
            }
            this.Hide();
        }
        #region Form Load

        private void FillSearchComboBoxes()
        {
            cbxStatus.DataSource = new List<object>
            {

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
            cbxStatus.DisplayMember = "Text";
            cbxStatus.ValueMember = "Value";

            cbxGender.DataSource = new List<object>
            {
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
            cbxGender.DisplayMember = "Text";
            cbxGender.ValueMember = "Value";
        }

        #endregion
        private void ClearFields()
        {
            txtEMail.Text = txtName.Text = "";
            cbxGender.SelectedItem = cbxStatus.SelectedItem = null;
        }
        private void PrepareModelFromInputs()
        {
            if (_model == null)
                _model = new SaveUserModel();

            _model.email = txtEMail.Text;
            _model.name = txtName.Text;
            if (cbxStatus.SelectedValue != null &&
              !string.IsNullOrEmpty(cbxStatus.SelectedValue.ToString()))
                _model.status = (EnumStatus)Convert.ToInt32(cbxStatus.SelectedValue);

            if (cbxGender.SelectedValue != null &&
                !string.IsNullOrEmpty(cbxGender.SelectedValue.ToString()))
                _model.gender = (EnumGender)Convert.ToInt32(cbxGender.SelectedValue);
        }
        public void PrepareInputFromModel()
        {
            txtEMail.Text = _model.email;
            txtName.Text = _model.name;
            cbxGender.SelectedValue = _model.gender.GetHashCode().ToString();
            cbxStatus.SelectedValue = _model.status.GetHashCode().ToString();
        }
    }
}
