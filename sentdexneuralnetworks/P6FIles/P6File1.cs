using Numpy;

namespace sentdexneuralnetworks.P6FIles;

public class P6File1
{
    private NDarray layerOutputs = np.array(
        new double[,] {
            { 4.8, 1.21, 2.385 },
            { 8.9, -1.81, 0.2 },
            { 1.41, 1.051, 0.026}} );
    private double E = Math.E;
    private NDarray expValues;

    public P6File1()
    {
        // List<double> expValues = new List<double>();
        expValues = np.exp(layerOutputs);
        // foreach (double output in layerOutputs)
        // {
        //     expValues.Add(Math.Pow(E, output));
        // }
        
        normalization(expValues);
    }

    private void normalization(NDarray expValues)
    {
        NDarray normBase = expValues.sum();
        NDarray normValues = expValues / np.sum(expValues, axis: 1, keepdims: true);

        // foreach (double value in expValues)
        // {
        //     normValues.Add(value / normBase); 
        //     // This will normalize all the values so that we can find the probability
        //     
        // }
        Console.WriteLine(string.Join(", ", normValues));
        Console.WriteLine(normValues.sum());
    }

    public NDarray getExpValues()
    {
        return expValues;
    }
}