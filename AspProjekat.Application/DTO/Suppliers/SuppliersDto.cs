﻿	using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.DTO.Suppliers
{
	public class SuppliersDto
	{
        public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Phone { get; set; }
    }
}
