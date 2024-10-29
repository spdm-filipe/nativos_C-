
ProcessAiTasks();

 void ProcessAiTasks()
{
    Thread visionThread = new Thread(() => ProcessVisionModule());
    Thread voiceThread = new Thread(() => ProcessVoiceModule());

    visionThread.Start();
    voiceThread.Start();

    visionThread.Join();
    voiceThread.Join();
}

 void ProcessVisionModule()
{
    // Simulate vision processing
    Console.WriteLine("Processing Vision Module...");
    Thread.Sleep(2000); // Simulate time to process
    Console.WriteLine("Vision Module Complete.");
}

 void ProcessVoiceModule()
{
    // Simulate voice processing
    Console.WriteLine("Processing Voice Module...");
    Thread.Sleep(3000); // Simulate time to process
    Console.WriteLine("Voice Module Complete.");
}

