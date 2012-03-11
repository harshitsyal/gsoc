// In this example a multi-class support vector machine is trained on a toy data
// set and the trained classifier is then used to predict labels of test
// examples. The training algorithm is based on BSVM formulation (L2-soft margin
// and the bias added to the objective function) which is solved by the Improved
// Mitchell-Demyanov-Malozemov algorithm. The training algorithm uses the Gaussian
// kernel of width 2.1 and the regularization constant C=1. The solver stops if the
// relative duality gap falls below 1e-5. 
// 
// For more details on the used SVM solver see 
//  V.Franc: Optimization Algorithms for Kernel Methods. Research report.
//  CTU-CMP-2005-22. CTU FEL Prague. 2005.
//  ftp://cmp.felk.cvut.cz/pub/cmp/articles/franc/Franc-PhD.pdf .
// 

import org.shogun.*;
import org.jblas.*;

public class classifier_gmnpsvm_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		double width = 2.1;
		double epsilon = 1e-5;
		double C = 1.0;

		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		DoubleMatrix trainlab = Load.load_labels("../data/label_train_multiclass.dat");

		RealFeatures feats_train = new RealFeatures();
		feats_train.set_feature_matrix(traindata_real);
		RealFeatures feats_test = new RealFeatures();
		feats_test.set_feature_matrix(testdata_real);

		GaussianKernel kernel = new GaussianKernel(feats_train, feats_train, width);

		Labels labels = new Labels(trainlab);

		GMNPSVM svm = new GMNPSVM(C, kernel, labels);
		svm.set_epsilon(epsilon);
		svm.train();
		kernel.init(feats_train, feats_test);
		DoubleMatrix out_labels = svm.apply(feats_test).get_labels();
		System.out.println(out_labels.toString());

		modshogun.exit_shogun();
	}
}
