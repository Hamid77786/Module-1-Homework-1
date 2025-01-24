//1.Verilmiş iki ədədin cəmini hesablayan proqram yazın.

//Console.WriteLine("Enter the number:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter the number two:");
//double b = double.Parse(Console.ReadLine());
//double sum = a + b;
//Console.WriteLine(sum);
//-----------------------------------------------------------------------------------

////6.İstifadəçidən 1 - dən 7 - yə qədər bir rəqəm daxil etməsini istəyin və ona uyğun həftənin gününü çap edin.Məsələn: 1 → Bazar ertəsi, 2 → Çərşənbə axşamı və s.

//Console.WriteLine("Enter number of Week:");
//int numberOfWeek = int.Parse(Console.ReadLine());

//if (numberOfWeek < 1 || numberOfWeek > 7)
//{
//    Console.WriteLine("Choose the correct number!");

//}
//else
//{
//    switch (numberOfWeek)
//    {
//        case 1:
//            Console.WriteLine("Monday");
//            break;
//        case 2:
//            Console.WriteLine("Tuesday");
//            break;
//        case 3:
//            Console.WriteLine("Wednesday");
//            break;
//        case 4:
//            Console.WriteLine("Thursday");
//            break;
//        case 5:
//            Console.WriteLine("Friday");
//            break;
//        case 6:
//            Console.WriteLine("Saturday");
//            break;
//        case 7:
//            Console.WriteLine("Sunday");
//            break;

//    }

//}
////-------------------------------------------------------------------------------------------

////8.İstifadəçidən parol istəyin. Əgər parol düzgünsə, "Giriş uğurludur", əks halda "Yanlış parol" yazdırın.Məsələn: Doğru parol: 12345.
//Console.WriteLine("Enter parol:");
//int parol = int.Parse(Console.ReadLine());
//if(parol==12345)
//{
//    Console.WriteLine("Parol success!");
//}
//else
//{
//    Console.WriteLine("Choose correct combination!");
//}
//-----------------------------------------------------------------------------------------------
////2.Verilmiş ədədin cüt və ya tək olduğunu təyin edən proqram yazın.
//Console.WriteLine("If you want know number couple or alone,enter number:");
//int number = int.Parse(Console.ReadLine());
//if (number%2==0)
//{
//    Console.WriteLine("Number is couple!");
//}
//else
//{
//    Console.WriteLine("Number is alone!");
//}
////---------------------------------------------------------------------------------------------
//4.İstifadəçinin yaşına əsasən, onu bir kateqoriyaya aid edin:
//0 - 12: Uşaq
//13-19: Yeniyetmə
////20 və yuxarı: Böyük.
//Console.WriteLine("Enter User by number of old:");
//int number = int.Parse(Console.ReadLine());
//if (number >=0&&number<=12)
//{
//    Console.WriteLine("Usaq");
//}
//else if(number>=13&&number<=19)
//{
//    Console.WriteLine("Yeniyetme");
//}
//else if (number>=20)
//{
//    Console.WriteLine("Boyuk");
//}
//---------------------------------------------------------------------------------
//5.

////İki ədəddən hansının daha böyük olduğunu müəyyən edən proqram yazın.
//int number1 = int.Parse(Console.ReadLine());
//int number2 = int.Parse(Console.ReadLine());
//if (number1>number2)
//{
//    Console.WriteLine("Boyukdur");
//}
//else
//{
//    Console.WriteLine("Balacadir");
//}
//-------------------------------------------------------------------------------------
////3.Verilmiş bir ədədin müsbət, mənfi və ya sıfır olub-olmadığını təyin edən proqram yazın.
//Console.WriteLine("Enter number:");
//int number = int.Parse(Console.ReadLine());
//if (number == 0)
//{
//    Console.WriteLine("Sifirdir!");

//}
//else if(number<0)
//{
//    Console.WriteLine("Menfidir!");
//}
//else if(number>0)
//{
//    Console.WriteLine("Musbetdir!");
//}
//----------------------------------------------------------------------------------------
