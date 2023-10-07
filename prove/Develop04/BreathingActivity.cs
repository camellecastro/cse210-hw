// Subclass for Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(5);
            
            Console.Write("\nNow breathe out...");
            ShowCountDown(5);

            Console.WriteLine("\n");
        }
        DisplayEndingMessage();
    }
}