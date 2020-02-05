using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is Form1)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }*///ASSIM OU
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ALTERAR COM O RESPECTIVO DIRETORIO LOCAL 
            string ba = @"C:\Users\mathe\OneDrive\Área de Trabalho\Gourmet\Fotos Gourmet\básico.png";
            string me = @"C:\Users\mathe\OneDrive\Área de Trabalho\Gourmet\Fotos GourmetFotos Gourmet /médio.png";
            string av = @"C:\Users\mathe\OneDrive\Área de Trabalho\Gourmet\Fotos Gourmet/avançado.png";

            float bvalor = 1000;//aqui sao os valores do curso conforme a habilidade do usuário
            float mvalor = 2000;
            float avalor = 5000;
            float valordesconto;
            float valorcomdesconto;


            //CASO PAGAMENTO SEJA EM DINHEIRO, HAVERÁ DESCONTO

            if (dinheiroradio.Checked)
            {
                if (basicoradio.Checked)
                {
                    valordesconto = (bvalor * 20) / 100;
                    valorcomdesconto = (bvalor - valordesconto);
                    valorexibir.Text = bvalor.ToString();
                    totalexibir.Text = valorcomdesconto.ToString();
                    pictureBox1.Load(ba);

                    if (nomebox.TextLength < 9)
                    {
                        MessageBox.Show("Preencha seu nome completo", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        nomeexibir.Text = nomebox.Text.ToString();
                    }
                    if (cpfbox.TextLength == 11)
                    {
                        cpfexibir.Text = cpfbox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Preencha seu CPF completo com apenas números", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if(idadebox.TextLength == 2)
                    {
                        idadeexibir.Text = idadebox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Informe sua idade", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (telefonebox.TextLength == 11)

                    {
                        telefoneexibir.Text = telefonebox.Text.ToString();
                        MessageBox.Show("Seu Cadastro foi realizado com Sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Preencha seu telefone completo com DDD sem hífen e parênteses", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                }

                else if (medioradio.Checked)
                {
                    valordesconto = (mvalor * 20) / 100;
                    valorcomdesconto = (mvalor - valordesconto);
                    valorexibir.Text = mvalor.ToString();
                    totalexibir.Text = valorcomdesconto.ToString();
                    pictureBox1.Load(me);

                    if (nomebox.TextLength < 9)
                    {
                        MessageBox.Show("Preencha seu nome completo", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        nomeexibir.Text = nomebox.Text.ToString();
                    }
                    if (cpfbox.TextLength == 11)
                    {
                        cpfexibir.Text = cpfbox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Preencha seu CPF completo com apenas números", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (idadebox.TextLength == 8)
                    {
                        idadeexibir.Text = idadebox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Informe sua data de nascimento", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (telefonebox.TextLength == 11)
                    {
                        telefoneexibir.Text = telefonebox.Text.ToString();
                        MessageBox.Show("Seu Cadastro foi realizado com Sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Preencha seu telefone completo com DDD sem hífen e parênteses", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                }

                else if (avancadoradio.Checked)
                {
                    valordesconto = (avalor * 20) / 100;
                    valorcomdesconto = (avalor - valordesconto);
                    valorexibir.Text = avalor.ToString();
                    totalexibir.Text = valorcomdesconto.ToString();
                    pictureBox1.Load(av);

                    if (nomebox.TextLength < 9)
                    {
                        MessageBox.Show("Preencha seu nome completo", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        nomeexibir.Text = nomebox.Text.ToString();
                    }
                    if (cpfbox.TextLength == 11)
                    {
                        cpfexibir.Text = cpfbox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Preencha seu CPF completo com apenas números", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (idadebox.TextLength == 2)
                    {
                        idadeexibir.Text = idadebox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Informe sua idade", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (telefonebox.TextLength == 11)
                    {
                        telefoneexibir.Text = telefonebox.Text.ToString();
                        MessageBox.Show("Seu Cadastro foi realizado com Sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Preencha seu telefone completo com DDD sem hífen e parênteses", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Escolha uma opção do curso para avançar", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                }
            }


            else if (debitobutton.Checked)
            {
                if (basicoradio.Checked)
                {
                    valorexibir.Text = bvalor.ToString();
                    totalexibir.Text = bvalor.ToString();

                    pictureBox1.Load(ba);
                    if (nomebox.TextLength < 9)
                    {
                        MessageBox.Show("Preencha seu nome completo", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        nomeexibir.Text = nomebox.Text.ToString();
                    }
                    if (cpfbox.TextLength == 11)
                    {
                        cpfexibir.Text = cpfbox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Preencha seu CPF completo com apenas números", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (idadebox.TextLength == 2)
                    {
                        idadeexibir.Text = idadebox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Informe sua idade", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (telefonebox.TextLength == 11)
                    {
                        telefoneexibir.Text = telefonebox.Text.ToString();
                        MessageBox.Show("Seu Cadastro foi realizado com Sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Preencha seu telefone completo com DDD sem hífen e parênteses", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                }

                else if (medioradio.Checked)
                {
                    valorexibir.Text = mvalor.ToString();
                    totalexibir.Text = mvalor.ToString();
                    pictureBox1.Load(me);

                    if (nomebox.TextLength < 9)
                    {
                        MessageBox.Show("Preencha seu nome completo", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        nomeexibir.Text = nomebox.Text.ToString();
                    }
                    if (cpfbox.TextLength == 11)
                    {
                        cpfexibir.Text = cpfbox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Preencha seu CPF completo com apenas números", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (idadebox.TextLength == 2)
                    {
                        idadeexibir.Text = idadebox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Informe sua idade", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (telefonebox.TextLength == 11)
                    {
                        telefoneexibir.Text = telefonebox.Text.ToString();
                        MessageBox.Show("Seu Cadastro foi realizado com Sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Preencha seu telefone completo com 9 e com DDD, sem hífen e parênteses", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                }

                else if (avancadoradio.Checked)
                {
                    valorexibir.Text = avalor.ToString();
                    totalexibir.Text = avalor.ToString();
                    pictureBox1.Load(av);

                    if (nomebox.TextLength < 9)
                    {
                        MessageBox.Show("Preencha seu nome completo", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        nomeexibir.Text = nomebox.Text.ToString();
                    }
                    if (cpfbox.TextLength == 11)
                    {
                        cpfexibir.Text = cpfbox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Preencha seu CPF completo com apenas números", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (idadebox.TextLength == 2)
                    {
                        idadeexibir.Text = idadebox.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Informe sua idade", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                    if (telefonebox.TextLength == 11)
                    {
                        telefoneexibir.Text = telefonebox.Text.ToString();
                        MessageBox.Show("Seu Cadastro foi realizado com Sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Preencha seu telefone completo com DDD sem hífen e parênteses", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Escolha uma opção do curso para avançar", "Preenchimento Incompleto", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Selecione opção de pagamento", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

        private void botaoCancelar(object sender, EventArgs e)
        {

            this.Close();
            
        }
    }
}
