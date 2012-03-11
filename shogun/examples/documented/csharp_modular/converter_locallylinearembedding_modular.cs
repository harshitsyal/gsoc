// In this example toy data is being preprocessed using the Locally Linear Embedding (LLE)
// algorithm as described in
// 
// Saul, L. K., Ave, P., Park, F., & Roweis, S. T. (2001).
// An Introduction to Locally Linear Embedding. Available from, 290(5500), 2323-2326.
// Retrieved from: http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.123.7319&rep=rep1&type=pdf
// 
// The number of neighbors used during the linear reconstruction step of the algorithm is set
// before processing of the data.

using System;

public class converter_locallylinearembedding_modular {
	public static void Main() {
		
		modshogun.init_shogun_with_defaults();

		double[,] data = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures features = new RealFeatures(data);
		LocallyLinearEmbedding preprocessor = new LocallyLinearEmbedding();
		preprocessor.set_target_dim(1);
		preprocessor.apply(features);

		modshogun.exit_shogun();
	}
}
