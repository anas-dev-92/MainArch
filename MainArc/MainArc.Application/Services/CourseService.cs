using MainArc.Application.InterFaces;
using MainArc.Application.ViewModel;
using MainArc.Ddomain.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainArc.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
