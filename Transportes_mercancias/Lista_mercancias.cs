using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_mercancias
{
    public class Lista_mercancias : List<Mercancia>
    {
        public Lista_mercancias(string nFich, out decimal precio_kilo) 
        {
            string? pais;
            decimal peso;
            using (StreamReader sr = new StreamReader(nFich));
            pais = sr.ReadLine();

            while (pais != null && pais != "0") 
            {
                try 
                {
                    peso = Convert.ToDecimal(sr.ReadLine());
                    Add(new Mercancia(pais, peso));
                }
                catch (MercanciasException ex) 
                {
                    Console.WriteLine($"Destino o peso demercacia es invalido \n{ex.Message}");
                }
                catch (FormatException ex) 
                {
                    Console.WriteLine($"Peso debe ser un número \n{ex.Message}");
                }
            }
            try
            {
                
            }
            catch ()
            {
                
            }
        }
    }
}
