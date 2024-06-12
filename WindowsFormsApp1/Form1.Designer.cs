namespace WindowsFormsApp
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pnlWinUpMeny = new System.Windows.Forms.Panel();
            this.btnSizeMinForm = new System.Windows.Forms.Label();
            this.btnClosForm = new System.Windows.Forms.Label();
            this.LineUpMeny = new System.Windows.Forms.Panel();
            this.LineRight = new System.Windows.Forms.Panel();
            this.LineDown = new System.Windows.Forms.Panel();
            this.flagFrame = new System.Windows.Forms.CheckBox();
            this.flagAddress = new System.Windows.Forms.CheckBox();
            this.flagCompanyName = new System.Windows.Forms.CheckBox();
            this.flagFrameReceiptDetails = new System.Windows.Forms.CheckBox();
            this.flagAmount = new System.Windows.Forms.CheckBox();
            this.flagAdvertisement = new System.Windows.Forms.CheckBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.panelItems = new System.Windows.Forms.Panel();
            this.rtbItems = new System.Windows.Forms.RichTextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tbAdvertisement = new System.Windows.Forms.TextBox();
            this.labelAdvertisement = new System.Windows.Forms.Label();
            this.pnlWinUpMeny.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWinUpMeny
            // 
            this.pnlWinUpMeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWinUpMeny.Controls.Add(this.btnSizeMinForm);
            this.pnlWinUpMeny.Controls.Add(this.btnClosForm);
            this.pnlWinUpMeny.Controls.Add(this.LineUpMeny);
            this.pnlWinUpMeny.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.pnlWinUpMeny.Location = new System.Drawing.Point(400, 0);
            this.pnlWinUpMeny.Name = "pnlWinUpMeny";
            this.pnlWinUpMeny.Size = new System.Drawing.Size(199, 21);
            this.pnlWinUpMeny.TabIndex = 3;
            this.pnlWinUpMeny.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWinUpMeny_MouseDown);
            // 
            // btnSizeMinForm
            // 
            this.btnSizeMinForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSizeMinForm.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnSizeMinForm.Location = new System.Drawing.Point(159, 0);
            this.btnSizeMinForm.Name = "btnSizeMinForm";
            this.btnSizeMinForm.Size = new System.Drawing.Size(20, 20);
            this.btnSizeMinForm.TabIndex = 3;
            this.btnSizeMinForm.Text = "🗕";
            this.btnSizeMinForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSizeMinForm.Click += new System.EventHandler(this.btnSizeMinForm_Click);
            this.btnSizeMinForm.MouseEnter += new System.EventHandler(this.LabelMouseEnter);
            this.btnSizeMinForm.MouseLeave += new System.EventHandler(this.LabelMouseLeave);
            // 
            // btnClosForm
            // 
            this.btnClosForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosForm.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnClosForm.Location = new System.Drawing.Point(179, 0);
            this.btnClosForm.Name = "btnClosForm";
            this.btnClosForm.Size = new System.Drawing.Size(20, 20);
            this.btnClosForm.TabIndex = 1;
            this.btnClosForm.Text = "🗙";
            this.btnClosForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClosForm.Click += new System.EventHandler(this.btnClosForm_Click);
            this.btnClosForm.MouseEnter += new System.EventHandler(this.LabelMouseEnter);
            this.btnClosForm.MouseLeave += new System.EventHandler(this.LabelMouseLeave);
            // 
            // LineUpMeny
            // 
            this.LineUpMeny.BackColor = System.Drawing.SystemColors.ControlText;
            this.LineUpMeny.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineUpMeny.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.LineUpMeny.Location = new System.Drawing.Point(0, 20);
            this.LineUpMeny.Name = "LineUpMeny";
            this.LineUpMeny.Size = new System.Drawing.Size(199, 1);
            this.LineUpMeny.TabIndex = 0;
            // 
            // LineRight
            // 
            this.LineRight.BackColor = System.Drawing.SystemColors.ControlText;
            this.LineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.LineRight.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.LineRight.Location = new System.Drawing.Point(599, 0);
            this.LineRight.Name = "LineRight";
            this.LineRight.Size = new System.Drawing.Size(1, 601);
            this.LineRight.TabIndex = 4;
            // 
            // LineDown
            // 
            this.LineDown.BackColor = System.Drawing.SystemColors.ControlText;
            this.LineDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineDown.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.LineDown.Location = new System.Drawing.Point(0, 600);
            this.LineDown.Name = "LineDown";
            this.LineDown.Size = new System.Drawing.Size(599, 1);
            this.LineDown.TabIndex = 5;
            // 
            // flagFrame
            // 
            this.flagFrame.AutoSize = true;
            this.flagFrame.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.flagFrame.Location = new System.Drawing.Point(270, 70);
            this.flagFrame.Name = "flagFrame";
            this.flagFrame.Size = new System.Drawing.Size(61, 19);
            this.flagFrame.TabIndex = 9;
            this.flagFrame.Text = "рамка";
            this.flagFrame.UseVisualStyleBackColor = true;
            this.flagFrame.CheckedChanged += new System.EventHandler(this.flagFrame_CheckedChanged);
            // 
            // flagAddress
            // 
            this.flagAddress.AutoSize = true;
            this.flagAddress.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.flagAddress.Location = new System.Drawing.Point(270, 50);
            this.flagAddress.Name = "flagAddress";
            this.flagAddress.Size = new System.Drawing.Size(61, 19);
            this.flagAddress.TabIndex = 10;
            this.flagAddress.Text = "адрес";
            this.flagAddress.UseVisualStyleBackColor = true;
            this.flagAddress.CheckedChanged += new System.EventHandler(this.flagAddress_CheckedChanged);
            // 
            // flagCompanyName
            // 
            this.flagCompanyName.AutoSize = true;
            this.flagCompanyName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.flagCompanyName.Location = new System.Drawing.Point(270, 30);
            this.flagCompanyName.Name = "flagCompanyName";
            this.flagCompanyName.Size = new System.Drawing.Size(124, 19);
            this.flagCompanyName.TabIndex = 27;
            this.flagCompanyName.Text = "название фирмы";
            this.flagCompanyName.UseVisualStyleBackColor = true;
            this.flagCompanyName.CheckedChanged += new System.EventHandler(this.flagCompanyName_CheckedChanged);
            // 
            // flagFrameReceiptDetails
            // 
            this.flagFrameReceiptDetails.AutoSize = true;
            this.flagFrameReceiptDetails.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.flagFrameReceiptDetails.Location = new System.Drawing.Point(270, 90);
            this.flagFrameReceiptDetails.Name = "flagFrameReceiptDetails";
            this.flagFrameReceiptDetails.Size = new System.Drawing.Size(173, 19);
            this.flagFrameReceiptDetails.TabIndex = 30;
            this.flagFrameReceiptDetails.Text = "рамка для данных чека";
            this.flagFrameReceiptDetails.UseVisualStyleBackColor = true;
            this.flagFrameReceiptDetails.CheckedChanged += new System.EventHandler(this.flagFrameReceiptDetails_CheckedChanged);
            // 
            // flagAmount
            // 
            this.flagAmount.AutoSize = true;
            this.flagAmount.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.flagAmount.Location = new System.Drawing.Point(270, 110);
            this.flagAmount.Name = "flagAmount";
            this.flagAmount.Size = new System.Drawing.Size(61, 19);
            this.flagAmount.TabIndex = 29;
            this.flagAmount.Text = "сумма";
            this.flagAmount.UseVisualStyleBackColor = true;
            this.flagAmount.CheckedChanged += new System.EventHandler(this.flagAmount_CheckedChanged);
            // 
            // flagAdvertisement
            // 
            this.flagAdvertisement.AutoSize = true;
            this.flagAdvertisement.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.flagAdvertisement.Location = new System.Drawing.Point(270, 130);
            this.flagAdvertisement.Name = "flagAdvertisement";
            this.flagAdvertisement.Size = new System.Drawing.Size(166, 19);
            this.flagAdvertisement.TabIndex = 28;
            this.flagAdvertisement.Text = "рекламное объявление";
            this.flagAdvertisement.UseVisualStyleBackColor = true;
            this.flagAdvertisement.CheckedChanged += new System.EventHandler(this.flagAdvertisement_CheckedChanged);
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.White;
            this.panelResult.Location = new System.Drawing.Point(10, 10);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(250, 580);
            this.panelResult.TabIndex = 31;
            this.panelResult.Click += new System.EventHandler(this.panelResult_Click);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelCompanyName.Location = new System.Drawing.Point(270, 160);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(112, 15);
            this.labelCompanyName.TabIndex = 24;
            this.labelCompanyName.Text = "название фирмы:";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelItems.Location = new System.Drawing.Point(270, 220);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(63, 15);
            this.labelItems.TabIndex = 25;
            this.labelItems.Text = "позиции:";
            // 
            // panelItems
            // 
            this.panelItems.BackColor = System.Drawing.Color.Black;
            this.panelItems.Controls.Add(this.rtbItems);
            this.panelItems.Location = new System.Drawing.Point(339, 222);
            this.panelItems.Name = "panelItems";
            this.panelItems.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.panelItems.Size = new System.Drawing.Size(200, 300);
            this.panelItems.TabIndex = 26;
            // 
            // rtbItems
            // 
            this.rtbItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbItems.Location = new System.Drawing.Point(0, 0);
            this.rtbItems.Name = "rtbItems";
            this.rtbItems.Size = new System.Drawing.Size(199, 299);
            this.rtbItems.TabIndex = 0;
            this.rtbItems.Text = "";
            this.rtbItems.TextChanged += new System.EventHandler(this.rtbItems_TextChanged);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.BackColor = System.Drawing.Color.White;
            this.tbCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompanyName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbCompanyName.Location = new System.Drawing.Point(423, 160);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.ReadOnly = true;
            this.tbCompanyName.Size = new System.Drawing.Size(165, 16);
            this.tbCompanyName.TabIndex = 27;
            this.tbCompanyName.Text = "---";
            this.tbCompanyName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbAddress.Location = new System.Drawing.Point(423, 180);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(165, 16);
            this.tbAddress.TabIndex = 33;
            this.tbAddress.Text = "---";
            this.tbAddress.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelAddress.Location = new System.Drawing.Point(270, 180);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(49, 15);
            this.labelAddress.TabIndex = 32;
            this.labelAddress.Text = "адрес:";
            // 
            // tbAdvertisement
            // 
            this.tbAdvertisement.BackColor = System.Drawing.Color.White;
            this.tbAdvertisement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdvertisement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdvertisement.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tbAdvertisement.Location = new System.Drawing.Point(423, 200);
            this.tbAdvertisement.Name = "tbAdvertisement";
            this.tbAdvertisement.ReadOnly = true;
            this.tbAdvertisement.Size = new System.Drawing.Size(165, 16);
            this.tbAdvertisement.TabIndex = 35;
            this.tbAdvertisement.Text = "---";
            this.tbAdvertisement.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // labelAdvertisement
            // 
            this.labelAdvertisement.AutoSize = true;
            this.labelAdvertisement.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.labelAdvertisement.Location = new System.Drawing.Point(270, 200);
            this.labelAdvertisement.Name = "labelAdvertisement";
            this.labelAdvertisement.Size = new System.Drawing.Size(147, 15);
            this.labelAdvertisement.TabIndex = 34;
            this.labelAdvertisement.Text = "рекламное объявление";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 601);
            this.Controls.Add(this.tbAdvertisement);
            this.Controls.Add(this.labelAdvertisement);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.flagFrameReceiptDetails);
            this.Controls.Add(this.flagAmount);
            this.Controls.Add(this.flagAdvertisement);
            this.Controls.Add(this.flagCompanyName);
            this.Controls.Add(this.flagAddress);
            this.Controls.Add(this.flagFrame);
            this.Controls.Add(this.LineDown);
            this.Controls.Add(this.LineRight);
            this.Controls.Add(this.pnlWinUpMeny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "SortComparison";
            this.pnlWinUpMeny.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlWinUpMeny;
        private System.Windows.Forms.Panel LineUpMeny;
        private System.Windows.Forms.Label btnSizeMinForm;
        private System.Windows.Forms.Label btnClosForm;
        private System.Windows.Forms.Panel LineRight;
        private System.Windows.Forms.Panel LineDown;
        private System.Windows.Forms.CheckBox flagFrame;
        private System.Windows.Forms.CheckBox flagAddress;
        private System.Windows.Forms.CheckBox flagCompanyName;
        private System.Windows.Forms.CheckBox flagFrameReceiptDetails;
        private System.Windows.Forms.CheckBox flagAmount;
        private System.Windows.Forms.CheckBox flagAdvertisement;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.RichTextBox rtbItems;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox tbAdvertisement;
        private System.Windows.Forms.Label labelAdvertisement;
    }

}

