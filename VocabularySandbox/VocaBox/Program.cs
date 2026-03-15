namespace VocaBox
{
    // NAME: Chuck Bishop
    // DATE: 
    // PURPOSE: 
    // NOTES: intellisense provides a good portion of these definitions

    // GOAL:
    // keep track of integral vocabulary
    // provide examples where possible

    //FORMAT:
    // string name = Proper definition
    // string name++ = Personal or embellished definition
    // string nameGUESS =  Guess at definition
    // string nameQUESTION = Question to look up
    // string nameKeyword = Protected word work around

    //PURPOSE:
    // Ensure we have the skills to search, naviagate and communicate vital information
    // Test our existing knowledge
    // Practice skills

    //PLANS
    // Split into separate classes for each category (Class Practice)
    // Create collections for categories of words
    internal class Program       
    {
        static void Main(string[] args)
        {

            //UNSORTED:
            string objectOrientedProgramming = "A style of programming that focuses on objects";
            string objectOrientedProgrammingII = "object focused, less limited than procedural but a little more complicated. Translates to visual thought processes fairly well";

            string objectKeyword = "An object is an instance of a class. Needs the new keyword. It's an implementation of the class";
            // Customer customer1 = new Customer();
            // Name of class (type of object) name of object = new (keyword) constructor         
            string classKeyword = "the template for a classes behaviors and attributes";

            string attribute = "A form of metadata.";
            string attributeQUESTION = "Question: How is an attribute different than a property? ";            
            string attributeANSWER = "field and property are part of the object's state and behavior, ATTRIBUTE describes the code itself. Not the object.";

            string properties = "something it has, something it knows";
            string behavior = "something it does, a behavior it has";

            string reservedKeyWord = "special words that cannot be used as string names";
            string classKeywordII = "used before a class is declared";                       
            

            //Access Keywords
            //========================================================================
            string publicKeyword = "Accesible from anywhere";
            string privateKeyword = "Accesible from inside the class";
            string protectedKeyword = "Accesible from this class and child classes";
            string internalKeyword = "Accesible from the same project";

            //Inheritance and Polymorphism Keywords
            //========================================================================
            string virtualKeyword = "The parent method can be replaced (optional)";
            string overrideKeyword = "The child method IS replacing it";
            string abstractKeyword = "MUST be overriden (nothing inside)";
            string sealedKeyword = "Cannot be overriden";
            string newKeyword = "";
            string parentClass = "";
            string childClass = "Derives from parent class";

            //Class keywords - what kind of class
            //========================================================================
            string classKeywordIII = "a normal class";
            string abstractKeywordII = "can't be instantiated, may contain abstract members";
            string staticKeyword = "can't be instantied, only static members. Belongs to the class and does not require an onject";
            string partialKeyword = "";
            string instance = "A specific occurance of a class";

            //Member keywords - describes what the member is
            //========================================================================
            string member = "Anything inside a class (field, property, method, etc.";
            string fieldKeyword = "A variable stored inside a class (often private)";
            string properyKeyword = "A get/set wrapper that exposes a value";
            string methodKeyword = "A function inside a class/An action the class can do";
            string eventKeyword = "TBD";

            //Member modifiers 
            //========================================================================
            string staticKeywordII = "belongs to the class, not the object";
            string readonlyKeyword = "can only be set in constructor";
            string constKeyword = "compile time constant";

            //Constructor keywords
            //========================================================================
            string baseParenthesisKeyword = "call the parent constructor: base()";
            string thisParenthesisKeyword = "call another constructor in the same class. this()";

            //Basic Math Terms
            //========================================================================
            string sumDefinition = "The result of adding two or more numbers";
            string differenceDefinition = "The result of subtraction operation";
            string productDefinition = "The result of multiplication operation";
            string quotientDefinition = "The result of a division operation";
            string moduloDefinition = "The remainder from imperfect division. A common way to test if even or odd. %2 == 0 ";
            string numeratorDefinition = "the top number of a fraction";
            string denominatorDefinition = "the bottom number of a fraction";
            string factorDefintion = "A factor is a number that can be multiplied by another number to produce a given number";
            string greatestCommonDivisor = "the largest number that can divide into both fractions";
            string lowestCommonDenominator = "the smallest denominator shared between two fractions";

            //Math Actions
            //========================================================================
            string simplifyFraction = "reduce the fraction to it's simplest form. Divide numerator and denominator by the greatest common factor";

            //Math Patterns
            //========================================================================
            string addition = "a+b=c";
            string subtraction = "a-b=c";
            string multiplication = "a*b=c";
            string division = "a/b=c";  

            //Unrelated but interesting
            //========================================================================
            string opticalCharacterRecognition = "electronic or mechanical conversion of images of text into machine encoded text-wikipedia";
            string projectionMapping = "A projection technique used to turn often uneven surfaces into display surfaces for video projection-wikipedia" ;

            //Design Terms
            //========================================================================
            string greenField = "refers to creating a system, application or project entirely from scratch. Has no contraints for existing infrastructure or legacy code. Term comes from real estate. ";
            string iterativeDesign = "create a prototype, testing it, and then refining the design based on feedback and results. This process is repeated until a final design is achieved. It allows for flexibility and adaptability in the design process, as changes can be made based on user feedback and testing results.";

            //People to Know
            //========================================================================
            string godbolt = "Matt 'compliler' Godbolt: creator of godbolt compiler";
            string uncleBob = "Robert 'Uncle Bob' Martin: Creator of clean Code and popular author";
            string linusTorvalds = "Linus Torvals: Creator of Linux and Git";
            string charlesSimonyi = "Charles Simonyi: Creator of Microsoft Word and Excel. Originator of Hungarian Notation";
            string brendanEich = "Brendan Eich: Creator of JavaScript and co-founder of Mozilla";

            //Software Paradigms
            //========================================================================
            string paradigm = "Theoretical framework or process for developing and designing software. ";
            string imperativeParadigm = "Code directly controls execution flow and state change, explicit statements that change a program's state";
            string objectOrientedParadigm = "A type of imperative. Organized as objects that encapsulate both data and behavior to design programs";
            string logicParadigm = "";
            string functionalParadigm = "";
            string declarativeParadigm = "Code delcares properties of the desired results";

            //Database Terms
            //========================================================================
            string database = "An organized collection of data that can be easily accessed, managed, and updated.";
            string table = "A collection of related data entries that consists of columns and rows.";
            string row = "";
            string column = "";

            //CLI Bash terms
            //========================================================================
            string knernel = "The core of an operating system, responsible for managing system resources and facilitating communication between hardware and software components.";
            string bash = "A Unix shell and command language that provides a command-line interface for users to interact with the operating system.";
            string bourneShell = "The original Unix shell, developed by Stephen Bourne. It served as the basis for many subsequent shells, including Bash.";
            string bourneAgainShell = "An enhanced version of the Bourne Shell, developed by Brian Fox. It is the default shell on many Linux distributions and macOS.";
            string vi = "A powerful text editor that is commonly used in Unix-like operating systems. It is known for its efficiency and extensive features, but has a steep learning curve for beginners.";
            string vim = "An improved version of the vi editor, created by Bram Moolenaar. It offers additional features and enhancements while maintaining compatibility with vi.";

            //Programming Terms
            //========================================================================
            string programming = "giving machines precise step by step instructions to carry out various tasks";
            string scriptingLanguage = "A programming language that is run line by line and is not compiled. Often used for web development and automation tasks. Examples include JavaScript, Python, and Ruby.";
            string compiledLanguage = "A programming language that is translated from human readable code into machine code that can be executed directly by a computer's processor. Examples include C, C++, and Java.";
            string scriptingHost = "A web browser with a scipting engine that can execute JavaScript code. Examples include Google Chrome, Mozilla Firefox, and Microsoft Edge.";


            Console.WriteLine("Hello, World!");
        }
    }
}
