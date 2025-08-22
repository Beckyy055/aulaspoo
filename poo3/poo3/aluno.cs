using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo3
{
    public class Aluno : Pessoa
    {
        protected string nmatricula;
        protected string curso;
        protected int semestre;
        protected string turma;

        public string Matricula
        {
            get { return nmatricula; }
            set { nmatricula = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public string Turma
        {
            get { return turma; }
            set { turma = value; }
        }
    }
}
