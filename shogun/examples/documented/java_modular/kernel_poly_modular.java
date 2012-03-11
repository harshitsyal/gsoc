// This example initializes the polynomial kernel with real data. 
// If variable 'inhomogene' is 'True' +1 is added to the scalar product 
// before taking it to the power of 'degree'. If 'use_normalization' is 
// set to 'true' then kernel matrix will be normalized by the square roots
// of the diagonal entries. 

import org.shogun.*;
import org.jblas.*;

public class kernel_poly_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		int degree = 4;

		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		RealFeatures feats_train = new RealFeatures(traindata_real);
		RealFeatures feats_test = new RealFeatures(testdata_real);

		PolyKernel kernel = new PolyKernel(feats_train, feats_train, degree, false);

		DoubleMatrix km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		DoubleMatrix km_test = kernel.get_kernel_matrix();

		System.out.println(km_train.toString());
		System.out.println(km_test.toString());

		modshogun.exit_shogun();
	}
}
