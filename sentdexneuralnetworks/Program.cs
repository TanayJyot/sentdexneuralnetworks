// See https://aka.ms/new-console-template for more information

using Numpy;
using sentdexneuralnetworks;
using sentdexneuralnetworks.P4Files;

P4Part2 p4Part2 = new P4Part2();
np.random.seed(0);
// Console.WriteLine(string.Join(", ", p4Part2.getOutput()));
Console.WriteLine(0.10*np.random.randn(4, 3));