//for (int i = 1; i <= 3 ; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.WriteLine($"I = {i}, J = {j+1}");
//    }
//}



//int sum = 0;
//for (int i = 0; i < 5; i++)
//{
//    sum += int.Parse(Console.ReadLine());
//}
//Console.WriteLine(sum);



//int[] rs4= new int[5];
//for (int i = 0; i < rs4.Length; i++)
//{
//    rs4[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine();
//Console.WriteLine("Rezultat: ");
//for (int i = 0; i < rs4.Length; i++)
//{
//    Console.WriteLine(rs4[i]);
//}



//int[] arr = { 5, 2, 3, 52, 7 };
//bool contains52 = false;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 52)
//    {
//        contains52 = true;
//        break;
//    }
//}
//if (contains52)
//{
//    Console.WriteLine("The array contains 52");
//}
//else
//{
//    Console.WriteLine("The array doesn't contain 52");
//}



//int[] A = { 1, 2, 3, 4, 5 };
//int[] B = { 5, 4, 3, 2, 1 };
//int[] results = new int[5];
//for (int i = 0; i < A.Length; i++)
//{
//   results[i] = A[i] + B[i];
//}
//Console.WriteLine(String.Join(",", results));



int[] num = { 5, 3, 2, 1, 7 };
int max = num[0];
for (int i = 1; i < num.Length; i++)
{
    if (num[i] > max)
    {
        max = num[i];
    }
    
}
Console.WriteLine(max);   


