using CleanArc.Domain.Models;

namespace CleanArc.Domain.Interfaces;

public interface ICourseRepository
{
    IEnumerable<Course> GetCourses();
}