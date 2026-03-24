namespace VocaBox
{
    // NAME: Chuck Bishop
    // DATE: 
    // PURPOSE: 
    // NOTES: intellisense provides a good portion of these definitions. 

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
    // Create an index of words and definitions
    // Organize words by category and alphabetically
    // Create a mini search engine to search for words and definitions
    // Create a mini quiz mode to test knowledge of words and definitions
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
            string unixTime = "milliseconds since January 1, 1970. Used in many programming languages to represent time as a single number. Can be converted to human readable date formats.";
            string iSO = "ISO international organization for standardization.";
            

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

            //Logical Operators
            //========================================================================

            //Relational Operators
            //========================================================================

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

            //Programming Fundamentals
            //========================================================================
            string assignment = " = Assigns the value on the right to the variable on the left. Uses the = operator.";
            string add = " + Adds two values together. Uses the + operator.";
            string subtract = " - Subtracts the value on the right from the value on the left. Uses the - operator.";
            string multiply = " * Multiplies two values together. Uses the * operator.";
            string divide = " / Divides the value on the left by the value on the right. Uses the / operator.";
            string modulus = " % Takes the modulus of the value on the left by the value on the right. Uses the % operator.";
            string increment = " ++ Increases the value of a variable by 1. Uses the ++ operator.";
            string decrement = " -- Decreases the value of a variable by 1. Uses the -- operator.";
            string addAndAssign = " += Adds the value on the right to the variable on the left and assigns the result to the variable on the left.";
            string subtractAndAssign = " -= Subtracts the value on the right from the variable on the left and assigns the result to the variable on the left.";
            string multiplyAndAssign = " *= Multiplies the variable on the left by the value on the right and assigns the result to the variable on the left.";
            string divideAndAssign = " /= Divides the variable on the left by the value on the right and assigns the result to the variable on the left.";
            string modulusAndAssign = " %= Takes the modulus of the variable on the left by the value on the right and assigns the result to the variable on the left.";
            string incrementAndAct = "++a, increment the variable then use it.";
            string ActAndIncrement = "a++, use the variable then increment it.";
            string stringConcatenation = " + Combines two strings together. Uses the + operator.";
            string stringConcatenationAssignment = " += Combines the string on the right with the variable on the left and assigns the result to the variable on the left.";
            string newLine = "\\n";
            string escapeCharacter = "\\ Used to escape special characters in a string. For example, \\n is used to represent a new line character in a string.";
            string horizontalTab = "\\t Used to represent a horizontal tab character in a string.";
            string verticalTab = "\\v Used to represent a vertical tab character in a string. Not commonly used in many languages.!";
            string nullCharacter = "\\0 Used to represent a null character in a string. It is often used to indicate the end of a string in languages like C and C++.";
            string backspaceCharacter = "\\b Used to represent a backspace character in a string. It is used to move the cursor back one position in the output.";
            string formFeedCharacter = "\\f Used to represent a form feed character in a string. It is used to advance the output to the next page or section.";
            string NewLineCharacter = "\\n Used to represent a new line character in a string. It is used to move the cursor to the next line in the output.";
            string CarriageReturnCharacter = "\\r Used to represent a carriage return character in a string. It is used to move the cursor to the beginning of the current line in the output.";
            string singleQuoteCharacter = "\\' Used to represent a single quote character in a string. It is used to include a single quote within a string that is enclosed in single quotes.";
            string doubleQuoteCharacter = "\\\" Used to represent a double quote character in a string. It is used to include a double quote within a string that is enclosed in double quotes.";
            string backslashCharacter = "\\\\ Used to represent a backslash character in a string. It is used to include a backslash within a string.";
            string tryCatchFinally = "try: code that may throw an exception. catch: code to handle the exception if it is thrown. finally: code that will always be executed after the try and catch blocks, regardless of whether an exception was thrown or caught.";
            string controlStatement = "A statement that controls the flow of execution in a program. Examples: if, else, switch, for, while, do-while, etc.";
            string conditionalStatement = "A statement that evaluates a condition and executes code if true. Examples: if, else if, else, switch, etc.";
            string conditionalExpression = "Returns boolean true or false.";
            string relationalOperator = "Used to compare two values. Examples: ==, !=, >, <, >=, <=.";
            string logicalOperator = "Used to combine or invert boolean values. Examples: &&, ||, !.";
            string keyValuePair = "A set of two related data items: a key, which is a unique identifier for the item, and a value, which is the data associated with the key.";

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
            string grep = "global regular expression print, searches for patterns. Uses basic regular expressions by default. BRE";
            string egrep = "same as grep -E. Uses extended regular expressions";
            string fgrep = "same as grep -F. searches for fixed strings. no regex, faster for literal matches";


            string BRE = "Basic regular expressions";
            string ERE = "Extended regular expressions: no need to escape +, ?, |, (), {}";
            string commandGTfilename = "command > filename. Redirects stdout to a file name filename";
            string commandGTGTfilename = "command >> filename. Redirects stdout and appends to a file named filename unless it doesn't exist then it will create it";
            string command2GTfilename = "command 2> filename. Redirects error output only";
            string commandGTfilename2GTamp1 = "command > filename 2>&1. Redirects error output from 2 to 1. amp& is needed else it would create a file name 1";

            //Missing terms 
            //Learning moment: I was scared to branch out to use more than one computer at a time
            //I know this projec tis further ahead on my home pc but failed to push in the last 5-10 mins. Not far off. But enough.
            //Will delete comment on next commit 


            //Programming Terms
            //========================================================================
            string programming = "giving machines precise step by step instructions to carry out various tasks";
            string scriptingLanguage = "A programming language that is run line by line and is not compiled. Often used for web development and automation tasks. Examples include JavaScript, Python, and Ruby.";
            string compiledLanguage = "A programming language that is translated from human readable code into machine code that can be executed directly by a computer's processor. Examples include C, C++, and Java.";
            string scriptingHost = "A web browser with a scipting engine that can execute JavaScript code. Examples include Google Chrome, Mozilla Firefox, and Microsoft Edge.";
            string frontEndDevelopment = "The user interface and user experience. It involves using HTML, CSS, and JavaScript.";
            string backEndDevelopment = "The server side of web development. It involves working with databases, server logic, and APIs. Common languages include Python, Ruby, Java, and PHP, Perl.";
            string looselyTypedLanguage = "A programming language that does not require explicit type declarations for variables. Examples include JavaScript and Python.";
            string stronglyTypedLanguage = "A programming language that requires explicit type declarations for variables. Examples include C#, Java, and C++.";

            //Website Terms
            //========================================================================
            string clientServerArchitecture = "1. site loads in browser from the server. 2. client side scripts run in the browser. Process requests without callbacks. 3. When a call is required javascipt and ajax send it to back end. 4. backend server scripts process and pull. 5. Server side scripts process the data then updates the site";
            string webServer = "Hosts: static html files and assets, css files, javascript files, server side code for dynamic html, recieves requests from clients, access data from database, sends response back to client";
            string databaseServer = "Stores or persists data between requests and visits";
            string client = "A user accessing website via mobile or laptop. Recieves html, css and javascript to be executed in the browser.";

            //JavaScript Syntax
            //========================================================================
            string jsCaseSensitivity = "JavaScript is case sensitive, variables must be written with consistent capitalization. myPickle and MyPickle are different variables.";
            string jsLineTermination = "JavaScript does not need semi colons to terminate lines but it's considered good practice to use them. Similar to html it will automatically insert them at the end of lines but this can lead to unexpected results in some cases.";
            string jsAuthoringComments = "Line1: /** Line2: * Author: <name> Line3: * Title: <title> Line4: * Date: <date> Line5: */";
            string jsVariableDefinition = "Can contain letters, numbers, underscores and dollar signs. Cannot start with a number. Case sensitive. Cannot be a reserved keyword.";
            string jsReservedKeywords = "abstract, boolean, break, byte, case, catch, char, class, const, continue, debugger, default, delete, do, double, else, enum, export, extends, final, finally, float, for, function, goto, if, implements, import, in, instanceof, int, interface, long, new, null, package, private, protected, public, return, short, static, super, switch, synchronized, this, throw, transient, true, try, typeof, var, void, volatile, while, with and let";
            string jsLineComments = "Single line: // comment goes here.";
            string jsBlockComments = "Multi line: /* comment goes here */";
            string letKeyword = "Used to declare block-scoped variables. Variables declared with let are only accessible within the block they are defined in.";
            string varKeyword = "Used to declare function-scoped variables. Variables declared with var are accessible throughout the entire function they are defined in, regardless of block scope. Can be redeclared.";
            string jsGotcha = "typeof null is object. This is a quirk of JavaScript and can lead to unexpected results when checking for null values. It's important to be aware of this when working with JavaScript.";
            string jsString = "enclosed in single or double quotes. Can use backticks for template literals which allow for string interpolation and multi-line strings. Use double quotes for this course.";
            string jsRawStringLiteral = "enclosed in backticks. `` Can contain variables and expressions inside ${}. Can span multiple lines without the need for escape characters.";
            string jsEscapeCharacter = "\\ Used to escape special characters in a string. You can use a opposite type of quote to avoid using escape: \"string's\" or \'\"happy\"\'";
            string jsTemplateString = "raw string literal. Enclosed in backticks ``";
            string jsDates = "To work with dates we instantiate a new date object: let date = new Date(); This creates a new date object with the current date and time. This is the client's computer's date and time.";
            string jsDatesCompare = " >, ==, < can be used to compare date objects. Will results in true/false";
            string jsDatesAdding = """ pickleDate = demoDate.getDate() + 20; This adds 20 days to demoDate.""";
            string jsDatesSubtracting = """ pickleDate = demoDate.getDate() - 20; This subtracts 20 days from demoDate.""";
            string jsIfElseifElse = """ if (condition) { // code to execute if condition is true } else if (condition) { // code to execute if the first condition is false and this condition is true } else { // code to execute if all conditions are false }. Else if and else are optional """;
            string jsIfElseifElseII = "Open curly braces on the same line as the if statement. This is a common convention in JavaScript and can help improve readability.";
            string jsIfElseifElseSingle = "when code executed by the condition is on a single line, curly braces are optional.";
            string jsSwitchStatement = """
                 
                switch (expression) {
                    case value1:
                        // code to execute if expression matches value1
                        break; 
                    case value2: 
                        // code to execute if expression matches value2 
                        break; 
                    default: 
                        // code to execute if expression does not match any case 
                        break;
                } 
                """;
            string jsSwitchTrue = """ switch(true) means any of the case options must be true """;
            string jsForLoop = """ for (initialization; condition; increment) { // code to execute } """;
            string jsWhileLoop = """ while (condition) { // code to execute } Checks the conditioni before the code""";
            string jsDoLoop = """ do { // code to execute } while (condition); Checks the condition after the code. Will always execute at least once.""";
            string jsDoLoopExample =
                """
                let i = 0; 
                do { behavior; 
                increment++; } while (condition);
                """;

            //JavaScript Gotchas
            //========================================================================
            string equalityGotcha = "== compares values but not types. === compares values and types. This can lead to unexpected results when comparing values of different types. For example, 0 == false returns true, but 0 === false returns false.";

            //JavaScript Methods
            //========================================================================
            string jsParseInt = """ parseInt(string) // Parses a string and returns an integer. Example: parseInt('42') returns 42.""";
            string jsParseFloat = """ parseFloat(string) // Parses a string and returns a floating point number. Example: parseFloat('3.14') returns 3.14.""";
            string jsNan = """ NaN // Stands for Not-a-Number. It is a special value that represents an undefined or unrepresentable value in JavaScript. Example: parseInt('hello') returns NaN.""";


            //JavaScript + HTML Syntax
            //========================================================================
            string embeddedJavaScript = "<script> JavaScript code goes here </script> Used to include JavaScript code in an HTML document. Generally placed within <head> but can go anywhere.";
            string externalJavaScript = "<script src=\"path/to/script.js\"></script> Used to include an external JavaScript file in an HTML document. Generally placed within <head> but can go anywhere.";
            string jsPromptFunction = """ prompt('message','default value') // Displays a dialog box that prompts the user for input. The message parameter is the text to display in the dialog box, default fills default msg. Returns the user's input as a string. Example: let name = prompt('What is your name?'); """;
            string jsAlertFunction = """ alert('message') // Displays an alert dialog box with the specified message. Example: alert('Hello, World!'); """;
            string jsWindowLocation = """ window.location // Returns the current URL of the page. Can be used to redirect to a different URL. Example: window.location = 'https://www.example.com'; """;
            string documentObject = "Highest object within the HTML DOM. Represents the entire HTML document. Can be used to access and manipulate elements within the document. Example: document.getElementById('myElement') returns the element with the id of 'myElement'.";
            string windowObject = "The global object in a web browser environment. Represents the browser window and provides access to various properties and methods related to the browser. Example: window.alert('Hello, World!'); displays an alert dialog box with the message 'Hello, World!'.";
            string jsDocumentWrite = """ <script> document.write('message') </script> // Writes a string of text to the HTML document. Example: document.write('Hello, World!'); writes 'Hello, World!' to the document. Note: This method should be used with caution as it can overwrite the entire document if called after the page has loaded.""";


            //JavaScript String Methods
            //========================================================================
            string jsDotLength = """ .length // Type: Property. Returns the length of a string. Example: 'hello'.length returns 5.""";
            string jsDotSubstring = """ .substring() // Type: Method. Returns a portion of a string between the start and end indexes. Including the first number, excluding the second. Example: 'hello world'.substring(0, 5) returns 'hello'.""";
            string jsDotToUpperCase = """ .toUpperCase() // Type: Method. Returns a new string with all characters converted to uppercase. Example: 'hello'.toUpperCase() returns 'HELLO'.""";
            string jsDotToLowerCase = """ .toLowerCase() // Type: Method. Returns a new string with all characters converted to lowercase. Example: 'HELLO'.toLowerCase() returns 'hello'.""";
            string jsDotIndexOf = """ .indexOf() // Type: Method. Returns the index of the first occurrence of a specified value in a string. Example: 'hello world'.indexOf('world') returns 6.""";
            string jsDotTrim = """ .trim() // Type: Method. Returns a new string with whitespace removed from both ends of the original string. Example: '  hello  '.trim() returns 'hello'.""";

            //JavaScript Date Methods
            //========================================================================
            string jsDateGotcha = "when creating specific date, month is zero indexed. January is 0, December is 11. This can lead to unexpected results when creating date objects with specific dates.";
            string jsDateGotchaDate = "There is no set day. setDate() is set day, everything else is named";
            string jsToDateString = """ .toDateString() // Returns the date portion of a date object as a human-readable string. Example: let date = new Date('1990-01-01'); date.toDateString() returns 'Mon Jan 01 1990'.""";                        
            string jsDateToString = """ .toString() //  Returns a string representation of a date object. Example: let date = new Date('1990-01-01'); date.toString() returns 'Mon Jan 01 1990 00:00:00 GMT+0000 (Coordinated Universal Time)'.""";
            string jsDateToTimeString = """ .toTimeString() //  Returns the time portion of a date object as a human-readable string. Example: let date = new Date('1990-01-01T12:30:00'); date.toTimeString() returns '12:30:00 GMT+0000 (Coordinated Universal Time)'.""";
            string jsDateToISOString = """ .toISOString() //  Returns a string in simplified extended ISO format (YYYY-MM-DDTHH:mm:ss.sssZ) representing the date object. Example: let date = new Date('1990-01-01T12:30:00'); date.toISOString() returns '1990-01-01T12:30:00.000Z'.""";
            // Getters
            //=========
            string jsDateGetDate = """ .getDate() //  Returns the day of the month of a date object as a number (1-31). Example: let date = new Date('1190-01-01'); date.getDate() returns 1.""";
            string jsDateGetTime = """ .getTime() //  Returns the number of milliseconds since January 1, 1970 for a date object. Example: let date = new Date('1990-01-01'); date.getTime() returns 631152000000.""";
            string jsDateGetFullYear = """ .getFullYear() // Returns the year of a date object as a four-digit number. Example: let date = new Date('1990-01-01'); date.getFullYear() returns 1990.""";
            string jsDateGetMonth = """ .getMonth() // Returns the month of a date object as a zero-based index (0-11). Example: let date = new Date('1990-01-01'); date.getMonth() returns 0 for January.""";
            string jsDateGetHours = """ .getHours() //  Returns the hour of a date object as a number (0-23). Example: let date = new Date('1990-01-01T12:30:00'); date.getHours() returns 12.""";
            string jsDateGetMinutes = """ .getMinutes() // Returns the minutes of a date object as a number (0-59). Example: let date = new Date('1990-01-01T12:30:00'); date.getMinutes() returns 30.""";
            string jsDateGetSeconds = """ .getSeconds() // Returns the seconds of a date object as a number (0-59). Example: let date = new Date('1990-01-01T12:30:45'); date.getSeconds() returns 45.""";
            string jsDateGetMilliseconds = """ .getMilliseconds() // Returns the milliseconds of a date object as a number (0-999). Example: let date = new Date('1990-01-01T12:30:00.500'); date.getMilliseconds() returns 500.""";
            // Setters
            //=========
            string jsDateSetFullYear = """ .setFullYear(year) // Sets the year of a date object. Example: let date = new Date('1990-01-01'); date.setFullYear(2000); date.toDateString() returns 'Sat Jan 01 2000'.""";
            string jsDateSetMonth = """ .setMonth(month) // Sets the month of a date object. Example: let date = new Date('1990-01-01'); date.setMonth(5); date.toDateString() returns 'Fri Jun 01 1990'.""";
            string jsDateSetDay = """ .setDate(day) // Sets the day of the month of a date object. Example: let date = new Date('1990-01-01'); date.setDate(15); date.toDateString() returns 'Mon Jan 15 1990'.""";
            string jsDateSetHours = """ .setHours(hours) // Sets the hour of a date object. Example: let date = new Date('1990-01-01T12:30:00'); date.setHours(15); date.toTimeString() returns '15:30:00 GMT+0000 (Coordinated Universal Time)'.""";
            string jsDateSetMinutes = """ .setMinutes(minutes) // Sets the minutes of a date object. Example: let date = new Date('1990-01-01T12:30:00'); date.setMinutes(45); date.toTimeString() returns '12:45:00 GMT+0000 (Coordinated Universal Time)'.""";
            string jsDateSetSeconds = """ .setSeconds(seconds) // Sets the seconds of a date object. Example: let date = new Date('1990-01-01T12:30:00'); date.setSeconds(45); date.toTimeString() returns '12:30:45 GMT+0000 (Coordinated Universal Time)'.""";
            string jsDateSetMilliseconds = """ .setMilliseconds(milliseconds) // Sets the milliseconds of a date object. Example: let date = new Date('1990-01-01T12:30:00.500'); date.setMilliseconds(250); date.toTimeString() returns '12:30:00 GMT+0000 (Coordinated Universal Time)'.""";

            //JavaScript Date Constructors
            //========================================================================
            string jsConstructorSpecificDate = """ new Date('year, month, day, hour, min, milliseconds') // Creates a new date object with the specified date. Example: let date = new Date('1990, 0, 1, 12, 30'); creates a date object representing January 1, 1990.""";
            string jsConstructorNewDate = """ new Date() // Creates a new date object with the current date and time. Example: let date = new Date(); creates a date object representing the current date and time.""";
            string jsConstructorMilliseconds = """ new Date(milliseconds) // Creates a new date object based on the number of milliseconds since January 1, 1970. Example: let date = new Date(0); creates a date object representing January 1, 1970.""";
            string jsConstructorDateString = """ new Date(dateString) // Creates a new date object based on a date string. Example: let date = new Date('1990-01-01'); creates a date object representing January 1, 1990.""";

            //C# Syntax
            //========================================================================
            string cSharpRawStringLiteral = "enclosed in triple quotes. \"\"\" Can contain variables and expressions inside {}. Can span multiple lines without the need for escape characters.";

            //Database Programming Terms
            //========================================================================
            string distributedApplication = "is an application where the components of the application are located on different computers. These computers communicate by passing messages to one another";
            string dbClientServerArchitecture = "is a distributed application structure that partitions tasks or workloads between the providers of a resource or service, called server, and service requesters, called clients";
            string dbClient = "Pc's mobile devices etc. They request content from a server, but do not share any of their resources";
            string dbDataAccessAPI = "Provides the interface between the application and the DBMS. The data access API which is a part of the .NET framework is ADO.NET";
            string dbADOdotNET = "the data access API for .NET applications. Provides consistent access to data sources through a common set of components" +
                                 "Separates data access from data manipulation into discrete components that can be used separately or along side each other";
            string dbADOdotNETComponents = ".NET Framework Data Providers: provides the classes used to access data in the databse. The DataSet: designed for data access independant of any data source. Consists of a collection of one or more DataTable objects consisting of rows and columns of data";
            string dbServer = "store the files and databases of the system and provides services to the clients. Servers that store databases are often referred to as database servers";
            string dbNetwork = "consists of cabling, communication lines, and other components that connect clients and the servers of the system";
            string DBMS = "Database management system.";
            string dbBackendProcessing = "processing done by DBMS is generally referred to as the backend";
            string dbFrontEndProcessing = "processing done by the client is generally referred to as the frontend";
            string dbSQLInterface = "the app software communicates with the DBMS by sending SQL queries through the data access API (ADO.NET)." +
                                    "When the DBMS receives a query, it provides a service like returning the requested data (the query results) to the client";
            string dbSystemDotData = "the namespace in .NET that contains the classes for working with data and databases. It includes classes for connecting to databases, executing commands, and retrieving results.";
            string dbMicrosoftDotData = "";
            string dbConnectionObject = "class Name: SqlConnection. Establishes a connection to a specific data source/database. It is used to open and close connections to a database. It tells the rest of the ADO.NET code which data source/database to talk to";
            string dbCommandObject = "class Name: SqlCommand. Executes a command (SQL statement) against a data source. It is used to execute queries and stored procedures against a database.";
            string dbDataReader = "class Name: SqlDataReader. Provides a way of reading a forward-only stream of data from a data source. It is used to read the results of a query executed against a database.";
            string dbDataAdapter = "class Name: SqlDataAdapter. Provides a way of filling a DataSet and updating a data source. It is used to fill a DataSet with the results of a query executed against a database and to update the database with changes made to the DataSet.";
            string dbDataSet = "Contains one or more data tables that store data from a data source.";

            string dbManagingConnection = "ADO.NET uses connection pooling by default. 100/100. Use one when opening a connection, return it when closed";
            string dbManagingConnectionII = "Opening physical connection is expensive: network comms, auth, resource allocation";
            string dbManagingConnectionIII = "Closing physical connection: returns to pool, allows reuse, reduces overhead, improves throughout";
            string dbManagingConnectionIV = "Each open connection consumes: memory, threads, locks, session resources";
            string dbManagingConnectionV = "On high traffic systems, unclosed connections can: Slow down the database server, block other users, cause system instability";
            string dbIfDoNotCloseConnection = "they stay in use, pool will eventually run out, new requests must wait, runtime exceptions may occur like time out expired";
            string dbIfDoCloseConnection = "Closing connections after use: prevents data locks and blocking, transactions are completed or rolled back, locks are released, frees up resources, improves performance, makes applications scalable";
            string dbCLRKeyCharacteristics = "Type safety, exception handling services, runtime security checks, executes intermediate language (compiled c#) automatic memory management";

            //ConnectionString
            //=========
            string dbSqlConnection = "required to establish a physical connectiono to the data source/database. Consists of Key-Value-Pairs (KVPs) separated by semi colons";
            string dbDataSource = "the name of the SQL server you want to connect to.";
            string dbDatabaseInitialCatalog = "the name of the database you want to connect to.";
            string dbIntegratedSecurity = "Determines whether the connections is secure. Valid values are true, false and SSPI. SSPI uses Windows integrated security and is equivalent to true";
            string dbPersistSecurityInfo = "Determines whether sensistive information, such as password, is returned as part of the connection. The default is false.";
            string dbEncrypt = "Used to explicitly configure Securities Policies or Exceptions";
            string dbConnectionStringExample = "server=(local);database=Northwind;integrated security=SSPI";
            string dbConnectionStringExampleII = "Data Source=(local);Initial Catalog=Northwind;integrated security=SSPI";
            string dbConnectionObjectExample = "SqlConnection conn = new SqlConnection(stringWeMadeAbove);";
            string dbConnectionOpenExample = "conn.Open();";
            string dbConnectionCloseExample = "conn.Close();";
            string dbUsingStatement = "Will close and dispose of the connection automatically";
            string dbUsingStatementExample = "using (SqlConnection conn = new SqlConnection(connStr)){" +
                                            "conn.Open()" +
                                             "}";
            //CommandObject
            //=========
            string dbCommandObjectII = "Enables access to database commands to get, create, modify and delete data, run stored procedures, and send and retrieve parameter information";
            string dbCommandObjectIII = "It represents a SQL statement or stored procedure to execute against a data source. It must know what SQL command to execute and what connection to use in order to do its job";
            string dbNuGetSystemdotDatadotSqlClient = "System.Data.SqlClient modern: Microsoft.Data.SqlClient";
            //Properties
            string dbSqlCommandConnection = "the connection used to connect to the database";
            string dbSqlCommandCommandText = "The SQL statement, the name of the stored procedure, or the name of the table";
            string dbSqlCommandCommandType = "A member of the CommandType enumeration that determines how the value in the CommandText property is interpreted";
            string dbSqlCommandParameters = "The collection of parameters for the command";
            //Methods
            string dbSqlCommandExecuteReader = "ExecuteReader(); Used when the SQL statement/stored pro returns more than a single value. Sends the CommandText to the Connection and builds a SqlDataReader";
            string dbSqlCommandExecuteNonQuery = "ExecuteNonQuery(); Used when we want to perform an insert, update, or delete operation. It executes a SQL statement/stored proc against the connection and returns the number of rows affected";
            string dbSqlCommandExecuteScalar = "ExecuteScalar(); Used when the query returns a single (scalar) value. It executes the SQL statement/stored proc and returns the firm column of the first row in the result set returned by the query. Any additional columns or rows are ignored";
            string dbSqlCommandExample = """
                
                using (SqlConnection conn = new SqlConnection("server=(local);database=Northwind;integrated security=SSPI"))
                {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Employee";

                conn.Open();

                }                
                """;
            string dbSqlCommandExampleII = """
                
                using (SqlConnection conn = new SqlConnection("server=(local);database=Northwind;integrated security=SSPI"))
                {
                SqlComman cmd = new SqlCommand("SELECT * FROM Employee", conn);                         

                conn.Open();

                }                
                """;

            //.NET Framework Data Providers
            //========================================================================            
            string OLEDBDataProvider = "Provides data access for OLE DB data sources. Uses System.Data.OleDb namespace";
            string ODBCDataProvider = "Provides data access for ODBC data sources. Uses System.Data.Odbc namespace";
            string OracleDataProvider = "Provides data access for Oracle databases. Uses System.Data.OracleClient namespace";
            string EntityClientDataProvider = "Provides data access for the Entity Data Model (EDM). Uses System.Data.EntityClient namespace";
            string SQLServerCompact4point0DataProvider = "Provides data access for SQL Server Compact 4.0 databases. Uses System.Data.SqlServerCe namespace";

            //SQL SERVER
            //=========
            string SQLServerDataProvider = "Provides data access for Microsoft SQL Server databases. Uses System.Data.SqlClient namespace";
            string connectionObjectDataProvider = "Establishes a connection to a specific data source";
            string commandObjectDataProvider = "Executes a command (SQL statement) against a data source";
            string dataReaderDataProvider = "Provides a way of reading a forward-only stream of data from a data source";
            string dataAdapterDataProvider = "Provides a way of filling a DataSet and updating a data source";





            Console.WriteLine("Hello, World!");
        }
    }
}
