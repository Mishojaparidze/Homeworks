using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO.Compression;

namespace Homework11
{

    
    public class Myclass
    {


        public string key1 { get;}
        public string key2 { get;}
        
    }
    internal class Program
    {
        static void getAndSaveWordsInFile()
        {
            Console.WriteLine("Enter numbers of words you want to enter: ");
            var words = new List<string>();
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter words: ");
            for (int i = 0; i < n; i++)                    //get words from console and adds to list
            {
                var x = Console.ReadLine();
                words.Add(x);
            }

            string inputFilePath = @"C:\Users\misho\Desktop\Homeworks\lecture";
            if (!File.Exists(inputFilePath))            //checks if file is already created or not, if not creates new one
            {
                File.Create(inputFilePath);
            }
            for (int i = 0; i < n; i++)       //saves words from list to file
            {
                var word = words[i];
                File.AppendAllText(inputFilePath, word + Environment.NewLine);
            }
            StreamReader lastSentenceReader = File.OpenText(inputFilePath);

            var lastLine = File.ReadLines(inputFilePath).Last();   
            Console.WriteLine(lastLine);   //prints last sentence
        }
        static void multiplicationTable() 
        {
            var n = Convert.ToInt32(Console.ReadLine());
            string table = @"C:\Users\misho\Desktop\Homeworks\multiplicationTable";
            for (int i = 1; i <= n; i++)  //first iteration for counting numbers from 1 to entered numbers
            {
                for (int k = 1; k < 11; k++) //second iteration for 1 to 10
                {
                    var number = i * k;
                    File.AppendAllText(table, number + Environment.NewLine); //adds multiplication table on the new lines
                }
            }
        }
        static void countingDaysToBirthday()
        {
            StreamReader r = new StreamReader(@"C:\Users\misho\source\repos\Homeworks\Homework11\jsconfig1.json");
            string jsonString = r.ReadToEnd();
            Myclass m = JsonConvert.DeserializeObject<Myclass>(jsonString);
            int todayDate = Convert.ToInt32(m.key1);
            int birthdayDate = Convert.ToInt32(m.key2);
            int numberOfDays = birthdayDate - todayDate;
            Console.WriteLine(numberOfDays);
        }
        static void workingWithFiles()
        {
            Console.WriteLine("Solution-N6");
            string fileName = @"C:\mydir.old\myfile.ext";
            string path = @"C:\mydir.old\";
            string extension;

            extension = Path.GetExtension(fileName);
            Console.WriteLine("GetExtension('{0}') returns '{1}'", fileName, extension);

            extension = Path.GetExtension(path);
            Console.WriteLine("GetExtension('{0}') returns '{1}'", path, extension);
            if (extension == ".json")
            {
                //using JsonDocument doc=JsonDocument.Parse(fileName);
                //  JsonElement root = doc.RootElement;
                //  Console.WriteLine(root);
                //  var u1 = root[0];
                //  var u2 = root[1];
                //  var u3 = root[2];
                //  Console.WriteLine(u1);
                //  Console.WriteLine(u2);
                //  Console.WriteLine(u3);
                StreamReader r = new StreamReader(@"C:\Users\Artur\source\repos\WEEK_11_Files\JSON\myjson.json");
                string jsonString = r.ReadToEnd();
                Console.WriteLine(jsonString);
                Console.WriteLine("-------");
                Myclass m = JsonConvert.DeserializeObject<Myclass>(jsonString);
                Console.WriteLine(m.key1);
            }
            else if (extension == ".txt")
            {
                string[] filePaths = System.IO.Directory.GetFiles(fileName);
                foreach (string filePath in filePaths)

                    System.IO.File.Delete(filePath);

            }
            else if (extension == ".zip")
            {
                string startPath = @".\start";
                string extractPath = @".\extract";

                ZipFile.CreateFromDirectory(startPath, fileName);

                ZipFile.ExtractToDirectory(fileName, extractPath);
            }
        }

        static void xmlFileNode()
        {

            Console.WriteLine("Enter your word : ");
            var word = Console.ReadLine();
            Console.WriteLine("Enter your number : ");
            var n = Convert.ToInt32(Console.ReadLine());
            var substring = word.Substring(0, word.Length - n);
            var substring2 = word.Substring(word.Length - n, n);
            var xmlFile = @"C:\Users\misho\Desktop\Homeworks\names1.xml";
            var doc = new XmlDocument();
            XmlElement root = doc.DocumentElement;
            XmlElement e1 = doc.CreateElement(substring);
            e1.InnerText = word;
            root?.InsertAfter(e1, root.LastChild);
            XmlElement e2 = doc.CreateElement(substring2);
            e2.InnerText = word;
            root?.InsertAfter(e2, root.LastChild);
            var xmlFile2 = @"C:\Users\misho\Desktop\Homeworks\names2.xml";
            doc.Save(xmlFile);
            doc.Save(xmlFile2);

        }
        static void Main(string[] args)
        {
            #region SolutionN1
            Console.WriteLine("Solution-N1");
            getAndSaveWordsInFile();

            #endregion

            #region SolutionN2
            Console.WriteLine("Solution-N2");

            Console.WriteLine("Enter your number : ");

            multiplicationTable();

            #endregion

            #region SolutionN3

            Console.WriteLine("Solution-N3");
            xmlFileNode();
            #endregion

            #region SolutionN4
            countingDaysToBirthday();
            #endregion

            #region SolutionN5




            #endregion

            #region SolutionN6
            workingWithFiles();
            #endregion
        }
    }
}
