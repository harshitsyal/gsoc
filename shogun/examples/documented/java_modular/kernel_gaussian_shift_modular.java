// An experimental kernel inspired by the WeightedDegreePositionStringKernel and the Gaussian kernel.
// The idea is to shift the dimensions of the input vectors against eachother. 'shift_step' is the step 
// size of the shifts and  max_shift is the maximal shift.

import org.shogun.*;
import org.jblas.*;

public class kernel_gaussian_shift_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		double width = 1.8;
		int max_shift = 2;
		int shift_step = 1;

		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		RealFeatures feats_train = new RealFeatures(traindata_real);
		RealFeatures feats_test = new RealFeatures(testdata_real);

		GaussianShiftKernel kernel = new GaussianShiftKernel(feats_train, feats_train, width, max_shift, shift_step);

		DoubleMatrix km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		DoubleMatrix km_test = kernel.get_kernel_matrix();

		System.out.println(km_train.toString());
		System.out.println(km_test.toString());

		modshogun.exit_shogun();
	}
}
