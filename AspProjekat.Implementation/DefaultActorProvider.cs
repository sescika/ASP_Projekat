﻿using AspProjekat.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspProjekat.Implementation
{
	public class DefaultActorProvide : IApplicationActorProvider
	{
		public IApplicationActor GetActor()
		{
			return new Actor
			{
				Username = "test",
				//Email = "test",
				Id = 0,
				//FirstName = "Test",
				//LastName = "Test",
			};
		}
	}
}
