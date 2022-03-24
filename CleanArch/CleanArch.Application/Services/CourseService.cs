using CleanArc.Domain.Interfaces;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services;

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