//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Records
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Records()
        {
            this.Pictures = new HashSet<Pictures>();
        }
    
        public System.Guid RecordID { get; set; }
        public System.Guid FaultTypeID { get; set; }
        public string Conclusion { get; set; }
        public string Timestamp { get; set; }
        public System.DateTime Inserted { get; set; }
    
        public virtual FaultTypes FaultTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pictures> Pictures { get; set; }
    }
}
