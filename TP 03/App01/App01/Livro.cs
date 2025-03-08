using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Livro
    {

        private string titulo;
        private string autor;
        private string editora;
        private string anoedicao;
        private string local;

        public void settitulo(string _titulo) { titulo = _titulo; }
        public String gettitulo() { return titulo; }
        public void setautor(string _autor) { autor = _autor; }
        public String getautor() { return autor; }
        public void seteditora(string _editora) { editora = _editora; }
        public String geteditora() { return editora; }
        public void setanoedicao(string _anoEdicao) { anoedicao = _anoEdicao; }
        public String getanoedicao() { return anoedicao; }
        public void setlocal(string _local) { local = _local; }
        public String getlocal() { return local; }

    }
}
