// In this example toy data is being processed using the kernel PCA algorithm
// as described in
// 
// Schölkopf, B., Smola, A. J., & Muller, K. R. (1999).
// Kernel Principal Component Analysis.
// Advances in kernel methods support vector learning, 1327(3), 327-352. MIT Press.
// Retrieved from http://citeseerx.ist.psu.edu/viewdoc/summary?doi=10.1.1.32.8744i
// 
// A gaussian kernel is used for the processing.

using System;

public class preprocessor_kernelpca_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		double width = 2.0;
		double threshold = 0.05;

		double[,] data = Load.load_numbers("../data/fm_train_real.dat");
		RealFeatures features = new RealFeatures(data);

		GaussianKernel kernel = new GaussianKernel(features, features, width);

		KernelPCA preprocessor = new KernelPCA(kernel);
		preprocessor.init(features);
		preprocessor.apply_to_feature_matrix(features);

		modshogun.exit_shogun();
	}
}
