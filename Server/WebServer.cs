using System.Net;
using ExampleServer.Data;

namespace ExampleServer.Server;

class WebServer
{
    private readonly TaskRepository _taskRepository;
    private readonly HttpListener _httpListener = new HttpListener();

    public WebServer(string url, TaskRepository repository)
    {
        // The repository parameter is assigned to the readonly field
        _taskRepository = repository;

        _httpListener.Prefixes.Add(url);
    }

    public void Run()
    {
        // Start the Server
        _httpListener.Start();

        // Add a "debug" line that will write to the console
        Console.WriteLine($"Listening for connections on {_httpListener.Prefixes.First()}");

        // Handle our incoming connections/requests
        // The bulk of our logic
        HandleIncomingConnections();

        // Stop the server
        _httpListener.Close();
    }

    private void HandleIncomingConnections()
    {
        while (true)
    {
        //Have the server sit and wait for a connection
        //Once a request comes in, it will create a context
        HttpListenerContext context = _httpListener.GetContext();
}

        //Get the request and response objects (references) from teh connection context
        //These are two objects that already exist, we are just accessing them.
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;

        //Log the request in the console, showing "GET localhost:xxxxx"
        Console.WriteLine($"\n{request.HttpMethod} {request.Url");
    }
    }