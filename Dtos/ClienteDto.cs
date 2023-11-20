﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Dtos
{
    internal class ClienteDto
    {
        long idCliente;

        string nombreCliente;

        string apellidosClientes;

        string DNI;

        int TLF;

        string fechaNacimiento;

        string fechaAlta;

        string fechaBaja = "12/31/9999";

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosClientes { get => apellidosClientes; set => apellidosClientes = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public int TLF1 { get => TLF; set => TLF = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }

        public ClienteDto(long idCliente, string nombreCliente, string apellidosClientes, string dNI, int tLF, string fechaNacimiento, string fechaAlta, string fechaBaja)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosClientes = apellidosClientes;
            DNI = dNI;
            TLF = tLF;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
        }

        public ClienteDto()
        {

        }

        public string ToString()
        {
            string todoCliente =
                "Nombre--> " + nombreCliente
                + "Apellidos--> " + apellidosClientes
                + "DNI--> " + DNI
                + "Telefono--> " + TLF
                + "Fecha de Nacimiento--> " + fechaNacimiento
                + "Fecha de Alta--> " + fechaAlta
                 + "Fecha de Baja--> " + fechaBaja;

            return todoCliente;
        }
    }
}