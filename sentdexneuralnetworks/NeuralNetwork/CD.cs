using Numpy.Models;

namespace sentdexneuralnetworks.NeuralNetwork;
using Numpy;

public class CD
{
    public (NDarray, NDarray) CreateData(int points, int classes)
    {
        // Set random seed for reproducibility
        np.random.seed(0);

        // Initialize arrays for features (X) and labels (y)
        NDarray X = np.zeros((points * classes, 2));
        NDarray y = np.zeros(new Shape(points * classes), dtype: np.uint8);

        // Generate data for each class
        for (int classNumber = 0; classNumber < classes; classNumber++)
        {
            int startIdx = points * classNumber;
            int endIdx = points * (classNumber + 1);

            // Radius values
            NDarray r = np.linspace(0.0, 1.0, points);

            // Theta values with some randomness
            NDarray t = np.linspace(classNumber * 4, (classNumber + 1) * 4, points) + np.random.randn(points) * 0.2;

            // Assign X values (spiral pattern)
            X[new Slice(startIdx, endIdx), 0] = r * np.sin(t * 2.5);
            X[new Slice(startIdx, endIdx), 1] = r * np.cos(t * 2.5);

            // Assign class labels
            y[new Slice(startIdx, endIdx)] = np.full(new Shape(points), classNumber, dtype: np.uint8);
        }

        return (X, y);
    }

    // public static void Main(string[] args)
    // {
    //     int points = 100;  // Number of points per class
    //     int classes = 3;   // Number of classes
    //
    //     // Generate dataset
    //     var (X, y) = CreateData(points, classes);
    //
    //     // Print a small sample of the generated data
    //     Console.WriteLine("X (first 10 rows):");
    //     Console.WriteLine(X[$":10, :"]);
    //
    //     Console.WriteLine("\ny (first 10 elements):");
    //     Console.WriteLine(y[$":10"]);
    // }
}