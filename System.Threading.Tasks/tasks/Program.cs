// See https://aka.ms/new-console-template for more information
Task task1 = Task.Run(() => {
    // Task body (some work)
    Console.WriteLine("Task is running");
});

task1.Wait();  // Waits for the task to complete
Console.WriteLine("-------------");

Task firstTask = Task.Run(() => {
    Console.WriteLine("First task running...");
});

Task continuationTask = firstTask.ContinueWith((t) => {
    Console.WriteLine("Continuation task running...");
});

continuationTask.Wait(); // Wait for both tasks to complete
Console.WriteLine("----------------");
Task task11 = Task.Run(() => {
    Console.WriteLine("Task 1 running...");
});

Task task2 = Task.Run(() => {
    Console.WriteLine("Task 2 running...");
});

await Task.WhenAll(task11, task2);  // Wait for both tasks to complete
Console.WriteLine("Both tasks completed");
