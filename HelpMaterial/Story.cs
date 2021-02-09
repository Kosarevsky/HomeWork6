namespace Homework6.HelpMaterial
{
    public class Story
    {
        public int Id { get; set; }
        public string StoryName { get; set; }
        public string Description { get; set; }


        public Story(int storyId, string storyName, string description)
        {
            Id = storyId;
            StoryName = storyName;
            Description = description;
        }

        public override string ToString()
        {
            return $"StoryId: {Id}, \tStoryName: {StoryName},  \tDescription: {Description}";
        }
    }
}