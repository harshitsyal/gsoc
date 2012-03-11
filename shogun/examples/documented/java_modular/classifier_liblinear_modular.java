// In this example a two-class linear support vector machine classifier is trained
// on a toy data set and the trained classifier is then used to predict labels of
// test examples. As training algorithm the LIBLINEAR solver is used with the SVM
// regularization parameter C=0.9 and the bias in the classification rule switched
// on and the precision parameters epsilon=1e-5.
// 
// For more details on LIBLINEAR see
//     http://www.csie.ntu.edu.tw/~cjlin/liblinear/

import org.shogun.*;
import org.jblas.*;
import static org.shogun.LIBLINEAR_SOLVER_TYPE.L2R_L2LOSS_SVC_DUAL;

public class classifier_liblinear_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		double C = 0.9;
		double epsilon = 1e-3;

		org.shogun.Math.init_random(17);
		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		DoubleMatrix trainlab = Load.load_labels("../data/label_train_twoclass.dat");

		RealFeatures feats_train = new RealFeatures();
		feats_train.set_feature_matrix(traindata_real);
		RealFeatures feats_test = new RealFeatures();
		feats_test.set_feature_matrix(testdata_real);

		Labels labels = new Labels(trainlab);

		LibLinear svm = new LibLinear(C, feats_train, labels);
		svm.set_liblinear_solver_type(L2R_L2LOSS_SVC_DUAL);
		svm.set_epsilon(epsilon);
		svm.set_bias_enabled(true);
		svm.train();
		svm.set_features(feats_test);
		DoubleMatrix out_labels = svm.apply().get_labels();
		System.out.println(out_labels.toString());

		modshogun.exit_shogun();
	}
}
