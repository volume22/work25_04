//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableEquipmentHistory
    {
        public int intEquipmentHistoryId { get; set; }
        public Nullable<int> intEquipmentID { get; set; }
        public Nullable<int> intTypeHistory { get; set; }
        public Nullable<System.DateTime> dStartDate { get; set; }
        public Nullable<System.DateTime> dEndDate { get; set; }
        public Nullable<int> intDaysCount { get; set; }
        public Nullable<int> intStatys { get; set; }
        public Nullable<int> intUserId { get; set; }
        public Nullable<System.DateTime> dCahengeDate { get; set; }
    
        public virtual newEquipment newEquipment { get; set; }
    }
}
