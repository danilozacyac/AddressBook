using System;
using System.Linq;

namespace AddressBook.Dto
{
    public class Codigos
    {
        private int idLocalidad;
        private string codigo;
        private string estado;
        private string municipio;
        private string colonia;
        public int IdLocalidad
        {
            get
            {
                return this.idLocalidad;
            }
            set
            {
                this.idLocalidad = value;
            }
        }

        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string Municipio
        {
            get
            {
                return this.municipio;
            }
            set
            {
                this.municipio = value;
            }
        }

        public string Colonia
        {
            get
            {
                return this.colonia;
            }
            set
            {
                this.colonia = value;
            }
        }
    }
}
