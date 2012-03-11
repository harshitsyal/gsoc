// In this example toy data is being processed using the multidimensional
// scaling as described on p.261 (Section 12.1) of
// 
// Borg, I., & Groenen, P. J. F. (2005).
// Modern multidimensional scaling: Theory and applications. Springer.
// 
// Before processing the landmark approximation is disabled.

import org.shogun.*;
import org.jblas.*;

public class converter_multidimensionalscaling_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();

		DoubleMatrix data = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures features = new RealFeatures(data);
		MultidimensionalScaling mds = new MultidimensionalScaling();
		mds.set_target_dim(1);
		mds.set_landmark(false);
		mds.embed(features);

		modshogun.exit_shogun();
	}
}
