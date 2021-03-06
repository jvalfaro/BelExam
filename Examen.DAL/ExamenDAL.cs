﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Examen.BE;
using System.Configuration;

namespace Examen.DAL
{
   public class ExamenDAL
    {

        private string ConnectionString = null;
        public ExamenDAL()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["Examen"].ConnectionString;
        }

        public List<Producto> ListarProductos(string nombre )
        {
            var Producto = new List<Producto>();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var query = new SqlCommand("usp_s_ListarProductos", con);
                query.Parameters.AddWithValue("@vDescripcion", nombre);
                query.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = query.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var Marca = new List<Marca>();

                        Marca.Add(new Marca

                        {
                            Descripcion = dr["DescMarca"].ToString(),
                        });

                        Producto.Add(new Producto
                        {
                            Descripcion = dr["Descripcion"].ToString(),
                            Cuv = dr["Cuv"].ToString(),
                            Precio = Convert.ToDecimal(dr["Precio"]),
                            Marca = Marca
                        });
                    }
                }
                return Producto;
            }
        }
    }
}
