namespace GitPractice_Project
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public void Commit3()
        {
            Console.WriteLine("This is the example of Commit3");
        }
        public void Commit4()
        {
            Console.WriteLine("This is the example of Commit4");
        }

        public void Hotfix_method()
        {
            Console.WriteLine("This is the example of hotfix method");
        }
    }


}
