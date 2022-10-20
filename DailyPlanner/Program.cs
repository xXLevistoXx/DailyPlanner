
namespace DailyPlanner
{
    internal class Program
    {
        static void Main()
        {
            DateTime date = new DateTime(2022, 10, 15);
            Notes task1 = new Notes();
            {
                task1.Name = "Complete all practic work";
                task1.Description = "Subjects: Python, MS Word, Phylosophy";
            }
            Notes task2 = new Notes();
            {
                task2.Name = "Do house cleaning";
                task2.Description = "Wipe dust, mirrors and vacuum";
            }
            Notes task3 = new Notes();
            {
                task3.Name = "Watch some movies";
                task3.Description = "\"Prestige\", \"best offer\" or \"illusionist\"";
            }
            Notes task4 = new Notes();
            {
                task4.Name = "Go to study";
                task4.Description = "From 1 to 4";
            }
            Notes task5 = new Notes();
            {
                task5.Name = "Go to walk";
                task5.Description = "Walkin with my friends";
            }
            Notes new_task = new Notes();
            {
                new_task.Name = "Add new task";
                new_task.Description = "";
            }
            List<Notes> tasks_Date_One = new List<Notes>();
            tasks_Date_One.Add(task1);
            tasks_Date_One.Add(task2);
            tasks_Date_One.Add(new_task);
            List<Notes> tasks_Date_Two = new List<Notes>();
            tasks_Date_Two.Add(task3);
            tasks_Date_Two.Add(task4);
            tasks_Date_Two.Add(new_task);
            List<Notes> tasks_Date_Three = new List<Notes>();
            tasks_Date_Three.Add(task5);
            tasks_Date_Three.Add(new_task);


            Menu1(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
        }

        static void Menu1(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            ConsoleKeyInfo arrowLR = Console.ReadKey();
            do
            {
                if (arrowLR.Key != ConsoleKey.Enter)
                {
                    while (arrowLR.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        date = date.AddDays(1);
                        Console.WriteLine(" Selected date: " + date.Date.ToString("dd/MM/yyyy"));
                        switch (date.Day)
                        {
                            case 15:
                                foreach (Notes note in tasks_Date_One)
                                {
                                    Console.WriteLine("  " + note.Name);
                                }
                                break;
                            case 16:
                                foreach (Notes note in tasks_Date_Two)
                                {
                                    Console.WriteLine("  " + note.Name);
                                }
                                break;
                            case 17:
                                foreach (Notes note in tasks_Date_Three)
                                {
                                    Console.WriteLine("  " + note.Name);
                                }
                                break;
                            case > 17:
                                Console.WriteLine("  " + new_task.Name);
                                break;
                            case < 15:
                                Console.WriteLine("  " + new_task.Name);
                                break;
                        }
                        arrowLR = Console.ReadKey();
                    }
                }
                if (arrowLR.Key != ConsoleKey.Enter)
                {
                    while (arrowLR.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();
                        date = date.AddDays(-1);
                        Console.WriteLine(" Selected date: " + date.Date.ToString("dd/MM/yyyy"));
                        if (date.Day == 15)
                        {
                            foreach(Notes note in tasks_Date_One)
                            {
                                Console.WriteLine("  " + note.Name);
                            }
                        }
                        if (date.Day == 16)
                        {
                            foreach (Notes note in tasks_Date_Two)
                            {
                                Console.WriteLine("  " + note.Name);
                            }
                        }
                        if (date.Day == 17)
                        {
                            foreach (Notes note in tasks_Date_Three)
                            {
                                Console.WriteLine("  " + note.Name);
                            }
                        }
                        if (date.Day < 15)
                        {
                            
                            Console.WriteLine("  " + new_task.Name);
                        }
                        if (date.Day > 17)
                        {
                            Console.WriteLine("  " + new_task.Name);
                        }
                        arrowLR = Console.ReadKey();
                    }
                }
                if(arrowLR.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
                
            } while (arrowLR.Key == ConsoleKey.LeftArrow || arrowLR.Key == ConsoleKey.RightArrow);
            Menu2(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
            
        }
        static void Menu2(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            int position = 1;
            switch (date.Day)
            {
                case 15:
                    foreach (Notes note in tasks_Date_One)
                    {
                        Console.Clear();
                        Console.WriteLine("  " + note.Name);
                        Console.Clear();
                    }
                    break;
                case 16:
                    foreach (Notes note in tasks_Date_Two)
                    {
                        Console.Clear();
                        Console.WriteLine("  " + note.Name);
                        Console.Clear();
                    }
                    break;
                case 17:
                    foreach (Notes note in tasks_Date_Three)
                    {
                        Console.Clear();
                        Console.WriteLine("  " + note.Name);
                        Console.Clear();
                    }
                    break;
                case > 17:
                    Console.Clear();
                    Console.WriteLine("  " + new_task.Name);
                    Console.Clear();
                    break;
                case < 15:
                    Console.Clear();
                    Console.WriteLine("  " + new_task.Name);
                    Console.Clear();
                    break;
            }
            ConsoleKeyInfo arrowUD = Console.ReadKey();
            while (arrowUD.Key != ConsoleKey.Escape)
            {
                if (arrowUD.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                if (arrowUD.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                if (position < 1)
                {
                    position++;
                    Console.SetCursorPosition(0, position);
                }
                if (position > 3)
                {
                    position--;
                    Console.SetCursorPosition(0, position);
                }
                if (date.Day < 15)
                {
                    position--;
                    Console.SetCursorPosition(0, position);
                    if(position < 1)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                    }
                }
                if (date.Day > 18)
                {
                    position--;
                    Console.SetCursorPosition(0, position);
                    if (position < 1)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                    }
                }
        
                else if (arrowUD.Key == ConsoleKey.Enter & position == 1 & date.Day == 15)
                {
                    Task_1_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 2 & date.Day == 15)
                {
                    Task_2_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 3 & date.Day == 15)
                {
                    Create_New_Task_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 1 & date.Day == 16)
                {
                    Task_3_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 2 & date.Day == 16)
                {
                    Task_4_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 3 & date.Day == 16)
                {
                    Create_New_Task_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 1 & date.Day == 17)
                {
                    Task_5_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 2 & date.Day == 17)
                {
                    Create_New_Task_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 1 & date.Day >= 18)
                {
                    Create_New_Task_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                else if (arrowUD.Key == ConsoleKey.Enter & position == 1 & date.Day < 15)
                {
                    Create_New_Task_Description(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                if(arrowUD.Key == ConsoleKey.LeftArrow || arrowUD.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Menu1(tasks_Date_One, tasks_Date_Two, tasks_Date_Three, task1, task2, task3, task4, task5, new_task, date);
                }
                if (date.Day == 17)
                {
                    if (position < 1)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                    }
                    if (position > 2)
                    {
                        position--;
                        Console.SetCursorPosition(0, position);
                    }
                }

                Console.Clear();
                Console.WriteLine(" Selected date: " + date.Date.ToString("dd/MM/yyyy"));
                switch (date.Day)
                {
                    case 15:
                        foreach (Notes note in tasks_Date_One)
                        {
                            Console.WriteLine("  " + note.Name);
                        }
                        break;
                    case 16:
                        foreach (Notes note in tasks_Date_Two)
                        {
                            Console.WriteLine("  " + note.Name);
                        }
                        break;
                    case 17:
                        foreach (Notes note in tasks_Date_Three)
                        {
                            Console.WriteLine("  " + note.Name);
                        }
                        break;
                    case > 17:
                        Console.WriteLine("  " + new_task.Name);
                        break;
                    case < 15:
                        Console.WriteLine("  " + new_task.Name);
                        break;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                arrowUD = Console.ReadKey();
            }

            Console.Clear();
        }
        static void Task_1_Description(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            Console.Clear();
            Console.WriteLine(task1.Name);
            Console.WriteLine(task1.Description);
            Console.WriteLine("--------------------");
            Console.WriteLine(date);
            ConsoleKeyInfo back = Console.ReadKey();
        }

        static void Task_2_Description(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            Console.Clear();
            Console.WriteLine(task2.Name);
            Console.WriteLine(task2.Description);
            Console.WriteLine("--------------------");
            Console.WriteLine(date);
            ConsoleKeyInfo back_key = Console.ReadKey();
        }

        static void Create_New_Task_Description(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("Add task's name: ");
            new_task.Name = Console.ReadLine();
            Console.WriteLine("Add task's Description: ");
            new_task.Description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(new_task.Name);
            Console.WriteLine(new_task.Description);
            Console.WriteLine("--------------------");
            Console.WriteLine(date);
            ConsoleKeyInfo back = Console.ReadKey(); 
        }

        static void Task_3_Description(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            Console.Clear();
            Console.WriteLine(task3.Name);
            Console.WriteLine(task3.Description);
            Console.WriteLine("--------------------");
            Console.WriteLine(date);
            ConsoleKeyInfo back = Console.ReadKey();
        }

        static void Task_4_Description(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {
            Console.Clear();
            Console.WriteLine(task4.Name);
            Console.WriteLine(task4.Description);
            Console.WriteLine("--------------------");
            Console.WriteLine(date);
            ConsoleKeyInfo back = Console.ReadKey();
        }

        static void Task_5_Description(List<Notes> tasks_Date_One, List<Notes> tasks_Date_Two, List<Notes> tasks_Date_Three, Notes task1, Notes task2, Notes task3, Notes task4, Notes task5, Notes new_task, DateTime date)
        {

            Console.Clear();
            Console.WriteLine(task5.Name);
            Console.WriteLine(task5.Description);
            Console.WriteLine("--------------------");
            Console.WriteLine(date);
            ConsoleKeyInfo back = Console.ReadKey();
        }
    }
}