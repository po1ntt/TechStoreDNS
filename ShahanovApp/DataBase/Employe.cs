//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShahanovApp.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employe
    {
        public int id_emp { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public Nullable<int> post_id { get; set; }
        public Nullable<int> dep_id { get; set; }
        public Nullable<int> Experience { get; set; }
        public string FIO { get; set; }
        public virtual Departament Departament { get; set; }
        public virtual Post Post { get; set; }
    }
}