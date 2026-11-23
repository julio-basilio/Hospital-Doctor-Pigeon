namespace Hosp_Proj_1611_
{
    partial class frmAtendimento
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
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtCPFPaciente = new System.Windows.Forms.TextBox();
            this.lblCPFmed = new System.Windows.Forms.Label();
            this.lblEspecialidadeMed = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCodAgend = new System.Windows.Forms.Label();
            this.txtCodAgend = new System.Windows.Forms.TextBox();
            this.dtpAgend = new System.Windows.Forms.DateTimePicker();
            this.lblDataAgend = new System.Windows.Forms.Label();
            this.dtpHoraAtend = new System.Windows.Forms.DateTimePicker();
            this.lblHoraAtend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusAtend = new System.Windows.Forms.TextBox();
            this.btnPesqGeralAtend = new System.Windows.Forms.Button();
            this.btnPesqIndivAtend = new System.Windows.Forms.Button();
            this.btnExcluirAtend = new System.Windows.Forms.Button();
            this.btnIncluirAtned = new System.Windows.Forms.Button();
            this.lblFormAgend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(80, 152);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(159, 20);
            this.txtCRM.TabIndex = 8;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(40, 155);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 7;
            this.lblCRM.Text = "CRM:";
            // 
            // txtCPFPaciente
            // 
            this.txtCPFPaciente.Location = new System.Drawing.Point(80, 196);
            this.txtCPFPaciente.Name = "txtCPFPaciente";
            this.txtCPFPaciente.Size = new System.Drawing.Size(159, 20);
            this.txtCPFPaciente.TabIndex = 25;
            // 
            // lblCPFmed
            // 
            this.lblCPFmed.AutoSize = true;
            this.lblCPFmed.Location = new System.Drawing.Point(44, 199);
            this.lblCPFmed.Name = "lblCPFmed";
            this.lblCPFmed.Size = new System.Drawing.Size(30, 13);
            this.lblCPFmed.TabIndex = 24;
            this.lblCPFmed.Text = "CPF:";
            // 
            // lblEspecialidadeMed
            // 
            this.lblEspecialidadeMed.AutoSize = true;
            this.lblEspecialidadeMed.Location = new System.Drawing.Point(260, 155);
            this.lblEspecialidadeMed.Name = "lblEspecialidadeMed";
            this.lblEspecialidadeMed.Size = new System.Drawing.Size(76, 13);
            this.lblEspecialidadeMed.TabIndex = 27;
            this.lblEspecialidadeMed.Text = "Especialidade:";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(260, 199);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(38, 13);
            this.lblNomePaciente.TabIndex = 26;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // lblCodAgend
            // 
            this.lblCodAgend.AutoSize = true;
            this.lblCodAgend.Location = new System.Drawing.Point(40, 95);
            this.lblCodAgend.Name = "lblCodAgend";
            this.lblCodAgend.Size = new System.Drawing.Size(127, 13);
            this.lblCodAgend.TabIndex = 28;
            this.lblCodAgend.Text = "Codigo de Agendamento:";
            // 
            // txtCodAgend
            // 
            this.txtCodAgend.Location = new System.Drawing.Point(173, 92);
            this.txtCodAgend.Name = "txtCodAgend";
            this.txtCodAgend.Size = new System.Drawing.Size(159, 20);
            this.txtCodAgend.TabIndex = 29;
            // 
            // dtpAgend
            // 
            this.dtpAgend.Location = new System.Drawing.Point(146, 293);
            this.dtpAgend.Name = "dtpAgend";
            this.dtpAgend.Size = new System.Drawing.Size(200, 20);
            this.dtpAgend.TabIndex = 31;
            // 
            // lblDataAgend
            // 
            this.lblDataAgend.AutoSize = true;
            this.lblDataAgend.Location = new System.Drawing.Point(23, 293);
            this.lblDataAgend.Name = "lblDataAgend";
            this.lblDataAgend.Size = new System.Drawing.Size(117, 13);
            this.lblDataAgend.TabIndex = 30;
            this.lblDataAgend.Text = "Data de Agendamento:";
            // 
            // dtpHoraAtend
            // 
            this.dtpHoraAtend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraAtend.Location = new System.Drawing.Point(428, 293);
            this.dtpHoraAtend.Name = "dtpHoraAtend";
            this.dtpHoraAtend.Size = new System.Drawing.Size(86, 20);
            this.dtpHoraAtend.TabIndex = 33;
            // 
            // lblHoraAtend
            // 
            this.lblHoraAtend.AutoSize = true;
            this.lblHoraAtend.Location = new System.Drawing.Point(378, 293);
            this.lblHoraAtend.Name = "lblHoraAtend";
            this.lblHoraAtend.Size = new System.Drawing.Size(44, 13);
            this.lblHoraAtend.TabIndex = 32;
            this.lblHoraAtend.Text = "Horário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Status:";
            // 
            // txtStatusAtend
            // 
            this.txtStatusAtend.Location = new System.Drawing.Point(80, 330);
            this.txtStatusAtend.Name = "txtStatusAtend";
            this.txtStatusAtend.Size = new System.Drawing.Size(111, 20);
            this.txtStatusAtend.TabIndex = 35;
            // 
            // btnPesqGeralAtend
            // 
            this.btnPesqGeralAtend.Location = new System.Drawing.Point(161, 428);
            this.btnPesqGeralAtend.Name = "btnPesqGeralAtend";
            this.btnPesqGeralAtend.Size = new System.Drawing.Size(85, 27);
            this.btnPesqGeralAtend.TabIndex = 39;
            this.btnPesqGeralAtend.Text = "Pesq. Geral";
            this.btnPesqGeralAtend.UseVisualStyleBackColor = true;
            // 
            // btnPesqIndivAtend
            // 
            this.btnPesqIndivAtend.Location = new System.Drawing.Point(80, 428);
            this.btnPesqIndivAtend.Name = "btnPesqIndivAtend";
            this.btnPesqIndivAtend.Size = new System.Drawing.Size(85, 27);
            this.btnPesqIndivAtend.TabIndex = 38;
            this.btnPesqIndivAtend.Text = "Alterar";
            this.btnPesqIndivAtend.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAtend
            // 
            this.btnExcluirAtend.Location = new System.Drawing.Point(161, 399);
            this.btnExcluirAtend.Name = "btnExcluirAtend";
            this.btnExcluirAtend.Size = new System.Drawing.Size(85, 27);
            this.btnExcluirAtend.TabIndex = 37;
            this.btnExcluirAtend.Text = "Excluir";
            this.btnExcluirAtend.UseVisualStyleBackColor = true;
            // 
            // btnIncluirAtned
            // 
            this.btnIncluirAtned.Location = new System.Drawing.Point(80, 399);
            this.btnIncluirAtned.Name = "btnIncluirAtned";
            this.btnIncluirAtned.Size = new System.Drawing.Size(85, 27);
            this.btnIncluirAtned.TabIndex = 36;
            this.btnIncluirAtned.Text = "Incluir";
            this.btnIncluirAtned.UseVisualStyleBackColor = true;
            // 
            // lblFormAgend
            // 
            this.lblFormAgend.AutoSize = true;
            this.lblFormAgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormAgend.Location = new System.Drawing.Point(294, 25);
            this.lblFormAgend.Name = "lblFormAgend";
            this.lblFormAgend.Size = new System.Drawing.Size(163, 29);
            this.lblFormAgend.TabIndex = 40;
            this.lblFormAgend.Text = "Agendamento";
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.lblFormAgend);
            this.Controls.Add(this.btnPesqGeralAtend);
            this.Controls.Add(this.btnPesqIndivAtend);
            this.Controls.Add(this.btnExcluirAtend);
            this.Controls.Add(this.btnIncluirAtned);
            this.Controls.Add(this.txtStatusAtend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraAtend);
            this.Controls.Add(this.lblHoraAtend);
            this.Controls.Add(this.dtpAgend);
            this.Controls.Add(this.lblDataAgend);
            this.Controls.Add(this.txtCodAgend);
            this.Controls.Add(this.lblCodAgend);
            this.Controls.Add(this.lblEspecialidadeMed);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtCPFPaciente);
            this.Controls.Add(this.lblCPFmed);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.lblCRM);
            this.Name = "frmAtendimento";
            this.Text = "frmAtendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtCPFPaciente;
        private System.Windows.Forms.Label lblCPFmed;
        private System.Windows.Forms.Label lblEspecialidadeMed;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCodAgend;
        private System.Windows.Forms.TextBox txtCodAgend;
        private System.Windows.Forms.DateTimePicker dtpAgend;
        private System.Windows.Forms.Label lblDataAgend;
        private System.Windows.Forms.DateTimePicker dtpHoraAtend;
        private System.Windows.Forms.Label lblHoraAtend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatusAtend;
        private System.Windows.Forms.Button btnPesqGeralAtend;
        private System.Windows.Forms.Button btnPesqIndivAtend;
        private System.Windows.Forms.Button btnExcluirAtend;
        private System.Windows.Forms.Button btnIncluirAtned;
        private System.Windows.Forms.Label lblFormAgend;
    }
}