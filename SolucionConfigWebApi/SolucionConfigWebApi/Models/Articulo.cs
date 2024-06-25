using System;
using System.Collections.Generic;

namespace SolucionConfigWebApi.Models;

public partial class Articulo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }
}
