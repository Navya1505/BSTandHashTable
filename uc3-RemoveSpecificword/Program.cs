using uc3_RemoveSpecificword;
Console.WriteLine("----- Hash table -----\n");


MyMapNode2<string, string> hash = new MyMapNode2<string, string>(5);
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


hash.RemoveWord();
Console.ReadKey();