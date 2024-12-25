namespace sentdexneuralnetworks.NeuralNetwork;
using Numpy;

public class ActivationSoftmax
{
    public NDarray output;
    public void forward(NDarray inputs)
    {
        NDarray expValues = np.exp(inputs - np.max(inputs, axis: [1], keepdims: true));
        NDarray probabilities = expValues / np.sum(expValues, axis: 1, keepdims: true);

        this.output = probabilities;
    }
}