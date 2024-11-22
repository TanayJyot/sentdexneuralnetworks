namespace sentdexneuralnetworks.P4Files;
using Numpy;
public class P4Part2
{
    private NDarray inputs = np.array(new double[,]
    {
        { 1, 2, 3, 2.5 },
        {2.0, 5.0, -1.0, 2.0},
        {-1.5, 2.7, 3.3, -0.8}
        
    });

    private NDarray weights = np.array(
        new double[,]
        {
            { 0.2, 0.8, -0.5, 1.0 },
            { 0.5, -0.91, 0.26, -0.5 },
            { -0.26, -0.27, 0.17, 0.87 }
        });

    private NDarray weights2 = np.array(
        new double[,]
        {
            {-0.1, -0.14, 0.5},
            {-0.5, 0.12, -0.33},
            { -0.44, 0.73, -0.13}
        });

    private NDarray biases = np.array(new double[] { 2, 3, 0.5 });
    private NDarray biases2 = np.array(new double[] { -1, 2, -0.5});

    private NDarray layer1Outputs;
    private NDarray layer2Outputs;

    public P4Part2()
    {
        // Perform the dot product and add biases
        layer1Outputs = np.dot(inputs, weights.T) + biases;
        layer2Outputs = np.dot(layer1Outputs, weights2.T) + biases2;
    }

    public NDarray getOutput()
    {
        return layer2Outputs;
    }
}