using System.Collections.Generic;
using System.Linq;

namespace GameConstructor
{
    public class Building
    {
        private List<IRoom> Rooms { get; set; }
        private string Description { get; set; }

        public Building()
        {
            this.Rooms = new List<IRoom>();
        }
        public Building AddKitchen() {
            this.Rooms.Add(new Kitchen());
            return this;
        }
        public Building AddBalcony()
        {
            this.Rooms.Add(new Balcony());
            return this;
        }
        public Building AddBedroom(string name)
        {
            this.Rooms.Add(new BedRoom(name));
            return this;
        }
        public void  Build() {
            this.Description = string.Join(", ", this.Rooms.Select(t => t.GetName()));
        }
        public string Describe() {
            return this.Description;
        }
    }

}
