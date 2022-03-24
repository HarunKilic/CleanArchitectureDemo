using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository;

public class CourseRepository : ICourseRepository
{
    private readonly UniversityDBContext _context;

    public CourseRepository(UniversityDBContext context)
    {
        _context = context;
    }

    public IEnumerable<Course> GetCourses()
    {
        return _context.Courses;
    }
}