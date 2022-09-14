using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Acceso_a_Datos
{
    /// <summary>
    /// Descripción breve de WebService4
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService4 : System.Web.Services.WebService
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        [WebMethod(Description = "Listar CustomerDemographics con SP")]
        public DataSet ListarCustomerDemographics()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spListarCustomerDemographics", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

        [WebMethod(Description = "Agregar CustomerDemographics con SP")]
        public string[] AgregarCustomerDemographics(string CustomerTypeID, string CustomerDesc)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spAgregarCustomerDemographics", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@CustomerTypeID", CustomerTypeID);
                comando.Parameters.AddWithValue("@CustomerDesc", CustomerDesc);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }


        [WebMethod(Description = "Actualizar CustomerDemographics con SP")]
        public string[] ActualizarCustomerDemographics(string CustomerTypeID, string CustomerDesc)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spActualizarCustomerDemographics", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@CustomerTypeID", CustomerTypeID);
                comando.Parameters.AddWithValue("@CustomerDesc", CustomerDesc);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Eliminar CustomerDemographics con SP")]
        public string[] EliminarCustomerDemographics(string CustomerTypeID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spEliminarCustomerDemographics", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@CustomerTypeID", CustomerTypeID);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Buscar CustomerDemographics con SP")]
        public DataSet BuscarCustomerDemographics(string texto)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spBuscarCustomerDemographics", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CustomerTypeID", texto);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }



        [WebMethod(Description = "Listar Region con SP")]
        public DataSet ListarRegion()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spListarRegion", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

        [WebMethod(Description = "Agregar Region con SP")]
        public string[] AgregarRegion(int RegionID, string RegionDescription)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spAgregarRegion", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@RegionID", RegionID);
                comando.Parameters.AddWithValue("@RegionDescription", RegionDescription);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }


        [WebMethod(Description = "Actualizar Region con SP")]
        public string[] ActualizarRegion(int RegionID, string RegionDescription)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spActualizarRegion", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@RegionID", RegionID);
                comando.Parameters.AddWithValue("@RegionDescription", RegionDescription);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Eliminar Region con SP")]
        public string[] EliminarRegion(int RegionID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spEliminarRegion", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@RegionID", RegionID);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Buscar Region con SP")]
        public DataSet BuscarRegion(int RegionID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spBuscarRegion", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RegionID", RegionID);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }



        [WebMethod(Description = "Listar Shippers con SP")]
        public DataSet ListarShippers()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spListarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

        [WebMethod(Description = "Agregar Shippers con SP")]
        public string[] AgregarShippers(int ShipperID, string CompanyName, string Phone)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spAgregarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@ShipperID", ShipperID);
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);
                comando.Parameters.AddWithValue("@Phone", Phone);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }


        [WebMethod(Description = "Actualizar Shippers con SP")]
        public string[] ActualizarShippers(int ShipperID, string CompanyName, string Phone)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spActualizarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@ShipperID", ShipperID);
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);
                comando.Parameters.AddWithValue("@Phone", Phone);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Eliminar Shippers con SP")]
        public string[] EliminarShippers(int ShipperID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spEliminarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure; //Exigir que sea un SP
                comando.Parameters.AddWithValue("@ShipperID", ShipperID);
                string[] arreglo = new string[2];//Arreglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Buscar Shippers con SP")]
        public DataSet BuscarShippers(string texto, string criterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("spBuscarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@texto", texto);
                comando.Parameters.AddWithValue("@criterio", criterio);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
    }
}
