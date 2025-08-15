// Calculate factorial !5 = 5*4*3*2*1

PrintGirectoryFileSystemEntries(@"C:\Users\MK\Downloads\Algoriza Internship",1);
var size = CalculateDirectorySize(@"C:\Users\MK\Downloads\Algoriza Internship");
Console.WriteLine(size/1024);
static void PrintGirectoryFileSystemEntries(string dirPath, int level)
{
    foreach (var fileSystem  in Directory.GetFiles(dirPath))
    {
        Console.WriteLine($"{new string('-', level)} {new FileInfo (fileSystem).Name}");
    }
    foreach (var dirName in Directory.GetDirectories(dirPath))
    {
        Console.WriteLine($"{new string('-', level)} {new DirectoryInfo(dirName).Name}");
        PrintGirectoryFileSystemEntries(dirName, level +1);
    }

}

static long CalculateDirectorySize(string dirPath)
{
    long size = 0;

    foreach (var fileName in Directory.GetFiles(dirPath))
    {
        size += new FileInfo(fileName).Length;
    }
    foreach (var dirName in Directory.GetDirectories(dirPath))
    {
        size += CalculateDirectorySize(dirName);
    }
    return size;

}






static int CalculateFactorial(int number)
{
    int factorial = 1;
    for(int i =1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;


    //if(number <= 1)
    //{
    //    return number;
    //}

    //return number * CalculateFactorial(number -1);

};


//Console.Write("Enter your number : ");
//int yourNumber = int.Parse(Console.ReadLine());

//Console.WriteLine(CalculateFactorial(yourNumber));
