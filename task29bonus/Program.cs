int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void ConvertStrToInt(char[] arrStr, int[] arrNum)
{
    int temp;
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i] != ' ' && arrStr[i] != ',')
        {
            for (int j = 0; j < arrNum.Length; j++)
            {
                arrNum[j] = Convert.ToInt32(arrStr[i]) - 48;
                Console.Write($"{arrNum[j]} ");
                break;
            }
        }
    }

}
Console.WriteLine("Vvedite text");
string text = Console.ReadLine();
char[] arrString = new char[text.Length];
arrString = text.ToCharArray();
Console.WriteLine("vvedite size arr num");
int sizeNum = InputNumber();
int[] arrNumber = new int[sizeNum];
ConvertStrToInt(arrString, arrNumber);


// char test = '1'; //тут работает таблица ascii при преобразовании char 0 = 48 https://blog.skillfactory.ru/wp-content/uploads/2023/02/ascii_table-nocolor.svg-1541742.png
// int test2 = Convert.ToInt32(test);
// Console.WriteLine(test2);
