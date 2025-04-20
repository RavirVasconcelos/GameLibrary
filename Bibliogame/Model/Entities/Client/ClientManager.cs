using Bibliogame.Model.Entities.Client.Enums;


namespace Bibliogame.Model.Entities.Client
{
    class ClientManager
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender TypeGender { get; set; }

        public ClientManager()
        {
        }

        public ClientManager(string name, string email, string id, DateTime birthDate, Gender typeGender)
        {
            Name = name;
            Email = email;
            Id = id;
            BirthDate = birthDate;
            TypeGender = typeGender;
        }

        public override string ToString()
        {
            return
                "Name: " + Name +
                ", Email: " + Email +
                ", Id: " + Id +
                ", Birth Date: " + BirthDate.ToString("dd/MM/yyyy") +
                ", Gender: " + TypeGender;
        }
    }
}
