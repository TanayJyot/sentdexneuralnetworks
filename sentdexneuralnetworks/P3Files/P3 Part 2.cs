namespace sentdexneuralnetworks;

using Numpy;

public class P3_Part_2
{
    private NDarray inputs = np.array(new double[] { 1, 2, 3, 2.5 });

    private NDarray weights = np.array(
        new double[,]
        {
            { 0.2, 0.8, -0.5, 1.0 },
            { 0.5, -0.91, 0.26, -0.5 },
            { -0.26, -0.27, 0.17, 0.87 }
        });

    private NDarray biases = np.array(new double[] { 2, 3, 0.5 });

    private NDarray output;

    public P3_Part_2()
    {
        // Perform the dot product and add biases
        output = np.dot(weights, inputs) + biases;
    }

    public NDarray getOutput()
    {
        return output;
    }
}