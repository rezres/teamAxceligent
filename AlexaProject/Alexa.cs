using System;

namespace AlexaProject
{
    public class Alexa
    {
        //Use shadow property to control object contrsuction 
        private Settings _settings { get; set; }
        private Settings Settings
        {
            get
            {
                if (this._settings == null)
                    this._settings = new Settings();
                return this._settings;
            }
            set
            {
                this._settings = value;
            }
        }

        public string Talk()
        {
            return Settings.GreetingMessage;
        }
        public void Configure(Action<Settings> setting)
        {
            setting.Invoke(Settings);
        }
    }
}
