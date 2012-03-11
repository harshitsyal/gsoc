// In this example we show how to perform Multiple Kernel Learning (MKL)
// with the modular interface for multi-class classification. 
// First, we create a number of base kernels and features.
// These kernels can capture different views of the same features, or actually
// consider entirely different features associated with the same example 
// (e.g. DNA sequences = strings AND gene expression data = real values of the same tissue sample). 
// The base kernels are then subsequently added to a CombinedKernel, which
// contains a weight for each kernel and encapsulates the base kernels
// from the training procedure. When the CombinedKernel between two examples is
// evaluated it computes the corresponding linear combination of kernels according to their weights.
// We then show how to create an MKLMultiClass classifier that trains an SVM and learns the optimal
// weighting of kernels (w.r.t. a given norm q) at the same time. The main difference to the binary
// classification version of MKL is that we can use more than two values as labels, when training
// the classifier.
// Finally, the example shows how to classify with a trained MKLMultiClass classifier.
// 

import org.shogun.*;
import org.jblas.*;

public class mkl_multiclass_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		double width = 2.1;
		double epsilon = 1e-5;
		double C = 1.0;
		int mkl_norm = 2;

		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		DoubleMatrix trainlab = Load.load_labels("../data/label_train_multiclass.dat");

		CombinedKernel kernel = new CombinedKernel();
		CombinedFeatures feats_train = new CombinedFeatures();
		CombinedFeatures feats_test = new CombinedFeatures();

		RealFeatures subkfeats1_train = new RealFeatures(traindata_real);
		RealFeatures subkfeats1_test = new RealFeatures(testdata_real);
		
		GaussianKernel subkernel = new GaussianKernel(10, width);
		feats_train.append_feature_obj(subkfeats1_train);
		feats_test.append_feature_obj(subkfeats1_test);
		kernel.append_kernel(subkernel);

		RealFeatures subkfeats2_train = new RealFeatures(traindata_real);
		RealFeatures subkfeats2_test = new RealFeatures(testdata_real);
		
		LinearKernel subkernel2 = new LinearKernel();
		feats_train.append_feature_obj(subkfeats2_train);
		feats_test.append_feature_obj(subkfeats2_test);
		kernel.append_kernel(subkernel2);

		RealFeatures subkfeats3_train = new RealFeatures(traindata_real);
		RealFeatures subkfeats3_test = new RealFeatures(testdata_real);
		
		PolyKernel subkernel3 = new PolyKernel(10, 2);
		feats_train.append_feature_obj(subkfeats3_train);
		feats_test.append_feature_obj(subkfeats3_test);
		kernel.append_kernel(subkernel3);

		kernel.init(feats_train, feats_train);

		Labels labels = new Labels(trainlab);

		MKLMultiClass mkl = new MKLMultiClass(C, kernel, labels);
		mkl.set_epsilon(epsilon);
		mkl.set_mkl_epsilon(epsilon);
		mkl.set_mkl_norm(mkl_norm);

		mkl.train();

		kernel.init(feats_train, feats_test);
		DoubleMatrix out =  mkl.apply().get_labels();

		modshogun.exit_shogun();
	}
}
