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

import org.shogun.*;
import org.jblas.*;

public class converter_isomap_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();

		DoubleMatrix data = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures features = new RealFeatures(data);
		Isomap isomap = new Isomap();
		isomap.set_target_dim(1);
		isomap.set_k(6);
		isomap.set_landmark(false);
		RealFeatures embedding = isomap.embed(features);

		modshogun.exit_shogun();
	}
}
