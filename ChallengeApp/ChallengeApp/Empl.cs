﻿
namespace ChallengeApp
{
    public class Empl
    {
        private List<int> score = new List<int>();
        public Empl(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
        public int result
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
}
