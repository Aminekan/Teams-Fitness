using System.Collections.Generic;

namespace Fetnissfirst.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Exercise> Exercises { get; set; }
        public string Goal { get; set; }
    }
}
