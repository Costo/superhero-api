using System.ComponentModel.DataAnnotations;

namespace superhero
{
    /// <summary>
    /// Person object, also use to represent a Team member of the Legion object
    /// </summary>
    public class Person
    {
        /// <summary>
        /// First Name of the Person object
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the Person object
        /// </summary>
        [Required]
        public string LastName { get; set; }
        
        private string _heroName;
        
        /// <summary>
        /// Superhero name generated by using the HeroGenerator
        /// </summary>
        public string HeroName {get {return _heroName;}}

        /// <summary>
        /// Method used to call HeroGenerator to set the Superhero Name using the First and Last Name
        /// </summary>
        public void SetHeroName(){ _heroName = HeroGenerator.GetHeroName(FirstName, LastName);}

    }
}
