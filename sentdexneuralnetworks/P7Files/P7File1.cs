using Numpy;

namespace sentdexneuralnetworks.P7Files;

public class P7File1
{
    private NDarray softmaxOutput = np.array(new double[] { 0.7, 0.1, 0.2 });
    private NDarray targetOutput = np.array(new double[] { 1, 0, 0 });
    public P7File1()
    {
        NDarray loss = -(np.log((softmaxOutput[0]) * targetOutput[0] + 
                         np.log(softmaxOutput[1]) * targetOutput[1] +
                         np.log(softmaxOutput[2]) * targetOutput[2]));
        
        Console.WriteLine(loss);
    }
    
}