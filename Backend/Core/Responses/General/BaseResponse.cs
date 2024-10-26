﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Responses.General
{
	public abstract class BaseResponse
	{
		public required bool IsSuccess { get; set; }
		public string Message { get; set; }
	}
}
