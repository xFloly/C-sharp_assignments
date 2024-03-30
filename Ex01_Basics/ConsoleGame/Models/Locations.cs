namespace homework1
{
    public class Location
    {
        public string Name { get; set; }
        public NonPlayerCharacter[] npcList { get; set; }

        public Location(string Name, params NonPlayerCharacter[] npcs)
        {
            this.Name = Name;
            this.npcList = npcs;
        }

    }
}