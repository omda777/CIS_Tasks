using System.ComponentModel;
using System.Threading.Tasks;

namespace Tasks_Systen
{
    internal class Program
    {
        string[] task_title = new string[10];
        string[] task_description = new string[10];
        DateTime[] task_date = new DateTime[10];
        string[] task_priority = new string[10];
        string[] task_state = new string[10];
        int index_task = -1;

        static void Main(string[] args)
        {
            
            int position = 0;
            bool flage = true;
            string[] meun = { "  Add  ", " UpDate ", "  View  ", "  Delete  " ,"  Exist  " };
            Program p1 = new Program();

            do
            {
                for (int i = 0; i < meun.Length; i++)
                {
                    if (i == position)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                    Console.SetCursorPosition(60, (i + 1) * (30 / 6));
                    Console.Write(meun[i]);
                }
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        position--;
                        if (position < 0)
                            position = meun.Length-1;
                        break;
                    case ConsoleKey.DownArrow:
                        position++;
                        if (position > meun.Length-1)
                            position = 0;
                        break;
                    case ConsoleKey.Enter:
                        switch (position)
                        {
                            case 0:
                                Console.Clear();
                                p1.Add();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 1:
                                Console.Clear();
                                p1.Update();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                p1.View();
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            case 3:
                                Console.Clear();
                                p1.delete();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 4:
                                flage = false;
                                break;
                           
                        }
                        break;
                }

            } while (flage);
        }
        
        public void Add()
        {
            index_task++;
            if(index_task == 10)
            {
                Console.WriteLine("you cant add new task");
                return; 
            }

            Console.Write("Enter task title: ");
            task_title[index_task] = Console.ReadLine();
            Console.Write("Enter task description: ");
            task_description[index_task] = Console.ReadLine();
            Console.Write("Enter due date yyyy-MM-dd : ");
            task_date[index_task] = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter priority (Low/Medium/High): ");
            task_priority[index_task] = Console.ReadLine();
            task_state[index_task] = "pending";
            Console.WriteLine("The ID of task is : {0}",index_task);
        }

        public void View()
        {
            
            if (index_task == -1)
            {
                Console.WriteLine("No tasks available."); 
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (task_title[i] == null)
                    continue;
                Console.WriteLine("Task ID :{0}",i);
                Console.WriteLine("Title   : {0} ", task_title[i]);
                if (task_state[i] == "completed")
                     Console.WriteLine("state   : completed ");
               else  if (task_date[i] >DateTime.Today)
                {
                    Console.WriteLine("state   : active ");
                }
                else
                    Console.WriteLine("state   : overdue ");

            }
        }
        public void Update()
        {
            Console.Write("Enter the ID of task : ");

            int id  =int.Parse(Console.ReadLine());
            if(id <10 && task_title[id] != null)
            {
                Console.Write("enter the state (pending / in progress / completed) : ");
                string s = Console.ReadLine();
                task_state[id] = s;
            }
            else
            {
                Console.WriteLine("wrong ID plz enter correct ID");
            }
        }
        public void delete() 
        {
            Console.Write("Enter the ID of task : ");
            int id = int.Parse(Console.ReadLine());
            if(id < 10)
            {
                task_title[id] = null;
                Console.WriteLine("the task is deleted sucssefull..... ");
            }

        }


    }
}