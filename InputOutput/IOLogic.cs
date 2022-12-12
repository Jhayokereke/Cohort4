using System; 
using System.IO;

namespace InputOutput
{
    public class IOLogic
    {
        public List<string> ReadFromFile(string filepath)
        {
            if (!File.Exists(filepath))
            {
                File.Create(filepath);
            }
            return File.ReadAllLines(filepath).ToList();   
        }

        public bool WriteToFile(string filepath, List<string> content)
        {
            File.WriteAllLines(filepath, content);
            return true;
        }

        public string ReadFromFileWithFileClass(string filepath)
        {
            try
            {
                return File.ReadAllText(filepath);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public bool WriteToFileWithFileClass(string filepath, string content)
        {
            try
            {
                File.AppendAllText(filepath, content);
                 
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ReadFromFileWithFileInfoClass(string filepath)
        {
            try
            {
                FileInfo file = new FileInfo(filepath);
                var sr = file.OpenText();
                var str = sr.ReadToEnd();

                sr.Close();
                sr.Dispose();
                return str;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public bool WriteToFileWithFileInfoClass(string filepath, string content)
        {
            try
            {
                FileInfo file = new FileInfo(filepath);
                var sw = file.CreateText();
                sw.WriteLine(content);

                sw.Close();
                sw.Dispose();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
//Work done