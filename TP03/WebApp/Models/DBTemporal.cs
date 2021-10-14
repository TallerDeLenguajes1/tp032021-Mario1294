using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebApp.Entidades;

namespace WebApp.Entidades
{
    public class DBTemporal
    {
        public Cadeteria Cadeteria { get; set; }

        public DBTemporal()
        {
            Cadeteria = new Cadeteria();
            if (GetListCadetes() != null)
            {
                Cadeteria.Cadetes = GetListCadetes();
            }
        }
        private static string pathPedidos = @"Pedidos.json";
        public void GuardarCadete(List<Cadete> cadetes)
        {
            try
            {
                string _path = @"Cadetes.json";
                string CadeteJson = JsonSerializer.Serialize(cadetes);

                using (FileStream miArchivo = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    using (StreamWriter strReader = new StreamWriter(miArchivo))
                    {
                        strReader.Write(CadeteJson);
                        strReader.Close();
                        strReader.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }
        public List<Cadete> GetListCadetes()
        {
            List<Cadete> CadetesJson = null;
            try
            {
                string _path = @"Cadetes.json";

                if (File.Exists(_path))
                {
                    using (FileStream miArchivo = new FileStream(_path, FileMode.Open))
                    {
                        using (StreamReader streamReader = new StreamReader(miArchivo))
                        {
                            string strCadetes = streamReader.ReadToEnd();
                            CadetesJson = JsonSerializer.Deserialize<List<Cadete>>(strCadetes);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                string error = ex.ToString();
            }
            return CadetesJson;
        }

        //-------------- GUARDAR PEDIDOS-----------------//
        public void GuardarPedido(List<Pedido> pedidos)
        {
            string pedidosJson = JsonSerializer.Serialize(pedidos);
            using (StreamWriter strWriter = new StreamWriter(pathPedidos, false))
            {
                strWriter.WriteLine(pedidosJson);
                strWriter.Close();
                strWriter.Dispose();
            }
        }

        public static List<Pedido> ObtenerPedidos()
        {
            List<Pedido> pedidos = null;

            if (File.Exists(pathPedidos) && new FileInfo(pathPedidos).Length >= 5)
            {
                using (StreamReader strReader = new StreamReader(pathPedidos))
                {
                    string datos = strReader.ReadToEnd();
                    pedidos = JsonSerializer.Deserialize<List<Pedido>>(datos);
                    strReader.Close();
                    strReader.Dispose();
                }
            }

            return pedidos;
        }

        public static int UltimoIDPedido()
        {
            List<Pedido> pedidos = null;

            if (File.Exists(pathPedidos) && new FileInfo(pathPedidos).Length >= 5)
            {
                using (StreamReader strReader = new StreamReader(pathPedidos))
                {
                    string datos = strReader.ReadToEnd();
                    pedidos = JsonSerializer.Deserialize<List<Pedido>>(datos);
                    strReader.Close();
                    strReader.Dispose();
                }
            }

            return pedidos[^1].Num;
        }
    }

 
    
}
