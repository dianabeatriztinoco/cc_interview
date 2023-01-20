// set of classes that represent data that app manages
namespace TodoApi.Models; // namespace ensure that all set of obj have a unique name 
public class TodoItem // keyword thats an access modifier 
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }