using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizacionCompartida
{
  internal class Television
  {
    private const int MAX_CANALES = 150;
    private string _marca;
    private string _modelo;
    private int _pulgadas;
    private bool _estado;
    private int _canalActual;

    public Television(string ma, string mo, int pul)
    {
      this._marca = ma;
      this._modelo = mo;
      this._pulgadas = pul;
      this._estado = false;
      this._canalActual = 1;
    }

    public string Marca
    {
      get { return _marca; }
      set { _marca = value; }
    }
    public string Modelo
    {
      get { return _modelo; }
      set { _modelo = value; }
    }
    public int Pulgadas
    {
      get { return _pulgadas; }
      set { _pulgadas = value; }
    }
    public bool Estado
    {
      get { return _estado; }
      set { _estado = value; }
    }
    public int CanalActual
    {
      get { return _canalActual; }
      set { _canalActual = value; }
    }

    public void ToggleEstado()
    {
      this._estado = !this._estado;
    }

    public bool CambiarCanal(int canal)
    {
      if (this._estado)
      {
        this._canalActual = canal;
        return true;
      }
      return false;
    }

    //Cambia el canal incrementando en uno al que se está reproduciendo actualmente.
    //Si llega al tope de 150, debe comenzar por el primero.
    public bool CambiarCanal()
    {
      if (this._estado)
      {
        if (this._canalActual < MAX_CANALES)
        {
          this._canalActual++;
        }
        else if (this._canalActual == MAX_CANALES)
        {
          this._canalActual = 1;
        }
        return true;
      }
      return false;
    }

    public int ObtenerCanalActual()
    {
      return this._canalActual;
    }

    public bool VerPrendido()
    {
      return this._estado;
    }

    public override string ToString()
    {
      if (this._estado)
      {
        return $"la TV está encendida, en el canal {_canalActual}";
      }
      else
      {
        return "la TV está apagada";
      }
    }
  }
}
