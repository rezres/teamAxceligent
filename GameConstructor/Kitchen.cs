namespace GameConstructor
{
    public class Kitchen : IRoom
    {
        protected string _Name { get; set; }
        public Kitchen() {
            this._Name = "kitchen";
        }
        public string GetName()
        {
            return this._Name;
        }
    }

}
