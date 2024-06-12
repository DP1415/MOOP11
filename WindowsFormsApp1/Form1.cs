using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            UpdateCheque();
        }

        private void LabelMouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = base.ForeColor;
            ((Label)sender).ForeColor = base.BackColor;
        }
        private void LabelMouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = base.BackColor;
            ((Label)sender).ForeColor = base.ForeColor;
        }

        private void btnSizeMinForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClosForm_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void pnlWinUpMeny_MouseDown(object sender, MouseEventArgs e)
        {
            pnlWinUpMeny.Capture = false;
            Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }


        string lastCompanyName = "none";
        string lastAddress = "none";
        string lastAdvertisement = "none";

        #region flag -//- _CheckedChanged
        private void flagCompanyName_CheckedChanged(object sender, EventArgs e)
        {
            if (flagCompanyName.Checked)
            {
                tbCompanyName.Text = lastCompanyName;
                tbCompanyName.ReadOnly = false;
            }
            else
            {
                lastCompanyName = tbCompanyName.Text;
                tbCompanyName.Text = "---";
                tbCompanyName.ReadOnly = true;
            }
            UpdateCheque();
        }
        private void flagAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (flagAddress.Checked)
            {
                tbAddress.Text = lastAddress;
                tbAddress.ReadOnly = false;
            }
            else
            {
                lastAddress = tbAddress.Text;
                tbAddress.Text = "---";
                tbAddress.ReadOnly = true;
            }
            UpdateCheque();
        }
        private void flagFrame_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheque();
        }
        private void flagFrameReceiptDetails_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheque();
        }
        private void flagAmount_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheque();
        }
        private void flagAdvertisement_CheckedChanged(object sender, EventArgs e)
        {
            if (flagAdvertisement.Checked)
            {
                tbAdvertisement.Text = lastAdvertisement;
                tbAdvertisement.ReadOnly = false;
            }
            else
            {
                lastAdvertisement = tbAdvertisement.Text;
                tbAdvertisement.Text = "---";
                tbAdvertisement.ReadOnly = true;
            }
            UpdateCheque();
        }
        #endregion


        private void UpdateCheque()
        {
            ChequeAbs obj = new Cheque(rtbItems.Text);
            obj.FrameReceiptDetails = flagFrameReceiptDetails.Checked;

            if (flagAmount.Checked)
            {
                obj = new DecoratorAmount(obj);
            }
            if (flagFrame.Checked)
            {
                obj = new DecoratorFrame(obj);
            }
            if (flagAddress.Checked)
            {
                obj = new DecoratoAddress(obj, tbAddress.Text);
            }
            if (flagCompanyName.Checked)
            {
                obj = new DecoratorCompanyName(obj, tbCompanyName.Text);
            }
            if (flagAdvertisement.Checked)
            {
                obj = new DecoratorAdvertisement(obj, tbAdvertisement.Text);
            }
            obj = new DecoratorFinal(obj, this);
            obj.Rendering();
        }



        public void Rendering(Control control = null)
        {
            panelResult.Controls.Clear();
            if (control != null)
            {
                panelResult.Controls.Add(control);
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            UpdateCheque();
        }

        private void rtbItems_TextChanged(object sender, EventArgs e)
        {
            UpdateCheque();
            while (rtbItems.Text.IndexOf("\n\n") != -1)
            {
                rtbItems.Text = rtbItems.Text.Replace("\n\n", "\n");
            }
            while (rtbItems.Text.IndexOf("  ") != -1)
            {
                rtbItems.Text = rtbItems.Text.Replace("  ", " ");
            }
        }

        private void panelResult_Click(object sender, EventArgs e)
        {
            if (panelResult.BorderStyle == System.Windows.Forms.BorderStyle.FixedSingle)
            {
                panelResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else
            {
                panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
        }
    }
}
