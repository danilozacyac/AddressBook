using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AddressBook.Dto;

namespace AddressBook
{
    /// <summary>
    /// Lógica de interacción para AddContacto.xaml
    /// </summary>
    public partial class AddContacto : Window
    {

        private Contactos contacto;

        public AddContacto()
        {
            InitializeComponent();
            contacto = new Contactos();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            contacto.Direcciones = new ObservableCollection<Dto.DireccionesDto>();
            contacto.ModosContacto = new ObservableCollection<ModoContacto>();
        }

        private void BtnAddDireccion_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddDirecciones direc = new AddDirecciones(contacto.Direcciones);
            direc.ShowDialog();

            if (direc.DialogResult == true)
            {
                DireccionesDto direccion = contacto.Direcciones[contacto.Direcciones.Count - 1];

                ShowDirection user = new ShowDirection();

                user.TxtCalle.Text = direccion.Direccion;
                user.TxtDescripcion.Text = direccion.Descripcion;
                user.TxtColonia.Text = direccion.Codigo.Colonia;
                user.TxtEstado.Text = direccion.Codigo.Estado;
                user.TxtDel.Text = direccion.Codigo.Municipio;
                user.TxtCp.Text = direccion.Codigo.Codigo;
                user.Tag = direccion.Codigo.IdLocalidad;
                Direcciones.Children.Add(user);
            }
        }

        private void BtnAddMetodo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (contacto.ModosContacto == null)
                contacto.ModosContacto = new ObservableCollection<ModoContacto>();

            ShowMethods tels = new ShowMethods();
            Telefonos.Children.Add(tels);

            //AddMethod metodo = new AddMethod();
            //metodo.ShowDialog();

            //if (metodo.DialogResult == true)
            //{
            //    ModoContacto modo = contacto.ModosContacto[contacto.ModosContacto.Count - 1];


            //}
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (contacto.ModosContacto == null)
                contacto.ModosContacto = new ObservableCollection<ModoContacto>();
            if (contacto.Direcciones == null)
                contacto.Direcciones = new ObservableCollection<DireccionesDto>();


            foreach (ShowMethods show in Telefonos.Children)
            {
                ModoContacto modo = new ModoContacto();

                modo.TipoContacto = (show.RbtTipoContacto == true) ? 1 : 2;
                modo.Descripcion = show.TxtTipoContacto.Text;
                modo.TelefonoMail = show.TxtContacto.Text;

                contacto.ModosContacto.Add(modo);
            }

            //foreach (ShowDirection dir in Direcciones.Children)
            //{
            //    DireccionesDto direccion = new DireccionesDto();
            //    direccion.Descripcion = dir.TxtDescripcion.Text;
            //    direccion.IdLocalidad = dir.cb
            //}

        }

        

        
    }
}
