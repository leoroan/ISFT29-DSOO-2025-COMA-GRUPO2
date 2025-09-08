using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Persona{

    private string _nombre = string.Empty;
    private int _edad;

    public Persona(){}

    public Persona(string n, int e){
        this._nombre = n;
        this._edad = e;
    }

    public string Nombre{ get => _nombre;  set => _nombre = value;}
    public int Edad{ get => _edad;  set => _edad = value; }

    public string Saludar()
    {
        if (string.IsNullOrEmpty(Nombre) && Edad == 0)
        {
            return "¡Hola!";
        }
        else if (string.IsNullOrEmpty(Nombre))
        {
            return $"¡Hola! Tengo {Edad} años";
        }
        else if (Edad == 0)
        {
            return $"¡Hola! Me llamo {Nombre}";
        }
        else
        {
            return $"¡Hola! Me llamo {Nombre} y tengo {Edad} años";
        }
    }

    public override string ToString()
    {
        return this._nombre +" "+ this._edad;
    }
}
