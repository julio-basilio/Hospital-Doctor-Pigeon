namespace Hosp_Proj_1611_
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem1,
            this.pacienteToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.listagensToolStripMenuItem});
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.médicoToolStripMenuItem.Text = "Menu";
            this.médicoToolStripMenuItem.Click += new System.EventHandler(this.médicoToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.médicoToolStripMenuItem1.Text = "Médico";
            this.médicoToolStripMenuItem1.Click += new System.EventHandler(this.médicoToolStripMenuItem1_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.Click += new System.EventHandler(this.atendimentoToolStripMenuItem_Click);
            // 
            // listagensToolStripMenuItem
            // 
            this.listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            this.listagensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listagensToolStripMenuItem.Text = "Listagens";
            this.listagensToolStripMenuItem.Click += new System.EventHandler(this.listagensToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagensToolStripMenuItem;
    }
}

