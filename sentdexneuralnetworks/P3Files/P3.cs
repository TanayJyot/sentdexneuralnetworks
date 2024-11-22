namespace sentdexneuralnetworks;

public class P3
{
    private double[] inputs = { 1, 2, 3, 2.5 };

    private double[][] weights =
    {
        new double[] { 0.2, 0.8, -0.5, 1.0 },
        new double[] { 0.5, -0.91, 0.26, -0.5 },
        new double[] { -0.26, -0.27, 0.17, 0.87 }
    };

    private double[] biases = { 2, 3, 0.5};
    private List<double> layerOutputs;

    /// <summary>
    /// What we do is that we have 4 neurons(inputs) mapping to 3 outputs.
    /// We also have the weights of those inputs acting on those outputs and the bias for the three inputs.
    /// The objective here is to multiply each of the three weights (representing the three neurons) to the inputs to
    /// get the value for 3 nwueons and then take the biases of those neurons and add them to the values that we got.
    /// </summary>
    public P3()
    {
        layerOutputs = [];

        for (int i = 0; i < biases.Length; i++)
        {
            double neuronOutput = 0;
            for (int j = 0; i < inputs.Length; j++)
            {
                neuronOutput += inputs[j] * weights[i][j];
            }

            neuronOutput += biases[i];
            layerOutputs.Append(neuronOutput);
        }
        // output =
        // [
        //     inputs[0] * weights1[0] + inputs[1] * weights1[1] + inputs[2] * weights1[2] + inputs[3] * weights1[3] +
        //     bias1,
        //     inputs[0] * weights2[0] + inputs[1] * weights2[1] + inputs[2] * weights2[2] + inputs[3] * weights2[3] +
        //     bias2,
        //     inputs[0] * weights3[0] + inputs[1] * weights3[1] + inputs[2] * weights3[2] + inputs[3] * weights3[3] +
        //     bias3
        // ];
    }

    // public List<double> getOutput() => output;

    static void Main()
    {
        Layer layer = new Layer();
        Console.WriteLine(layer.getOutput);
    }
}