using System.Collections.Generic;

namespace Luxonish
{
    public class Settings
    {
        private readonly Dictionary<string, string?> _settings = new Dictionary<string, string?>();

        public static Settings Default => new Settings
        {
            DefaultLocale = "en",
            DefaultNumberingSystem = null,
            DefaultOutputCalendar = "gregorian"
        };

        public string? DefaultLocale
        {
            get => _settings[nameof(DefaultLocale)];
            set => _settings[nameof(DefaultLocale)] = value;
        }

        public string? DefaultNumberingSystem
        {
            get => _settings[nameof(DefaultNumberingSystem)];
            set => _settings[nameof(DefaultNumberingSystem)] = value;
        }

        public string? DefaultOutputCalendar
        {
            get => _settings[nameof(DefaultOutputCalendar)];
            set => _settings[nameof(DefaultOutputCalendar)] = value;
        }

        public string? this[string key]
        {
            get => _settings[key];
            set => _settings[key] = value;
        }
    }
}
