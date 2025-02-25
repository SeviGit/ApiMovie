﻿using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ApiPeliculas.Modelos.Dtos;

public class CategoriaDto {

    public int Id { get; set; }

    [Required(ErrorMessage ="El nombre es obligatorio.")]
    [MaxLength(60,ErrorMessage ="El nombre es obligatorio.")]
    public string Nombre { get; set; }

    public DateTime FechaCreacion { get; set; }
}
