using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    static string _path = "../../../City.txt";


    public class Temper
    {
        [JsonPropertyName("temp")] public double Value { get; set; }
    }

    public class City
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("main")] public Temper Temperature { get; set; }
    }

    public class Info
    {
        [JsonPropertyName("list")] public List<City> Cities { get; set; }
    }


    public static string GetJsonStringFromUrl(string url)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        Stream stream = response.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        string jsonString = reader.ReadToEnd();

        response.Close();
        return jsonString;
    }

    static void Main()
    {
        string city = File.ReadAllText(_path);
        string responseBody;
        try
        {
            responseBody = GetJsonStringFromUrl("http://openweathermap.org/data/2.5/find?q=" + city +
                                                "&appid=439d4b804bc8187953eb36d2a8c26a02&units=metric");
        }
        catch
        {
            Console.WriteLine("Города по умолчаию не обноруженно или город указан не верно");
        }

        Info info = new Info();

        if (city != "")
        {
            responseBody = GetJsonStringFromUrl("http://openweathermap.org/data/2.5/find?q=" + city +
                                                "&appid=439d4b804bc8187953eb36d2a8c26a02&units=metric");
            info = JsonSerializer.Deserialize<Info>(responseBody);
            foreach (var c in info.Cities)
            {
                Console.WriteLine("{0} - {1} C", c.Name,
                    Math.Round(c.Temperature.Value - 273.15, 2, MidpointRounding.ToEven));
            }
        }

        string choose;
        bool flag = true;
        while (flag)
        {
            Console.WriteLine(
                "Выберите команду (города вводить на англиском языке с малненькой буквы): \n 1 - сохранить/изменить город по умолчанию \n 2 - узнать погоду по городу с клавиатуры \n 3 - завершить работу программы");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.WriteLine("Введите город по умолчанию");
                    File.WriteAllText(_path, Console.ReadLine());
                    Console.WriteLine("Город по умолчанию сохранён");
                    break;
                case "2":
                    Console.WriteLine("Введите город ");
                    city = Console.ReadLine();
                    responseBody = GetJsonStringFromUrl("http://openweathermap.org/data/2.5/find?q=" + city +
                                                        "&appid=439d4b804bc8187953eb36d2a8c26a02&units=metric");

                    info = JsonSerializer.Deserialize<Info>(responseBody);

                    if (info.Cities.Count == 0)
                    {
                        Console.WriteLine("Не найдена информация по городу {0}", city);
                    }

                    foreach (var c in info.Cities)
                    {
                        Console.WriteLine("{0} - {1} C", c.Name,
                            Math.Round(c.Temperature.Value - 273.15, 2, MidpointRounding.ToEven));
                    }

                    break;
                case "3":
                    Console.WriteLine("Программа завершина ");
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Неверный формат ввода команды, попробуйте ещё раз ");
                    break;
            }
        }

    }
}
