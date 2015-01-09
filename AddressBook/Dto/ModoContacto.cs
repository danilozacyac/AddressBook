using System;
using System.Linq;

namespace AddressBook.Dto
{
    public class ModoContacto
    {
        private int id;
        private int idContacto;
        private int tipoContacto;
        private string telefonoMail;
        private string descripcion;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
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

        public int TipoContacto
        {
            get
            {
                return this.tipoContacto;
            }
            set
            {
                this.tipoContacto = value;
            }
        }

        public string TelefonoMail
        {
            get
            {
                return this.telefonoMail;
            }
            set
            {
                this.telefonoMail = value;
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
    }
}
