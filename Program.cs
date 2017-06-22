using System;
using System.Collections.Generic;

namespace csharp_todo_methods
{

  class Program
  {

    static void Main(string[] args)
    {



      List<string> todoList = new List<string>();
      string typeInput;

      while (0 < 1)
      {

        DisplayTodoItems();
      
        DisplayMenuPrompt();
        
        typeInput = UserInputPrompt();

        if (typeInput == "+") 
        {
          Console.WriteLine("Enter Todo Item to add:");
          todoList.Add(UserInputPrompt());
        }

        else if (typeInput == "-")
        {
          Console.WriteLine("Enter Todo Item to remove:");
          todoList.Remove(UserInputPrompt());
        }

        else if (typeInput == "--")
        {
          todoList.Clear();
        }

        else
        {
          Console.WriteLine("Invalid Entry! Please try again.");
        }
      }

      // Menu Prompt
      void DisplayMenuPrompt()
      {
        Console.WriteLine("##################################");
        Console.WriteLine("# Add a Todo Item with (+)       #");
        Console.WriteLine("# Remove a Todo Item with (-)    #");
        Console.WriteLine("# Clear all Todo Items with (--) #");
        Console.WriteLine("##################################");
      }

      // Display List
      void DisplayTodoItems()
      {
        Console.Clear();
        Console.WriteLine("Total Todo Items: " + todoList.Count);
        Console.WriteLine("Todo Items:");
        todoList.ForEach(Console.WriteLine);
        Console.WriteLine();
        Console.WriteLine();
      }

      string UserInputPrompt()
      {
        string userInput;
        userInput = (Console.ReadLine());
        return userInput;
      }
          
      // ..
    }
  }
}
