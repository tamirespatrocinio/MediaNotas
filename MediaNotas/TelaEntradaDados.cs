using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNotas
{
    public partial class TelaEntradaDados : Form
    {
        public TelaEntradaDados()
        {
            InitializeComponent();
        }

        private decimal MediaAluno (params decimal[] notas)
        {
            decimal soma = 0;
            for(int i=0; i <=notas.GetLength(0) - 1; i++)
            {
                soma += notas[i];
            }

            return soma / notas.Length;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listBoxDados.Items.Clear();
            string nome = textBoxNome.Text;
            string nascimento = dateTimePickerNascimento.Value.ToString();
            decimal nota1 = numericNota1.Value;
            decimal nota2 = numericNota2.Value;
            decimal nota3 = numericNota3.Value;
            decimal nota4 = numericNota4.Value;


            listBoxDados.Items.Add("Aluno(a): " + nome);

            listBoxDados.Items.Add("Data de Nascimento: " + nascimento);

            listBoxDados.Items.Add("Nota da atividade 1 = " + nota1);
            listBoxDados.Items.Add("Nota da atividade 2 = " + nota2);
            listBoxDados.Items.Add("Nota da atividade 3 = " + nota3);
            listBoxDados.Items.Add("Nota da atividade 4 = " + nota4);
            listBoxDados.Items.Add("Média Final: " + MediaAluno(nota1, nota2, nota3, nota4));

            decimal media = MediaAluno(nota1, nota2, nota3, nota4);

            decimal valormedia = numericMedia.Value;

            if(media >= valormedia)
            {
                MessageBox.Show("Aluno Aprovado! :D");
            }
            else
            {
                MessageBox.Show("Aluno Reprovado! :(");
            }
        }
    }
}
