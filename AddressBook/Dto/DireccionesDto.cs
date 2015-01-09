using System;
using System.Linq;

namespace AddressBook.Dto
{
    public class DireccionesDto
    {
        private string descripcion;
        private int idDireccion;
        private int idContacto;
        private int idLocalidad;
        private Codigos codigo;
        private string direccion;
        
        
        public Codigos Codigo
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

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public int IdDireccion
        {
            get
            {
                return this.idDireccion;
            }
            set
            {
                this.idDireccion = value;
            }
        }

        public int IdContacto
        {
            get
            {
                return this.idContacto;
            }
            set
            {
                this.idContacto = value;
            }
        }

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

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
    }
}
