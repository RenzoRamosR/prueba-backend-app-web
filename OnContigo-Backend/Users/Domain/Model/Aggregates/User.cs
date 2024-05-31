using OnContigo_Backend.Users.Domain.Model.Commands;

namespace OnContigo_Backend.Users.Domain.Model.Aggregates
{
    public class User
    {
        public int Id { get; set; }
        public string NewsApiKey { get; set; }
        public string SourceId { get; set; }

        protected User()
        {
            this.NewsApiKey = string.Empty;
            this.SourceId = string.Empty;
        }

        public User(CreateUserCommand command)
        {
            this.NewsApiKey = command.NewsApiKey;
            this.SourceId = command.SourceId;
        }

    }
}