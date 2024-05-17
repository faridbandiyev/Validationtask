using System.Drawing;
using System.Xml.Schema;

namespace Validationtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;
            int idxSize = 0;
            int idxbradName = 0;
            int idxCategory = 0;
            int idxColor = 0;
            int idxPrice = 0;
            int idxCount = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                #region Arrays

                int[] sizes = new int[2];
                string[] brandNames = new string[2];
                string[] categories = new string[2];
                string[] colors = new string[2];
                decimal[] prices = new decimal[2];
                int[] counts = new int[2];

                #endregion

                #region Variable validation
                int size;
                string brandName;
                string category;
                string color;
                decimal price;
                int count;

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());
                    sizes[idxSize] = size;
                    if (size >= 30 && size <= 50)
                    {
                        idxSize++;
                        break;
                    }
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Brand name validation

                while (true)
                {
                    Console.Write("Brand name : ");
                    brandName = Console.ReadLine();
                    brandNames[idxbradName] = brandName;

                    if (brandName == "Adidas" || brandName == "Nike" || brandName == "Puma")
                    {
                        idxbradName++;
                        break;
                    }
                    else
                        Console.WriteLine("Brand adi duzgun daxil edilmeyib");
                }

                #endregion

                #region Category validation

                while (true)
                {
                    Console.Write("Category : ");
                    category = Console.ReadLine();
                    categories[idxCategory] = category;
                    if (category.Length > 8 || category.Length < 3)
                        Console.WriteLine("Duzgun category adi qeyd olunmayib");
                    else
                    {
                        idxCategory++;
                        break;
                    }
                }

                #endregion

                #region Color validation

                string[] possibleColors = { "Red", "Blue", "White", "Black" };

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();
                    int idx = 0;
                    bool isValidColor = false;
                    colors[idxColor] = color;
                    while (idx < possibleColors.Length)
                    {
                        if (color == possibleColors[idx])
                        {
                            isValidColor = true;
                            idxColor++;
                            break;
                        }
                        idx++;
                    }

                    if (isValidColor)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun color qeyd edilmeyib");
                    }
                }
                #endregion

                #region Price validation
                while (true)
                {
                    Console.Write("Price : ");
                    price = decimal.Parse(Console.ReadLine());
                    prices[idxPrice] = price;
                    if (price < 100 || price > 9999)
                    {
                        Console.WriteLine("Duzgun price qeyd edin");
                    }
                    else
                    {
                        idxPrice++;
                        break;
                    }

                }

                string[] currencies = { "AZN", "USD", "TL", "EURO" };

                while (true)
                {
                    Console.Write("Currency : ");
                    string currency = Console.ReadLine();
                    int idx = 0;
                    bool isValidCurrency = false;

                    while (idx < currencies.Length)
                    {
                        if (currencies[3] == currency)
                        {
                            isValidCurrency = true;
                            break;
                        }
                        idx++;
                    }

                    if (isValidCurrency)
                        break;
                    if (!isValidCurrency)
                        Console.WriteLine("Duzgun currency qeyd edin");
                }

                #endregion

                #region

                while (true)
                {
                    Console.Write("Count : ");
                    count = int.Parse(Console.ReadLine());
                    counts[idxCount] = count;

                    if (count > 0 && count < 30)
                    {
                        idxCount++;
                        break;
                    }
                    else
                        Console.WriteLine("Duzgun count qeyd edin");
                }

                #endregion

                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    break;

                }
                else if (loopTerminationResult == "Yes" || loopTerminationResult == "Y")
                    continue;
            }


            Console.WriteLine("Result Total : " + resultTotal);
        }
    }
}