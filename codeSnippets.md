C:\Users\Administrator\Documents\Visual Studio 2019\Code Snippets\Visual C#\My Code Snippets

* * *
# strj
Console.WriteLine($"{string.Join(", ", result)}");

* * *

# intarr

int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                
* * *

# strarr

string[] line = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();               
                
* * *

# ints

int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
Stack<int> myStack = new Stack<int>(numbers);
    
* * *

# intq    
 
int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    
Queue<int> myStack = new Queue<int>(numbers);
    
* * *

# strs
    
string[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            Stack<string> myStack = new Stack<string>(input);
    
* * *

# cr

Console.ReadLine();

* * *

# jag

int rows = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] currRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedMatrix[i] = currRow;
            }

            foreach (var row in jaggedMatrix)
            {
                Console.WriteLine($"{string.Join(", ", row)}");
            }

* * *

# dictclass

            /* Allows repeating names for the different colors
             * Tests:
             * Ivan apple red / 32 14.4
             * Slav; kiwi blue 17 33.10
             * Slav grape blue 18 , 12.4
             * Grigor apple red / 77 14.4
             * Mimi orange blue  \ 19 18.8
             * Koni grape yellow / 33   17.6
             * Mihail orange yellow 33   18.20
             * End
             * https://github.com/petiatodorova/CSharpExercises/blob/master/TheProject/DictClass/DictClassRep.cs
            */

            // Dictionary which holds the color as a Key Value and a List of Customr objects as Value
            
class DictClassRep
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Customr>> customers = new Dictionary<string, List<Customr>>();
            string newInput = Console.ReadLine();

            while (true)
            {
                if (newInput == "End")
                {
                    break;
                }
                Customr cust = ReadCustomr(newInput);
                string color = cust.Color;
                
                if (!customers.ContainsKey(color))
                {
                    customers[color] = new List<Customr>();
                }
                customers[color].Add(cust);

                newInput = Console.ReadLine();
            }

            foreach (var cust in customers)
            {
                string theColor = cust.Key;
                Console.WriteLine($"The Color: --> {theColor}");
                List<Customr> theValues = cust.Value;
                foreach (var person in theValues.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"Name: {person.Name} --> Total Money: {person.TotalMoney}");
                }
            }
        }

        static Customr ReadCustomr(string input)
        {
            string[] inputArr = input
                .Split(new char[] { ' ', '/', '\\', ';', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return new Customr
            {
                Name = inputArr[0],
                Fruit = inputArr[1],
                Color = inputArr[2],
                Quantity = double.Parse(inputArr[3]),
                Price = decimal.Parse(inputArr[4])
            };
        }
    }

    class Customr
    {
        public string Name { get; set; }
        public string Fruit { get; set; }
        public string Color { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal TotalMoney
        {
            get
            {
                return (decimal)Quantity * Price;
            }
        }
    }            


            
    
* * *

# dct

if (!marks.ContainsKey(name))
{
    marks[name] = new List<double>();
}
marks[name].Add(mark);


