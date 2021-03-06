﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SysCustomer.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int GenderId { get; set; }

        public int CityId { get; set; }

        public int RegionId { get; set; }

        public DateTime LastPurchase { get; set; }

        public int ClassificationId { get; set; }

        public string UserId { get; set; }

    }
}
