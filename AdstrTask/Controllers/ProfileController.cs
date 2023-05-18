﻿using AdstrTask.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AdstrTask.Controllers
{
    public class ProfileController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        // تم تحديث بيانات المستخدم بنجاح
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        // حدث خطأ أثناء تحديث بيانات المستخدم
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    // المستخدم غير موجود
                    ModelState.AddModelError("", "User not found.");
                }
            }

            // إعادة عرض الصفحة في حالة وجود أخطاء في الإدخال
            return View(model);
        }
    }

}

