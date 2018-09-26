using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Examen.BE
{
    [DataContract]
    public  class Pedido
    {
        [DataMember]
        public int   PedidoID { get; set; }
        [DataMember]
        public string    Usuario { get; set; }
        [DataMember]
        public int AnioCampania { get; set; }
        [DataMember]
        public string Cuv { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
    }
}
