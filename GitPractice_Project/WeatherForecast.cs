namespace GitPractice_Project
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }


        public void revert_Commit1()
        {
            Console.WriteLine("This is a new method added to demonstrate revert commit1  functionality.");
        }
    }
}
