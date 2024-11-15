using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models;

public partial class Livro
{
    [Required]
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Column("Titulo")]
    public string Titulo { get; set; }

    [StringLength(30)]
    [Column("Autor")]
    public string Autor { get; set; }

    [StringLength(10)]
    [Column("Genero")]
    public string Genero { get; set; }

    [StringLength(20)]
    [Column("Ano")]
    public string Ano { get; set; }

}
