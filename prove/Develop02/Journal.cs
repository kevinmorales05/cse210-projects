public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public Journal(){
        
    }
    public Entry addEntry(Entry entry){
        _entries.Add(entry);
        return entry;
    }
    public void displayEntries(){
        foreach (Entry entry in _entries)
        {
            entry.displayEntry();
        }
    }
}