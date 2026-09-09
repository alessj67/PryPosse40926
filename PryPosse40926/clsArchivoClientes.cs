                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Policy;

namespace PryPosse40926
{
    internal class clsArchivoClientes
    {
        public string nombreAr = "../../Archivos/Clientes.csv";
        

        public void Grabar(String cod, String nom, String deu, String lim)
        {
            StreamWriter ad = new StreamWriter(nombreAr, true);

            ad.Write(cod);
            ad.Write(";");
            ad.Write(nom);
            ad.Write(";");
            ad.Write(deu);
            ad.Write(";");
            ad.WriteLine(lim);

            ad.Close();
            ad.Dispose();
        }


        public void Listar(DataGridView Grilla )
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            
            StreamReader ad = new StreamReader(nombreAr);
            
            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null )
            {
                vcDatos = DatosLeidos.Split(';');
                Grilla.Rows.Add(vcDatos[0], vcDatos[1], vcDatos[2], vcDatos[3]);
                DatosLeidos = ad.ReadLine();
            }
                
            
            ad.Close();
                                
        }

        public int CantClientes()
        {
            int c = 0;
            
            string DatosLeidos = "";
            
            StreamReader ad = new StreamReader(nombreAr);
            
            DatosLeidos = ad.ReadLine();
         
            
            while (DatosLeidos != null)
            {
                c++;
                DatosLeidos = ad.ReadLine();
            }
            ad.Close();
            ad.Dispose();
            return c;
        }
        public decimal Tdeuda()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vcDatos = new string[4];

            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');

                total = total + Convert.ToDecimal(vcDatos[2]);

                DatosLeidos = ad.ReadLine();
            }
            ad.Close();
            ad.Dispose();

            return total;
        }
        public decimal Promedio()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            Int32 c = 0;


            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                c++;        

                total = total + Convert.ToDecimal(vcDatos[2]);

                DatosLeidos = ad.ReadLine();
            }           

            ad.Close();
            ad.Dispose();
            
            return total / c;
        
        }
        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];

            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                if(Convert.ToDecimal(vcDatos[2]) > 0)
                {
                    Grilla.Rows.Add(vcDatos[0], vcDatos[1], vcDatos[2], vcDatos[3]);
                }
                
                DatosLeidos = ad.ReadLine();
            }


            ad.Close();
            ad.Dispose ();

        }
        public decimal CantidadDeudores()
        {
            
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            Int32 c = 0;


            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(vcDatos[2]) > 0)
                {
                    c++;
                }

                DatosLeidos = ad.ReadLine();

            }

            ad.Close();
            ad.Dispose();

            return c;
        }
        public decimal PromedioDeudores()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            Int32 c = 0;


            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(vcDatos[2]) > 0)
                {
                    total = total + Convert.ToDecimal(vcDatos[2]);
                    c++;
                }

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total / c;

        }
    }
}
