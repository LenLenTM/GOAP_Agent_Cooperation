using System;
using System.Collections.Generic;
using System.Linq;

public class Logger
{
        private static List<string> _logEntries = new List<string>();


        public static void WriteLog(string entry)
        {
                if (_logEntries.Count != 0 && _logEntries[^1].Equals(entry)) return;
                
                if (_logEntries.Count > 15)
                {
                        _logEntries.RemoveAt(0);
                }
                _logEntries.Add(entry);
                PrintLog();
        }

        private static void PrintLog()
        {
                var log = "";
                foreach (var entry in _logEntries)
                {
                        log = log + entry + "\n";
                }
                // _textField.text = log;
        }

        public static void ResetLog()
        {
                _logEntries = new List<string>();
        }

        public static string GetLastEntry()
        {
                return _logEntries.Count != 0 ? _logEntries.Last() : "";
        }
}