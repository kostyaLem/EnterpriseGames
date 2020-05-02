namespace EnterpriseGames.Core.Other
{
    public enum RecordState
    {
        New,
        Editing,
        Closed
    }

    public class Record
    {
        public long ID { get; internal set; }
        public string EmployeeFullName { get; internal set; }
        public string CustomerFullName { get; internal set; }
        public string DateCreated { get; internal set; }
        public string DateClosed { get; internal set; }
        public RecordState State { get; internal set; }
        public Item[] Items { get; internal set; }
    }
}
