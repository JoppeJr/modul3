namespace EgenTestKunnskap
{
    public class ToDoList
    {


        public int Date { get; set; }
        public int Count { get; set; }


        public string ToDo { get; set; }

        public ToDoList(string text, int date, int count)
        {
            ToDo = text;
            Date = date;
            Count = count;
        }


        public override string ToString()
        {
            return " Task: " + ToDo + ", Date: " + Date + ", Count: " + Count;
        }



    }
}