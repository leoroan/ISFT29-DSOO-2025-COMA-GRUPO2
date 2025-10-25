
namespace ClubDeportivo.Entidades
{
    public class E_Usuario
    {
        public int CodUsuario { get; set; }
        public string? NombreUsuario { get; set; }
        public string? PassUsuario { get; set; }
        public int RolUsuario { get; set; }
        public bool Activo { get; set; }
    }
}
