using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Data;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private readonly AppDbContext _context;

    public CourseController(AppDbContext context)
    {
        _context = context;
    }

    // Everyone logged in can view courses
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        return Ok(await _context.Courses.ToListAsync());
    }

    // Admin & Faculty can create courses
    [Authorize(Roles = "Admin,Faculty")]
    [HttpPost]
    public async Task<IActionResult> AddCourse(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
        return Ok(course);
    }

    // Admin & Faculty can edit
    [Authorize(Roles = "Admin,Faculty")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCourse(int id, Course course)
    {
        var existing = await _context.Courses.FindAsync(id);
        if (existing == null) return NotFound();

        existing.Name = course.Name;
        existing.Description = course.Description;
        existing.Credits = course.Credits;

        await _context.SaveChangesAsync();
        return Ok(existing);
    }

    // Admin only can delete
    [Authorize(Roles = "Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCourse(int id)
    {
        var course = await _context.Courses.FindAsync(id);
        if (course == null) return NotFound();

        _context.Courses.Remove(course);
        await _context.SaveChangesAsync();

        return Ok("Course Deleted");
    }
}