using Fetnissfirst.Models;
using Fetnissfirst.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fetnissfirst.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly FitnessService _service = new FitnessService();

        [HttpGet("calories")]
        public IActionResult GetCalories(double weight, double height, int age, string gender, double activityLevel)
        {
            double calories = _service.CalculateCalories(weight, height, age, gender, activityLevel);
            return Ok(new { Calories = calories });
        }

        [HttpGet("exercises")]
        public IActionResult GetExercises()
        {
            var exercises = new List<Exercise>
            {
                new Exercise { Id = 1, Name = "Liegestütze", MuscleGroup = "Brust, Arme", Description = "Push-Up", MediaUrl = "pushup.jpg" },
                new Exercise { Id = 2, Name = "Kniebeugen", MuscleGroup = "Beine, Po", Description = "Squat", MediaUrl = "squat.jpg" }
            };
            return Ok(exercises);
        }
    }
}
