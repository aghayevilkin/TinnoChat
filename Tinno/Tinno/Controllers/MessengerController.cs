using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tinno.Data;
using Tinno.Models;
using Tinno.ViewModels;

namespace Tinno.Controllers
{
    [Authorize]
    public class MessengerController : BaseController
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public MessengerController(AppDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            string userId = _userManager.GetUserId(User);

            VmBase model = new VmBase()
            {
                CustomUsers = _context.CustomUsers.Where(u => u.Id != userId).ToList(),
            };

            return View(model);
        }

        public IActionResult Chat(string friendId)
        {
            if (friendId == null)
            {
                return NotFound();
            }

            string userId = _userManager.GetUserId(User);

            ViewBag.Friend = _context.CustomUsers.Find(friendId);
            ViewBag.FriendNameSubstring = _context.CustomUsers.Find(friendId).Name.Substring(0, 1);

            List<Message> messages = _context.Messages.Include(u => u.Sender)
                                                      .Where(m => (m.SenderId == friendId && m.RecieverId == userId) ||
                                                                  (m.SenderId == userId && m.RecieverId == friendId))
                                                      .OrderBy(o => o.Date)
                                                      .ToList();

            foreach (var item in messages)
            {
                item.IsRead = true;
                _context.Update(item);
            }
            _context.SaveChanges();

            VmBase model = new VmBase()
            {
                Messages = messages,
                Customuser = _context.CustomUsers.Find(userId),
            };

            return View(model);
        }
    }
}
