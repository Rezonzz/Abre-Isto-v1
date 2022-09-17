namespace Abre_Isto
{
    partial class frm_abreisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_abreisto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nao = new System.Windows.Forms.Button();
            this.btn_sim = new System.Windows.Forms.Button();
            this.pic_heart = new System.Windows.Forms.PictureBox();
            this.lbl_amote = new System.Windows.Forms.Label();
            this.lbl_frase = new System.Windows.Forms.Label();
            this.pic_demonslayer = new System.Windows.Forms.PictureBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_demonslayer)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_nao);
            this.panel1.Controls.Add(this.btn_sim);
            this.panel1.Controls.Add(this.pic_heart);
            this.panel1.Controls.Add(this.lbl_amote);
            this.panel1.Controls.Add(this.lbl_frase);
            this.panel1.Controls.Add(this.pic_demonslayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 474);
            this.panel1.TabIndex = 1;
            // 
            // btn_nao
            // 
            this.btn_nao.BackColor = System.Drawing.Color.Thistle;
            this.btn_nao.FlatAppearance.BorderSize = 0;
            this.btn_nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nao.ForeColor = System.Drawing.Color.White;
            this.btn_nao.Location = new System.Drawing.Point(210, 115);
            this.btn_nao.Name = "btn_nao";
            this.btn_nao.Size = new System.Drawing.Size(109, 34);
            this.btn_nao.TabIndex = 2;
            this.btn_nao.Text = "Não";
            this.btn_nao.UseVisualStyleBackColor = false;
            this.btn_nao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_nao_MouseMove);
            // 
            // btn_sim
            // 
            this.btn_sim.BackColor = System.Drawing.Color.Thistle;
            this.btn_sim.FlatAppearance.BorderSize = 0;
            this.btn_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sim.ForeColor = System.Drawing.Color.White;
            this.btn_sim.Location = new System.Drawing.Point(58, 115);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(109, 34);
            this.btn_sim.TabIndex = 1;
            this.btn_sim.Text = "Sim";
            this.btn_sim.UseVisualStyleBackColor = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // pic_heart
            // 
            this.pic_heart.Image = global::Abre_Isto.Properties.Resources.heart__2_;
            this.pic_heart.Location = new System.Drawing.Point(189, 122);
            this.pic_heart.Name = "pic_heart";
            this.pic_heart.Size = new System.Drawing.Size(26, 27);
            this.pic_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_heart.TabIndex = 4;
            this.pic_heart.TabStop = false;
            this.pic_heart.Visible = false;
            // 
            // lbl_amote
            // 
            this.lbl_amote.AutoSize = true;
            this.lbl_amote.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amote.Location = new System.Drawing.Point(146, 126);
            this.lbl_amote.Name = "lbl_amote";
            this.lbl_amote.Size = new System.Drawing.Size(49, 18);
            this.lbl_amote.TabIndex = 5;
            this.lbl_amote.Text = "Amo te";
            this.lbl_amote.Visible = false;
            // 
            // lbl_frase
            // 
            this.lbl_frase.AutoSize = true;
            this.lbl_frase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_frase.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frase.Location = new System.Drawing.Point(65, 59);
            this.lbl_frase.Name = "lbl_frase";
            this.lbl_frase.Size = new System.Drawing.Size(253, 29);
            this.lbl_frase.TabIndex = 0;
            this.lbl_frase.Text = "Queres namorar comigo?";
            // 
            // pic_demonslayer
            // 
            this.pic_demonslayer.BackColor = System.Drawing.Color.Transparent;
            this.pic_demonslayer.Image = global::Abre_Isto.Properties.Resources.transferir_removebg_preview;
            this.pic_demonslayer.Location = new System.Drawing.Point(82, 91);
            this.pic_demonslayer.Name = "pic_demonslayer";
            this.pic_demonslayer.Size = new System.Drawing.Size(208, 315);
            this.pic_demonslayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_demonslayer.TabIndex = 3;
            this.pic_demonslayer.TabStop = false;
            this.pic_demonslayer.Visible = false;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Thistle;
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_top.Location = new System.Drawing.Point(0, -72);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(382, 100);
            this.pnl_top.TabIndex = 2;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::Abre_Isto.Properties.Resources.minimize_sign__1___1_;
            this.btn_minimize.Location = new System.Drawing.Point(324, 72);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(28, 28);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Abre_Isto.Properties.Resources.close__1___1___1_;
            this.btn_close.Location = new System.Drawing.Point(352, 72);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 28);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "<3";
            // 
            // frm_abreisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 502);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_abreisto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abre Isto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_demonslayer)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nao;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.PictureBox pic_heart;
        private System.Windows.Forms.Label lbl_amote;
        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.PictureBox pic_demonslayer;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
    }
}

