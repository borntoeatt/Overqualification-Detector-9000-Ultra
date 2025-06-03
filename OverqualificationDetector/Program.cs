using System;

namespace OverqualificationDetector
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Overqualification Detector 9000";

            PrintBanner();
            WaitUntilReady();

            bool isOverqualified = CheckIfOverqualified();

            Console.WriteLine($"\nResult: Am I overqualified? {isOverqualified}");
        }

        static void WaitUntilReady()
        {
            Console.WriteLine("\nPlease type anything you want while we warm up the system...");
            Console.WriteLine("Type 'READY' when you're ready to proceed with the diagnostic.\n");

            string input;
            do
            {
                Console.Write(">> ");
                input = Console.ReadLine()?.Trim();
            } while (!string.Equals(input, "READY", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nSystem is READY. Beginning diagnostic...\n");
        }

        static bool CheckIfOverqualified()
        {
            ShowSpinner("Booting diagnostic engine", 2000);
            ShowSpinner("Establishing secure link with HR AI", 3000);
            ShowSpinner("Authenticating credentials", 2000);

            Console.WriteLine("\nStage 1: Scanning qualifications...");
            ShowProgressBar("Analyzing education & experience", 40, 30);

            Console.WriteLine("\nStage 2: Comparing with job requirements...");
            ShowProgressBar("Matching skills matrix", 40, 40);

            Console.WriteLine("\nStage 3: Consulting HR Oracle...");
            ShowSpinner("Loading wisdom", 2500);

            Console.WriteLine("\nFinal stage: Calibrating humility sensors...");
            ShowProgressBar("Finalizing judgment", 30, 60);

            Console.WriteLine("\n📢 Verdict:");
            Console.WriteLine("You are not overqualified; you simply haven’t unlocked your full potential yet!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Remember: Great engineers are always learning. Stay curious!");
            System.Threading.Thread.Sleep(1500);

            return false;
        }

        static void PrintBanner()
        {
            Console.WriteLine("|=========================================|");
            Console.WriteLine("|       Welcome to the Overqualification  |");
            Console.WriteLine("|       Detector 9000 Ultra - Version 2.0 |");
            Console.WriteLine("|=========================================|");
            Console.WriteLine("|       This program will determine if    |");
            Console.WriteLine("|     you are overqualified for your job. |");
            Console.WriteLine("| ****************************************|");
            Console.WriteLine("|     Type what you feel. Then type       |");
            Console.WriteLine("|        READY to begin diagnostics.      |");
            Console.WriteLine("|=========================================|\n");
        }

        static void ShowProgressBar(string label, int steps, int delay)
        {
            Console.Write($"{label}: [");
            for (int i = 0; i < steps; i++)
            {
                Console.Write("#");
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine("] 100%");
        }

        static void ShowSpinner(string label, int durationMs)
        {
            char[] spinnerFrames = { '|', '/', '-', '\\' };
            int totalFrames = durationMs / 100;
            Console.Write(label + " ");

            for (int i = 0; i < totalFrames; i++)
            {
                Console.Write(spinnerFrames[i % spinnerFrames.Length]);
                System.Threading.Thread.Sleep(100);
                Console.Write("\b"); // backspace to erase spinner char
            }

            Console.WriteLine("✓");
        }
    }
}
