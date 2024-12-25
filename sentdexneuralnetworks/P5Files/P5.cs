namespace sentdexneuralnetworks.P5Files;

using Numpy;

public class P5
{
    private double[] inputs = { 0, 2, -1, 3.3, -2.7, 1.1, 2.2, -100 };
    private double[] outputs = { };

    public P5()
    {
        outputs = new double[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            if (inputs[i] > 0)
            {
                outputs[i] = inputs[i];
            }
            else
            {
                outputs[i] = 0;
            }
        }
    }


    public String getOutputs()
    {
        return String.Join(", ", outputs);
    }
    
}
// public static void Main(string[] args)
// {
//     P5 p5 = new P5();
//         
//     Console.WriteLine(p5.getOutputs());
// }