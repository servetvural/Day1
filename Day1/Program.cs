//SOLUTION 1
//StreamReader reader = new StreamReader("input.txt");

//int total = 0;

//while (true)
//{
//    string theLine = reader.ReadLine();
//    if (theLine == null)
//        break;
//    else
//    {
//        string str = "";
//        for (int i = 0; i < theLine.Length; i++)
//        {
//            if (Char.IsDigit(theLine[i]))
//            {
//                str = theLine[i].ToString();
//                break;
//            }
//        }
//        for (int i = theLine.Length - 1; i >= 0; i--)
//        {
//            if (Char.IsDigit(theLine[i]))
//            {
//                str += theLine[i].ToString();
//                break;
//            }
//        }
//        if (str != "")
//        {
//            total += int.Parse(str);
//        }
//    }
//}


//SOLUTION 2
StreamReader reader = new StreamReader("input.txt");

int total = 0;

List<Tuple<string, int>> nums = new List<Tuple<string, int>>() {
    Tuple.Create("one",1), 
    Tuple.Create("two",2),
    Tuple.Create("three",3),
    Tuple.Create("four",4),
    Tuple.Create("five",5),
    Tuple.Create("six",6),
    Tuple.Create("seven",7),
    Tuple.Create("eight",8),
    Tuple.Create("nine",9)
};

while (true) {
    string theLine = reader.ReadLine();
    if (theLine == null)
        break;
    else
    {
        int firstindex = 0;
        string firstdigit = "";
        int lastindex = 0;
        string lastdigit = "";
        string str = "";
        for (int i=0; i<theLine.Length; i++)
        {
            if (Char.IsDigit(theLine[i]))
            {
                firstdigit = theLine[i].ToString();
                firstindex = i;
                break;
            }                
        }
        for (int i = theLine.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(theLine[i]))
            {
                lastdigit = theLine[i].ToString();
                lastindex = i;
                break;
            }
        }

        for (int i=0; i < nums.Count; i++)
        {
            if (theLine.IndexOf(nums[i].Item1) >=0 && theLine.IndexOf(nums[i].Item1) < firstindex)
            {
                firstindex = theLine.IndexOf(nums[i].Item1);
                firstdigit = nums[i].Item2.ToString();
            }
            if ( theLine.LastIndexOf(nums[i].Item1) > lastindex)
            {
                lastindex = theLine.LastIndexOf(nums[i].Item1);
                lastdigit = nums[i].Item2.ToString();
            }
        }
       
        str = firstdigit + lastdigit;
                
        if (str != "")
        {
            total += int.Parse(str);
        }
    }
}

Console.WriteLine(total);

Console.ReadLine();
