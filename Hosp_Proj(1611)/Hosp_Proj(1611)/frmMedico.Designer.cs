namespace Hosp_Proj_1611_
{
    partial class frmMedico
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
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNomeMed = new System.Windows.Forms.Label();
            this.lblEspecialidadeMed = new System.Windows.Forms.Label();
            this.lblCelularMed = new System.Windows.Forms.Label();
            this.lblEmailMed = new System.Windows.Forms.Label();
            this.lblNascMed = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtCelularMed = new System.Windows.Forms.TextBox();
            this.txtEmailMed = new System.Windows.Forms.TextBox();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.dtpNascMed = new System.Windows.Forms.DateTimePicker();
            this.cbbEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnIncluirMed = new System.Windows.Forms.Button();
            this.btnExcluirMed = new System.Windows.Forms.Button();
            this.btnPesqGeralMed = new System.Windows.Forms.Button();
            this.btnAlterarMed = new System.Windows.Forms.Button();
            this.lblMedicoForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(117, 136);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 0;
            this.lblCRM.Text = "CRM:";
            // 
            // lblNomeMed
            // 
            this.lblNomeMed.AutoSize = true;
            this.lblNomeMed.Location = new System.Drawing.Point(308, 136);
            this.lblNomeMed.Name = "lblNomeMed";
            this.lblNomeMed.Size = new System.Drawing.Size(38, 13);
            this.lblNomeMed.TabIndex = 1;
            this.lblNomeMed.Text = "Nome:";
            // 
            // lblEspecialidadeMed
            // 
            this.lblEspecialidadeMed.AutoSize = true;
            this.lblEspecialidadeMed.Location = new System.Drawing.Point(75, 162);
            this.lblEspecialidadeMed.Name = "lblEspecialidadeMed";
            this.lblEspecialidadeMed.Size = new System.Drawing.Size(76, 13);
            this.lblEspecialidadeMed.TabIndex = 2;
            this.lblEspecialidadeMed.Text = "Especialidade:";
            // 
            // lblCelularMed
            // 
            this.lblCelularMed.AutoSize = true;
            this.lblCelularMed.Location = new System.Drawing.Point(109, 212);
            this.lblCelularMed.Name = "lblCelularMed";
            this.lblCelularMed.Size = new System.Drawing.Size(42, 13);
            this.lblCelularMed.TabIndex = 3;
            this.lblCelularMed.Text = "Celular:";
            // 
            // lblEmailMed
            // 
            this.lblEmailMed.AutoSize = true;
            this.lblEmailMed.Location = new System.Drawing.Point(113, 241);
            this.lblEmailMed.Name = "lblEmailMed";
            this.lblEmailMed.Size = new System.Drawing.Size(38, 13);
            this.lblEmailMed.TabIndex = 4;
            this.lblEmailMed.Text = "E-mail:";
            // 
            // lblNascMed
            // 
            this.lblNascMed.AutoSize = true;
            this.lblNascMed.Location = new System.Drawing.Point(44, 273);
            this.lblNascMed.Name = "lblNascMed";
            this.lblNascMed.Size = new System.Drawing.Size(107, 13);
            this.lblNascMed.TabIndex = 5;
            this.lblNascMed.Text = "Data de Nascimento:";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(157, 133);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(120, 20);
            this.txtCRM.TabIndex = 6;
            this.txtCRM.TextChanged += new System.EventHandler(this.txtCRM_TextChanged);
            // 
            // txtCelularMed
            // 
            this.txtCelularMed.Location = new System.Drawing.Point(157, 209);
            this.txtCelularMed.Name = "txtCelularMed";
            this.txtCelularMed.Size = new System.Drawing.Size(120, 20);
            this.txtCelularMed.TabIndex = 7;
            // 
            // txtEmailMed
            // 
            this.txtEmailMed.Location = new System.Drawing.Point(157, 238);
            this.txtEmailMed.Name = "txtEmailMed";
            this.txtEmailMed.Size = new System.Drawing.Size(199, 20);
            this.txtEmailMed.TabIndex = 8;
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Location = new System.Drawing.Point(352, 133);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMed.TabIndex = 9;
            this.txtNomeMed.TextChanged += new System.EventHandler(this.txtNomeMed_TextChanged);
            // 
            // dtpNascMed
            // 
            this.dtpNascMed.Location = new System.Drawing.Point(157, 273);
            this.dtpNascMed.Name = "dtpNascMed";
            this.dtpNascMed.Size = new System.Drawing.Size(200, 20);
            this.dtpNascMed.TabIndex = 10;
            // 
            // cbbEspecialidade
            // 
            this.cbbEspecialidade.FormattingEnabled = true;
            this.cbbEspecialidade.Location = new System.Drawing.Point(157, 159);
            this.cbbEspecialidade.Name = "cbbEspecialidade";
            this.cbbEspecialidade.Size = new System.Drawing.Size(121, 21);
            this.cbbEspecialidade.TabIndex = 11;
            this.cbbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cbbEspecialidade_SelectedIndexChanged);
            // 
            // btnIncluirMed
            // 
            this.btnIncluirMed.Location = new System.Drawing.Point(120, 339);
            this.btnIncluirMed.Name = "btnIncluirMed";
            this.btnIncluirMed.Size = new System.Drawing.Size(85, 27);
            this.btnIncluirMed.TabIndex = 12;
            this.btnIncluirMed.Text = "Incluir";
            this.btnIncluirMed.UseVisualStyleBackColor = true;
            this.btnIncluirMed.Click += new System.EventHandler(this.btnIncluirMed_Click);
            // 
            // btnExcluirMed
            // 
            this.btnExcluirMed.Location = new System.Drawing.Point(201, 339);
            this.btnExcluirMed.Name = "btnExcluirMed";
            this.btnExcluirMed.Size = new System.Drawing.Size(85, 27);
            this.btnExcluirMed.TabIndex = 13;
            this.btnExcluirMed.Text = "Excluir";
            this.btnExcluirMed.UseVisualStyleBackColor = true;
            // 
            // btnPesqGeralMed
            // 
            this.btnPesqGeralMed.Location = new System.Drawing.Point(201, 368);
            this.btnPesqGeralMed.Name = "btnPesqGeralMed";
            this.btnPesqGeralMed.Size = new System.Drawing.Size(85, 27);
            this.btnPesqGeralMed.TabIndex = 15;
            this.btnPesqGeralMed.Text = "Pesq. Geral";
            this.btnPesqGeralMed.UseVisualStyleBackColor = true;
            // 
            // btnAlterarMed
            // 
            this.btnAlterarMed.Location = new System.Drawing.Point(120, 368);
            this.btnAlterarMed.Name = "btnAlterarMed";
            this.btnAlterarMed.Size = new System.Drawing.Size(85, 27);
            this.btnAlterarMed.TabIndex = 14;
            this.btnAlterarMed.Text = "Alterar";
            this.btnAlterarMed.UseVisualStyleBackColor = true;
            // 
            // lblMedicoForm
            // 
            this.lblMedicoForm.AutoSize = true;
            this.lblMedicoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicoForm.Location = new System.Drawing.Point(307, 39);
            this.lblMedicoForm.Name = "lblMedicoForm";
            this.lblMedicoForm.Size = new System.Drawing.Size(93, 29);
            this.lblMedicoForm.TabIndex = 16;
            this.lblMedicoForm.Text = "Médico";
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.lblMedicoForm);
            this.Controls.Add(this.btnPesqGeralMed);
            this.Controls.Add(this.btnAlterarMed);
            this.Controls.Add(this.btnExcluirMed);
            this.Controls.Add(this.btnIncluirMed);
            this.Controls.Add(this.cbbEspecialidade);
            this.Controls.Add(this.dtpNascMed);
            this.Controls.Add(this.txtNomeMed);
            this.Controls.Add(this.txtEmailMed);
            this.Controls.Add(this.txtCelularMed);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.lblNascMed);
            this.Controls.Add(this.lblEmailMed);
            this.Controls.Add(this.lblCelularMed);
            this.Controls.Add(this.lblEspecialidadeMed);
            this.Controls.Add(this.lblNomeMed);
            this.Controls.Add(this.lblCRM);
            this.Name = "frmMedico";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNomeMed;
        private System.Windows.Forms.Label lblEspecialidadeMed;
        private System.Windows.Forms.Label lblCelularMed;
        private System.Windows.Forms.Label lblEmailMed;
        private System.Windows.Forms.Label lblNascMed;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtCelularMed;
        private System.Windows.Forms.TextBox txtEmailMed;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.DateTimePicker dtpNascMed;
        private System.Windows.Forms.ComboBox cbbEspecialidade;
        private System.Windows.Forms.Button btnIncluirMed;
        private System.Windows.Forms.Button btnExcluirMed;
        private System.Windows.Forms.Button btnPesqGeralMed;
        private System.Windows.Forms.Button btnAlterarMed;
        private System.Windows.Forms.Label lblMedicoForm;
    }
}