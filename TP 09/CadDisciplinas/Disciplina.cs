using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadDisciplinas
{
    internal class Disciplina
    {
        private string codigo;
        private string descricao;
        private string horas;

        public void setCodigo(string _codigo) { codigo = _codigo; }
        public string getCodigo() { return codigo; }
        public void setDescricao(string _descricao) { descricao = _descricao; }
        public string getDescricao() { return descricao; }
        public void setHoras(string _horas ) { horas = _horas; }
        public string getHoras() { return horas; }
    }
}
