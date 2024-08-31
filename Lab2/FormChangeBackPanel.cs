using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormChangeBackPanel : Form
    {
        public FormChangeBackPanel(Boolean net, int net_size, Boolean period_net_exist, int period_net, int period_net_size, Color background_color, Color net_color,Boolean gradient, int gradient_color)
        {
            InitializeComponent();
            if (net)
                CheckNet.Checked = true;
            else
            {
                CheckNet.Checked = false;
                SizeNet.Enabled = false;
            }
            SizeNet.Value = net_size;
            if (period_net_exist)
                CheckPeriodNet.Checked = true;
            else
            {
                CheckPeriodNet.Checked = false;
                NumPeriodNet.Enabled = false;
                SizePeriodNet.Enabled = false;
            }
            NumPeriodNet.Value = period_net;
            SizePeriodNet.Value = period_net_size;
            lNetColor.BackColor = net_color;
            lBackColor.BackColor = background_color;
            if (gradient) CheckGradient.Checked = true;
            else
            {
                CheckGradient.Checked = false;
                radioButtonBlue.Enabled = false;
                radioButtonRed.Enabled = false;
            }
            if (gradient_color == 1)
                radioButtonBlue.Checked = true;
            else radioButtonRed.Checked = true;
        }

        private void CheckNet_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNet.Checked == true)
            {
                SizeNet.Enabled = true;
            }
            else SizeNet.Enabled = false;
        }

        private void CheckPeriodNet_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPeriodNet.Checked == true)
            {
                NumPeriodNet.Enabled = true;
                SizePeriodNet.Enabled = true;
            }
            else
            {
                NumPeriodNet.Enabled = false;
                SizePeriodNet.Enabled = false;
            }
        }

        private void bChooseColorNet_Click(object sender, EventArgs e)
        {
            ColorDialog NetColor = new ColorDialog();
            NetColor.AllowFullOpen = false;
            NetColor.ShowHelp = true;
            NetColor.Color = lNetColor.BackColor;
            if (NetColor.ShowDialog() == DialogResult.OK)
            {
                lNetColor.BackColor = NetColor.Color;
            }
        }

        private void bСhooseBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog BackColor = new ColorDialog();
            BackColor.AllowFullOpen = false;
            BackColor.ShowHelp = true;
            BackColor.Color = lBackColor.BackColor;
            if (BackColor.ShowDialog() == DialogResult.OK)
            {
                lBackColor.BackColor = BackColor.Color;
            }
        }

        private void CheckGradient_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckGradient.Checked == true)
            {
                radioButtonBlue.Enabled = true;
                radioButtonRed.Enabled = true;
                bСhooseBackColor.Enabled = false;
            }
            else
            {
                radioButtonBlue.Enabled = false;
                radioButtonRed.Enabled = false;
                bСhooseBackColor.Enabled = true;
            }
        }
        public Boolean get_net()
        {
            return CheckNet.Checked;
        }
        public int get_size_net()
        {
            return SizeNet.Value;
        }
        public Boolean get_period_net_exist()
        {
            return CheckPeriodNet.Checked;
        }
        public int get_period_net()
        {
            return (int)NumPeriodNet.Value;
        }
        public int get_period_net_size()
        {
            return SizePeriodNet.Value;
        }
        public Color get_net_color()
        {
            return lNetColor.BackColor;
        }
        public Color get_background_color()
        {
            return lBackColor.BackColor;
        }
        public Boolean get_gradient()
        {
            return CheckGradient.Checked;
        }
        public int get_gradient_color()
        {
            if (radioButtonBlue.Checked) return 1;
            else return 2;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void bCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
