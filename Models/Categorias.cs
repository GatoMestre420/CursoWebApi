
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;    
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace API.Models;


[Table("Categorias")]
public class Categoria{

    public Categoria(){
        Produtos = new Collection<APICatalogo.Models.Produto>();

    }
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }   
    [Required]
    [StringLength(300)]
    public string? ImagemUrl    { get; set; }

    public ICollection<APICatalogo.Models.Produto>? Produtos{ get; set; }  



} 