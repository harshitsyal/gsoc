// In this example a two-class linear classifier based on the Linear Discriminant
// Analysis (LDA) is trained on a toy data set and then the trained classifier is
// used to predict test examples. The regularization parameter, which corresponds
// to a weight of a unitary matrix added to the covariance matrix, is set to
// gamma=3.
// 
// For more details on the LDA see e.g.
//     http://en.wikipedia.org/wiki/Linear_discriminant_analysis

import org.shogun.*;
import org.jblas.*;

public class classifier_lda_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		int gamma = 3;

		DoubleMatrix traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		DoubleMatrix testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		DoubleMatrix trainlab = Load.load_labels("../data/label_train_twoclass.dat");

		RealFeatures feats_train = new RealFeatures();
		feats_train.set_feature_matrix(traindata_real);
		RealFeatures feats_test = new RealFeatures();
		feats_test.set_feature_matrix(testdata_real);

		Labels labels = new Labels(trainlab);

		LDA lda = new LDA(gamma, feats_train, labels);
		lda.train();

		System.out.println(lda.get_bias());
		System.out.println(lda.get_w().toString());
		lda.set_features(feats_test);
		DoubleMatrix out_labels = lda.apply().get_labels();
		System.out.println(out_labels.toString());

		modshogun.exit_shogun();
	}
}
