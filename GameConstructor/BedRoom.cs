namespace GameConstructor
{
    public class BedRoom : IRoom
    {
        protected string _Name { get; set; }
        public BedRoom(string name)
        {
            this._Name = $"{name} room";
        }
        public string GetName()
        {
            return this._Name;
        }
    }

}
