namespace homework1
{
    
    public interface IDialogPart
    {
        public string sentence { get; set; }
        public IDialogPart[]? dialogParts { get; set; }
        
    }


    public class NpcDialogPart : IDialogPart
    {
        public string sentence { get; set; }
        public IDialogPart[]? dialogParts { get; set; }

        public NpcDialogPart(string sentence = "")
        {
            this.sentence = sentence;
        }

        public NpcDialogPart(string sentence = "", params string[] answers)
        {
            this.sentence = sentence;
            dialogParts = new HeroDialogPart[answers.Length];

            for (int i = 0; i < answers.Length; i++)
            {
                dialogParts[i] = new HeroDialogPart(answers[i]);
            }
        }

        public NpcDialogPart(string sentence = "", params HeroDialogPart[] answers)
        {
            this.sentence = sentence;
            this.dialogParts = answers;
        }

    }

    public class HeroDialogPart : IDialogPart
    {
        public string sentence { get; set; }
        public IDialogPart[]? dialogParts {  get; set; }

        public HeroDialogPart(string sentence="")
        {
            this.sentence = sentence;
        }

        /*public HeroDialogPart(string sentence="", params string[] answers)
        {
            this.sentence = sentence;
            dialogParts = new NpcDialogPart[answers.Length];
            
            for(int i = 0; i < answers.Length; i++)
            {
                dialogParts[i] = new NpcDialogPart(answers[i]);
            }
        }*/

        public HeroDialogPart(string sentence="", params NpcDialogPart[] answers)
        {
            this.sentence = sentence;
            this.dialogParts = answers;
        }

    }

}