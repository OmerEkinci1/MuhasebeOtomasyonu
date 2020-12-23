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

namespace OnMuhasebe
{
    public partial class frmMasaustu : DevExpress.XtraEditors.XtraForm
    {
        public frmMasaustu()
        {
            InitializeComponent();
        }

        private void frmMasaustu_Load(object sender, EventArgs e)
        {
            YetkileriUygula();
            
        }

        void YetkileriUygula()
        {

            if (frmAnaForm.AdminMi == "0")//admin değilse 
            {
                navBarKullanici.Visible = false;//admin değilse kullanıcı navbarı göremeyecek
            }



      
        }
    }
}