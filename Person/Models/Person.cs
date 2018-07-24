﻿using System;
using System.Collections.Generic;

namespace Person.Models
{
	public class Person
	{
		public int PersonId { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string MiddleName { get; set; }

		public DateTime Birthday { get; set; }

		public string Address { get; set; }

		public List<Person> Relatives { get; set; }
	}
}