using System;
using System.Security.Cryptography;

namespace employes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iscilerin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            Employes[] employees = new Employes[count];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"{i + 1}. Fullaname:");
                string fullname = Console.ReadLine();

                Console.Write($"{i + 1}. NO:");
                string no = Console.ReadLine();

                Console.Write($"{i + 1}. Salary:");
                int salary = Convert.ToInt32(Console.ReadLine());


                string opt;
                do
                {
                    Console.WriteLine("1. isciler uzerinde axtaris");
                    Console.WriteLine("2. Yeni isci yarat");
                    Console.WriteLine("0.  cixmaq");

                    opt = Console.ReadLine();

                    if (opt == "1")
                    {
                        Console.WriteLine("Axtaris deyerini daxil edin:");
                        string search = Console.ReadLine();

                        var filteredArr = SearchByName(employes, search);

                        ShowEmployesInfo(filteredArr);
                    }
                    else if (opt == "2")
                    {

                        try
                        {
                            var employes = CreateEmployes();
                            Array.Resize(ref employes, employes.Length + 1);
                            employes[employes.Length - 1] = employes;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Xeta bas verdi");
                            Console.WriteLine("Xeta: " + e.Message);

                        }
                    }

                } while (opt != "0");

            }

            static Employes[] SearchByName(Employes[] arr, string search)
            {
                Employes[] newArr = new Employes[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].name.Contains(search))
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1] = arr[i];
                    }
                }

                return newArr;
            }

            static void ShowEmployesInfo(Employes[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i].GetInfo());
                }
            }

            static void Add(ref Employes[] arr, Employes value)
            {
                Employes[] newArr = new Employes[arr.Length + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }

                newArr[newArr.Length - 1] = value;
                arr = newArr;
            }

            static Employes CreateEmployes()
            {
                Console.WriteLine("Ad:");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
                {
                    throw new Exception("Ad-in uzunlugu minimum 3 olmalidir");
                }

                Console.WriteLine("Soyad:");
                string surname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(surname) || surname.Length < 3)
                {
                    throw new Exception("Soyadin-in uzunlugu minimum 3 olmalidir");
                }

                Employes employe = new Employes
                {
                    Name = name,
                    Surname = surname
                };

                return employes;

            }
        }
    }
    







}
        }

    }


}