//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace gmc_v_2_0.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string real_name { get; set; }
        public string password { get; set; }
        public string avatar { get; set; }
        public Nullable<int> gender { get; set; }
        public Nullable<int> is_validation { get; set; }
        public Nullable<int> is_can_login { get; set; }
    }
}
