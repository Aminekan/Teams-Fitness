namespace Fetnissfirst.Services
{
    public class FitnessService
    {
        public double CalculateCalories(double weight, double height, int age, string gender, double activityLevel)
        {
            // Grundumsatz (Mifflin-St Jeor)
            double bmr = gender.ToLower() == "male"
                ? 10 * weight + 6.25 * height - 5 * age + 5
                : 10 * weight + 6.25 * height - 5 * age - 161;

            // Aktivitätsfaktor multiplizieren
            return bmr * activityLevel;
        }
    }
}
