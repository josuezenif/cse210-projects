using System.Data;

public class PromptGenerator
{
    // information and code
    public List<string> _promptsList = [
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What made me feel happy today, and why? ",
        "If I could give advice to my future self, what would I say?",
        "What is something I’m grateful for in my life right now? ",
        "What is a challenge I faced recently, and what did I learn from it? ",
        "If I could improve one habit in my life, what would it be? ",
        "What are three goals I want to accomplish this year? ",
        "When do I feel most like myself? "
];

    public string promptQuestion()
    {
        Random random = new Random();
        int index = random.Next(_promptsList.Count);
        string randomQuestion = _promptsList[index];
        return randomQuestion;
        // Console.Write(randomQuestion);
        // string userQuestionMessage =
        // Console.ReadLine();
        // return userQuestionMessage;
    }
}