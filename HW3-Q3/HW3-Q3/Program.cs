Console.Write("String: ");
string str = Console.ReadLine();
Console.Write("number:");
int sep = int.Parse(Console.ReadLine());
string[] result_ar = new string[str.Length];
void def (string str, int sep)
{
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {

        if (i + sep <= str.Length)
        {
            result_ar[j] = str.Substring(i, sep);
            i += sep-1;
            j++;
        }
        else
        {
            result_ar[j] = str.Substring(i, 1);
            j++;
        }
    }

    foreach (string st in result_ar)
    {
        Console.WriteLine(st);
    }
}
def  (str, sep);