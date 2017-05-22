﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AcademySolution
{
    public partial class frmBuscarAluno : MetroFramework.Forms.MetroForm
    {

        Instance instance = new Instance();

        public frmBuscarAluno()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT * FROM v_aluno WHERE Codigo = "+txbParametro.Text+"";

                instance.NovaConexao();
                
                //instance.NovoComando(query).Parameters.Add("@Codigo", SqlDbType.Int).Value = Convert.ToInt32(txbParametro.Text);

                //if (instance.LerDados(query).HasRows == false)
                //{
                //    MetroFramework.MetroMessageBox.Show(this,"Código do aluno não foi encontrado!");
                //}
                SqlDataReader leituras = instance.NovoComando(query).ExecuteReader();

                leituras.Read();

                txbNome.Text = Convert.ToString(leituras["Nome"]);
                txbNascimento.Text = Convert.ToString(leituras["DataDeNascimento"]);
                txbCpf.Text = Convert.ToString(leituras["Cpf"]);
                txbEmail.Text = Convert.ToString(leituras["Email"]);
                txbEstado.Text = Convert.ToString(leituras["Estado"]);
                txbTelefone.Text = Convert.ToString(leituras["Telefone"]);
                txbRua.Text = Convert.ToString(leituras["Rua"]);
                txbNumero.Text = Convert.ToString(leituras["Numero"]);
                txbComplemento.Text = Convert.ToString(leituras["Complemento"]);
                txbCidade.Text = Convert.ToString(leituras["Cidade"]);
                txbBairro.Text = Convert.ToString(leituras["Bairro"]);
                txbPais.Text = Convert.ToString(leituras["Pais"]);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message,"Erro",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            finally
            {
                instance.FechaConexao();
            }
        }
    }
}
