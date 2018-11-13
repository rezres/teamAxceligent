namespace GameConstructor
{
    public class Balcony : IRoom
    {
        protected string _Name { get; set; }
        public Balcony()
        {
            this._Name = "balcony";
        }
        public string GetName()
        {
            return this._Name;
        }
    }

}
