using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Examen.BE
{
    [DataContract]
    public class Marca
    {
        [DataMember]
        public int MarcaID { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
