﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonFoShiz.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int ContactId { get; set; }
        public int EventId { get; set; }
        public bool IsActive { get; set; }

    }
}