
using uc2_FindFreqofparagraph;

Console.WriteLine("----- Hash table -----\n");

MyMapNode1<string, string> hash = new MyMapNode1<string, string>(5);
//hash.Add("0", "To");
//hash.Add("1", "be");
//hash.Add("2", "or");
//hash.Add("3", "not");
//hash.Add("4", "to");
//hash.Add("5", "be");
////string hash5 = hash.Get("5");
////Console.WriteLine("5th index value: " + hash5);
////string hash2 = hash.Get("2");
////Console.WriteLine("2th index value: " + hash2);

//hash.Display("5");
//hash.Display("2");

hash.GetFreq();
Console.ReadKey();