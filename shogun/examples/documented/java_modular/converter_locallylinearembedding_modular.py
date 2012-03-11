# In this example toy data is being preprocessed using the Locally Linear Embedding (LLE)
# algorithm as described in
# 
# Saul, L. K., Ave, P., Park, F., & Roweis, S. T. (2001).
# An Introduction to Locally Linear Embedding. Available from, 290(5500), 2323-2326.
# Retrieved from: http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.123.7319&rep=rep1&type=pdf
# 
# The number of neighbors used during the linear reconstruction step of the algorithm is set
# before processing of the data.

import org.shogun.*;
import org.jblas.*;

public class converter_locallylinearembedding_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();

		DoubleMatrix data = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures features = new RealFeatures(data);
		LocallyLinearEmbedding lle = new LocallyLinearEmbedding();
		lle.set_target_dim(1);
		RealFeatures embedding = lle.embed(features);

		modshogun.exit_shogun();
	}
}
