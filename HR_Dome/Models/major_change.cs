//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class major_change
    {
        public short mch_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public string new_first_kind_id { get; set; }
        public string new_first_kind_name { get; set; }
        public string new_second_kind_id { get; set; }
        public string new_second_kind_name { get; set; }
        public string new_third_kind_id { get; set; }
        public string new_third_kind_name { get; set; }
        public string new_major_kind_id { get; set; }
        public string new_major_kind_name { get; set; }
        public string new_major_id { get; set; }
        public string new_major_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string salary_standard_id { get; set; }
        public string salary_standard_name { get; set; }
        public Nullable<decimal> salary_sum { get; set; }
        public string new_salary_standard_id { get; set; }
        public string new_salary_standard_name { get; set; }
        public Nullable<decimal> new_salary_sum { get; set; }
        public string change_reason { get; set; }
        public string check_reason { get; set; }
        public Nullable<short> check_status { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public Nullable<System.DateTime> regist_time { get; set; }
        public Nullable<System.DateTime> check_time { get; set; }
    }
}