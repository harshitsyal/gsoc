// In this example a two-class linear classifier based on the Linear Discriminant
// Analysis (LDA) is trained on a toy data set and then the trained classifier is
// used to predict test examples. The regularization parameter, which corresponds
// to a weight of a unitary matrix added to the covariance matrix, is set to
// gamma=3.
// 
// For more details on the LDA see e.g.
//     http://en.wikipedia.org/wiki/Linear_discriminant_analysis

using System;

public class classifier_lda_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		int gamma = 3;

		double[,] traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		double[,] testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		double[] trainlab = Load.load_labels("../data/label_train_twoclass.dat");

		RealFeatures feats_train = new RealFeatures();
		feats_train.set_feature_matrix(traindata_real);
		RealFeatures feats_test = new RealFeatures();
		feats_test.set_feature_matrix(testdata_real);

		Labels labels = new Labels(trainlab);

		LDA lda = new LDA(gamma, feats_train, labels);
		lda.train();

		Console.WriteLine(lda.get_bias());

		//Console.WriteLine(lda.get_w().toString());
		foreach(double item in lda.get_w()) {
			Console.Write(item);
		}


		lda.set_features(feats_test);
		double[] out_labels = lda.apply().get_labels();

		foreach(double item in out_labels) {
			Console.Write(item);
		}

		modshogun.exit_shogun();
	}
}