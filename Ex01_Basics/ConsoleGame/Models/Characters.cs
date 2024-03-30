namespace homework1
{
    public class Hero
    {
        public string Name { get; set; }
        public EHeroClass Class { get; set; }
    }

    public class NonPlayerCharacter
    {
        public string Name { get; set; }
        public NpcDialogPart startingDialogPart { get; set; }

        public NonPlayerCharacter(string Name, string startingSentence)
        {
            this.Name = Name;
            this.startingDialogPart = new NpcDialogPart(startingSentence);
        }


        public NonPlayerCharacter(string Name, NpcDialogPart startingDialogPart)
        {
            this.Name = Name;
            this.startingDialogPart = startingDialogPart;
        }

        public NpcDialogPart StartTalking()
        {
            return startingDialogPart;
        }
    }
}