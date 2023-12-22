using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ConsoleApplication1diary;

internal class Program
{
    static string _pathToFile =
        "../../../diary.json";

    static void Main()
    {
        string choose = "";
        bool flag = true;

        while (flag)
        {
            Console.WriteLine(
                " \n Введите команду: \n 1 - Добавить задачу \n 2 - Удалить задачу \n 3 - Посмотреть все задачи \n 4 - Посмотреть все предстоящие задачи \n 5 - Посмотреть все прошедшие задачи \n 6 - Посмотреть все задачи на сегодня \n 7 - Посмотреть все задачи на завтра \n 8 - Посмотреть все задачи на эту неделю \n 9 - Изменить задачу \n 0 - Завершить работу программы");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    CreateNewTask();
                    break;
                case "2":
                    Delete();
                    break;
                case "3":
                    WriteAllTasks();
                    break;
                case "4":
                    WriteUpcominTasks();
                    break;
                case "5":
                    WritePastTasks();
                    break;
                case "6":
                    WriteTodayTasks();
                    break;
                case "7":
                    WriteTomorrowTasks();
                    break;
                case "8":
                    WriteWeekTasks();
                    break;
                case "9":
                    Update();
                    break;
                case "0":
                    Console.WriteLine("Программа завершина ");
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Некоректный формат ввода комманды ");
                    break;
            }
        }

    }


    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desckription { get; set; }
        public DateTime DateOfCompletion { get; set; }
    }

    public static void CreateNewTask()
    {
        List<Task> allTasks = SelectAll();
        int lastIdx;
        if (allTasks.Count == 0)
        {
            lastIdx = 0;
        }
        else
        {
            lastIdx = allTasks.Last().Id;
        }

        Task task = new Task();
        task.Id = lastIdx + 1;
        Console.WriteLine("Введите заголовок ");
        task.Title = Console.ReadLine();
        Console.WriteLine("Введите описание ");
        task.Desckription = Console.ReadLine();
        Console.WriteLine("Введите дату (ГГГГ-ММ-ДД)");
        try
        {
            task.DateOfCompletion = DateTime.Parse(Console.ReadLine());
            allTasks.Add(task);
            Console.WriteLine("Задача добавленна");
            _saveList(allTasks);
        }
        catch
        {
            Console.WriteLine("Не коректный формат ввода даты");
            Console.WriteLine("Задача не добавленна");
        }

    }

    private static void _saveList(List<Task> tasks)
    {
        string json = JsonConvert.SerializeObject(tasks);
        File.WriteAllText(_pathToFile, json);
    }

    public static List<Task> SelectAll()
    {
        string json = File.ReadAllText(_pathToFile);
        List<Task> allTasks = JsonConvert.DeserializeObject<List<Task>>(json);
        if (allTasks == null)
        {
            allTasks = new List<Task>();
        }

        return allTasks;
    }

    public static void WriteAllTasks()
    {
        List<Task> allTasks = SelectAll();
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string json = JsonSerializer.Serialize<List<Task>>(allTasks, options);
        Console.WriteLine(json);
    }

    public static void Delete()
    {
        List<Task> allTasks = SelectAll();
        int id = 0;
        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Неверный формат ввода Id");
        }

        Task? task = allTasks.FirstOrDefault(x => x.Id == id);
        if (task != null)
        {
            allTasks.Remove(task);
            _saveList(allTasks);
            Console.WriteLine("Задача успешно удаленна ");
        }
        else
        {
            Console.WriteLine("Некоректно введён ID или задача была удаленна рание ");
        }
    }

    public static void WriteUpcominTasks()
    {
        List<Task> allTasks = SelectAll();
        Task task = new Task();
        string json = "";
        string res = "";
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        for (int i = 0; i < allTasks.Count; i++)
        {
            if (allTasks[i].DateOfCompletion > DateTime.Now)
            {
                json = JsonSerializer.Serialize<Task>(allTasks[i], options);
                res = json + "\n";
            }
        }

        if (json != "")
        {
            Console.WriteLine($"Предстоящие задачи: \n {res}");
        }
        else
        {
            Console.WriteLine("Предстоящие задачи отсутствуют");
        }
    }


    public static void WritePastTasks()
    {
        List<Task> allTasks = SelectAll();
        Task task = new Task();
        string json = "";
        string res = "";
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        for (int i = 0; i < allTasks.Count; i++)
        {
            if (allTasks[i].DateOfCompletion < DateTime.Now)
            {
                json = JsonSerializer.Serialize<Task>(allTasks[i], options);
                res += json + "\n";
            }
        }

        if (json != "")
        {
            Console.WriteLine($"Прошедшие задачи: \n {res}");
        }
        else
        {
            Console.WriteLine("Прошедшие задачи отсутствуют");
        }
    }


    public static void WriteTodayTasks()
    {
        List<Task> allTasks = SelectAll();
        Task task = new Task();
        string json = "";
        string res = "";
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        for (int i = 0; i < allTasks.Count; i++)
        {
            if (allTasks[i].DateOfCompletion == DateTime.Today)
            {
                json = JsonSerializer.Serialize<Task>(allTasks[i], options);
                res += json + "\n";
            }
        }

        if (json != "")
        {
            Console.WriteLine($"Задачи на сегодня: \n {res}");
        }
        else
        {
            Console.WriteLine("Задачи на сегодня отсутствуют");
        }
    }

    public static void WriteTomorrowTasks()
    {
        List<Task> allTasks = SelectAll();
        Task task = new Task();
        string json = "";
        string res = "";
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        for (int i = 0; i < allTasks.Count; i++)
        {
            if (allTasks[i].DateOfCompletion == DateTime.Today.AddDays(1))
            {
                json = JsonSerializer.Serialize<Task>(allTasks[i], options);
                res += json + "\n";
            }
        }

        if (json != "")
        {
            Console.WriteLine($"Задачи на завтра: \n {res}");
        }
        else
        {
            Console.WriteLine("Задачи на завтра отсутствуют");
        }
    }

    public static void WriteWeekTasks()
    {
        List<Task> allTasks = SelectAll();
        Task task = new Task();
        string json = "";
        string res = "";
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        int weekConvert = (int)DateTime.Today.DayOfWeek;
        if (weekConvert == 0)
        {
            weekConvert = 7;
        }

        for (int i = 0; i < allTasks.Count; i++)
        {
            if (allTasks[i].DateOfCompletion > DateTime.Now &&
                allTasks[i].DateOfCompletion <= DateTime.Today.AddDays(7 - weekConvert))
            {
                json = JsonSerializer.Serialize<Task>(allTasks[i], options);
                res += json + "\n";
            }
        }

        if (json != "")
        {
            Console.WriteLine($"Задачи на неделю: \n {res}");
        }
        else
        {
            Console.WriteLine("Задачи на неделю отсутствуют");
        }
    }


    public static void Update()
    {
        List<Task> allTasks = SelectAll();
        Console.WriteLine("Введите Id задачи");
        int id = 0;
        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Неверный формат ввода Id");
        }

        Task? task = allTasks.FirstOrDefault(x => x.Id == id);
        if (task != null)
        {
            Console.WriteLine("Введите заголовок ");
            task.Title = Console.ReadLine();
            Console.WriteLine("Введите описание ");
            task.Desckription = Console.ReadLine();
            Console.WriteLine("Введите дату (ГГГГ-ММ-ДД)");
            try
            {
                task.DateOfCompletion = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Задача успешна изменена");
                _saveList(allTasks);
            }
            catch
            {
                Console.WriteLine("Не коректный формат ввода даты");
                Console.WriteLine("Задача не изменена");
            }
        }

    }
}