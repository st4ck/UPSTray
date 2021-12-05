
namespace UPSTray
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chargingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeRemainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerToolStripMenuItem,
            this.timeRemainingToolStripMenuItem,
            this.voltageToolStripMenuItem,
            this.chargingToolStripMenuItem,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 124);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // chargingToolStripMenuItem
            // 
            this.chargingToolStripMenuItem.Name = "chargingToolStripMenuItem";
            this.chargingToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.chargingToolStripMenuItem.Text = "Charging";
            // 
            // voltageToolStripMenuItem
            // 
            this.voltageToolStripMenuItem.Name = "voltageToolStripMenuItem";
            this.voltageToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.voltageToolStripMenuItem.Text = "Voltage";
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.powerToolStripMenuItem.Text = "Power";
            // 
            // timeRemainingToolStripMenuItem
            // 
            this.timeRemainingToolStripMenuItem.Name = "timeRemainingToolStripMenuItem";
            this.timeRemainingToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.timeRemainingToolStripMenuItem.Text = "Time remaining: -";
            this.timeRemainingToolStripMenuItem.Click += new System.EventHandler(this.timeRemainingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 24);
            this.toolStripMenuItem3.Text = "100%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chargingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeRemainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Timer timer1;
    }
}

