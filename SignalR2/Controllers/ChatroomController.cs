﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR2.Controllers
{
    [Authorize]
    public class ChatroomController : Controller
    {
        // GET: Chatroom
        public ActionResult Index()
        {
            return View();
        }
    }
}