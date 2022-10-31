using Akka;
using ActorsAgainstHumanity.Actors;
using Akka.Actor;

var actorSystem = ActorSystem.Create("aah-actorsystem");

var playerActor = actorSystem.ActorOf<PlayerActor>("player-actor");

var inputKey = ConsoleKey.Enter;
while (inputKey != ConsoleKey.X)
{
    Console.WriteLine("\n");
    Console.WriteLine("Select an option:");
    Console.WriteLine("A: Create new game.");
    Console.WriteLine("B: Join existing game.");
    Console.WriteLine("X: Exit application.");

    inputKey = Console.ReadKey().Key;
}

actorSystem.Terminate();


