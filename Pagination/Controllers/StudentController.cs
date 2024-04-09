using Microsoft.AspNetCore.Mvc;
using Pagination.Data;
using Pagination.Models;

namespace Pagination.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList = _db.Students;
            return View(objStudentList);
        }

        //public IActionResult GetData(JqueryDatatableParam param)
        //{
        //    //var query = _db.Students.AsQueryable();

        //    IEnumerable<Student> objSubjectList = _db.Students;
        //    var query = objSubjectList;

        //    // Search
        //    if (!string.IsNullOrEmpty(param.sSearch))
        //    {
        //        query = query.Where(x =>
        //            x.Name.ToLower().Contains(param.sSearch.ToLower()) ||
        //            x.Position.ToLower().Contains(param.sSearch.ToLower()) ||
        //            x.Location.ToLower().Contains(param.sSearch.ToLower()) ||
        //            x.Salary.ToString().Contains(param.sSearch.ToLower()) ||
        //            x.Age.ToString().Contains(param.sSearch.ToLower()) ||
        //            x.StartDate.ToString("dd/MM/yyyy").ToLower().Contains(param.sSearch.ToLower())
        //        );
        //    }

        //    // Sorting
        //    var sortColumnIndex = param.iSortCol_0;
        //    var sortDirection = param.sSortDir_0;

        //    switch (sortColumnIndex)
        //    {
        //        case 3:
        //            query = sortDirection == "asc" ? query.OrderBy(c => c.Age) : query.OrderByDescending(c => c.Age);
        //            break;
        //        case 4:
        //            query = sortDirection == "asc" ? query.OrderBy(c => c.StartDate) : query.OrderByDescending(c => c.StartDate);
        //            break;
        //        case 5:
        //            query = sortDirection == "asc" ? query.OrderBy(c => c.Salary) : query.OrderByDescending(c => c.Salary);
        //            break;
        //        default:
        //            query = sortDirection == "asc" ? query.OrderBy(x => x.Name) : query.OrderByDescending(x => x.Name);
        //            break;
        //    }

        //    // Pagination
        //    var totalRecords = query.Count();
        //    var displayResult = query.Skip(param.iDisplayStart).Take(param.iDisplayLength).ToList();

        //    Console.WriteLine($"Total records: {totalRecords}");
        //    Console.WriteLine($"Display result: {string.Join(",", displayResult.Select(x => x.Name))}");

        //    return Json(new
        //    {
        //        param.sEcho,
        //        iTotalRecords = totalRecords,
        //        iTotalDisplayRecords = totalRecords,
        //        aaData = displayResult
        //    });
        //}


    }
}
