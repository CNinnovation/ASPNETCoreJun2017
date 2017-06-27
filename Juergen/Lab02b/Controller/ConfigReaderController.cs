using Lab02.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    public class ConfigReaderController
    {

        ConfigSettings _settings;

        Caching _caching;

        public ConfigReaderController() { }
        public ConfigReaderController(IOptions<ConfigSettings> settings, IOptions<Caching> caching)
        {
            _settings = settings.Value;
            _caching = caching.Value;
        }

        public string GetConnString()
        {
           return _settings.ConnectionString;
        }

        public void GetCachingInfos()
        {
            Console.WriteLine("Caching: " + _caching.Enabled + ", Duration: " + _caching.Duration);
        }
    }
}
