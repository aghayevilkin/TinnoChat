using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tinno.Data;
using Tinno.Models;

namespace Tinno.Hubs
{
    public class Chathub : Hub
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public Chathub(AppDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task SendMessage(string friendId, string message)
        {
            string userId = _userManager.GetUserId(Context.User);

            //datetime
            DateTime serverTime = DateTime.Now;
            DateTime utcTime = serverTime.ToUniversalTime();
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
            DateTime date = localTime;
            bool countUp = false;
            if (!_context.Messages.Any(m => m.RecieverId == friendId && m.SenderId == userId && m.IsRead == false))
            {
                countUp = true;
            }

            Message newMessage = new Message()
            {
                SenderId = userId,
                RecieverId = friendId,
                MessageText = message,
                Date = date,
                IsRead = false
            };

            _context.Messages.Add(newMessage);
            _context.SaveChanges();

            await Clients.User(friendId).SendAsync("ReceiveMessage", message, date, countUp, userId);
        }




        public async override Task OnConnectedAsync()
        {
            CustomUser customUser = _context.CustomUsers.Find(_userManager.GetUserId(Context.User));
            customUser.IsActive = true;
            _context.CustomUsers.Update(customUser);
            _context.SaveChanges();

            bool isActive = true;
            string userId = _userManager.GetUserId(Context.User);
            await Clients.All.SendAsync("ChangeActiveStatus", isActive, userId);

        }

        public async override Task OnDisconnectedAsync(Exception ex)
        {
            CustomUser customUser = _context.CustomUsers.Find(_userManager.GetUserId(Context.User));
            customUser.IsActive = false;
            _context.CustomUsers.Update(customUser);
            _context.SaveChanges();

            bool isActive = false;
            string userId = _userManager.GetUserId(Context.User);
            await Clients.All.SendAsync("ChangeActiveStatus", isActive, userId);
        }



    }
}
