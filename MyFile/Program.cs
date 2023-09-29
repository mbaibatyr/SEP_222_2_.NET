using System.Text;

namespace MyFile
{
    internal class Program
    {
        const string fileNameSource = @"\\share\Shared_Folder\Временные файлы\SEP_222.2\my_file.txt";
        const string fileNameDest = @"C:\Temp\my_file.txt";

        const string dirName = @"\\share\Shared_Folder\Временные файлы\SEP_222.2\MyDirMurat";

        static void Main(string[] args)
        {
            //using (FileStream fs = new FileStream(fileNameSource, FileMode.Open))
            //{
            //    byte[] content = new byte[fs.Length];
            //    fs.Read(content, 0, content.Length);
            //    File.WriteAllBytes(@"C:\Temp\test_123.txt", content);
            //}

            //using (FileStream fs = new FileStream(@"C:\Temp\test_123.txt", FileMode.CreateNew))
            //{
            //    string hello = "hello step";                
            //    byte[] content = Encoding.UTF8.GetBytes(hello);
            //    fs.Write(content, 0, content.Length);                
            //}

            using (FileStream fs = new FileStream(fileNameSource, FileMode.Open))
            {                
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }      
                }
            }




            //if (File.Exists(fileNameDest))
            //    File.Delete(fileNameDest);
            //File.Copy(fileNameSource, fileNameDest);

            //File.Move(fileNameSource, fileNameDest);

            //Console.WriteLine(Path.GetFileName(fileNameSource));
            //Console.WriteLine(Path.GetDirectoryName(fileNameSource));
            //Console.WriteLine(Path.GetExtension(fileNameSource));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(fileNameSource));

            //FileInfo fi = new FileInfo(fileNameSource);

            //Directory.CreateDirectory(dirName);
            //Directory.Delete(@"C:\Temp\Новая папка", true);

            //var files = Directory.GetFiles(@"\\share\Shared_Folder\Временные файлы\SEP_222.2", "*.*")
            //                        .Where(s => s.EndsWith(".xlsx") || s.EndsWith(".docx"));
            //foreach (var item in files)
            //{
            //    Console.WriteLine(Path.GetFileName(item));
            //}




        }
    }
}