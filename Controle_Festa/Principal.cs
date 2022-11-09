using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Festa
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btm_Verificar_Click(object sender, EventArgs e)
        {
            //verificar se ainda possuem esse fone
            try
            {
                if (txb_data.Text == "" || txb_nome.Text == "" || txb_sobrenome.Text == "")
                {
                    MessageBox.Show("Você não pode deixar valores em branco!");
                    
                }
                else
                {
                    if (Regex.IsMatch(txb_nome.Text, @"\d"))
                    {
                        MessageBox.Show("Você não pode colocar números!");
                    }
                    
                    else {
                        DateTime d;
                        d = Convert.ToDateTime(txb_data.Text);
                        int dt = DateTime.Now.Year - d.Year;

                        if (dt >= 18)
                        {
                            lbl_resultado.Text = "Olá " + txb_nome.Text + " " + txb_sobrenome.Text + " você tem " + dt + " anos!";
                            lbl_resultado.ForeColor = Color.Green;
                            // mudar imagem para happy
                            pib_Headphones.Image = Properties.Resources.Happy;
                            lbl_Cadsuc.Text = "Usuário cadastrado com sucesso!!!";
                            lbl_Cadsuc.ForeColor = Color.Green;


                        }
                        else
                        {

                            lbl_resultado.Text = ("Você não é maior de idade jovemzinho!");
                            lbl_resultado.ForeColor = Color.Red;
                            pib_Headphones.Image = Properties.Resources.sad;
                            lbl_Cadsuc.Text = "Usuário não cadastrado!!!";
                            lbl_Cadsuc.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Você não pode colocar letras na data!!");
            }

        }

        private void btm_Limpar_Click(object sender, EventArgs e)
        {
            //Limpar a pib_Headphones
            pib_Headphones.Image = null;
            lbl_Cadsuc.Text = null;
            lbl_resultado.Text = null;
        }
        private void btm_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
