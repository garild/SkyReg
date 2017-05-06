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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.TabsIconList = new System.Windows.Forms.ImageList(this.components);
            this.StyleManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 446);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(1216, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
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
            // StyleManager
            // 
            this.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 468);
            this.Controls.Add(this.statusStrip);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyReg";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ImageList TabsIconList;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager StyleManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}

