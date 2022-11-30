using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTask.Application
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository _repository;
    }
}
