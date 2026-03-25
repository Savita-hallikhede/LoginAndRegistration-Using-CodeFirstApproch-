using code_second_approch.Appdata;
using code_second_approch.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace code_second_approch.Controllers
{

    public class RegController : Controller
    {
        private readonly mainCode _mainCode;
        public RegController(mainCode mainCode)
        {
            _mainCode = mainCode;
        }

        public IActionResult dataShow()
        {
            List<register> Table_data = _mainCode.registers.ToList();
            return View(Table_data);
        }
        [HttpGet]
        public IActionResult gettingdata  ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult gettingdata(register register)
         {
            register reg = new register()
            {
               Name = register.Name,
               Email = register.Email,
               Password = register.Password,
               ConfirmPassword = register.ConfirmPassword,
               Phone = register.Phone
            };
            _mainCode.registers.Add(reg);
            _mainCode.SaveChanges();
            return RedirectToAction("dataShow");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            register onerow= _mainCode.registers.Where(r => r.ID == id).FirstOrDefault();
            return View(onerow);
        }

        [HttpPost]
        public IActionResult Edit(register data)
        {
            _mainCode.registers.Update(data);
            _mainCode.SaveChanges();
            return RedirectToAction("dataShow");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            register onerow = _mainCode.registers.FirstOrDefault(r => r.ID == id);
            if (onerow == null)
            {
                return NotFound(); // record not found
            }
            _mainCode.registers.Remove(onerow);
            _mainCode.SaveChanges();
            return RedirectToAction("dataShow");
            //  return View(onerow);
        }

        //[HttpPost]
        //public IActionResult Delete(register onerow)
        //{
        //    _mainCode.registers.Remove(onerow);
        //    _mainCode.SaveChanges();
        //    return RedirectToAction("dataShow");
        //}

    }


}
        
