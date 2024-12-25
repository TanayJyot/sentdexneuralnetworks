using Numpy;

namespace sentdexneuralnetworks.P6FIles;

public class P6File1
{
    private List<double> layerOutputs = new List<double> { 4.8, 1.21, 2.385 };
    private double E = Math.E;
    private List<double> expValues = new List<double>();

    public P6File1()
    {
        // List<double> expValues = new List<double>();

        foreach (double output in layerOutputs)
        {
            expValues.Add(Math.Pow(E, output));
        }
        
        normalization(expValues);
    }

    private void normalization(List<double> expValues)
    {
        double normBase = expValues.Sum();
        List<double> normValues = new List<double>();

        foreach (double value in expValues)
        {
            normValues.Add(value / normBase); 
            // This will normalize all the values so that we can find the probability
            
        }
        Console.WriteLine(string.Join(", ", normValues));
        Console.WriteLine(normValues.Sum());
    }

    public List<double> getExpValues()
    {
        return expValues;
    }
}