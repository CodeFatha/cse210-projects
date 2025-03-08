using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void LoadJournal(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                Entry entry = new Entry();
                string[] component = line.Split("~");
                entry._date = component[0];
                entry._prompt = component[1];
                entry._response = component[2];
                _entries.Add(entry);
            }
        }
    }
    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, false))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}~{entry._prompt.Trim()}~{entry._response.Trim()}");
            }
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DeleteEntry(int index)
    {
        _entries.RemoveAt(index);
    }
}