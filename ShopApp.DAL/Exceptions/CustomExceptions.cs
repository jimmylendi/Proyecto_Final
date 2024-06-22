
using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
using System;

namespace ShopApp.DAL.Exceptions
{
    public class EntidadNoEncontradaException : Exception
    {
        public EntidadNoEncontradaException() : base() { }
        public EntidadNoEncontradaException(string message) : base(message) { }
        public EntidadNoEncontradaException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class EntidadYaEliminadaException : Exception
    {
        public EntidadYaEliminadaException() : base() { }
        public EntidadYaEliminadaException(string message) : base(message) { }
        public EntidadYaEliminadaException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class OperacionBaseDatosException : Exception
    {
        public OperacionBaseDatosException() : base() { }
        public OperacionBaseDatosException(string message) : base(message) { }
        public OperacionBaseDatosException(string message, Exception innerException) : base(message, innerException) { }
    }
}
