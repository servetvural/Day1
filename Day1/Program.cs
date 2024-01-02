StreamReader reader = new StreamReader("input.txt");

int total = 0;

while (true) {
    string theLine = reader.ReadLine();
    if (theLine == null)
        break;
    else
    {
        string str = "";
        for (int i=0; i<theLine.Length; i++)
        {
            if (Char.IsDigit(theLine[i]))
            {
                str = theLine[i].ToString();
                break;
            }                
        }
        for (int i = theLine.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(theLine[i]))
            {
                str += theLine[i].ToString();
                break;
            }
        }
        if (str != "")
        {
            total += int.Parse(str);
        }
    }
}

Console.WriteLine(total);

Console.ReadLine();
