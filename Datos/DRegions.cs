using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos
{
    public class DRegions
    {
        public List<ERegions> Listar()
        {
            List<ERegions> Regions = new List<ERegions>();
            try
            {
                using (var connection = new SqlConnection(Conexion.cadena))
                {
                    //Usar el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_ReadRegion", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Recorrer el data reader
                    while (reader.Read())
                    {

                        int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                        string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";
                        string Enabled = reader["Enabled"] != DBNull.Value ? Convert.ToString(reader["Enabled"]) : "";

                        Regions.Add(new ERegions { RegionId = RegionId, RegionName = RegionName, Enabled = Enabled });

                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return Regions;

        }

        public string Registrar(string strNombre, bool bitEnabled)
        {
            string result = "false";

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_CreateRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter prmName = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                prmName.Value = strNombre;
                command.Parameters.Add(prmName);

                SqlParameter prmEnabled = new SqlParameter("@Enabled", SqlDbType.Bit);
                prmEnabled.Value = bitEnabled;
                command.Parameters.Add(prmEnabled);

                command.ExecuteNonQuery();
                result = "true";
            }
            return result;
        }

        public string Editar(int intId, string strNombre, bool bitEnabled)
        {
            string result = "false";

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_UpdateRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter prmId = new SqlParameter("@RegionId", SqlDbType.Int);
                prmId.Value = intId;
                command.Parameters.Add(prmId);

                SqlParameter prmName = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                prmName.Value = strNombre;
                command.Parameters.Add(prmName);

                SqlParameter prmEnabled = new SqlParameter("@Enabled", SqlDbType.Bit);
                prmEnabled.Value = bitEnabled;
                command.Parameters.Add(prmEnabled);

                command.ExecuteNonQuery();
                result = "true";
            }
            return result;
        }
    }
}
