/* if i % 3 == 0 then (Fizz)
	if i % 5 == 0 then (Buzz)
*/


// namespace is like a 'Folder' that organizes your files
namespace FizzBuzz;

class Program{
    // Entry Point
    static void Main(string[] args){

        Console.WriteLine("Hello World");

    }

		// public (access to all classes)
		// private (restricted to only the same class declared in)
		// protected (accessed to itself and subclasses only)

		public static void FizzBuzz(int n){

			for (int i = 1; i < n; i++){

				if (i % 15 == 0){
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 5 == 0){
					Console.WriteLine("Buzz");
				}
				else if (i % 3 == 0){
					Console.WriteLine("Fizz");
				}
				else{
					Console.WriteLine(i);
				}
			}

		}
}
