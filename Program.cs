using System.Diagnostics;

//set the path to the file where the loggs should be written
string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "log.txt"); 

Console.WriteLine($"Writing to: {logPath}");
//create TraceListener
TextWriterTraceListener logFile = new(File.CreateText(logPath)); 
//add TraceListener to listeners
Trace.Listeners.Add(logFile); 

// text writer is buffered, so this option calls
// Flush() on all listeners after writing
Trace.AutoFlush = true;

//this displays debug message but only in Debug configuration
Debug.WriteLine("Debug says, I am watching!"); 

//efectivelly writing trace to log
Trace.WriteLine("Trace says, I am watching!"); 
