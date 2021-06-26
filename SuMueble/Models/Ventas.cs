﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.Models
{
    [Table("Ventas")]
    public class Ventas
    {
        [ExplicitKey]
        public Guid ID { get; set; }

        [Write(false)]
        [Computed]
        public int CodigoFactura { get; set; }
        public string IDCliente { 
            get { return this.Cliente.DNI; }
            set { IDCliente = value; } 
        }
        public string IDColaborador { get; set; }
        public int IDTipoVenta { get; set; }
        public float Prima { get; set; }
        public int Cuotas { get; set; }

        [Write(false)]
        [Computed]
        public DateTime FechaInicio { get; set; }
        
        [Computed]
        public DateTime FechaFin { get; set; }

        // propiedades con de la parte programable
        [Write(false)]
        [Computed]
        public List<DetallesVentas> DetallesVenta { get; set; }

        [Write(false)]
        [Computed]
        public Clientes Cliente { get; set; }


    }
}