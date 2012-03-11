// In this example toy data is being processed using the Isomap algorithm
// as described in
// 
// Silva, V. D., & Tenenbaum, J. B. (2003). 
// Global versus local methods in nonlinear dimensionality reduction. 
// Advances in Neural Information Processing Systems 15, 15(Figure 2), 721-728. MIT Press. 
// Retrieved from http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.9.3407&rep=rep1&type=pdf
// 
// Before applying to the data the landmark approximation is enabled with 
// specified number of landmarks. The landmark approximation is described in
// 
// Sparse multidimensional scaling using landmark points
// V De Silva, J B Tenenbaum (2004) Technology, p. 1-4
// 
// After enabling the landmark approximation k parameter -- the number 
// of neighbors in the k nearest neighbor graph -- is initialized.

using System;

public class converter_classicisomap_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();

		double[,] data = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures features = new RealFeatures(data);
		
		Isomap preprocessor = new Isomap();
		preprocessor.set_target_dim(1);
		preprocessor.apply(features);

		modshogun.exit_shogun();
	}
}
