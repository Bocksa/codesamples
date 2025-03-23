public interface IVehicle {
    void StartEngine();
    void StopEngine();
    void ChangeGear();
}

// fetch class somehow
var car = new Honda();
var bike = new Yamaha();

IVehicle foo; // pretend this fetches one of the two above, we dont actually know which it is (for example in a game context everything is just GameObject)

// we can just run it without doing weird casting or anything, simply by knowing it absolutely is an IVehicle of some kind
foo.StartEngine();
