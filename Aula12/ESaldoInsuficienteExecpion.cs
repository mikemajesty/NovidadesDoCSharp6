using System;
using System.Runtime.Serialization;

namespace Aula12
{
    [Serializable]
    public class ESaldoInsuficienteExecpion : Exception
    {
        public ESaldoInsuficienteExecpion()
        {
        }

        public ESaldoInsuficienteExecpion(string message) : base(message)
        {
        }

        public ESaldoInsuficienteExecpion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ESaldoInsuficienteExecpion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}