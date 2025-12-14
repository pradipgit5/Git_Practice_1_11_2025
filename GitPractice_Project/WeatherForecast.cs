namespace GitPractice_Project
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public void data()
        {
            Console.WriteLine("Test Data");
        }

        public void test1()
        {
            Console.WriteLine("test Data 2");
        }

        public void Commit_5()
        {
            Console.WriteLine("this is the example of commit-5");
        }

        public void fixingCherrypick_2()
        {
            Console.WriteLine("This is the example of fixing cherry-pick -2");
        }
    }
}
