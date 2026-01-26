namespace VocaBox
{
    // GOAL:
    // keep track of integral vocabulary
    // provide examples where possible

    //FORMAT:
    // string name = Proper definition
    // string name++ = Personal or embellished definition
    // string name?? =  Guess at definition
    // string nameDEF = protected word work around

    //PURPOSE:
    // Ensure we have the skills to search and communicate vital information
    // Test our existing knowledge
    // Practice skills
    internal class Program       
    {
        static void Main(string[] args)
        {
            string objectOrientedProgramming = "A style of programming that focuses on objects";
            string objectOrientedProgramming++ = "object focused, less limited than procedural but a little more complicated. Translates to visual thought processes fairly well";

            string objectDef = "An object is an instance of a class. Needs the new keyword";
            string instance = "A specific occurance of a class";

            Console.WriteLine("Hello, World!");
        }
    }
}
