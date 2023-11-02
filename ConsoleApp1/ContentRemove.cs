using System;

namespace ConsoleApp1
{
    public class ContentRemove
    {
        private string removeselect;
        public ContentRemove(string removeselect)
        {
            this.removeselect = removeselect;
        }
        //private void Removal(ContentAssign assign, string removeselect, string nameorsub)
        //{
        //   switch (removeselect)
        //    {
        //       case "name":
        //            for (int i = 0; i < assign.GetArray().GetLength(0); i++)
        //            {
        //                if (assign.GetArray()[i,0] == nameorsub)
        //                {
        //                    Console.WriteLine("contains the name");
        //               }
        //            }
        //            break;
        //        case "subject":
        //            for (int j = 0; j < assign.GetArray().GetLength(1); j++)
        //            {
        //
        //            }
        //            break;
        //    }
        //}
        public void GetName(ContentAssign assign, string nameorsub)
        {
            //Removal(assign, removeselect, nameorsub);
        }
    }
}
