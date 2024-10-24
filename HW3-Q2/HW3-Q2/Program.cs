Console.WriteLine("Enter count of numbers");
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];

Console.WriteLine("Enter the numbers:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"number[{i+1}] : ");
    numbers[i] = int.Parse(Console.ReadLine());
}
int count = 1;
    string result = "";  
string res (int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {

        if (i < numbers.Length - 1 && numbers[i] == numbers[i + 1])
        {
            count++;
        }
        else
        {

            if (count > 1)
            {
                result += numbers[i] + "^" + count;
            }
            else
            {
                result += numbers[i];
            }


            if (i < numbers.Length - 1)
            {
                result += "*";
            }


            count = 1;
        }
    }

    return result;
}
Console.WriteLine(res(numbers));