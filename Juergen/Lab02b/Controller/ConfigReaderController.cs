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

        public ConfigReaderController(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
        }

        public string GetConnString()
        {
           return _settings.ConnectionString;
        }
    }
}
