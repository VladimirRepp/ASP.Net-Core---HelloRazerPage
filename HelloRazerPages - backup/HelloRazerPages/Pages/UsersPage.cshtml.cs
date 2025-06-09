using HelloRazerPages.Models;
using HelloRazerPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloRazerPages.Pages
{
    public class UsersPage : PageModel
    {
        private readonly UserService _userService;

        [BindProperty]
        public User CurrentUser { get; set; } = new User();

        public List<User> Users => _userService.GetAll();

        public UsersPage(UserService userService)
        {
            _userService = userService;
        }

        public void OnGet() { }

        public JsonResult OnGetUser(int id)
        {
            var user = _userService.GetById(id);
            return new JsonResult(user);
        }

        public IActionResult OnPostSave()
        {
            bool isResult; 
            
            if (CurrentUser.Id == 0)
                isResult = (CurrentUser = _userService.Add(CurrentUser)).Id != 0 ? true : false;
            else
                isResult = _userService.Update(CurrentUser);

            return RedirectToPage();
        }

        public JsonResult OnPostDelete(int id)
        {
            bool isResult = _userService.Delete(id);
            return new JsonResult(new { success = isResult });
        }
    }
}
