﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.DTO.Orders
{
	public class CreateOrderDto
	{
		public int CustomerId { get; set; }
        public string Status { get; set; }
        public double TotalAmount { get; set; }
        public string PaymentMethod { get; set; }

        public DeliveryDetailsDto DeliveryDetails { get; set; }
	}
}
