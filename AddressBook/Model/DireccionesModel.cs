using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using AddressBook.DataAccess;
using AddressBook.Dto;

namespace AddressBook.Model
{
    public class DireccionesModel
    {

        public void SetNewFormaContacto(ObservableCollection<DireccionesDto> direcciones, int idContacto)
        {
            OleDbConnection connection = Conexiones.GetConnection();

            OleDbDataAdapter dataAdapter;

            DataSet dataSet = new DataSet();
            DataRow dr;

            try
            {
                foreach (DireccionesDto direccion in direcciones)
                {
                    string sqlCadena = "SELECT * FROM Direcciones WHERE IdDireccion = 0";

                    dataAdapter = new OleDbDataAdapter();
                    dataAdapter.SelectCommand = new OleDbCommand(sqlCadena, connection);

                    dataAdapter.Fill(dataSet, "Direcciones");

                    dr = dataSet.Tables["Direcciones"].NewRow();
                    dr["IdDireccion"] = ContactoModel.GetNextIdForUse("Direcciones", "IdDireccion");
                    dr["IdContacto"] = idContacto;
                    dr["Direccion"] = direccion.Direccion;
                    dr["IdLocalidad"] = direccion.IdLocalidad;

                    dataSet.Tables["Direcciones"].Rows.Add(dr);

                    dataAdapter.InsertCommand = connection.CreateCommand();

                    dataAdapter.InsertCommand.CommandText = "INSERT INTO Direcciones (IdDireccion,IdContacto,Direccion,IdLocalidad) VALUES (@IdDireccion,@IdContacto,@Direccion,@IdLocalidad)";
                    dataAdapter.InsertCommand.Parameters.Add("@IdDireccion", OleDbType.Numeric, 0, "IdDireccion");
                    dataAdapter.InsertCommand.Parameters.Add("@IdContacto", OleDbType.Numeric, 0, "IdContacto");
                    dataAdapter.InsertCommand.Parameters.Add("@Direccion", OleDbType.VarChar, 0, "Direccion");
                    dataAdapter.InsertCommand.Parameters.Add("@IdLocalidad", OleDbType.Numeric, 0, "IdLocalidad");

                    dataAdapter.Update(dataSet, "Direcciones");
                    dataSet.Dispose();
                    dataAdapter.Dispose();
                }
            }
            catch (OleDbException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Utilities.SetNewErrorMessage(ex, methodName, 0);
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Utilities.SetNewErrorMessage(ex, methodName, 0);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
