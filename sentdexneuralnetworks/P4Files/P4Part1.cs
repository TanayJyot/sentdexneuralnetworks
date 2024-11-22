namespace sentdexneuralnetworks.P4Files;
using Numpy;
public class P4Part1
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

    private NDarray biases = np.array(new double[] { 2, 3, 0.5 });

    private NDarray output;

    public P4Part1()
    {
        // Perform the dot product and add biases
        output = np.dot(inputs, weights.T) + biases;
    }

    public NDarray getOutput()
    {
        return output;
    }
}