﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsShelterBackend.Domain.Tokens
{
	public class RefreshToken
	{
		public Guid Id { get; set; }
		public string Token { get; set; }
		public DateTime ExpiresAt { get; set; }
		public Guid UserId { get; set; }
	}
}
