using OllamaSharp;

var uri = new Uri("http://localhost:11434");
var ollama = new OllamaApiClient(uri)
{
    SelectedModel = "phi3:mini"
};

var chat = new Chat(ollama);

var prompt = "You are an astronomy specialist, answer in just one sentence";
prompt += Console.ReadLine();

await foreach (var answer in chat.SendAsync(prompt))
{
    Console.Write(answer);
}

Console.WriteLine("");
Console.WriteLine("Done.");

