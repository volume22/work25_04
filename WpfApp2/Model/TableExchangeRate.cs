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
    
    public partial class TableExchangeRate
    {
        public int intExchangeRateId { get; set; }
        public Nullable<int> intCurrencyId { get; set; }
        public Nullable<double> fRate { get; set; }
        public Nullable<System.DateTime> dDateRate { get; set; }
    
        public virtual TablesCurrency TablesCurrency { get; set; }
    }
}
