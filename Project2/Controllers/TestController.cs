using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Project2.Models;

public class TestController : Controller
{
    // Sample data to display in the dropdown list
    private List<TestItem> tests = new List<TestItem>
    {
        new TestItem { SlNo = 17, Code = "H10P", TestName = "ACBC- COMPLETE BLOOD PICTURE", MRP = 250, B2CPrice = 200, LabB2B = 70 },
        new TestItem { SlNo = 74, Code = "M09", TestName = "Anaerobic Blood Culture", MRP = 1100, B2CPrice = 880, LabB2B = 485 },
        new TestItem { SlNo = 127, Code = "C188", TestName = "BCR-ABL Quantitative(PCR)", MRP = 7000, B2CPrice =5600, LabB2B = 4320 },
        new TestItem { SlNo = 128, Code = "MB01", TestName = "BCR-ABL(9:2)Qualitative", MRP = 4000, B2CPrice = 3200, LabB2B = 2700 },
        new TestItem { SlNo = 129, Code = "MB02", TestName = "BCR-ABL(9:2)Quantitative", MRP = 150, B2CPrice = 3200, LabB2B = 3700 },
        new TestItem { SlNo = 158, Code = "H66", TestName = "Bleeding Time-Clottng Time(BT-CT)", MRP = 150, B2CPrice = 120, LabB2B = 80 },
        new TestItem { SlNo = 159, Code = "H05", TestName = "Bleeding Time", MRP = 150, B2CPrice = 120, LabB2B = 80 },
        new TestItem { SlNo = 160, Code = "H06", TestName = "Blood Grouping(A,B,O)and Rh factor", MRP = 150, B2CPrice = 120, LabB2B = 45 },
        new TestItem { SlNo = 161, Code = "BC060", TestName = "Blood Urea Nitrogen/Creatinine Ratio", MRP = 200, B2CPrice = 160, LabB2B = 65 },
        new TestItem { SlNo = 187, Code = "H10", TestName = "CBC-Complete Blood Count", MRP = 150, B2CPrice = 120, LabB2B = 55 },
        new TestItem { SlNo = 188, Code = "H10P", TestName = "CBP-Complete Blood Picture", MRP = 250, B2CPrice = 220, LabB2B = 70 },







        // Add more test data here...
    };

    // GET: Test
    public ActionResult Index()
    {
        return View(tests);  // Pass the list of tests to the view
    }

    // POST: Submit selected tests
    [HttpPost]
    public ActionResult SubmitSelectedTests(List<int> selectedTests)
    {
        var selectedTestDetails = tests.Where(t => selectedTests.Contains(t.SlNo)).ToList();
        return View("SelectedTests", selectedTestDetails);  // Pass selected tests to the view
    }
}

