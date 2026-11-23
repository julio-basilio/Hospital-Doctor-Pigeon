using DSS_TORRE_161126;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosp_Proj_1611_
{
    
    public partial class frmMedico : Form

    {
        // Instanciando as classes

        ClsConexao Conexao = new ClsConexao(); 
        StringBuilder CmdSql = new StringBuilder();

        

        public frmMedico()
        {
            InitializeComponent();
            
        }

        private void txtCRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtCRM.Clear();
            txtNomeMed.Clear(); 
            txtCelularMed.Clear();
            txtEmailMed.Clear();
            dtpNascMed.Value = DateTime.Now;
        }

        private void btnIncluirMed_Click(object sender, EventArgs e)
        {
            try
            {
                CmdSql.Clear();
                CmdSql.Append("INSERT INTO Medico (crm_Med, nome_Med, espec_Med, fone_Med , email_Med, data_Med ) ");
                CmdSql.Append("VALUES (@crm_Med, @nome_Med, @espec_Med, @fone_Med, @email_Med, @data_Med)");

                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@crm_Med", txtCRM.Text);
                Conexao.Cmd.Parameters.AddWithValue("@nome_Med", txtNomeMed.Text);
                Conexao.Cmd.Parameters.AddWithValue("@espec_Med", cbbEspecialidade.Text);
                Conexao.Cmd.Parameters.AddWithValue("@fone_Med", txtCelularMed.Text);
                Conexao.Cmd.Parameters.AddWithValue("@email_Med", txtEmailMed.Text);
                Conexao.Cmd.Parameters.AddWithValue("@data_Med", dtpNascMed.Value.Date);

                Conexao.StrSql = CmdSql.ToString();

                int resultado = Conexao.ExecutarCmd();

                if (resultado > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void txtNomeMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }