using System;

class Program
{
    static void Main(string[] args)
    {
        // non-static
        Prompt prompt = new Prompt();
        prompt.getPrompt2();

        // static
        Prompt.GetPrompt("Statically called.");

    }
}