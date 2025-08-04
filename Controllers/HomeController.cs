using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Klinik.Models;
using Microsoft.EntityFrameworkCore;

namespace Klinik.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ApplicationDbContext _context = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public ViewResult Doctors( int page = 1)
    {
        // This method would typically retrieve a list of doctors from a database or service.
        
        var doctors = _context.Doctors.Include(e => e.Category).AsQueryable();

        // Pagination
        double totalPages = Math.Ceiling(doctors.Count() / 8.0);
        int currentPage = page;

        ViewBag.TotalPages = totalPages;
        ViewBag.CurrentPage = currentPage;

        doctors = doctors.Skip((page -1) * 8).Take(8);
        return View(doctors.ToList());
    }
    
    
    public IActionResult Specialties()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Appointment(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
    
    public IActionResult Appointment([FromRoute] int id)
    {
        var doctor = _context.Doctors.Include(e => e.Category).FirstOrDefault(e => e.Id == id);

        if (doctor is null)
            return NotFound();
        return View(doctor);
    }
    
    public ViewResult Appointments( int page = 1)
    {
        var appointments = _context.Appointments.Include(e => e.Doctor).AsQueryable();

        // Pagination
        double totalPages = Math.Ceiling(appointments.Count() / 8.0);
        int currentPage = page;

        ViewBag.TotalPages = totalPages;
        ViewBag.CurrentPage = currentPage;

        appointments = appointments.Skip((page -1) * 8).Take(8);
        return View(appointments.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}