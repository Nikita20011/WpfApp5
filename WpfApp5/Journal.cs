//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int ID { get; set; }
        public int ID_students { get; set; }
        public int Evaluation { get; set; }
        public int ID_group { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Group Group { get; set; }
    }
}