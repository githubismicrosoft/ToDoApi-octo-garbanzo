namespace ToDoApi.Models {
    public class ToDoItem {
        public long ID { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public ToDoItem(long ID, string name, bool isComplete)
        {
            this.ID = ID;
            this.Name = name;
            this.IsComplete = isComplete;
        }
    }
}