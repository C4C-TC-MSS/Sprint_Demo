using System;
using System.Collections.Generic;

namespace TC_Sprint.Data.Certification
{
    public class Certification
    {
        public string Name { get; set; }
        public int QualifyingServiceYears { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Education> EducationList { get; set; }

        public Certification()
        {
            Exams = new List<Exam>();
            EducationList = new List<Education>();
        }
    }
}

