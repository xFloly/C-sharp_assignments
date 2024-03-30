using System;

namespace homework1
{
    public static class LocationCreater
    {
        public static Location createMiodowyLas()
        {
            NpcDialogPart n1 = new NpcDialogPart("w sumie to nic");
            HeroDialogPart h1 = new HeroDialogPart("Tak to w³asnie ja, #HERONAME#. Czego potrzbujesz?", n1);
            NpcDialogPart n0 = new NpcDialogPart("jo³ to ty jesteœ ten s³ynny #HERONAME#", h1);
            NonPlayerCharacter npc2 = new NonPlayerCharacter("EpicPoggers5k",n0);

            HeroDialogPart H7 = new HeroDialogPart("cool");
            NpcDialogPart N6 = new NpcDialogPart("musisz pozbierac mi 20 jab³ek, dam ci 10 jak wrócisz przed 14", H7);
            HeroDialogPart H6 = new HeroDialogPart("spoko", N6);
            HeroDialogPart H5 = new HeroDialogPart("niech ci bedzie");
            HeroDialogPart H4 = new HeroDialogPart("no to naura");
            NpcDialogPart N5 = new NpcDialogPart("nie ma szans, cwaniaku", H4, H5);
            HeroDialogPart H3 = new HeroDialogPart("wincyj", N5);
            NpcDialogPart N4 = new NpcDialogPart("za 5 ziko musisz pozbierac mi 20 jab³ek", H3, H5);
            HeroDialogPart HN3 = new HeroDialogPart("no dobra", N4);
            HeroDialogPart H2 = new HeroDialogPart("nadal nie");
            NpcDialogPart N2 = new NpcDialogPart("a jak zaplace?", H2,HN3);
            HeroDialogPart H1 = new HeroDialogPart("NIE", N2);
            NpcDialogPart N1 = new NpcDialogPart("Witaj, pomozesz dla mnie", H1,H6);

            NonPlayerCharacter npc1 = new NonPlayerCharacter("Marcin", N1);

            return new Location("Miodowy Las", npc1, npc2);
        }
    }
}