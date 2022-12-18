namespace GatesApp.Models
{
    internal class Gates
    {
        public int Id { get; set; }
        public string GateName { get; set; }

        public Gates(int id, string gateName)
        {
            Id = id;
            GateName = gateName;
        }
    }
}
