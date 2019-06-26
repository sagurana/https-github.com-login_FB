﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceBook_Login_MVC.Models
{
    public class FaceBookUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
    }
}