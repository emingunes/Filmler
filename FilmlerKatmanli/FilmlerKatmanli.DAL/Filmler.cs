//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmlerKatmanli.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Filmler
    {
        public Filmler()
        {
            this.FilmOyuncular = new HashSet<FilmOyuncular>();
        }
    
        public int FilmId { get; set; }
        public string FilmAdi { get; set; }
        public Nullable<System.DateTime> YayinTarihi { get; set; }
        public Nullable<int> YonetmenId { get; set; }
    
        public virtual Yonetmenler Yonetmenler { get; set; }
        public virtual ICollection<FilmOyuncular> FilmOyuncular { get; set; }
    }
}
