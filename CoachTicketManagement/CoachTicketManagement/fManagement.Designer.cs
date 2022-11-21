﻿
namespace CoachTicketManagement
{
    partial class fManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManagement));
            this.menuStripManagement = new System.Windows.Forms.MenuStrip();
            this.ToolStripAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripInfoAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.cboDepartureStation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDestinationStation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerChoose = new System.Windows.Forms.DateTimePicker();
            this.btnFindTicket = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.imageListSeat = new System.Windows.Forms.ImageList(this.components);
            this.picBoxEmpty = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxNo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxChoose = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelA = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelB = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStripManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripManagement
            // 
            this.menuStripManagement.BackColor = System.Drawing.Color.DarkGray;
            this.menuStripManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStripManagement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAdmin,
            this.ToolStripAccount});
            this.menuStripManagement.Location = new System.Drawing.Point(0, 0);
            this.menuStripManagement.Name = "menuStripManagement";
            this.menuStripManagement.Size = new System.Drawing.Size(1360, 28);
            this.menuStripManagement.TabIndex = 0;
            this.menuStripManagement.Text = "menuStrip1";
            // 
            // ToolStripAdmin
            // 
            this.ToolStripAdmin.Name = "ToolStripAdmin";
            this.ToolStripAdmin.Size = new System.Drawing.Size(68, 24);
            this.ToolStripAdmin.Text = "Admin";
            this.ToolStripAdmin.Click += new System.EventHandler(this.ToolStripAdmin_Click);
            // 
            // ToolStripAccount
            // 
            this.ToolStripAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripInfoAccount,
            this.ToolStripLogOut});
            this.ToolStripAccount.Name = "ToolStripAccount";
            this.ToolStripAccount.Size = new System.Drawing.Size(89, 24);
            this.ToolStripAccount.Text = "Tài khoản";
            // 
            // ToolStripInfoAccount
            // 
            this.ToolStripInfoAccount.Name = "ToolStripInfoAccount";
            this.ToolStripInfoAccount.Size = new System.Drawing.Size(226, 26);
            this.ToolStripInfoAccount.Text = "Thông tin tài khoản";
            this.ToolStripInfoAccount.Click += new System.EventHandler(this.ToolStripInfoAccount_Click);
            // 
            // ToolStripLogOut
            // 
            this.ToolStripLogOut.Name = "ToolStripLogOut";
            this.ToolStripLogOut.Size = new System.Drawing.Size(226, 26);
            this.ToolStripLogOut.Text = "Đăng xuất";
            this.ToolStripLogOut.Click += new System.EventHandler(this.ToolStripLogOut_Click);
            // 
            // cboDepartureStation
            // 
            this.cboDepartureStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartureStation.FormattingEnabled = true;
            this.cboDepartureStation.Location = new System.Drawing.Point(222, 81);
            this.cboDepartureStation.Name = "cboDepartureStation";
            this.cboDepartureStation.Size = new System.Drawing.Size(216, 28);
            this.cboDepartureStation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm đi";
            // 
            // cboDestinationStation
            // 
            this.cboDestinationStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinationStation.FormattingEnabled = true;
            this.cboDestinationStation.Location = new System.Drawing.Point(479, 81);
            this.cboDestinationStation.Name = "cboDestinationStation";
            this.cboDestinationStation.Size = new System.Drawing.Size(216, 28);
            this.cboDestinationStation.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn ngày";
            // 
            // dateTimePickerChoose
            // 
            this.dateTimePickerChoose.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerChoose.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChoose.Location = new System.Drawing.Point(739, 79);
            this.dateTimePickerChoose.Name = "dateTimePickerChoose";
            this.dateTimePickerChoose.Size = new System.Drawing.Size(216, 27);
            this.dateTimePickerChoose.TabIndex = 2;
            // 
            // btnFindTicket
            // 
            this.btnFindTicket.AutoSize = true;
            this.btnFindTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnFindTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFindTicket.ForeColor = System.Drawing.Color.White;
            this.btnFindTicket.Location = new System.Drawing.Point(990, 66);
            this.btnFindTicket.Name = "btnFindTicket";
            this.btnFindTicket.Size = new System.Drawing.Size(149, 51);
            this.btnFindTicket.TabIndex = 3;
            this.btnFindTicket.Text = "Tìm vé";
            this.btnFindTicket.UseVisualStyleBackColor = false;
            this.btnFindTicket.Click += new System.EventHandler(this.btnFindTicket_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(7, 124);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 29;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(688, 523);
            this.dataGridViewEmployee.TabIndex = 13;
            // 
            // imageListSeat
            // 
            this.imageListSeat.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSeat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSeat.ImageStream")));
            this.imageListSeat.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSeat.Images.SetKeyName(0, "Trong.png");
            this.imageListSeat.Images.SetKeyName(1, "Co.png");
            this.imageListSeat.Images.SetKeyName(2, "DangChon.png");
            // 
            // picBoxEmpty
            // 
            this.picBoxEmpty.Location = new System.Drawing.Point(823, 140);
            this.picBoxEmpty.Name = "picBoxEmpty";
            this.picBoxEmpty.Size = new System.Drawing.Size(40, 40);
            this.picBoxEmpty.TabIndex = 15;
            this.picBoxEmpty.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(869, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Còn trống";
            // 
            // picBoxNo
            // 
            this.picBoxNo.Location = new System.Drawing.Point(965, 140);
            this.picBoxNo.Name = "picBoxNo";
            this.picBoxNo.Size = new System.Drawing.Size(40, 40);
            this.picBoxNo.TabIndex = 15;
            this.picBoxNo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1011, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Không bán";
            // 
            // picBoxChoose
            // 
            this.picBoxChoose.Location = new System.Drawing.Point(1111, 140);
            this.picBoxChoose.Name = "picBoxChoose";
            this.picBoxChoose.Size = new System.Drawing.Size(40, 40);
            this.picBoxChoose.TabIndex = 15;
            this.picBoxChoose.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1157, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đang chọn";
            // 
            // flowLayoutPanelA
            // 
            this.flowLayoutPanelA.Location = new System.Drawing.Point(823, 253);
            this.flowLayoutPanelA.Name = "flowLayoutPanelA";
            this.flowLayoutPanelA.Size = new System.Drawing.Size(180, 394);
            this.flowLayoutPanelA.TabIndex = 17;
            // 
            // flowLayoutPanelB
            // 
            this.flowLayoutPanelB.Location = new System.Drawing.Point(1058, 253);
            this.flowLayoutPanelB.Name = "flowLayoutPanelB";
            this.flowLayoutPanelB.Size = new System.Drawing.Size(180, 394);
            this.flowLayoutPanelB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(867, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tầng dưới";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1111, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tầng trên";
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 654);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanelB);
            this.Controls.Add(this.flowLayoutPanelA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picBoxChoose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBoxNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBoxEmpty);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.btnFindTicket);
            this.Controls.Add(this.dateTimePickerChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDestinationStation);
            this.Controls.Add(this.cboDepartureStation);
            this.Controls.Add(this.menuStripManagement);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStripManagement;
            this.Name = "fManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé";
            this.menuStripManagement.ResumeLayout(false);
            this.menuStripManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripManagement;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAccount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripInfoAccount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripLogOut;
        private System.Windows.Forms.ComboBox cboDepartureStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDestinationStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerChoose;
        private System.Windows.Forms.Button btnFindTicket;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.ImageList imageListSeat;
        private System.Windows.Forms.PictureBox picBoxEmpty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoxChoose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}