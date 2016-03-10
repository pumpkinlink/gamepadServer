namespace PadServer
{
    partial class FormMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_panelbtn = new System.Windows.Forms.Panel();
            this.m_btna = new System.Windows.Forms.TextBox();
            this.m_btnx = new System.Windows.Forms.TextBox();
            this.m_btnb = new System.Windows.Forms.TextBox();
            this.m_btny = new System.Windows.Forms.TextBox();
            this.m_panelspc = new System.Windows.Forms.Panel();
            this.m_btnselect = new System.Windows.Forms.TextBox();
            this.m_btnstart = new System.Windows.Forms.TextBox();
            this.m_paneldiag = new System.Windows.Forms.Panel();
            this.m_diagright = new System.Windows.Forms.TextBox();
            this.m_diagup = new System.Windows.Forms.TextBox();
            this.m_diagdown = new System.Windows.Forms.TextBox();
            this.m_diagleft = new System.Windows.Forms.TextBox();
            this.m_btnexit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.m_panelbtn.SuspendLayout();
            this.m_panelspc.SuspendLayout();
            this.m_paneldiag.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.Control;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(71, 17);
            this.statusText.Text = "Inicialização";
            // 
            // m_panelbtn
            // 
            this.m_panelbtn.BackgroundImage = global::PadServer.Properties.Resources.buttons;
            this.m_panelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_panelbtn.Controls.Add(this.m_btna);
            this.m_panelbtn.Controls.Add(this.m_btnx);
            this.m_panelbtn.Controls.Add(this.m_btnb);
            this.m_panelbtn.Controls.Add(this.m_btny);
            this.m_panelbtn.Location = new System.Drawing.Point(432, 18);
            this.m_panelbtn.Name = "m_panelbtn";
            this.m_panelbtn.Size = new System.Drawing.Size(200, 200);
            this.m_panelbtn.TabIndex = 12;
            // 
            // m_btna
            // 
            this.m_btna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_btna.Location = new System.Drawing.Point(103, 90);
            this.m_btna.MaxLength = 6;
            this.m_btna.Name = "m_btna";
            this.m_btna.ReadOnly = true;
            this.m_btna.Size = new System.Drawing.Size(55, 20);
            this.m_btna.TabIndex = 3;
            this.m_btna.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_btnx
            // 
            this.m_btnx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_btnx.Location = new System.Drawing.Point(74, 63);
            this.m_btnx.MaxLength = 6;
            this.m_btnx.Name = "m_btnx";
            this.m_btnx.ReadOnly = true;
            this.m_btnx.Size = new System.Drawing.Size(55, 20);
            this.m_btnx.TabIndex = 1;
            this.m_btnx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_btnb
            // 
            this.m_btnb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_btnb.Location = new System.Drawing.Point(74, 116);
            this.m_btnb.MaxLength = 6;
            this.m_btnb.Name = "m_btnb";
            this.m_btnb.ReadOnly = true;
            this.m_btnb.Size = new System.Drawing.Size(55, 20);
            this.m_btnb.TabIndex = 4;
            this.m_btnb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_btny
            // 
            this.m_btny.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_btny.Location = new System.Drawing.Point(42, 90);
            this.m_btny.MaxLength = 6;
            this.m_btny.Name = "m_btny";
            this.m_btny.ReadOnly = true;
            this.m_btny.Size = new System.Drawing.Size(55, 20);
            this.m_btny.TabIndex = 2;
            this.m_btny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_panelspc
            // 
            this.m_panelspc.BackgroundImage = global::PadServer.Properties.Resources.select_start_buttons;
            this.m_panelspc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_panelspc.Controls.Add(this.m_btnselect);
            this.m_panelspc.Controls.Add(this.m_btnstart);
            this.m_panelspc.Location = new System.Drawing.Point(241, 90);
            this.m_panelspc.Name = "m_panelspc";
            this.m_panelspc.Size = new System.Drawing.Size(160, 64);
            this.m_panelspc.TabIndex = 11;
            // 
            // m_btnselect
            // 
            this.m_btnselect.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_btnselect.Location = new System.Drawing.Point(15, 18);
            this.m_btnselect.MaxLength = 6;
            this.m_btnselect.Name = "m_btnselect";
            this.m_btnselect.ReadOnly = true;
            this.m_btnselect.Size = new System.Drawing.Size(55, 20);
            this.m_btnselect.TabIndex = 5;
            this.m_btnselect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_btnstart
            // 
            this.m_btnstart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_btnstart.Location = new System.Drawing.Point(76, 18);
            this.m_btnstart.MaxLength = 6;
            this.m_btnstart.Name = "m_btnstart";
            this.m_btnstart.ReadOnly = true;
            this.m_btnstart.Size = new System.Drawing.Size(55, 20);
            this.m_btnstart.TabIndex = 6;
            this.m_btnstart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_paneldiag
            // 
            this.m_paneldiag.BackgroundImage = global::PadServer.Properties.Resources.dpad;
            this.m_paneldiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_paneldiag.Controls.Add(this.m_diagright);
            this.m_paneldiag.Controls.Add(this.m_diagup);
            this.m_paneldiag.Controls.Add(this.m_diagdown);
            this.m_paneldiag.Controls.Add(this.m_diagleft);
            this.m_paneldiag.Location = new System.Drawing.Point(12, 18);
            this.m_paneldiag.Name = "m_paneldiag";
            this.m_paneldiag.Size = new System.Drawing.Size(200, 200);
            this.m_paneldiag.TabIndex = 10;
            // 
            // m_diagright
            // 
            this.m_diagright.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_diagright.Location = new System.Drawing.Point(103, 90);
            this.m_diagright.MaxLength = 6;
            this.m_diagright.Name = "m_diagright";
            this.m_diagright.ReadOnly = true;
            this.m_diagright.Size = new System.Drawing.Size(55, 20);
            this.m_diagright.TabIndex = 3;
            this.m_diagright.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_diagup
            // 
            this.m_diagup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_diagup.Location = new System.Drawing.Point(74, 63);
            this.m_diagup.MaxLength = 6;
            this.m_diagup.Name = "m_diagup";
            this.m_diagup.ReadOnly = true;
            this.m_diagup.Size = new System.Drawing.Size(55, 20);
            this.m_diagup.TabIndex = 1;
            this.m_diagup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_diagdown
            // 
            this.m_diagdown.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_diagdown.Location = new System.Drawing.Point(74, 116);
            this.m_diagdown.MaxLength = 6;
            this.m_diagdown.Name = "m_diagdown";
            this.m_diagdown.ReadOnly = true;
            this.m_diagdown.Size = new System.Drawing.Size(55, 20);
            this.m_diagdown.TabIndex = 4;
            this.m_diagdown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_diagleft
            // 
            this.m_diagleft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_diagleft.Location = new System.Drawing.Point(42, 90);
            this.m_diagleft.MaxLength = 6;
            this.m_diagleft.Name = "m_diagleft";
            this.m_diagleft.ReadOnly = true;
            this.m_diagleft.Size = new System.Drawing.Size(55, 20);
            this.m_diagleft.TabIndex = 2;
            this.m_diagleft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagKeyDown);
            // 
            // m_btnexit
            // 
            this.m_btnexit.Location = new System.Drawing.Point(285, 195);
            this.m_btnexit.Name = "m_btnexit";
            this.m_btnexit.Size = new System.Drawing.Size(75, 23);
            this.m_btnexit.TabIndex = 13;
            this.m_btnexit.Text = "Sair";
            this.m_btnexit.UseVisualStyleBackColor = true;
            this.m_btnexit.Click += new System.EventHandler(this.m_btnexit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(285, 166);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(648, 259);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.m_btnexit);
            this.Controls.Add(this.m_panelbtn);
            this.Controls.Add(this.m_panelspc);
            this.Controls.Add(this.m_paneldiag);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Gamepad Server";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.m_panelbtn.ResumeLayout(false);
            this.m_panelbtn.PerformLayout();
            this.m_panelspc.ResumeLayout(false);
            this.m_panelspc.PerformLayout();
            this.m_paneldiag.ResumeLayout(false);
            this.m_paneldiag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox m_diagup;
        private System.Windows.Forms.TextBox m_diagleft;
        private System.Windows.Forms.TextBox m_diagright;
        private System.Windows.Forms.TextBox m_diagdown;
        private System.Windows.Forms.TextBox m_btnselect;
        private System.Windows.Forms.TextBox m_btnstart;
        private System.Windows.Forms.Panel m_paneldiag;
        private System.Windows.Forms.Panel m_panelspc;
        private System.Windows.Forms.Panel m_panelbtn;
        private System.Windows.Forms.TextBox m_btna;
        private System.Windows.Forms.TextBox m_btnx;
        private System.Windows.Forms.TextBox m_btnb;
        private System.Windows.Forms.TextBox m_btny;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.Button m_btnexit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
    }
}

