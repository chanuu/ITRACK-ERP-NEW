using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using ITRACK.models;

namespace EFTesting.UI.User_Accounts
{
    public partial class frmLoging : DevExpress.XtraEditors.XtraForm
    {
        public frmLoging()
        {
            InitializeComponent();
        }

        private void frmLoging_Load(object sender, EventArgs e)
        {

            try {
                DevExpress.UserSkins.BonusSkins.Register();
                UserLookAndFeel.Default.SkinName = "Metropolis";
                ItrackContext _context = new ItrackContext();
                _context.Database.Initialize(false);
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            catch (Exception ex) {
            }
             
         


        }

        public static User _user { get; set; }

        bool Verrify(string _userName,string _pword) {

            try {

                ItrackContext _context = new ItrackContext();
                var users =( from item in _context.User

                             where item.Password == _pword && item.UserName == _userName

                            select item).ToList();

                if(users.Count > 0)
                {
                    _user = users.Last();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex) {
                return false;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            if (Verrify(txtUserName.Text,txtPWord.Text) == true)
            {
                frmMain main = new frmMain();
                main.Show();
                splashScreenManager1.CloseWaitForm();
                this.Hide();
            }
            else
            {
                lblError.Text = "Your password Or User Name Does not valid. Please Contact System Administrator";
                splashScreenManager1.CloseWaitForm();
            }
        }
    }
}