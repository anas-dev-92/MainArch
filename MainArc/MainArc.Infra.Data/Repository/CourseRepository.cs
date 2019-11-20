using MainArc.Ddomain;
using MainArc.Ddomain.InterFaces;
using MainArc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainArc.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _Universitydbcontext;
        public CourseRepository (UniversityDBContext Universitydbcontext)
        {
            _Universitydbcontext = Universitydbcontext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _Universitydbcontext.Courses;
        }
    }
}
