using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Models;

namespace MultiClientArchitecture.Repository.Client.Interface
{
	public interface IClientRepository
	{
		ClientRecord OfClient { get; set; }
	}
}
