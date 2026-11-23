namespace Hosp_Proj_1611_
{
    partial class frmPaciente
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
            this.btnPesqGeralPaciente = new System.Windows.Forms.Button();
            this.btnAlterarPaciente = new System.Windows.Forms.Button();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.btnIncluirPaciente = new System.Windows.Forms.Button();
            this.lblCPFPaciente = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtCPFpaciente = new System.Windows.Forms.TextBox();
            this.lblNascMed = new System.Windows.Forms.Label();
            this.dtpNascPaciente = new System.Windows.Forms.DateTimePicker();
            this.gpbGeneroPaciente = new System.Windows.Forms.GroupBox();
            this.rdbFemPaciente = new System.Windows.Forms.RadioButton();
            this.rdbMascPaciente = new System.Windows.Forms.RadioButton();
            this.lblMedicoForm = new System.Windows.Forms.Label();
            this.gpbGeneroPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesqGeralPaciente
            // 
            this.btnPesqGeralPaciente.Location = new System.Drawing.Point(191, 378);
            this.btnPesqGeralPaciente.Name = "btnPesqGeralPaciente";
            this.btnPesqGeralPaciente.Size = new System.Drawing.Size(85, 27);
            this.btnPesqGeralPaciente.TabIndex = 19;
            this.btnPesqGeralPaciente.Text = "Pesq. Geral";
            this.btnPesqGeralPaciente.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPaciente
            // 
            this.btnAlterarPaciente.Location = new System.Drawing.Point(110, 378);
            this.btnAlterarPaciente.Name = "btnAlterarPaciente";
            this.btnAlterarPaciente.Size = new System.Drawing.Size(85, 27);
            this.btnAlterarPaciente.TabIndex = 18;
            this.btnAlterarPaciente.Text = "Alterar";
            this.btnAlterarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Location = new System.Drawing.Point(191, 349);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(85, 27);
            this.btnExcluirPaciente.TabIndex = 17;
            this.btnExcluirPaciente.Text = "Excluir";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            // 
            // btnIncluirPaciente
            // 
            this.btnIncluirPaciente.Location = new System.Drawing.Point(110, 349);
            this.btnIncluirPaciente.Name = "btnIncluirPaciente";
            this.btnIncluirPaciente.Size = new System.Drawing.Size(85, 27);
            this.btnIncluirPaciente.TabIndex = 16;
            this.btnIncluirPaciente.Text = "Incluir";
            this.btnIncluirPaciente.UseVisualStyleBackColor = true;
            // 
            // lblCPFPaciente
            // 
            this.lblCPFPaciente.AutoSize = true;
            this.lblCPFPaciente.Location = new System.Drawing.Point(343, 114);
            this.lblCPFPaciente.Name = "lblCPFPaciente";
            this.lblCPFPaciente.Size = new System.Drawing.Size(30, 13);
            this.lblCPFPaciente.TabIndex = 20;
            this.lblCPFPaciente.Text = "CPF:";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(85, 111);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(38, 13);
            this.lblNomePaciente.TabIndex = 21;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(129, 111);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(200, 20);
            this.txtNomePaciente.TabIndex = 22;
            // 
            // txtCPFpaciente
            // 
            this.txtCPFpaciente.Location = new System.Drawing.Point(379, 111);
            this.txtCPFpaciente.Name = "txtCPFpaciente";
            this.txtCPFpaciente.Size = new System.Drawing.Size(159, 20);
            this.txtCPFpaciente.TabIndex = 23;
            // 
            // lblNascMed
            // 
            this.lblNascMed.AutoSize = true;
            this.lblNascMed.Location = new System.Drawing.Point(16, 166);
            this.lblNascMed.Name = "lblNascMed";
            this.lblNascMed.Size = new System.Drawing.Size(107, 13);
            this.lblNascMed.TabIndex = 24;
            this.lblNascMed.Text = "Data de Nascimento:";
            // 
            // dtpNascPaciente
            // 
            this.dtpNascPaciente.Location = new System.Drawing.Point(129, 160);
            this.dtpNascPaciente.Name = "dtpNascPaciente";
            this.dtpNascPaciente.Size = new System.Drawing.Size(200, 20);
            this.dtpNascPaciente.TabIndex = 25;
            // 
            // gpbGeneroPaciente
            // 
            this.gpbGeneroPaciente.Controls.Add(this.rdbMascPaciente);
            this.gpbGeneroPaciente.Controls.Add(this.rdbFemPaciente);
            this.gpbGeneroPaciente.Location = new System.Drawing.Point(88, 224);
            this.gpbGeneroPaciente.Name = "gpbGeneroPaciente";
            this.gpbGeneroPaciente.Size = new System.Drawing.Size(241, 100);
            this.gpbGeneroPaciente.TabIndex = 26;
            this.gpbGeneroPaciente.TabStop = false;
            this.gpbGeneroPaciente.Text = "Gênero:";
            // 
            // rdbFemPaciente
            // 
            this.rdbFemPaciente.AutoSize = true;
            this.rdbFemPaciente.Location = new System.Drawing.Point(19, 43);
            this.rdbFemPaciente.Name = "rdbFemPaciente";
            this.rdbFemPaciente.Size = new System.Drawing.Size(67, 17);
            this.rdbFemPaciente.TabIndex = 0;
            this.rdbFemPaciente.TabStop = true;
            this.rdbFemPaciente.Text = "Feminino";
            this.rdbFemPaciente.UseVisualStyleBackColor = true;
            // 
            // rdbMascPaciente
            // 
            this.rdbMascPaciente.AutoSize = true;
            this.rdbMascPaciente.Location = new System.Drawing.Point(135, 43);
            this.rdbMascPaciente.Name = "rdbMascPaciente";
            this.rdbMascPaciente.Size = new System.Drawing.Size(73, 17);
            this.rdbMascPaciente.TabIndex = 1;
            this.rdbMascPaciente.TabStop = true;
            this.rdbMascPaciente.Text = "Masculino";
            this.rdbMascPaciente.UseVisualStyleBackColor = true;
            // 
            // lblMedicoForm
            // 
            this.lblMedicoForm.AutoSize = true;
            this.lblMedicoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicoForm.Location = new System.Drawing.Point(281, 32);
            this.lblMedicoForm.Name = "lblMedicoForm";
            this.lblMedicoForm.Size = new System.Drawing.Size(107, 29);
            this.lblMedicoForm.TabIndex = 27;
            this.lblMedicoForm.Text = "Paciente";
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedicoForm);
            this.Controls.Add(this.gpbGeneroPaciente);
            this.Controls.Add(this.dtpNascPaciente);
            this.Controls.Add(this.lblNascMed);
            this.Controls.Add(this.txtCPFpaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.lblCPFPaciente);
            this.Controls.Add(this.btnPesqGeralPaciente);
            this.Controls.Add(this.btnAlterarPaciente);
            this.Controls.Add(this.btnExcluirPaciente);
            this.Controls.Add(this.btnIncluirPaciente);
            this.Name = "frmPaciente";
            this.Text = "frmPaciente";
            this.gpbGeneroPaciente.ResumeLayout(false);
            this.gpbGeneroPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesqGeralPaciente;
        private System.Windows.Forms.Button btnAlterarPaciente;
        private System.Windows.Forms.Button btnExcluirPaciente;
        private System.Windows.Forms.Button btnIncluirPaciente;
        private System.Windows.Forms.Label lblCPFPaciente;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtCPFpaciente;
        private System.Windows.Forms.Label lblNascMed;
        private System.Windows.Forms.DateTimePicker dtpNascPaciente;
        private System.Windows.Forms.GroupBox gpbGeneroPaciente;
        private System.Windows.Forms.RadioButton rdbMascPaciente;
        private System.Windows.Forms.RadioButton rdbFemPaciente;
        private System.Windows.Forms.Label lblMedicoForm;
    }
}