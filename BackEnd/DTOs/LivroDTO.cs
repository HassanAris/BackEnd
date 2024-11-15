using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models;

public partial class LivroDTO
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Titulo { get; set; }

    [StringLength(30)]
    public string Autor { get; set; }

    [StringLength(10)]
    public string Genero { get; set; }

    [Column("Ano")]
    public string Ano { get; set; }

}
