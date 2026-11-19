using CatalogoMaui.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMaui.ViewModels
{
    public class CatalogoViewModel
    {
        // Cada objeto de esta lista se convertirá en una tarjeta.
        public List<Producto> Productos { get; } = new()
        {
           new Producto
            {
                Nombre = "Mochila urbana",
                Descripcion = "Con espacio para laptop y cuadernos.",
                Precio = 499.00m,
                Detalle = "Mochila de uso diario con bolsillo frontal.",
                Foto = "mochila.jpg"
            },
            new Producto
            {
                Nombre = "Libreta A5",
                Descripcion = "80 hojas rayadas con pasta dura.",
                Precio = 89.50m,
                Detalle = "Libreta de calidad con pasta dura.",
                Foto = "cuaderno.jpg"
            },
            new Producto
            {
                Nombre = "Termo de acero",
                Descripcion = "Botella reutilizable de 500 ml.",
                Precio = 219.00m,
                Detalle = "Termo de acero inoxidable con tapa a rosca.",
                Foto = "termo.jpg"
            },
            new Producto
            {
                Nombre = "Lapiz",
                Descripcion = "Lapiz de grafito de 0.7 mm.",
                Precio = 15.00m,
                Detalle = "Lapiz de calidad con punta de grafito.",
                Foto = "lapiz.jpg"
            }

        };
    }
}
