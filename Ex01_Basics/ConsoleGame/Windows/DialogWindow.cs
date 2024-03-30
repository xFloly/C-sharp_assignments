using System;
using System.Data.Common;

namespace homework1
{
    public static class DialogWindow
    {
        public static void TalkTo(NonPlayerCharacter npc)
        {
            Console.Clear();
            if (npc == null) return;

            IDialogPart dialog =  npc.StartTalking();

            while (dialog != null)
            {
                if (dialog is NpcDialogPart)
                {
                    Console.WriteLine($"NPC: {Program.ParseDialog(dialog)}");

                    if (dialog.dialogParts == null || dialog.dialogParts.Length == 0)
                    {
                        Console.ReadKey();
                        break;
                    }
                    else if (dialog.dialogParts.Length == 1)
                    {
                        Console.ReadKey();
                        dialog = dialog.dialogParts[0];
                    }
                    else
                    {
                        for (int i = 0; i < dialog.dialogParts.Length; i++)
                        {
                            Console.WriteLine($"[{i + 1}]{Program.ParseDialog(dialog.dialogParts[i])}");
                        }

                        while (true)
                        {
                            string choice = Console.ReadLine()?.Trim() ?? "";
                       
                            if (int.TryParse(choice, out int choiceAsInt)) 
                            {
                                if (choiceAsInt >= 1 && choiceAsInt <= dialog.dialogParts.Length)
                                {
                                    dialog = dialog.dialogParts[choiceAsInt-1];
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("wybrana opcja jest niew³aœciwa");
                                    Console.WriteLine("ponów wybór");
                                }

                            }
                            else
                            {
                                Console.WriteLine("wybrana opcja jest niew³aœciwa");
                                Console.WriteLine("ponów wybór");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Hero: {Program.ParseDialog(dialog)}");
                    Console.ReadKey();
                    dialog = dialog.dialogParts?[0];
                }

            }

            Console.WriteLine($"<Koniec>");
            Console.WriteLine("(press any button)");
            Console.ReadKey();
        }
    }
}