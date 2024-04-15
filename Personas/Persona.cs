namespace Personas;

public class Persona
{
    protected long dniNumero;
    protected char dniLetra;

    private String? nombre;
    private int edad;
    public String? Nombre
    {
        get { return nombre; }
        set
        {
            if (value == null)
                throw new Exception();
            nombre = value;
        }
    }
    public int Edad
    {
        get { return edad; }
        set
        {
            if (value < 0 || value > 140)
                throw new Exception();
            edad = value;
        }
    }

    public long DniNumero
    {
        get { return dniNumero; }
    }
    public char DniLetra
    {
        get { return dniLetra; }
    }


    public Persona(long n, char l, String nom, int edad) : this(n, l)
    {
        Nombre = nom;
        Edad = edad;
    }
    public Persona(long n, char l)
    {
        l = Char.ToUpper(l);
        if (LetraDNI(n) != l)
            throw new ArgumentException("El dni facilitado no es válido");
        this.dniNumero = n;
        this.dniLetra = l;
    }
    public override bool Equals(object? obj)
    {
        bool iguales;
        if (obj == null || !(obj is Persona))
            iguales = false;
        else
        {
            Persona elOtro = (Persona)obj;
            iguales = (dniNumero == elOtro.dniNumero);
        }
        return iguales;
    }

    public override int GetHashCode()
    {
        int code;
        code = dniNumero.GetHashCode();

        return code;
    }

    public override string ToString()
    {
        return $"{Nombre} con DNI:{dniNumero}{dniLetra} tiene {Edad} años.";
    }
    private static char LetraDNI(long l)
    {
        String LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posLetra = (int)(l % LETRAS.Length);
        return LETRAS[posLetra];
    }
}