using Transportes_mercancias;

public class Program
{
    public static void Main(string[] args)
    {
        FaseDos(FaseUno_v1());
    }

    private static List<Mercancia> FaseUno_v1()
    {
        String? pais;
        Decimal peso;
        List<Mercancia> mercancias = new List<Mercancia>();
        StreamReader sr = new StreamReader("entrada_datos.txt");

        pais = sr.ReadLine();
        while (pais != null || pais != "0") 
        {
            Console.Write("Peso: ");
            try
            {
                peso = Convert.ToDecimal(Console.ReadLine());
                mercancias.Add(new Mercancia(pais, peso));
            }
            catch (MercanciasException ex)
            {
                Console.WriteLine($"Destino o peso de mercancia es inválido\n{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Peso debe ser un número\n{ex.Message}");
            }
            Console.Write("País: ");
            pais = Console.ReadLine();
        }
        foreach (Mercancia m in mercancias)
        {
            Console.WriteLine(m);
        }
        try
        {

        }
        catch () 
        {
            
        }
        return mercancias;
    }
    private static List<Mercancia> FaseUno_v2(out decimal precio_kilo) 
    {
        String? pais;
        Decimal peso;
        Lista_mercancias mercancias = new Lista_mercancias("entrada_datos.txt", out precio_kilo);
        foreach (Mercancia m in mercancias)
        {
            Console.WriteLine(m);
        }
        return mercancias;
    }
    private static void FaseDos(List<Mercancia> mercancias) 
    {
        Decimal precioKilo, precioTotal;
        Dictionary<String, Decimal> enviosAgrupados = new Dictionary<String, Decimal>();
        int nConten;
        const int PRECIO_CONTAINER = 100;
        String lineaDeDetalle = "{0,-20}{1,-20}{2,-15}{3,-20}";

        Console.Write("Precio/kilo: ");
        precioKilo = Convert.ToDecimal(Console.ReadLine());

        foreach (Mercancia m in mercancias)
        {
            if (enviosAgrupados.ContainsKey(m.Destino))
                enviosAgrupados[m.Destino] = enviosAgrupados[m.Destino] + m.Peso;
            else
                //enviosAgrupados[m.Destino] = m.Peso;
                enviosAgrupados.Add(m.Destino, m.Peso);
        }

        Console.WriteLine("\nLISTADO DE DESTINOS Y CONTENEDORES");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(lineaDeDetalle, "Destino", "Peso Acumulado", "Nº contenedores", "Precio total");

        foreach (String dest in enviosAgrupados.Keys)
        {
            nConten = (int)Math.Ceiling(enviosAgrupados[dest] / Mercancia.PESO_MAX_CONTAINER);
            precioTotal = nConten * PRECIO_CONTAINER + precioKilo * enviosAgrupados[dest];
            Console.WriteLine(lineaDeDetalle, dest, enviosAgrupados[dest], nConten, precioTotal);
        }
        Console.WriteLine($"\nPrecio por kilo en el contenedor {precioKilo}");
        Console.WriteLine($"Precio por contenedor {PRECIO_CONTAINER}");
        Console.WriteLine($"Peso por contenedor {Mercancia.PESO_MAX_CONTAINER}");
    }
    private static void FaseDos_v2(List<Mercancia> mercancias)
    {
        Decimal precioKilo, precioTotal;
        Dictionary<String, Decimal> enviosAgrupados = new Dictionary<String, Decimal>();
        int nConten;
        const int PRECIO_CONTAINER = 100;
        String lineaDeDetalle = "{0,-20}{1,-20}{2,-15}{3,-20}";

        Console.Write("Precio/kilo: ");
        precioKilo = Convert.ToDecimal(Console.ReadLine());

        foreach (Mercancia m in mercancias)
        {
            if (enviosAgrupados.ContainsKey(m.Destino))
                enviosAgrupados[m.Destino] = enviosAgrupados[m.Destino] + m.Peso;
            else
                //enviosAgrupados[m.Destino] = m.Peso;
                enviosAgrupados.Add(m.Destino, m.Peso);
        }
        using StreamWriter sw = new StreamWriter("salida_datos.txt");
       
        sw.WriteLine("\nLISTADO DE DESTINOS Y CONTENEDORES");
        sw.WriteLine("----------------------------------");
        sw.WriteLine(lineaDeDetalle, "Destino", "Peso Acumulado", "Nº contenedores", "Precio total");

        foreach (String dest in enviosAgrupados.Keys)
        {
            nConten = (int)Math.Ceiling(enviosAgrupados[dest] / Mercancia.PESO_MAX_CONTAINER);
            precioTotal = nConten * PRECIO_CONTAINER + precioKilo * enviosAgrupados[dest];
            Console.WriteLine(lineaDeDetalle, dest, enviosAgrupados[dest], nConten, precioTotal);
        }
        sw.WriteLine($"\nPrecio por kilo en el contenedor {precioKilo}");
        sw.WriteLine($"Precio por contenedor {PRECIO_CONTAINER}");
        sw.WriteLine($"Peso por contenedor {Mercancia.PESO_MAX_CONTAINER}");
        
    }
    private static void FaseDos_v3(List<Mercancia> mercancias) 
    {
        
    }
}