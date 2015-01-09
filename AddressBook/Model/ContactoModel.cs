using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using AddressBook.DataAccess;
using AddressBook.Dto;

namespace AddressBook.Model
{
    public class ContactoModel
    {
        public void SetNewContact(Contactos contacto)
        {
            OleDbConnection connection = Conexiones.GetConnection();

            OleDbDataAdapter dataAdapter;

            DataSet dataSet = new DataSet();
            DataRow dr;

            try
            {
                string sqlCadena = "SELECT * FROM Contactos WHERE IdContacto = 0";

                dataAdapter = new OleDbDataAdapter();
                dataAdapter.SelectCommand = new OleDbCommand(sqlCadena, connection);

                dataAdapter.Fill(dataSet, "Contactos");

                dr = dataSet.Tables["Contactos"].NewRow();
                dr["IdContacto"] = ContactoModel.GetNextIdForUse("Contactos", "IdContacto");
                dr["IdTitulo"] = contacto.IdTitulo;

                dr["Nombre"] = contacto.Nombre;
                dr["Paterno"] = contacto.Paterno;
                dr["Materno"] = contacto.Materno;
                dr["Cumple"] = contacto.FechaNacimiento;
                
                dataSet.Tables["Contactos"].Rows.Add(dr);

                dataAdapter.InsertCommand = connection.CreateCommand();

                dataAdapter.InsertCommand.CommandText = "INSERT INTO Contactos (IdContacto,IdTitulo,Nombre,Paterno,Materno,Cumple) VALUES (@IdContacto,@IdTitulo,@Nombre,@Paterno,@Materno,@Cumple)";
                dataAdapter.InsertCommand.Parameters.Add("@IdContacto", OleDbType.Numeric, 0, "IdContacto");
                dataAdapter.InsertCommand.Parameters.Add("@IdTitulo", OleDbType.Numeric, 0, "IdTitulo");
                dataAdapter.InsertCommand.Parameters.Add("@Nombre", OleDbType.VarChar, 0, "Nombre");
                dataAdapter.InsertCommand.Parameters.Add("@Paterno", OleDbType.VarChar, 0, "Paterno");
                dataAdapter.InsertCommand.Parameters.Add("@Materno", OleDbType.VarChar, 0, "Materno");
                dataAdapter.InsertCommand.Parameters.Add("@Cumple", OleDbType.Date, 0, "Cumple");

                dataAdapter.Update(dataSet, "Contactos");
                dataSet.Dispose();
                dataAdapter.Dispose();
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

        public static int GetNextIdForUse(string nombreTabla, string nombreCampo)
        {
            OleDbConnection connection = Conexiones.GetConnection();
            OleDbCommand cmd;
            OleDbDataReader reader = null;

            int idForUse = 0;

            try
            {
                connection.Open();

                string sqlCadena = "SELECT MAX(" + nombreCampo + ") + 1 AS Id FROM " + nombreTabla;

                cmd = new OleDbCommand(sqlCadena, connection);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    idForUse = reader[nombreCampo] as int? ?? -1;
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
                reader.Close();
                connection.Close();
            }

            return idForUse;
        }
    }
}