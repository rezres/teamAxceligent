namespace AlexaProject
{
    public class Settings
    {
        public string OwnerName { get; set; }
        private string _GreetingMessage { get; set; }
        public string GreetingMessage
        {
            get
            {
                if (string.IsNullOrEmpty(this.OwnerName))
                    return "hello, i am Alexa";
                else
                    return this._GreetingMessage.Replace("{OwnerName}", this.OwnerName);
            }
            set
            {
                this._GreetingMessage = value;
            }
        }
    }
}
