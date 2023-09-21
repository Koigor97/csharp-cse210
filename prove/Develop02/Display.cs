// The responsibilty of the Display class is to print on the console
// This class works hand in glove with Journal class and the main program.

public class Display 
{
    // this class has no attributes
    private string _filePath = $"journal/";
    private string _promptsPath = "prompts/questions.txt";
    private List<string> theList = new();
    public void ShowMenu()
    {
        Console.WriteLine("\n1.New Journal 📓 | 2.Continue 📝 | 3.Load Journal 📖 | 4.Delete Journal 🚮 | 5.Quit ❌");
    }

    public string [] CurrentFiles()
    {
        /// <summary>
        /// This method gets hold of the saved journal files from the directory,
        /// loops through the files and displays it for the user to choice which files
        /// he/she want's to access. And returns the files as a list of strings
        /// </summary>
        /// <returns> It returns a list of files. <typeparam name="string[]">a list of strings[]</typeparam> </returns>

        int indexNum = 0;  
        var files = Directory.GetFiles(_filePath); 
        Console.WriteLine("These are the files 📑 in your Journal Folder 🗂️:");
        foreach (string file in files)    
        {
            indexNum ++;
            Console.WriteLine($"---------------------------  {indexNum}. {Path.GetFileNameWithoutExtension(file)} 📄  -----------------------------");
        }
        return files;
    }

    public void LoadJournal ()
    {
        /// <summary>
        /// This method, call the CurrentFiles methods, that displays the loaded files,
        /// get the user's response on the file that should be loaded, and tells the user
        /// the file has been loaded.
        /// </summary>
        /// <returns> It returns nothing </returns>

        string [] file = CurrentFiles();
        Console.Write("\nWhich file 📄 do you want to load ?: ");
        int userChoice = int.Parse(Console.ReadLine());

        string fileContent = File.ReadAllText(file[userChoice - 1]);
        Console.WriteLine($"\n{fileContent}");
        Console.WriteLine("\n------------ Your file 📄 has been loaded ✅ ----------------\n");

    }

    public void FileDelete ()
    {
        /// <summary>
        /// This method deletes a journal file from the journal folder,
        /// call the CurrentFiles methods, that displays the loaded files,
        /// get the user's response on the file that should be deleted, and tells the user
        /// the file has been deleted.
        /// </summary>
        /// <returns> It returns nothing </returns>

        string [] file = CurrentFiles();
        Console.Write("\nWhich file 📄 do you want to load ?: ");
        int userChoice = int.Parse(Console.ReadLine());

        string delete = file[userChoice - 1];
        if (File.Exists(delete))
        {
            Console.WriteLine($"\n{Path.GetFileNameWithoutExtension(delete)} has been DELETED 🗑️");
            File.Delete(delete);
        }
        else
        {
            Console.WriteLine("File 📄 doesn't exist.");
        }
    }

    public string GetPrompt ()
    {
        /// <summary>
        /// This method gets hold of the prompts, stores them in a list,
        /// generate a random number based on the length of the list of prompts.
        /// Gets hold of a random prompt, remove that random prompt from the list
        /// and adds it to another list. It then adds the new list to the prompt list 
        /// if the prompts in the list.
        /// </summary>
        /// <returns> It returns a string - the prompt. <typeparam name="String">a string</typeparam> </returns>

        Random random = new();
        List<string> prompts = new();
        prompts.AddRange(File.ReadAllLines($"{_promptsPath}"));
        int randomIndex = random.Next(prompts.Count());
        string thePrompt = prompts[randomIndex];
        theList.Add(thePrompt);
        prompts.RemoveAt(randomIndex);
        if (prompts.Count() == 0)
        {
            prompts.AddRange(theList);
        }
        return thePrompt;
    }

}