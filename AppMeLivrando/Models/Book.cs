using System.ComponentModel.DataAnnotations;

namespace AppMeLivrando.Models;

public class Book
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Autor { get; set; }
    
    public string? Categoria { get; set; }

    public string? Estado { get; set; }

    public decimal? Valor { get; set; }

}