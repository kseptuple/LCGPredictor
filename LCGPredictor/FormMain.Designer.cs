namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAdder = new System.Windows.Forms.TextBox();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMultiplierInverse = new System.Windows.Forms.TextBox();
            this.textBoxAdderInverse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrngValInput = new System.Windows.Forms.TextBox();
            this.textBoxPrngPos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrngPosInput = new System.Windows.Forms.TextBox();
            this.textBoxPrngVal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonReverseCalc = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonInit = new System.Windows.Forms.Button();
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownBit = new System.Windows.Forms.NumericUpDown();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAdder
            // 
            this.textBoxAdder.Location = new System.Drawing.Point(322, 33);
            this.textBoxAdder.Name = "textBoxAdder";
            this.textBoxAdder.Size = new System.Drawing.Size(150, 21);
            this.textBoxAdder.TabIndex = 0;
            this.textBoxAdder.TextChanged += new System.EventHandler(this.textBoxAdder_TextChanged);
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Location = new System.Drawing.Point(107, 33);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(150, 21);
            this.textBoxMultiplier.TabIndex = 1;
            this.textBoxMultiplier.TextChanged += new System.EventHandler(this.textBoxMultiplier_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原算法：PRNG =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "* PRNG +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "* PRNG +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "逆算法：PRNG =";
            // 
            // textBoxMultiplierInverse
            // 
            this.textBoxMultiplierInverse.Location = new System.Drawing.Point(107, 60);
            this.textBoxMultiplierInverse.Name = "textBoxMultiplierInverse";
            this.textBoxMultiplierInverse.ReadOnly = true;
            this.textBoxMultiplierInverse.Size = new System.Drawing.Size(150, 21);
            this.textBoxMultiplierInverse.TabIndex = 5;
            // 
            // textBoxAdderInverse
            // 
            this.textBoxAdderInverse.Location = new System.Drawing.Point(322, 60);
            this.textBoxAdderInverse.Name = "textBoxAdderInverse";
            this.textBoxAdderInverse.ReadOnly = true;
            this.textBoxAdderInverse.Size = new System.Drawing.Size(150, 21);
            this.textBoxAdderInverse.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "是从0开始的第";
            // 
            // textBoxPrngValInput
            // 
            this.textBoxPrngValInput.Enabled = false;
            this.textBoxPrngValInput.Location = new System.Drawing.Point(59, 114);
            this.textBoxPrngValInput.Name = "textBoxPrngValInput";
            this.textBoxPrngValInput.Size = new System.Drawing.Size(150, 21);
            this.textBoxPrngValInput.TabIndex = 9;
            this.textBoxPrngValInput.TextChanged += new System.EventHandler(this.textBoxPrngValInput_TextChanged);
            // 
            // textBoxPrngPos
            // 
            this.textBoxPrngPos.Location = new System.Drawing.Point(304, 114);
            this.textBoxPrngPos.Name = "textBoxPrngPos";
            this.textBoxPrngPos.ReadOnly = true;
            this.textBoxPrngPos.Size = new System.Drawing.Size(150, 21);
            this.textBoxPrngPos.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "个随机数是";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "从0开始的第";
            // 
            // textBoxPrngPosInput
            // 
            this.textBoxPrngPosInput.Enabled = false;
            this.textBoxPrngPosInput.Location = new System.Drawing.Point(89, 87);
            this.textBoxPrngPosInput.Name = "textBoxPrngPosInput";
            this.textBoxPrngPosInput.Size = new System.Drawing.Size(150, 21);
            this.textBoxPrngPosInput.TabIndex = 13;
            this.textBoxPrngPosInput.TextChanged += new System.EventHandler(this.textBoxPrngPosInput_TextChanged);
            // 
            // textBoxPrngVal
            // 
            this.textBoxPrngVal.Location = new System.Drawing.Point(316, 87);
            this.textBoxPrngVal.Name = "textBoxPrngVal";
            this.textBoxPrngVal.ReadOnly = true;
            this.textBoxPrngVal.Size = new System.Drawing.Size(150, 21);
            this.textBoxPrngVal.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "个随机数";
            // 
            // buttonReverseCalc
            // 
            this.buttonReverseCalc.Enabled = false;
            this.buttonReverseCalc.Location = new System.Drawing.Point(519, 112);
            this.buttonReverseCalc.Name = "buttonReverseCalc";
            this.buttonReverseCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonReverseCalc.TabIndex = 17;
            this.buttonReverseCalc.Text = "计算";
            this.buttonReverseCalc.UseVisualStyleBackColor = true;
            this.buttonReverseCalc.Click += new System.EventHandler(this.buttonReverseCalc_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Enabled = false;
            this.buttonCalc.Location = new System.Drawing.Point(519, 85);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 18;
            this.buttonCalc.Text = "计算";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(519, 31);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(75, 23);
            this.buttonInit.TabIndex = 19;
            this.buttonInit.Text = "初始化";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.AutoSize = true;
            this.checkBoxHex.Enabled = false;
            this.checkBoxHex.Location = new System.Drawing.Point(519, 60);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(72, 16);
            this.checkBoxHex.TabIndex = 20;
            this.checkBoxHex.Text = "十六进制";
            this.checkBoxHex.UseVisualStyleBackColor = true;
            this.checkBoxHex.CheckedChanged += new System.EventHandler(this.checkBoxHex_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "随机数为";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "比特";
            // 
            // numericUpDownBit
            // 
            this.numericUpDownBit.Location = new System.Drawing.Point(71, 7);
            this.numericUpDownBit.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownBit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBit.Name = "numericUpDownBit";
            this.numericUpDownBit.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownBit.TabIndex = 24;
            this.numericUpDownBit.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownBit.ValueChanged += new System.EventHandler(this.numericUpDownBit_ValueChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(157, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 12);
            this.labelInfo.TabIndex = 25;
            this.labelInfo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "随机数";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 147);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.numericUpDownBit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxHex);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonReverseCalc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrngPosInput);
            this.Controls.Add(this.textBoxPrngVal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrngValInput);
            this.Controls.Add(this.textBoxPrngPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMultiplierInverse);
            this.Controls.Add(this.textBoxAdderInverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMultiplier);
            this.Controls.Add(this.textBoxAdder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "线性同余随机数预测器";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdder;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMultiplierInverse;
        private System.Windows.Forms.TextBox textBoxAdderInverse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrngValInput;
        private System.Windows.Forms.TextBox textBoxPrngPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrngPosInput;
        private System.Windows.Forms.TextBox textBoxPrngVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonReverseCalc;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.CheckBox checkBoxHex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownBit;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label6;
    }
}

