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

        public void GuardarCadete(List<Cadete> cadetes)
        {
            try
            {
                string _path = @"Cadete.json";
                string CadeteJson = JsonSerializer.Serialize(cadetes);
              
                using(FileStream miArchivo = new FileStream(_path, FileMode.OpenOrCreate))           
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
                string _path = @"Cadete.json";
                
                if (File.Exists(_path))
                {
                    using (FileStream miArchivo = new FileStream(_path, FileMode.Open))
                    {
                        using (StreamReader streamReader = new StreamReader(miArchivo))
                        {
                            string strCadetes =  streamReader.ReadToEnd();
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
    }
}
