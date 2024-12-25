using Numpy;

namespace sentdexneuralnetworks.NeuralNetwork;

public class ActivationReLU
{
    public NDarray output;

    public void forward(NDarray inputs)
    {
        if (inputs == null)
        {
            throw new ArgumentNullException(nameof(inputs), "Input array cannot be null");
        }

        // Create an NDarray of zeros with the same shape and type as inputs
        NDarray zeroArray = np.zeros_like(inputs);
        
        // Use np.maximum to compare inputs with zero
        output = np.maximum(zeroArray, inputs);
    }
}