//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class engage_interview
    {
        public short ein_id { get; set; }
        public string human_name { get; set; }
        public Nullable<short> interview_amount { get; set; }
        public string human_major_kind_id { get; set; }
        public string human_major_kind_name { get; set; }
        public string human_major_id { get; set; }
        public string human_major_name { get; set; }
        public string image_degree { get; set; }
        public string native_language_degree { get; set; }
        public string foreign_language_degree { get; set; }
        public string response_speed_degree { get; set; }
        public string EQ_degree { get; set; }
        public string IQ_degree { get; set; }
        public string multi_quality_degree { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public Nullable<System.DateTime> registe_time { get; set; }
        public Nullable<System.DateTime> check_time { get; set; }
        public Nullable<short> resume_id { get; set; }
        public string result { get; set; }
        public string interview_comment { get; set; }
        public string check_comment { get; set; }
        public Nullable<short> interview_status { get; set; }
        public Nullable<short> check_status { get; set; }
    }
}
