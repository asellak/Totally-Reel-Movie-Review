using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using TRMR.Models;
using TRMR.Data;

namespace TRMR.Pages
{
    public class SelfProfileModel : PageModel
    {
        private readonly ILogger<ProfileModel> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public SelfProfileModel(UserManager<ApplicationUser> userManager, ILogger<ProfileModel> logger, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _logger = logger;
            _dbContext = dbContext;
        }

        [BindProperty]
        public ApplicationUser CurrentUser  {get; set;}


        public async Task<IActionResult> OnGet() 
        {
            this.CurrentUser = await _userManager.GetUserAsync(User);

            return Page();  

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var id = _userManager.GetUserId(User); 
            var dbuser = _dbContext.Users.Find(id);  // dbuser will be one instance of an ApplicationUser

            dbuser.Bio = CurrentUser.Bio; // and so on
            dbuser.FavGenre = CurrentUser.FavGenre;
            dbuser.FavMovie = CurrentUser.FavMovie;

            await _dbContext.SaveChangesAsync();


            return Redirect("./SelfProfile");
        }



    }
}
