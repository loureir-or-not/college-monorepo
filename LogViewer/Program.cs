// See https://aka.ms/new-console-template for more information
string logFile = "log.txt";
string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss");

File.AppendAllText(logFile, $"[{timestamp}] Application started.\n");

Console.WriteLine("--- BEGIN EVENT HISTORY ---");
using StreamReader reader = new StreamReader(logFile);
string line;
while ((line = reader.ReadLine()) != null)
{
    Console.WriteLine(line);
}
Console.WriteLine("--- END EVENT HISTORY ---");

timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss");
File.AppendAllText(logFile, $"[{timestamp}] Read event log successfully.\n");
