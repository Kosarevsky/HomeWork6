using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.HelpMaterial;

namespace Homework6.Job1
{
    public class Heroes
    {
        public static void ShowPersonDescription()
        {
            var characters = CharactersRepository.GetCharacters();

            var persons = characters.Select(character => new
            { PersonDescription = $"{character.FirstName} {character.LastName} {character.Age} {character.Gender}" });

            foreach (var person in persons)
                Console.WriteLine($"{person}");
        }


        public static void ShowLeftJoinQuerySyntax()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var joinResult = from characater in characters
                             join story in stories
                             on characater.StoryId equals story.Id into characterStory
                             from story in characterStory.DefaultIfEmpty()
                             select new Res
                             {
                                 FirstName=characater.FirstName,
                                 LastName=characater.LastName,
                                 StoryName = story == null ? "No story" : story.StoryName

                             };

            foreach (var item in joinResult)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.StoryName}");
            }
        }
    }

}
