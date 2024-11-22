namespace sentdexneuralnetworks;

public class Layer
{
    private List<double> inputs = new List<double>{1, 2, 3, 2.5};
    
    private List<double> weights1 = new List<double>{0.2, 0.8, -0.5, 1.0};
    private List<double> weights2 = new List<double>{0.5, -0.91, 0.26, -0.5};
    private List<double> weights3 = new List<double>{-0.26, -0.27, 0.17, 0.87};
    
    private double bias1 = 2;
    private double bias2 = 3;
    private double bias3 = 0.5;
    
    private List<double> output;

    public Layer()
    {
        output = [
            inputs[0] * weights1[0] + inputs[1] * weights1[1]+ inputs[2]* weights1[2]+ inputs[3]* weights1[3] + bias1,
            inputs[0] * weights2[0] + inputs[1] * weights2[1]+ inputs[2]* weights2[2]+ inputs[3]* weights2[3] + bias2,
            inputs[0] * weights3[0] + inputs[1] * weights3[1]+ inputs[2]* weights3[2]+ inputs[3]* weights3[3] + bias3
        ];
    }

    public List<double> getOutput() => output;

    static void Main()
    {
        Layer layer = new Layer();
        Console.WriteLine(layer.getOutput);
    }
}