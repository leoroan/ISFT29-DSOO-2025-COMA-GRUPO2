internal class Television
{
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

  public void CambiarCanal(int canal)
  {
    if (this._estado)
    {
      this._canalActual = canal;
    }
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
