using System;

//Superheroe.cs
internal class SuperHeroe
{
	/*atributos nombre (String), fuerza (int), resistencia (int) y
	superpoderes (int).*/
	private string Nombre { get; set; } = string.Empty;
	private int Resistencia { get; set; }
	private int SuperPoderes { get; set; }
	private int _fuerza;

	public SuperHeroe(string n, int f, int r, int s){
		this.Nombre = n;
		this._fuerza = f;
		this.Resistencia = r;
		this.SuperPoderes = s;
	}
	
	public int Fuerza { get => _fuerza; set => _fuerza = (value >= 0 && value <= 100) ? value : (value > 100) ? 100 : 0; }

	/*
	recibir otro superhéroe como parámetro,
	comparar los  poderes de él mismo contra el otro recibido, 
	devolver TRIUNFO, EMPATE o  DERROTA, dependiendo del resultado. 
	Para triunfar un superhéroe debe superar al otro en al menos 2 de los 3 ítems.
	*/
	public string Competir(SuperHeroe Otro){
		int victorias = 0;
		int derrotas = 0;
		int empates = 0;
		
		// Comp. Fuerza
		if (this.Fuerza > Otro.Fuerza)
			victorias++;
		else if (this.Fuerza < Otro.Fuerza)
			derrotas++;
		else
			empates++;
		
		// Comp. Resistencia
		if (this.Resistencia > Otro.Resistencia)
			victorias++;
		else if (this.Resistencia < Otro.Resistencia)
			derrotas++;
		else
			empates++;
		
		// Comp. SuperPoderes
		if (this.SuperPoderes > Otro.SuperPoderes)
			victorias++;
		else if (this.SuperPoderes < Otro.SuperPoderes)
			derrotas++;
		else
			empates++;
		
		// Resultado
		if (victorias > derrotas)
			return "TRIUNFO";
		else if (derrotas > victorias)
			return "DERROTA";
		else
			return "EMPATE";
	}

	public override string ToString(){
		return string.IsNullOrEmpty(Nombre) ? "Empty" : $"Saludos!, Soy el SuperHeroe ¡{Nombre}! y tengo Fuerza: {Fuerza}, Resistencia: {Resistencia}, SuperPoderes: {SuperPoderes}";
	}
}

// Program.cs
internal class Program
{
	internal static void Main(string[] args){
		/*
		superHeroe1: Nombre: “Batman”, Fuerza: 90, Resistencia: 70, Superpoderes: 0
		superHeroe2: Nombre: “Superman”, Fuerza: 95, Resistencia: 60, Superpoderes: 70
		*/
		var superHeroe1 = new SuperHeroe("Batman", 90, 70, 0);
		var superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);
		Console.WriteLine(superHeroe1.ToString());
		Console.WriteLine(superHeroe2.ToString());
		string resultado1 = superHeroe1.Competir(superHeroe2);
		Console.WriteLine("1° " + resultado1); // Debería ser DERROTA
		string resultado2 = superHeroe2.Competir(superHeroe1);
		Console.WriteLine("2° " + resultado2); // Debería ser TRIUNFO
	}
}
