using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaDsv.Models
{
    internal class Colaborador
    {
        
        
            public Colaborador() { }

            public Colaborador(string nome)
            {
                Nome = nome;
            }

        public Colaborador(string nome, string sobrenome, string setor)
            {
                Nome = nome;
                Sobrenome = sobrenome;
                Setor = setor;
            }

            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string Setor { get; set; }
            public string NomeCompleto => $"{Nome} {Sobrenome} {Setor}".ToUpper();
        }
    }

