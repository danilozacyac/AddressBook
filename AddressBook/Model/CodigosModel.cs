using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.DataAccess;
using AddressBook.Dto;
using ScjnUtilities;

namespace AddressBook.Model
{
    public class CodigosModel
    {

        public List<string> GetEstados()
        {
            List<string> codigos = new List<string>();


            OleDbConnection connection = Conexiones.GetConnection();
            OleDbCommand cmd;
            OleDbDataReader reader = null;


            try
            {
                connection.Open();

                string sqlCadena = "SELECT DISTINCT Estado FROM Codigos Order by Estado";

                cmd = new OleDbCommand(sqlCadena, connection);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        codigos.Add(reader["Estado"].ToString());
                    }
                }
            }
            catch (OleDbException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErrorUtilities.SetNewErrorMessage(ex, methodName, 0);
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErrorUtilities.SetNewErrorMessage(ex, methodName, 0);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }




            return codigos;
        }



        public List<string> GetCodigosPostales(string estado)
        {
            List<string> codigos = new List<string>();


            OleDbConnection connection = Conexiones.GetConnection();
            OleDbCommand cmd;
            OleDbDataReader reader = null;


            try
            {
                connection.Open();

                string sqlCadena = "SELECT DISTINCT codigo FROM Codigos WHERE Estado = @Estado";

                cmd = new OleDbCommand(sqlCadena, connection);
                cmd.Parameters.AddWithValue("@Estado", estado);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        codigos.Add(reader["Codigo"].ToString());
                    }
                }
            }
            catch (OleDbException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErrorUtilities.SetNewErrorMessage(ex, methodName, 0);
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErrorUtilities.SetNewErrorMessage(ex, methodName, 0);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }




            return codigos;
        }



        public List<Codigos> GetColoniasPorCodigo(string codigo)
        {
            List<Codigos> codigos = new List<Codigos>();


            OleDbConnection connection = Conexiones.GetConnection();
            OleDbCommand cmd;
            OleDbDataReader reader = null;


            try
            {
                connection.Open();

                string sqlCadena = "SELECT * FROM Codigos WHERE Codigo = @Codigo";

                cmd = new OleDbCommand(sqlCadena, connection);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Codigos cod = new Codigos();
                        cod.IdLocalidad = reader["IdLocalidad"] as int? ?? -1;
                        cod.Codigo = reader["Codigo"].ToString();
                        cod.Colonia = reader["Colonia"].ToString();
                        cod.Estado = reader["Estado"].ToString();
                        cod.Municipio = reader["Municipio"].ToString();
                        codigos.Add(cod);
                    }
                }
            }
            catch (OleDbException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErrorUtilities.SetNewErrorMessage(ex, methodName, 0);
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

                MessageBox.Show("Error ({0}) : {1}" + ex.Source + ex.Message, methodName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErrorUtilities.SetNewErrorMessage(ex, methodName, 0);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }




            return codigos;
        }

    }
}
