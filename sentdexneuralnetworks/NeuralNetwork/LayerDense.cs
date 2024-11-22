﻿using System.Net.Mail;
using Numpy;

namespace sentdexneuralnetworks.NeuralNetwork;

public class LayerDense
{
    private NDarray weights;
    private NDarray biases;
    public NDarray output;
    private NDarray X = np.array(new[,]
    {
        { 1, 2, 3, 2.5}, 
        {2.0, 5.0, -1.0, 2.0},
        {-1.5, 2.7, 3.3, -0.8}
    });

    public LayerDense(int n_inputs,int n_neurons)
    {
        np.random.seed(0);
        weights = 0.10 * np.random.randn(n_inputs, n_neurons); // we form the weights in a manner that we 
        // avoid transposing
        biases = np.zeros((1, n_neurons));
        // Gives us 1 array containing as many 0 placed arrays as there are neurons.
    }
    public void forward(NDarray inputs)
    {
        output = np.dot(inputs, weights) + biases;
    }

    public static void Main()
    {
        Console.WriteLine(0.10*np.random.randn(4, 3));
    }
}