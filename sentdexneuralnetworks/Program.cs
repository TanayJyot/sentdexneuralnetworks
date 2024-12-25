// See https://aka.ms/new-console-template for more information

using Numpy;
using sentdexneuralnetworks;
using sentdexneuralnetworks.NeuralNetwork;
using sentdexneuralnetworks.P4Files;
using sentdexneuralnetworks.P5Files;
using sentdexneuralnetworks.P6FIles;

NDarray X = np.array(new[,]
{
    { 1, 2, 3, 2.5}, 
    {2.0, 5.0, -1.0, 2.0},
    {-1.5, 2.7, 3.3, -0.8}
});
//
// P4Part2 p4Part2 = new P4Part2();
// np.random.seed(0);
// // Console.WriteLine(string.Join(", ", p4Part2.getOutput()));
// // Console.WriteLine(0.10*np.random.randn(4, 3));
// LayerDense layer1 = new LayerDense(4, 5);
// LayerDense layer2 = new LayerDense(5, 2);
// layer1.forward(X);
// // Console.WriteLine(layer1.output); // will be 12 neurons because that is what we gave as the input
// // Will form a 3 * 4 * 4 * 5 Matrix
//
// layer2.forward(layer1.output); // Mapped from 3 * 5 * 5 * 2
// Console.WriteLine(layer2.output);

// P5 p5 = new P5();
// //         
//      Console.WriteLine(p5.getOutputs());
// LayerDense layer1 = new LayerDense(4, 5);
//
// layer1.forward(X);
//
// ActivationReLU activationReLu = new ActivationReLU();
// Console.WriteLine(layer1.output);
// activationReLu.forward(layer1.output);
// Console.WriteLine(activationReLu.output);

P6File1 p6File1 = new P6File1();
Console.WriteLine(string.Join(", ", p6File1.getExpValues()));