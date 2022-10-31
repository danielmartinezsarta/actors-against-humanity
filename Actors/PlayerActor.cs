using Akka;
using Akka.Actor;

namespace ActorsAgainstHumanity.Actors;


public class PlayerActor:ReceiveActor
{
    public PlayerActor()
    {
        Receive<string>(StringHandler);
    }

    private void StringHandler(string message)
    {
        Console.WriteLine($"Player actor received message: {message}");
    }
}