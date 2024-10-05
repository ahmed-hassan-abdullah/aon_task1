using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.Drawing;

class Program
{
    //انشاء متغيرات ثوابت تحتوي على اسم المستخدم وكلمة المرور
    const string USERNAME = "ahmed hasan";
    const string PASSWORD = "19971997";

    //متغيرات المدخلات
    private static string? input_user;
    private static string? input_pass;

    //انشأنا الوظيفة الخاصة بتوريد ارقام عشوائية OTP
    
    public static string RandomNumberOtp()
    {
        Random random = new Random();
        return random.Next(300000, 877300).ToString(); 
    }
    //نهاية الوظيفة


    static void Main(string[] args)
    {

        //انشاء عملية تكرار للحلقة do While 
        do
        {

            Console.Write("*****Aon**************Task1***************************\n");
            //استخدام لكلاس والوضيفه الخاصة لطباعة وادخال الاسم
            Console.Write("Enter your name : \n");
            input_user = Console.ReadLine().ToLower();
            //ToLower-> تم استخدام هذه الدالة لتحويل اسم المستخدم الى حروف صغيره

            //استخدام لكلاس والوضيفه الخاصة لطباعة وادخال كلمة المرور
            Console.Write("Enter your password : \n");
            input_pass = Console.ReadLine();

            Console.Write("*****************************************************\n\n\n");


            //هنا استخدمنا شرط في حال كان الاسم و كلمة المرور صح نفذ التالي
            if (input_user == USERNAME && input_pass == PASSWORD)
            {

                //هنا تم بناء متغير وتم ربطه يساوي الوظيفة الخاصة بالارقام العشوائية
                string otp_number = RandomNumberOtp();

                Console.Write("##################################################\n\n");

                //طباعة الرقم العشوائي في حال تحقق الشرط

                Console.WriteLine($"The private number \n (OTP) is : {otp_number}\n\n" );

                Console.Write("##################################################\n\n");


                Console.Write("Enter your private number OTP : ");

                //استقبال الرقم الخاص
                string input_otp = Console.ReadLine();

                Console.Write("##################################################\n\n");

               
                //هنا انشأنا شرط اذا كان الرقم المدخل عن طرق المتغير
                //input_otp
                //يساوي الرقم الخاص اخرج لي الرساله -> You have successfully logged in
                if (input_otp == otp_number)
                {
                    Console.Write("\n");
                    Console.WriteLine("You have successfully logged in ");
                    System.Environment.Exit(1);
                }

                //في حال كان الرقم العشوائي خاطء سعرض رسالة مع التوقف
                Console.Write("__________________________________________________\n\n\n");
                Console.WriteLine("You have entered a wrong number.Try again");
                Console.Write("__________________________________________________\n\n");
                System.Environment.Exit(1);

            }
            //هنا انشأنا شرط اذا كان حقل الاسم فارغ سنخرج له رسالة انذار بان الحقل مطلوب
            else if (input_user == string.Empty)
            {
                Console.Write("*********************************************************\n");
                Console.WriteLine("Name field is required, do not leave it blank.");
                Console.Write("*********************************************************\n\n");

            }
            //هنا انشأنا شرط اذا كان حقل كلمة المرور فارغ سنخرج له رسالة انذار بان الحقل مطلوب
            else if (input_pass == string.Empty)
            {
                Console.Write("*********************************************************\n");    
                Console.WriteLine("Password field is required, do not leave it blank.");
                Console.Write("*********************************************************\n\n\n");

            }
            //في حال لم يترك الحقول فارغه وكانت المدخلات خاطئة معناها الاسم وكلمة المرور خاطئة 
            //سنخرج له الانذار التالي
            //Incorrect username or password. Please check the information.
            else
            {
                Console.Write("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
                Console.WriteLine("Incorrect username or password. Please check the information.");
                Console.Write("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
                System.Environment.Exit(1);
            }


        } while (true);
    }

   

}