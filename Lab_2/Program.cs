using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab_2
{
    class Program
    {
        enum BankAccountType
        {
            Current,
            Savings
        }

        struct BankAccount
        {
            public int Number;
            public BankAccountType Type;
            public int Balance;
        }
        enum ВУЗ
        {
            КГУ,
            КАИ,
            КХТИ
        }

        struct Worker
        {
            public string Name;
            public ВУЗ ВУЗ_Name;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            /*Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
            счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
            значение и вывести это значение на печать.*/

            BankAccountType myBankAccountType = BankAccountType.Savings;
            Console.WriteLine("Тип счета: " + myBankAccountType);

            Console.WriteLine("\nУпражнение 3.2");
            /*Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            значениями и напечатать результат.*/

            BankAccount myBankAccount = new BankAccount();
            myBankAccount.Balance = 1000000;
            myBankAccount.Type = BankAccountType.Current;
            myBankAccount.Number = 1029384765;
            Console.WriteLine("Номер счета: {0}\nТип счета: {1}\nБаланс: {2:C}", myBankAccount.Number, myBankAccount.Type, myBankAccount.Balance);



            Console.WriteLine("\nДомашнее задание 3.1");
            /*Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
            распечатать.*/
            Worker firstWorker = new Worker();
            firstWorker.Name = "Salavat";
            firstWorker.ВУЗ_Name = ВУЗ.КГУ;
            Console.WriteLine("Имя работника: {0}\nВуз: {1}", firstWorker.Name, firstWorker.ВУЗ_Name);
        }
    }
}



