using Lab03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03.Controller
{
    public class SampleController
    {
        ISampleService _service;

        public SampleController(ISampleService service)
        {
            _service = service;
        }

        public string Index()
        {
            return _service.DoSomething();
        }
    }
}
