
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;    
using System.Collections.ObjectModel;


namespace API.Models;

public class Categoria{

    public Categoria(){
        Produtos = new Collection<APICatalogo.Models.Produto>();

    }

    public int CategoriaId { get; set; }
    public string? Nome { get; set; }   
    public string? ImagemUrl    { get; set; }

    public ICollection<APICatalogo.Models.Produto>? Produtos{ get; set; }  



} 