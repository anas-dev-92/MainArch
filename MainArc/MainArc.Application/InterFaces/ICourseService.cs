using MainArc.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainArc.Application.InterFaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
