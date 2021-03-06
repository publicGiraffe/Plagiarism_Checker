﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Plagiarism_Checker.Models;
using Plagiarism_Checker.Models.AdminDTO;
using Plagiarism_Checker.Rpositories;

namespace Plagiarism_Checker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<User> userManager, SignInManager<User> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        
        public IActionResult UsersList()
        {
            AllUsers users = new AllUsers();
            List<User> teachers = _userManager.GetUsersInRoleAsync("Teacher").Result.ToList();
            List<User> students = _userManager.GetUsersInRoleAsync("Student").Result.ToList();
            foreach (var u in teachers)
            {
                users.allTeachers.Add(new _User(u.Id,u.UserName + ' ' + u.surname));
            }
            foreach (var u in students)
            {
                users.allStudents.Add(new _User(u.Id, u.UserName + ' ' + u.surname));
            }
            return View(users);
        }

        public void DeleteUser(string id)
        {
            
        }
    }
}