using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces;

public interface ICourseService
{
    CourseViewModel GetCourses();
}