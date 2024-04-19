using CajaFinalUniversidad.Modelos;
using Newtonsoft.Json;
using CajaFinalUniversidad.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UniversidadAPI.Models;

namespace CajaFinalUniversidad.Servicios
{
    internal class API 
    {
        static HttpClient client = new HttpClient();
       public API()
        {
            if (client.BaseAddress==null)
            client.BaseAddress = new Uri("https://integracion-api.duckdns.org/api/");
        }
        public List<Estudiante> ConsultaEstudiante()
        {
            List <Estudiante>Estudiante = null;
            HttpResponseMessage response = client.GetAsync("Estudiante").Result;
            if (response.IsSuccessStatusCode)
            {
               var resultado = response.Content.ReadAsStringAsync();

                Estudiante = JsonConvert.DeserializeObject<List<Estudiante>>(resultado.Result);
                
            }
            return Estudiante;
        }

        public List<Seleccion> ConsultaSeleccion(int ID_Estudiante)
        {

            List<Seleccion> Lista_Seleccion= new List<Seleccion>();
            HttpResponseMessage response = client.GetAsync("Seleccion").Result;
            if (response.IsSuccessStatusCode)
            {
                var resultado = response.Content.ReadAsStringAsync();
               var Seleccion = JsonConvert.DeserializeObject<List<Seleccion>>(resultado.Result);
                if (Seleccion.Any(c => c.estudiante_id == ID_Estudiante))
                {
                    Lista_Seleccion = Seleccion.Where(c => c.estudiante_id == ID_Estudiante).ToList();

                };
            }
            

            return Lista_Seleccion;
        }
        public List<Factura_pago> ConsultaFactura()
        {

            List<Factura_pago> Lista_Factura = new List<Factura_pago>();
            HttpResponseMessage response = client.GetAsync("Factura_pago").Result;
            if (response.IsSuccessStatusCode)
            {
                var resultado = response.Content.ReadAsStringAsync();
                var Seleccion = JsonConvert.DeserializeObject<List<Factura_pago>>(resultado.Result);
                
                    Lista_Factura = Seleccion.ToList();

                
            }


            return Lista_Factura;
        }
        public void CrearCuentaPorCobrar(Cuentas_cobrar  Model)
      {
            //Esto es para crear el registro 
            HttpResponseMessage response =  client.PostAsJsonAsync(
                "Cuentas_cobrar", Model).Result;
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
        }
    }
}
