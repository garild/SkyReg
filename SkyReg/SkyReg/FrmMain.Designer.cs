namespace SkyReg
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TabControl = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPageFlights = new System.Windows.Forms.TabPage();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.TabsIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageTandems = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageAirplanes = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1101, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TabControl
            // 
            this.TabControl.AllowCloseButton = false;
            this.TabControl.AllowContextButton = true;
            this.TabControl.AllowNavigatorButtons = false;
            this.TabControl.AllowSelectedTabHigh = false;
            this.TabControl.BorderWidth = 1;
            this.TabControl.Controls.Add(this.tabPageFlights);
            this.TabControl.Controls.Add(this.tabPageUsers);
            this.TabControl.Controls.Add(this.tabPageAirplanes);
            this.TabControl.Controls.Add(this.tabPageTandems);
            this.TabControl.Controls.Add(this.tabPageSettings);
            this.TabControl.CornerRoundRadiusWidth = 12;
            this.TabControl.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.TabControl.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.TabControl.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.HotTrack = true;
            this.TabControl.ImageList = this.TabsIconList;
            this.TabControl.ItemSize = new System.Drawing.Size(80, 30);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.PreserveTabColor = false;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1101, 446);
            this.TabControl.TabIndex = 2;
            this.TabControl.UseExtendedLayout = false;
            // 
            // tabPageFlights
            // 
            this.tabPageFlights.ImageIndex = 0;
            this.tabPageFlights.Location = new System.Drawing.Point(4, 34);
            this.tabPageFlights.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageFlights.Name = "tabPageFlights";
            this.tabPageFlights.Size = new System.Drawing.Size(1093, 408);
            this.tabPageFlights.TabIndex = 0;
            this.tabPageFlights.Tag = false;
            this.tabPageFlights.Text = "Wyloty";
            this.tabPageFlights.UseVisualStyleBackColor = true;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.ImageIndex = 4;
            this.tabPageUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPageUsers.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Size = new System.Drawing.Size(1093, 417);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Tag = false;
            this.tabPageUsers.Text = "Skoczkowie";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // TabsIconList
            // 
            this.TabsIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabsIconList.ImageStream")));
            this.TabsIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.TabsIconList.Images.SetKeyName(0, "airplane.png");
            this.TabsIconList.Images.SetKeyName(1, "settings.png");
            this.TabsIconList.Images.SetKeyName(2, "users_16.gif");
            this.TabsIconList.Images.SetKeyName(3, "parachute.png");
            this.TabsIconList.Images.SetKeyName(4, "user.png");
            // 
            // tabPageTandems
            // 
            this.tabPageTandems.ImageIndex = 2;
            this.tabPageTandems.Location = new System.Drawing.Point(4, 25);
            this.tabPageTandems.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageTandems.Name = "tabPageTandems";
            this.tabPageTandems.Size = new System.Drawing.Size(1093, 417);
            this.tabPageTandems.TabIndex = 2;
            this.tabPageTandems.Tag = false;
            this.tabPageTandems.Text = "Tandemy";
            this.tabPageTandems.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.ImageIndex = 1;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1093, 417);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Tag = false;
            this.tabPageSettings.Text = "Ustawienia";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageAirplanes
            // 
            this.tabPageAirplanes.ImageIndex = 0;
            this.tabPageAirplanes.Location = new System.Drawing.Point(4, 25);
            this.tabPageAirplanes.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageAirplanes.Name = "tabPageAirplanes";
            this.tabPageAirplanes.Size = new System.Drawing.Size(1093, 417);
            this.tabPageAirplanes.TabIndex = 4;
            this.tabPageAirplanes.Tag = false;
            this.tabPageAirplanes.Text = "Samoloty";
            this.tabPageAirplanes.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 468);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyReg";
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl TabControl;
        private System.Windows.Forms.TabPage tabPageFlights;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.ImageList TabsIconList;
        private System.Windows.Forms.TabPage tabPageTandems;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageAirplanes;
    }
}

