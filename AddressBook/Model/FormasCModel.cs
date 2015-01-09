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
    public class FormasCModel
    {

        public void SetNewFormaContacto(ObservableCollection<ModoContacto> modosContacto)
        {
            OleDbConnection connection = Conexiones.GetConnection();

            OleDbDataAdapter dataAdapter;

            DataSet dataSet = new DataSet();
            DataRow dr;

            try
            {
                foreach (ModoContacto contact in modosContacto)
                {
                    string sqlCadena = "SELECT * FROM TelefonoMail WHERE Id = 0";

                    dataAdapter = new OleDbDataAdapter();
                    dataAdapter.SelectCommand = new OleDbCommand(sqlCadena, connection);

                    dataAdapter.Fill(dataSet, "TelefonoMail");

                    dr = dataSet.Tables["TelefonoMail"].NewRow();
                    dr["IdContacto"] = ContactoModel.GetNextIdForUse("TelefonoMail", "Id");
                    dr["IdTipoContacto"] = contact.TipoContacto;
                    dr["Descripcion"] = contact.Descripcion;
                    dr["TelefMail"] = contact.TelefonoMail;

                    dataSet.Tables["TelefonoMail"].Rows.Add(dr);

                    dataAdapter.InsertCommand = connection.CreateCommand();

                    dataAdapter.InsertCommand.CommandText = "INSERT INTO TelefonoMail (Id,IdContacto,IdTipoContacto,Descripcion,TelefMail) VALUES (@Id,@IdContacto,@IdTipoContacto,@Descripcion,@TelefMail)";
                    dataAdapter.InsertCommand.Parameters.Add("@Id", OleDbType.Numeric, 0, "Id");
                    dataAdapter.InsertCommand.Parameters.Add("@IdContacto", OleDbType.Numeric, 0, "IdContacto");
                    dataAdapter.InsertCommand.Parameters.Add("@IdTipoContacto", OleDbType.Numeric, 0, "IdTipoContacto");
                    dataAdapter.InsertCommand.Parameters.Add("@Descripcion", OleDbType.VarChar, 0, "Descripcion");
                    dataAdapter.InsertCommand.Parameters.Add("@TelefMail", OleDbType.VarChar, 0, "TelefMail");

                    dataAdapter.Update(dataSet, "TelefonoMail");
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
