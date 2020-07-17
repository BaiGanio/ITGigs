using Common.Extensions;

namespace Common
{
    public class Fake
    {
        public Fake(string name)
        {
            this.Id = new CustomId();
            this.Name = name;
        }
        public CustomId Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\nName: {this.Name}";
        }
    }
}
