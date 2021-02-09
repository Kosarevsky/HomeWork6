namespace Homework6.HelpMaterial
{
    public struct Res
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StoryName { get; set; }

        public Res(string firstName, string lastName, string storyName)
        {
            FirstName = firstName;
            LastName = lastName;
            StoryName = storyName;
        }
    }
}