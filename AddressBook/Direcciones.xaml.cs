using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AddressBook.Dto;
using AddressBook.Model;

namespace AddressBook
{
    /// <summary>
    /// Lógica de interacción para Direcciones.xaml
    /// </summary>
    public partial class Direcciones : UserControl
    {
        public Direcciones()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CbxEstados.DataContext = new CodigosModel().GetEstados();
        }

        private void CbxCodigo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string codigo = e.AddedItems[0].ToString();
                CbxColonia.DataContext = new CodigosModel().GetColoniasPorCodigo(codigo);
            }
        }

        private void CbxEstados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string estado = e.AddedItems[0].ToString();

                CbxCodigo.DataContext = new CodigosModel().GetCodigosPostales(estado);
            }
        }

        private Codigos coloniaSelect;
        private void CbxColonia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbxColonia.SelectedItem != null)
            {
                coloniaSelect = CbxColonia.SelectedItem as Codigos;
                TxtMunicipio.Text = coloniaSelect.Municipio;
            }
        }
    }
}
