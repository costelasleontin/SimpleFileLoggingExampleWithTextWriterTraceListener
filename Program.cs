using System.Diagnostics;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "log12345.txt"); //set the path to the file where the loggs should be written
Console.WriteLine($"Writing to: {logPath}");
TextWriterTraceListener logFile = new(File.CreateText(logPath)); //create TraceListener
Trace.Listeners.Add(logFile); //add TraceListener to listeners
// text writer is buffered, so this option calls
// Flush() on all listeners after writing
Trace.AutoFlush = true;
Debug.WriteLine("Debug says, I am watching!"); //this displays debug message but only in Debug configuration
Trace.WriteLine("Trace says, I am watching!"); //efectivelly writing trace to log
