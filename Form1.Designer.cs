
namespace Amnesia_Trainer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckGameRunning = new System.Windows.Forms.Timer(this.components);
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.foreverTabPage1 = new ReaLTaiizor.Controls.ForeverTabPage();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.Info1 = new ReaLTaiizor.Controls.ForeverButton();
            this.separator1 = new ReaLTaiizor.Controls.Separator();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.OilCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.CheckGameRunningLabel = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.TinderBoxCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.LanternOilCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.label2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.SanityCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.HealthCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.MovementTab = new System.Windows.Forms.TabPage();
            this.Info2 = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverLabel8 = new ReaLTaiizor.Controls.ForeverLabel();
            this.JumpHeightCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.foreverLabel9 = new ReaLTaiizor.Controls.ForeverLabel();
            this.CrouchSpeedCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.foreverLabel10 = new ReaLTaiizor.Controls.ForeverLabel();
            this.RunSpeedCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.foreverLabel11 = new ReaLTaiizor.Controls.ForeverLabel();
            this.WalkSpeedCheck = new ReaLTaiizor.Controls.ForeverToggle();
            this.separator2 = new ReaLTaiizor.Controls.Separator();
            this.foreverLabel6 = new ReaLTaiizor.Controls.ForeverLabel();
            this.CheckGameRunningLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverForm1.SuspendLayout();
            this.foreverTabPage1.SuspendLayout();
            this.PlayerTab.SuspendLayout();
            this.MovementTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckGameRunning
            // 
            this.CheckGameRunning.Tick += new System.EventHandler(this.CheckGameRunning_Tick);
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.foreverForm1.Controls.Add(this.foreverClose1);
            this.foreverForm1.Controls.Add(this.foreverTabPage1);
            this.foreverForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreverForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverForm1.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.foreverForm1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.foreverForm1.HeaderMaximize = false;
            this.foreverForm1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverForm1.Image = null;
            this.foreverForm1.Location = new System.Drawing.Point(0, 0);
            this.foreverForm1.MinimumSize = new System.Drawing.Size(210, 50);
            this.foreverForm1.Name = "foreverForm1";
            this.foreverForm1.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.foreverForm1.Sizable = false;
            this.foreverForm1.Size = new System.Drawing.Size(261, 352);
            this.foreverForm1.TabIndex = 0;
            this.foreverForm1.Text = "Amnesia Trainer";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            // 
            // foreverClose1
            // 
            this.foreverClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverClose1.BackColor = System.Drawing.Color.Maroon;
            this.foreverClose1.BaseColor = System.Drawing.Color.Maroon;
            this.foreverClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverClose1.DefaultLocation = true;
            this.foreverClose1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.foreverClose1.Location = new System.Drawing.Point(231, 16);
            this.foreverClose1.Name = "foreverClose1";
            this.foreverClose1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverClose1.Size = new System.Drawing.Size(18, 18);
            this.foreverClose1.TabIndex = 1;
            this.foreverClose1.Text = "foreverClose1";
            this.foreverClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // foreverTabPage1
            // 
            this.foreverTabPage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.foreverTabPage1.ActiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.foreverTabPage1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.foreverTabPage1.Controls.Add(this.PlayerTab);
            this.foreverTabPage1.Controls.Add(this.MovementTab);
            this.foreverTabPage1.DeactiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverTabPage1.ItemSize = new System.Drawing.Size(120, 40);
            this.foreverTabPage1.Location = new System.Drawing.Point(4, 54);
            this.foreverTabPage1.Name = "foreverTabPage1";
            this.foreverTabPage1.SelectedIndex = 0;
            this.foreverTabPage1.Size = new System.Drawing.Size(253, 294);
            this.foreverTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.foreverTabPage1.TabIndex = 0;
            // 
            // PlayerTab
            // 
            this.PlayerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.PlayerTab.Controls.Add(this.Info1);
            this.PlayerTab.Controls.Add(this.separator1);
            this.PlayerTab.Controls.Add(this.foreverLabel5);
            this.PlayerTab.Controls.Add(this.foreverLabel1);
            this.PlayerTab.Controls.Add(this.OilCheck);
            this.PlayerTab.Controls.Add(this.CheckGameRunningLabel);
            this.PlayerTab.Controls.Add(this.foreverLabel3);
            this.PlayerTab.Controls.Add(this.TinderBoxCheck);
            this.PlayerTab.Controls.Add(this.foreverLabel4);
            this.PlayerTab.Controls.Add(this.LanternOilCheck);
            this.PlayerTab.Controls.Add(this.label2);
            this.PlayerTab.Controls.Add(this.SanityCheck);
            this.PlayerTab.Controls.Add(this.foreverLabel2);
            this.PlayerTab.Controls.Add(this.HealthCheck);
            this.PlayerTab.Location = new System.Drawing.Point(4, 44);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerTab.Size = new System.Drawing.Size(245, 246);
            this.PlayerTab.TabIndex = 0;
            this.PlayerTab.Text = "Player";
            // 
            // Info1
            // 
            this.Info1.BackColor = System.Drawing.Color.Transparent;
            this.Info1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.Info1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Info1.Location = new System.Drawing.Point(183, 223);
            this.Info1.Name = "Info1";
            this.Info1.Rounded = true;
            this.Info1.Size = new System.Drawing.Size(54, 18);
            this.Info1.TabIndex = 21;
            this.Info1.Text = "Info";
            this.Info1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Info1.Click += new System.EventHandler(this.Info1_Click);
            // 
            // separator1
            // 
            this.separator1.LineColor = System.Drawing.Color.Gray;
            this.separator1.Location = new System.Drawing.Point(7, 209);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(230, 10);
            this.separator1.TabIndex = 20;
            this.separator1.Text = "separator1";
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel5.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel5.Location = new System.Drawing.Point(9, 176);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(85, 21);
            this.foreverLabel5.TabIndex = 19;
            this.foreverLabel5.Text = "Infinite Oil:";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel1.ForeColor = System.Drawing.Color.White;
            this.foreverLabel1.Location = new System.Drawing.Point(10, 222);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(52, 20);
            this.foreverLabel1.TabIndex = 9;
            this.foreverLabel1.Text = "Status:";
            // 
            // OilCheck
            // 
            this.OilCheck.BackColor = System.Drawing.Color.Transparent;
            this.OilCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OilCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.OilCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.OilCheck.Checked = false;
            this.OilCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OilCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OilCheck.Location = new System.Drawing.Point(152, 173);
            this.OilCheck.Name = "OilCheck";
            this.OilCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.OilCheck.Size = new System.Drawing.Size(76, 33);
            this.OilCheck.TabIndex = 18;
            this.OilCheck.Text = "foreverToggle1";
            this.OilCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.OilCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.OilCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.OilCheck_CheckedChanged);
            // 
            // CheckGameRunningLabel
            // 
            this.CheckGameRunningLabel.AutoSize = true;
            this.CheckGameRunningLabel.BackColor = System.Drawing.Color.Transparent;
            this.CheckGameRunningLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckGameRunningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CheckGameRunningLabel.Location = new System.Drawing.Point(60, 222);
            this.CheckGameRunningLabel.Name = "CheckGameRunningLabel";
            this.CheckGameRunningLabel.Size = new System.Drawing.Size(83, 20);
            this.CheckGameRunningLabel.TabIndex = 10;
            this.CheckGameRunningLabel.Text = "Searching...";
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel3.Location = new System.Drawing.Point(9, 139);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(138, 21);
            this.foreverLabel3.TabIndex = 17;
            this.foreverLabel3.Text = "Infinite Tinder Box:";
            // 
            // TinderBoxCheck
            // 
            this.TinderBoxCheck.BackColor = System.Drawing.Color.Transparent;
            this.TinderBoxCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TinderBoxCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.TinderBoxCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.TinderBoxCheck.Checked = false;
            this.TinderBoxCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TinderBoxCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TinderBoxCheck.Location = new System.Drawing.Point(152, 134);
            this.TinderBoxCheck.Name = "TinderBoxCheck";
            this.TinderBoxCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.TinderBoxCheck.Size = new System.Drawing.Size(76, 33);
            this.TinderBoxCheck.TabIndex = 16;
            this.TinderBoxCheck.Text = "foreverToggle1";
            this.TinderBoxCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TinderBoxCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.TinderBoxCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.TinderBoxCheck_CheckedChanged);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel4.Location = new System.Drawing.Point(9, 100);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(118, 21);
            this.foreverLabel4.TabIndex = 15;
            this.foreverLabel4.Text = "Infinite Lantern:";
            // 
            // LanternOilCheck
            // 
            this.LanternOilCheck.BackColor = System.Drawing.Color.Transparent;
            this.LanternOilCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LanternOilCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.LanternOilCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.LanternOilCheck.Checked = false;
            this.LanternOilCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LanternOilCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LanternOilCheck.Location = new System.Drawing.Point(152, 95);
            this.LanternOilCheck.Name = "LanternOilCheck";
            this.LanternOilCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.LanternOilCheck.Size = new System.Drawing.Size(76, 33);
            this.LanternOilCheck.TabIndex = 14;
            this.LanternOilCheck.Text = "foreverToggle1";
            this.LanternOilCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LanternOilCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.LanternOilCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.LanternOilCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Infinite Sanity:";
            // 
            // SanityCheck
            // 
            this.SanityCheck.BackColor = System.Drawing.Color.Transparent;
            this.SanityCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SanityCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.SanityCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.SanityCheck.Checked = false;
            this.SanityCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SanityCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SanityCheck.Location = new System.Drawing.Point(152, 56);
            this.SanityCheck.Name = "SanityCheck";
            this.SanityCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.SanityCheck.Size = new System.Drawing.Size(76, 33);
            this.SanityCheck.TabIndex = 12;
            this.SanityCheck.Text = "foreverToggle1";
            this.SanityCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SanityCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.SanityCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.SanityCheck_CheckedChanged);
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel2.Location = new System.Drawing.Point(9, 22);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(110, 21);
            this.foreverLabel2.TabIndex = 11;
            this.foreverLabel2.Text = "Infinite Health:";
            // 
            // HealthCheck
            // 
            this.HealthCheck.BackColor = System.Drawing.Color.Transparent;
            this.HealthCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HealthCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.HealthCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.HealthCheck.Checked = false;
            this.HealthCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HealthCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HealthCheck.Location = new System.Drawing.Point(152, 17);
            this.HealthCheck.Name = "HealthCheck";
            this.HealthCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.HealthCheck.Size = new System.Drawing.Size(76, 33);
            this.HealthCheck.TabIndex = 8;
            this.HealthCheck.Text = "foreverToggle1";
            this.HealthCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.HealthCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.HealthCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.HealthCheck_CheckedChanged);
            // 
            // MovementTab
            // 
            this.MovementTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.MovementTab.Controls.Add(this.Info2);
            this.MovementTab.Controls.Add(this.foreverLabel8);
            this.MovementTab.Controls.Add(this.JumpHeightCheck);
            this.MovementTab.Controls.Add(this.foreverLabel9);
            this.MovementTab.Controls.Add(this.CrouchSpeedCheck);
            this.MovementTab.Controls.Add(this.foreverLabel10);
            this.MovementTab.Controls.Add(this.RunSpeedCheck);
            this.MovementTab.Controls.Add(this.foreverLabel11);
            this.MovementTab.Controls.Add(this.WalkSpeedCheck);
            this.MovementTab.Controls.Add(this.separator2);
            this.MovementTab.Controls.Add(this.foreverLabel6);
            this.MovementTab.Controls.Add(this.CheckGameRunningLabel2);
            this.MovementTab.Location = new System.Drawing.Point(4, 44);
            this.MovementTab.Name = "MovementTab";
            this.MovementTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovementTab.Size = new System.Drawing.Size(245, 246);
            this.MovementTab.TabIndex = 1;
            this.MovementTab.Text = "Movement";
            // 
            // Info2
            // 
            this.Info2.BackColor = System.Drawing.Color.Transparent;
            this.Info2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.Info2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Info2.Location = new System.Drawing.Point(183, 223);
            this.Info2.Name = "Info2";
            this.Info2.Rounded = true;
            this.Info2.Size = new System.Drawing.Size(54, 18);
            this.Info2.TabIndex = 32;
            this.Info2.Text = "Info";
            this.Info2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Info2.Click += new System.EventHandler(this.Info2_Click);
            // 
            // foreverLabel8
            // 
            this.foreverLabel8.AutoSize = true;
            this.foreverLabel8.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel8.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel8.Location = new System.Drawing.Point(17, 151);
            this.foreverLabel8.Name = "foreverLabel8";
            this.foreverLabel8.Size = new System.Drawing.Size(123, 21);
            this.foreverLabel8.TabIndex = 31;
            this.foreverLabel8.Text = "Jump Height X2:";
            // 
            // JumpHeightCheck
            // 
            this.JumpHeightCheck.BackColor = System.Drawing.Color.Transparent;
            this.JumpHeightCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JumpHeightCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.JumpHeightCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.JumpHeightCheck.Checked = false;
            this.JumpHeightCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JumpHeightCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.JumpHeightCheck.Location = new System.Drawing.Point(152, 147);
            this.JumpHeightCheck.Name = "JumpHeightCheck";
            this.JumpHeightCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.JumpHeightCheck.Size = new System.Drawing.Size(76, 33);
            this.JumpHeightCheck.TabIndex = 30;
            this.JumpHeightCheck.Text = "foreverToggle1";
            this.JumpHeightCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.JumpHeightCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.JumpHeightCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.JumpHeightCheck_CheckedChanged);
            // 
            // foreverLabel9
            // 
            this.foreverLabel9.AutoSize = true;
            this.foreverLabel9.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel9.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel9.Location = new System.Drawing.Point(14, 111);
            this.foreverLabel9.Name = "foreverLabel9";
            this.foreverLabel9.Size = new System.Drawing.Size(132, 21);
            this.foreverLabel9.TabIndex = 29;
            this.foreverLabel9.Text = "Crouch Speed X2:";
            // 
            // CrouchSpeedCheck
            // 
            this.CrouchSpeedCheck.BackColor = System.Drawing.Color.Transparent;
            this.CrouchSpeedCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrouchSpeedCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.CrouchSpeedCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.CrouchSpeedCheck.Checked = false;
            this.CrouchSpeedCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrouchSpeedCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CrouchSpeedCheck.Location = new System.Drawing.Point(152, 108);
            this.CrouchSpeedCheck.Name = "CrouchSpeedCheck";
            this.CrouchSpeedCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.CrouchSpeedCheck.Size = new System.Drawing.Size(76, 33);
            this.CrouchSpeedCheck.TabIndex = 28;
            this.CrouchSpeedCheck.Text = "foreverToggle1";
            this.CrouchSpeedCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CrouchSpeedCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.CrouchSpeedCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.CrouchSpeedCheck_CheckedChanged);
            // 
            // foreverLabel10
            // 
            this.foreverLabel10.AutoSize = true;
            this.foreverLabel10.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel10.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel10.Location = new System.Drawing.Point(23, 73);
            this.foreverLabel10.Name = "foreverLabel10";
            this.foreverLabel10.Size = new System.Drawing.Size(110, 21);
            this.foreverLabel10.TabIndex = 27;
            this.foreverLabel10.Text = "Run Speed X2:";
            // 
            // RunSpeedCheck
            // 
            this.RunSpeedCheck.BackColor = System.Drawing.Color.Transparent;
            this.RunSpeedCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RunSpeedCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.RunSpeedCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.RunSpeedCheck.Checked = false;
            this.RunSpeedCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunSpeedCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RunSpeedCheck.Location = new System.Drawing.Point(152, 69);
            this.RunSpeedCheck.Name = "RunSpeedCheck";
            this.RunSpeedCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.RunSpeedCheck.Size = new System.Drawing.Size(76, 33);
            this.RunSpeedCheck.TabIndex = 26;
            this.RunSpeedCheck.Text = "foreverToggle1";
            this.RunSpeedCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.RunSpeedCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.RunSpeedCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.RunSpeedCheck_CheckedChanged);
            // 
            // foreverLabel11
            // 
            this.foreverLabel11.AutoSize = true;
            this.foreverLabel11.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel11.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel11.Location = new System.Drawing.Point(19, 35);
            this.foreverLabel11.Name = "foreverLabel11";
            this.foreverLabel11.Size = new System.Drawing.Size(116, 21);
            this.foreverLabel11.TabIndex = 25;
            this.foreverLabel11.Text = "Walk Speed X2:";
            // 
            // WalkSpeedCheck
            // 
            this.WalkSpeedCheck.BackColor = System.Drawing.Color.Transparent;
            this.WalkSpeedCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WalkSpeedCheck.BaseColorRed = System.Drawing.Color.DarkRed;
            this.WalkSpeedCheck.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.WalkSpeedCheck.Checked = false;
            this.WalkSpeedCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WalkSpeedCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WalkSpeedCheck.Location = new System.Drawing.Point(152, 30);
            this.WalkSpeedCheck.Name = "WalkSpeedCheck";
            this.WalkSpeedCheck.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.WalkSpeedCheck.Size = new System.Drawing.Size(76, 33);
            this.WalkSpeedCheck.TabIndex = 24;
            this.WalkSpeedCheck.Text = "foreverToggle1";
            this.WalkSpeedCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.WalkSpeedCheck.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.WalkSpeedCheck.CheckedChanged += new ReaLTaiizor.Controls.ForeverToggle.CheckedChangedEventHandler(this.WalkSpeedCheck_CheckedChanged);
            // 
            // separator2
            // 
            this.separator2.LineColor = System.Drawing.Color.Gray;
            this.separator2.Location = new System.Drawing.Point(7, 209);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(230, 10);
            this.separator2.TabIndex = 23;
            this.separator2.Text = "separator2";
            // 
            // foreverLabel6
            // 
            this.foreverLabel6.AutoSize = true;
            this.foreverLabel6.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel6.ForeColor = System.Drawing.Color.White;
            this.foreverLabel6.Location = new System.Drawing.Point(10, 222);
            this.foreverLabel6.Name = "foreverLabel6";
            this.foreverLabel6.Size = new System.Drawing.Size(52, 20);
            this.foreverLabel6.TabIndex = 21;
            this.foreverLabel6.Text = "Status:";
            // 
            // CheckGameRunningLabel2
            // 
            this.CheckGameRunningLabel2.AutoSize = true;
            this.CheckGameRunningLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CheckGameRunningLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckGameRunningLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CheckGameRunningLabel2.Location = new System.Drawing.Point(60, 222);
            this.CheckGameRunningLabel2.Name = "CheckGameRunningLabel2";
            this.CheckGameRunningLabel2.Size = new System.Drawing.Size(83, 20);
            this.CheckGameRunningLabel2.TabIndex = 22;
            this.CheckGameRunningLabel2.Text = "Searching...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 352);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2560, 1400);
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.foreverForm1.ResumeLayout(false);
            this.foreverTabPage1.ResumeLayout(false);
            this.PlayerTab.ResumeLayout(false);
            this.PlayerTab.PerformLayout();
            this.MovementTab.ResumeLayout(false);
            this.MovementTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CheckGameRunning;
        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverTabPage foreverTabPage1;
        private System.Windows.Forms.TabPage PlayerTab;
        private System.Windows.Forms.TabPage MovementTab;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverToggle LanternOilCheck;
        private ReaLTaiizor.Controls.ForeverLabel label2;
        private ReaLTaiizor.Controls.ForeverToggle SanityCheck;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel CheckGameRunningLabel;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverToggle HealthCheck;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverToggle TinderBoxCheck;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverToggle OilCheck;
        private ReaLTaiizor.Controls.Separator separator2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel6;
        private ReaLTaiizor.Controls.ForeverLabel CheckGameRunningLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel8;
        private ReaLTaiizor.Controls.ForeverToggle JumpHeightCheck;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel9;
        private ReaLTaiizor.Controls.ForeverToggle CrouchSpeedCheck;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel10;
        private ReaLTaiizor.Controls.ForeverToggle RunSpeedCheck;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel11;
        private ReaLTaiizor.Controls.ForeverToggle WalkSpeedCheck;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverButton Info1;
        private ReaLTaiizor.Controls.ForeverButton Info2;
    }
}

