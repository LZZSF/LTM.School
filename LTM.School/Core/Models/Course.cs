﻿using LTM.School.Application.enumsType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public CourseGrade Grade { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
