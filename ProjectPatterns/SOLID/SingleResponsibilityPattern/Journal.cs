using System.Collections.Generic;
using System.IO;

namespace ProjectPatterns.SOLID.SingleResponsibilityPattern
{
    public class Journal//wykonuje tylko operacje na dzienniku
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public void AddEntry(string entry)
        {
            _entries.Add($"{++_count}: {entry}");
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public class PersistenceManager//wykonuje tylko operacje nie ingerujace w dziennik
        {
            public void SaveToFile(Journal journal, string filename, bool overwrite = false)
            {
                if (overwrite || File.Exists(filename) == false)
                {
                    File.WriteAllText(filename, journal.ToString());
                }
            }
        }
    }
}