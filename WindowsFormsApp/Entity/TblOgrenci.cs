//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOgrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblOgrenci()
        {
            this.TblNotlar = new HashSet<TblNotlar>();
        }
    
        public int OgrId { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrNumara { get; set; }
        public string OgrSifre { get; set; }
        public string OgrMail { get; set; }
        public string OgrResim { get; set; }
        public Nullable<int> OgrBolum { get; set; }
        public Nullable<bool> OgrDurum { get; set; }
    
        public virtual TblBolumler TblBolumler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblNotlar> TblNotlar { get; set; }
    }
}
