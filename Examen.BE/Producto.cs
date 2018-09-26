using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Examen.BE
{
    [DataContract]
   public class Producto
    {

        public Producto()
        {
            Marca = new HashSet<Marca>();
        }
        [DataMember]
        public int AnioCampania { get; set; }
        [DataMember]
        public string   Cuv { get; set; }
        [DataMember]
        public int  MarcaID { get; set; }
        [DataMember]
        public decimal   Precio { get; set; }
        [DataMember]
        public string    Descripcion { get; set; }
        [DataMember]
        public string CodigoTipoOferta { get; set; }
        [DataMember]
        public string   CodigoSAP{ get; set; }
        [DataMember]
        public float  EstadoActivo { get; set; }


        [DataMember]
        public virtual ICollection<Marca> Marca { get; set; }
    }
}
