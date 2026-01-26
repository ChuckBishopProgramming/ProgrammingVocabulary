namespace VocaBox
{
    // GOAL:
    // keep track of integral vocabulary
    // provide examples where possible

    //FORMAT:
    // string name = Proper definition
    // string name++ = Personal or embellished definition
    // string nameGUESS =  Guess at definition
    // string nameQUESTION = Question to look up
    // string nameDEF = Protected word work around

    //PURPOSE:
    // Ensure we have the skills to search, naviagate and communicate vital information
    // Test our existing knowledge
    // Practice skills
    internal class Program       
    {
        static void Main(string[] args)
        {
            string objectOrientedProgramming = "A style of programming that focuses on objects";
            string objectOrientedProgramming++ = "object focused, less limited than procedural but a little more complicated. Translates to visual thought processes fairly well";

            string objectDEF = "An object is an instance of a class. Needs the new keyword";
            string instance = "A specific occurance of a class";

            string programming = "giving machines precise step by step instructions to carry out various tasks";

            string classDEF = "the template for a classes behaviors and attributes";

            string attribute = "A form of metadata.";
            string attributeQUESTION = "Question: How is an attribute different than a property? ";            
            string attributeANSWER = "field and property are part of the object's state and behavior, ATTRIBUTE describes the code itself. Not the object.";

            Console.WriteLine("Hello, World!");
        }
    }
}
