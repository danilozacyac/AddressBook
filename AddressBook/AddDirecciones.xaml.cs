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
    /// Lógica de interacción para AddDirecciones.xaml
    /// </summary>
    public partial class AddDirecciones : Window
    {

        private ObservableCollection<DireccionesDto> direcciones;
        

        public AddDirecciones( ObservableCollection<DireccionesDto> direcciones)
        {
            InitializeComponent();
            this.direcciones = direcciones;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            DireccionesDto direccion = new DireccionesDto();

            direccion.Descripcion = NewDirection.TxtDescripcion.Text;
            direccion.Direccion = NewDirection.TxtCalle.Text;

            direccion.Codigo = new Codigos();
            direccion.Codigo.Codigo = NewDirection.CbxCodigo.Text;
            direccion.Codigo.Colonia = NewDirection.CbxColonia.Text;
            direccion.Codigo.Estado = NewDirection.CbxEstados.Text;
            direccion.Codigo.Municipio = NewDirection.TxtMunicipio.Text;
            direccion.Codigo.IdLocalidad = Convert.ToInt32(NewDirection.CbxColonia.SelectedValue);

            direcciones.Add(direccion);

            DialogResult = true;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
