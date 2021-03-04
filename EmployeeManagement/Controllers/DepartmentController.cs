using System.Linq;
using Microsoft.AspNetCore.Mvc;
public class DepartmentController : Controller
{
    private readonly EMSContext db;

    public DepartmentController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        //var db = new EMSContext();
        var departments = db.Departments.ToList();

        return View(departments);
    }

    public ActionResult Add()
    {
        return View();
    }


    [HttpPost]
    public ActionResult Add([FromForm] Department department)
    {
        db.Departments.Add(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}

