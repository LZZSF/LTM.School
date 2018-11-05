using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("学生姓名")]
        public string RealName { get; set; }
        [DisplayName("入学时间")]
        public DateTime EnrollmentDate { get; set; }
        [DisplayName("注册信息")]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
