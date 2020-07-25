using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private ulong[] adders = new ulong[64];
        private ulong[] multipliers = new ulong[64];
        private ulong[] addersInv = new ulong[64];
        private ulong[] multipliersInv = new ulong[64];

        private int maxBit = 0;
        private ulong globalMask = 0;

        private bool ableToReverseCalc = false;
        private bool hasInverseAlgorithm = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void uninitilizeControls()
        {
            textBoxAdderInverse.Text = string.Empty;
            textBoxMultiplierInverse.Text = string.Empty;
            textBoxPrngPos.Text = string.Empty;
            textBoxPrngVal.Text = string.Empty;
            textBoxPrngPosInput.Enabled = false;
            textBoxPrngValInput.Enabled = false;
            checkBoxHex.Enabled = false;
            buttonCalc.Enabled = false;
            buttonReverseCalc.Enabled = false;
        }

        private void initilizeControls()
        {
            textBoxPrngPosInput.Enabled = true;
            checkBoxHex.Enabled = true;
            buttonCalc.Enabled = true;
            if (hasInverseAlgorithm)
            {
                if (ableToReverseCalc)
                {
                    textBoxPrngValInput.Enabled = true;
                    buttonReverseCalc.Enabled = true;
                    labelInfo.Visible = false;
                }
                else
                {
                    labelInfo.Text = "要计算某个随机数是从0开始第几个随机数，乘数除以4必须余1，加数必须是奇数。";
                    labelInfo.Visible = true;
                }
            }
            else
            {
                labelInfo.Text = "乘数是偶数时，随机数会落入陷阱，逆算法不存在。";
                labelInfo.Visible = true;
            }
        }

        private bool initilizeParams()
        {
            if (!(ulong.TryParse(textBoxAdder.Text, out ulong adder) && ulong.TryParse(textBoxMultiplier.Text, out ulong multiplier)))
            {
                try
                {
                    adder = Convert.ToUInt64(textBoxAdder.Text, 16);
                    multiplier = Convert.ToUInt64(textBoxMultiplier.Text, 16);
                }
                catch
                {
                    return false;
                }
            }
            maxBit = (int)numericUpDownBit.Value;
            globalMask = 0xFFFF_FFFF_FFFF_FFFF >> (64 - maxBit);
            if (adder > globalMask || multiplier > globalMask)
                return false;

            if ((multiplier & 1) == 0)
            {
                hasInverseAlgorithm = false;
            }
            else
            {
                hasInverseAlgorithm = true;
            }

            ableToReverseCalc = false;
            if ((adder & 1) == 1 && (multiplier & 3) == 1)
                ableToReverseCalc = true;

            for (int i = 0; i < maxBit; i++)
            {
                adders[i] = adder;
                multipliers[i] = multiplier;
                adder = (multiplier * adder + adder) & globalMask;
                multiplier = (multiplier * multiplier) & globalMask;
            }

            adder = adders[0];
            multiplier = multipliers[0];

            for (int i = 1; i < maxBit; i++)
            {
                adder = (multipliers[i] * adder + adders[i]) & globalMask;
                multiplier = (multiplier * multipliers[i]) & globalMask;
            }

            for (int i = 0; i < maxBit; i++)
            {
                addersInv[i] = adder;
                multipliersInv[i] = multiplier;
                adder = (multiplier * adder + adder) & globalMask;
                multiplier = (multiplier * multiplier) & globalMask;
            }

            return true;
        }

        private void textBoxMultiplier_TextChanged(object sender, EventArgs e)
        {
            uninitilizeControls();
        }

        private void textBoxAdder_TextChanged(object sender, EventArgs e)
        {
            uninitilizeControls();
        }

        private void numericUpDownBit_ValueChanged(object sender, EventArgs e)
        {
            uninitilizeControls();
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            if (initilizeParams())
            {
                initilizeControls();
                if (hasInverseAlgorithm)
                {
                    if (checkBoxHex.Checked)
                    {
                        textBoxAdderInverse.Text = "0x" + addersInv[0].ToString("X");
                        textBoxMultiplierInverse.Text = "0x" + multipliersInv[0].ToString("X");
                    }
                    else
                    {
                        textBoxAdderInverse.Text = addersInv[0].ToString();
                        textBoxMultiplierInverse.Text = multipliersInv[0].ToString();
                    }
                }
            }
        }

        private void textBoxPrngPosInput_TextChanged(object sender, EventArgs e)
        {
            textBoxPrngVal.Text = string.Empty;
        }

        private void textBoxPrngValInput_TextChanged(object sender, EventArgs e)
        {
            textBoxPrngPos.Text = string.Empty;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            textBoxPrngVal.Text = string.Empty;
            if (!ulong.TryParse(textBoxPrngPosInput.Text, out ulong pos))
                return;

            int bit = 0;
            ulong prng = 0;
            pos &= globalMask;
            while (pos != 0)
            {
                if ((pos & 1) == 1)
                {
                    prng = (prng * multipliers[bit] + adders[bit]) & globalMask;
                }
                bit++;
                pos >>= 1;
            }
            if (checkBoxHex.Checked)
            {
                textBoxPrngVal.Text = "0x" + prng.ToString("X");
            }
            else
            {
                textBoxPrngVal.Text = prng.ToString();
            }
        }

        private void buttonReverseCalc_Click(object sender, EventArgs e)
        {
            textBoxPrngPos.Text = string.Empty;
            if (!ulong.TryParse(textBoxPrngValInput.Text, out ulong prng))
            {
                try
                {
                    prng = Convert.ToUInt64(textBoxPrngValInput.Text, 16);
                }
                catch
                {
                    return;
                }
            }

            int bit = 0;
            ulong pos = 0;
            ulong bitMask = 1;
            if (prng > globalMask) return;
            while (prng != 0)
            {
                if ((prng & bitMask) == bitMask)
                {
                    prng = (prng * multipliersInv[bit] + addersInv[bit]) & globalMask;
                    pos += bitMask;
                }
                bit++;
                bitMask <<= 1;
            }
            textBoxPrngPos.Text = pos.ToString();
        }

        private void checkBoxHex_CheckedChanged(object sender, EventArgs e)
        {
            textboxConversion(textBoxPrngVal);
            textboxConversion(textBoxAdderInverse);
            textboxConversion(textBoxMultiplierInverse);
        }

        private void textboxConversion(TextBox textBox)
        {
            if (checkBoxHex.Checked)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "0x" + Convert.ToUInt64(textBox.Text).ToString("X");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = Convert.ToUInt64(textBox.Text, 16).ToString();
                }
            }
        }
    }
}
