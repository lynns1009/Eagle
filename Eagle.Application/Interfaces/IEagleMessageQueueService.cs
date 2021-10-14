﻿using Eagle.Domain;
using Eagle.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eagle.Application.Interfaces
{
    public interface IEagleMessageQueueService
	{
		public void SendMessage(string messageBody);
	}
}
