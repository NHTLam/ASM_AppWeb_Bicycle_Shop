using ASM_AppWeb_Bicycle_Shop.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASM_AppWeb_Bicycle_Shop.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly ASM_AppWeb_Bicycle_ShopContext _context;

        public AdminController(ASM_AppWeb_Bicycle_ShopContext context)
        {
            _context = context;
        }
        // GET: AdminController
        public ActionResult Index()
        {
            ViewBag.monthlyRevenue = GetMonthlyRevenue();
            ViewBag.earningAnnual = GetEarningAnnual();
            return View();
        }

        public ActionResult StatisticalReport()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetData()
        {
            var data = DatForChart();
            return Json(data);
        }

        private decimal GetMonthlyRevenue()
        {
            var data = _context.Shop.ToList();
            decimal sum = 0;
            foreach (var item in data)
            {
                if(item.Purchase_date.Month == DateTime.Now.Month)
                {
                    sum += item.TotalRevenue;
                }
            }
            return sum;
        }

        private decimal GetEarningAnnual()
        {
            var data = _context.Shop.ToList();
            decimal sum = 0;
            foreach (var item in data)
            {
                if (item.Purchase_date.Year == DateTime.Now.Year)
                {
                    sum += item.TotalRevenue;
                }
            }
            return sum;
        }

        private List<decimal> DatForChart()
        {
            List<decimal> colectedData = new List<decimal>();
            var data = _context.Shop.ToList();
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
            decimal sum4 = 0;
            decimal sum5 = 0;
            decimal sum6 = 0;
            decimal sum7 = 0;
            decimal sum8 = 0;
            decimal sum9 = 0;
            decimal sum10 = 0;
            decimal sum11 = 0;
            decimal sum12 = 0;
            foreach (var item in data)
            {              
                if (item.Purchase_date.Month == 1)
                {
                    sum1 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 2)
                {
                    sum2 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 3)
                {
                    sum3 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 4)
                {
                    sum4 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 5)
                {
                    sum5 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 6)
                {
                    sum6 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 7)
                {
                    sum7 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 8)
                {
                    sum8 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 9)
                {
                    sum9 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 10)
                {
                    sum10 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 11)
                {
                    sum11 += item.TotalRevenue;
                }
            }
            foreach (var item in data)
            {
                if (item.Purchase_date.Month == 12)
                {
                    sum12 += item.TotalRevenue;
                }
            }
            colectedData.Add(sum1);
            colectedData.Add(sum2);
            colectedData.Add(sum3);
            colectedData.Add(sum4);
            colectedData.Add(sum5);
            colectedData.Add(sum6);
            colectedData.Add(sum7);
            colectedData.Add(sum8);
            colectedData.Add(sum9);
            colectedData.Add(sum10);
            colectedData.Add(sum11);
            colectedData.Add(sum12);
            return colectedData;
        }
    }
}
