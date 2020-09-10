using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Xmaster
{

    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnVoidInvoice_Click(object sender, EventArgs e)
        {
            string langToApply;
            if (Config.AppLang == "ar")
            {
                langToApply = "en";
            } else
            {
                langToApply = "ar";
            }
            ApplyLanguage(langToApply);

        }

        private void ApplyLanguage(string lang)
        {
            if (lang == "en")
            {
                Config.AppLang = "en";
                this.RightToLeft = RightToLeft.No;
                lbSubTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lbTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lbDiscount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lbGrandTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lblSubTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lblTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lblDiscount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lblGrandTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                btnPay.Text = "PAY";

            } else
            {
                Config.AppLang = "ar";
                this.RightToLeft = RightToLeft.Yes;
                lbSubTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lbTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lbDiscount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lbGrandTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                lblSubTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lblTax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lblDiscount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                lblGrandTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                btnPay.Text = "دفع";
            }
        }
    }

}
