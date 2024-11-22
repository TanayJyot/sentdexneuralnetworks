// See https://aka.ms/new-console-template for more information

using sentdexneuralnetworks;

Neuron neuron = new Neuron();

Console.WriteLine("Hello, World!" + string.Join(", ", neuron.getOutput()));