// معلومات مهمه

/*

 انواع البيانات

int = ارقام صحيحه مثال 2
double = ارقام مع فاصله مثال 3.6
string = حروف او ارقام او جمل
bool = صحيح و غير صحيح

يمديك تشوف طريقة استخدامها تحت

 */

using System;

namespace LearingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstLeason();
            //SecondLeason();
            //ThirdLeason();
            FourthLeason();
        }

        static void FirstLeason()
        {
            Console.Write("Hello"); // بدون سطر جديد
            Console.WriteLine("Hello Worlds"); // مع سطر جديد

            // انواع السلاشات
            Console.WriteLine("KrezDev"); // b n t

            Console.ReadKey(); // لازم اضغط زر عشان يقفل
        }

        static void SecondLeason()
        {
            int x; // تعريف

            x = 123; // قيمة التعريف

            int y = 321; // تعريف + قيمة التعريف

            int z = x + y; // تعريف يجمع المتغيرات

            int age = 18; // int = ارقام ثابته

            double Earth = 25.5; // double = ارقام مع كسر عشري
            double Sea = 74.5;

            bool Dev = true; // bool = صحيح او غير صحيح

            char symbol = '@'; // char = رمز واحد فقط تستطيع كتابتة هنا

            string Name = "KrezDev"; // String = يمكنك كتابة جمل او اكثر من حرف ورقم
            string UserName = symbol + Name;

            Console.WriteLine("Your Name is: " + Name);
            Console.WriteLine("Your Age is : " + age);
            Console.WriteLine("Your Symbol is: " + symbol);
            Console.WriteLine("Your Username Is: " + UserName);
            Console.WriteLine("Are You A Good Developer? : " + Dev);
            Console.WriteLine("The proportion of the land is : " + Earth);
            Console.WriteLine("The proportion of the sea is : " + Sea);

            Console.ReadKey();
        }

        static void ThirdLeason()
        {
            const double Coins = 120.6; // const = قيمة ثابته غير قابله للتغيير

            Console.WriteLine(Coins);
        }

        static void FourthLeason()
        {
            // المثال الاول

            double a = 9.35;

            // Convert = هي مكتبة يمديك تحول فيها المتغيرات الى متغيرات اخره
            int b = Convert.ToInt32(a); // Double بدل Int الى A مثال حولنا

            Console.WriteLine(b);
            
            Console.WriteLine(b.GetType()); // عشان يكتب لك نوع البيانات المستخدم GetType() يمديك تكتب

            // المثال الثاني

            int c = 8;

            double d = Convert.ToDouble(c) + 0.3; // و اضفنا لهم رقم زياده double الى int حولنا

            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}