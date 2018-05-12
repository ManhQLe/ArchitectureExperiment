﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Repository.Client.Interface;
using Ninject;

namespace MultiClientArchitecture.Factory
{
	public interface IClientRepositoryFactory: IBaseFactory
	{
		T GetClientRepository<T>(int clientId) where T : IClientRepository;
	}
}
