namespace TaskAPI.Models
{
    public static class FakeDB
    {


        static List<Task> _tasks = new List<Task>()
        {
           new Task(1, "Faire une tartine", "Me faire une tartine de choco"),
           new Task(2, "Sauver la Corée du Nord", "Trop Fort"),
           new Task(3, "Faire un chateau de cartes", "J'aime les chateaux"),
           new Task(4, "Détruire le chateau de cartes", "Comme si j'étais le godzilla des chateaux de cartes"),
           new Task(5, "Re-sauver la Corée du Nord", "J'avoue il est fort"),
        };
        public static List<Task> tasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }

    }
}
