public class SuperHeroe
{
    private string _nombre = string.Empty;
    private int _resistencia = 0;
    private int _superPoderes = 0;
    private int _fuerza = 0;

    public int Fuerza
    {
        get => _fuerza;
        set => _fuerza = (value >= 0 && value <= 100) ? value : (value > 100) ? 100 : 0;
    }

    public int Resistencia
    {
        get => _resistencia;
        set => _resistencia = (value >= 0 && value <= 100) ? value : (value > 100) ? 100 : 0;
    }

    public int SuperPoderes
    {
        get => _superPoderes;
        set => _superPoderes = (value >= 0 && value <= 100) ? value : (value > 100) ? 100 : 0;
    }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public SuperHeroe(string n, int f, int r, int s)
    {
        this._nombre = n;
        this._fuerza = f;
        this._resistencia = r;
        this._superPoderes = s;
    }

    public string Competir(SuperHeroe Otro)
    {
        int victorias = 0;
        int derrotas = 0;
        int empates = 0;

        if (this.Fuerza > Otro.Fuerza)
            victorias++;
        else if (this.Fuerza < Otro.Fuerza)
            derrotas++;
        else
            empates++;

        if (this.Resistencia > Otro.Resistencia)
            victorias++;
        else if (this.Resistencia < Otro.Resistencia)
            derrotas++;
        else
            empates++;

        if (this.SuperPoderes > Otro.SuperPoderes)
            victorias++;
        else if (this.SuperPoderes < Otro.SuperPoderes)
            derrotas++;
        else
            empates++;

        if (victorias > derrotas)
            return "TRIUNFO";
        else if (derrotas > victorias)
            return "DERROTA";
        else
            return "EMPATE";
    }

    public override string ToString()
    {
        return string.IsNullOrEmpty(Nombre) ? "Empty" : $"Saludos!, Soy el SuperHeroe ¡{Nombre}! y tengo Fuerza: {Fuerza}, Resistencia: {Resistencia}, SuperPoderes: {SuperPoderes}";
    }
}
