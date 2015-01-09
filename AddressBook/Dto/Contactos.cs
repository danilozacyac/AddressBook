using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AddressBook.Dto
{
    public class Contactos
    {
        private int idContacto;
        private int idTitulo;
        private string nombre;
        private string paterno;
        private string materno;
        private bool? fechaNacimiento;
        private ObservableCollection<DireccionesDto> direcciones;
        private ObservableCollection<ModoContacto> modosContacto;

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

        public int IdTitulo
        {
            get
            {
                return this.idTitulo;
            }
            set
            {
                this.idTitulo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Paterno
        {
            get
            {
                return this.paterno;
            }
            set
            {
                this.paterno = value;
            }
        }

        public string Materno
        {
            get
            {
                return this.materno;
            }
            set
            {
                this.materno = value;
            }
        }

        public bool? FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }

        public ObservableCollection<DireccionesDto> Direcciones
        {
            get
            {
                return this.direcciones;
            }
            set
            {
                this.direcciones = value;
            }
        }

        public ObservableCollection<ModoContacto> ModosContacto
        {
            get
            {
                return this.modosContacto;
            }
            set
            {
                this.modosContacto = value;
            }
        }
    }
}
