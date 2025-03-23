//
// Cian McNamara, 2025
//

class InterfaceExample {
    public static void main(String[] args) {
        // Create our vehicles
        Car bmwM3 = new Car("M3", "BMW", 473, 1565);
        Bike suzukiHayabusa = new Bike("Hayabusa", "Suzuki", 163, 242);

        VehicleStorage vehicleStorage = new VehicleStorage(2);

        // Add our vehicles to storage
        // This is wrapped in a try catch as it does throw an exception so we want to be able to handle it
        try {
            vehicleStorage.addVehicleToStorage(bmwM3);
            vehicleStorage.addVehicleToStorage(suzukiHayabusa);
        } catch (Exception e) {
            e.printStackTrace();
        }

        // Go through every vehicle in storage and print out it's brand and model.
        for (IVehicle vehicle : vehicleStorage.getVehiclesInStorage()) {
            System.out.printf("%s %s %n", vehicle.getBrand(), vehicle.getModel());
        }
    }
}

// Create our interface
interface IVehicle {
    void startEngine();

    void stopEngine();

    void changeGear(int gear);

    String getModel();

    String getBrand();

    int getHorsepower();

    int getWeight();
}

// Class which uses IVehicle

// Create our VehicleStorage class where we store our vehicles
class VehicleStorage {
    // Create an IVehicle array so we can store any Vehicle
    private IVehicle[] vehicleStorage;

    /**
     * Sets up our VehicleStorage class by setting the size of the vehicelStorage array
     * @param size
     */
    public VehicleStorage(int size) {
        // Create our 
        this.vehicleStorage = new IVehicle[size];
    }

    /**
     * Gets an array of vehicles that we have in storage
     * @return IVehicle array of vehicles in storage
     */
    public IVehicle[] getVehiclesInStorage() {
        return this.vehicleStorage;
    }

    /**
     * Adds our vehicle to the vehicleStorage array
     * @param vehicle
     * @throws Exception
     */
    public void addVehicleToStorage(IVehicle vehicle) throws Exception {
        // Check if there is any free space in the vehicle storage
        for (int i = 0; i < vehicleStorage.length; i++) {
            // If we find a free spot put our vehicle there and stop searching
            if (vehicleStorage[i] == null) {
                vehicleStorage[i] = vehicle;
                return;
            }
        }

        // If no spaces were found we need to throw an error stating the storage is full
        throw new Exception("Vehicle Storage is full.");
    }
}

// Classes which implement IVehicle

class Car implements IVehicle {
    private String model;
    private String brand;
    private int horsePower;
    private int weight;

    public Car(String model, String brand, int horsePower, int weight) {
        this.model = model;
        this.brand = brand;
        this.horsePower = horsePower;
        this.weight = weight;
    }

    @Override
    public void startEngine() {
        // Start the engine
    }

    @Override
    public void stopEngine() {
        // Stop the engine
    }

    @Override
    public void changeGear(int gear) {
        // Change the gear to the users selected gear
    }

    @Override
    public String getModel() {
        return this.model;
    }

    @Override
    public String getBrand() {
        return this.brand;
    }

    @Override
    public int getHorsepower() {
        return this.horsePower;
    }

    @Override
    public int getWeight() {
        return this.weight;
    }

    public void powerslide() {
        // Do a powerslide
    }
}

class Bike implements IVehicle {
    private String model;
    private String brand;
    private int horsePower;
    private int weight;

    public Bike(String model, String brand, int horsePower, int weight) {
        this.model = model;
        this.brand = brand;
        this.horsePower = horsePower;
        this.weight = weight;
    }

    @Override
    public void startEngine() {
        // Start the engine
    }

    @Override
    public void stopEngine() {
        // Stop the engine
    }

    @Override
    public void changeGear(int gear) {
        // Change the gear to the users selected gear
    }

    @Override
    public String getModel() {
        return this.model;
    }

    @Override
    public String getBrand() {
        return this.brand;
    }

    @Override
    public int getHorsepower() {
        return this.horsePower;
    }

    @Override
    public int getWeight() {
        return this.weight;
    }

    public void wheelie() {
        // Do a wheelie
    }
}