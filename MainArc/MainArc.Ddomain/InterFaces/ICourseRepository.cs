using System;
using System.Collections.Generic;
using System.Text;

namespace MainArc.Ddomain.InterFaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
