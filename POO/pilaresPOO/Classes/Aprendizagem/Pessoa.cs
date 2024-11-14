using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        public string? Nome;
        public int idade;
        public string? cpf;
        public float peso;
        public float altura;

        public void Envelhecer()
        {
            idade++;
        }

        public void Engordar(float kg)
        {
            peso = peso + kg;
        }

        public void Emagrecer(float kg)
        {
            peso = peso - kg;
        }

    //     public class Aluno : Pessoa
    // {
    //     public int matricula;
    //     public string curso;
    //     public float media;
    //     public string nome;
    // }
    }
}