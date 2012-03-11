// In this example a two-class support vector machine classifier is trained on a
// 2-dimensional randomly generated data set and the trained classifier is used to
// predict labels of test examples. As training algorithm the LIBSVM solver is used
// with SVM regularization parameter C=1 and a Gaussian kernel of width 2.1.
// 
// For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

using System;


public class classifier_libsvm_minimal_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();

		int num = 1000;
		double dist = 1.0;
		double width = 2.1;
		double C = 1.0;

		Random RandomNumber = new Random();

		double[,] traindata_real = new double[2, num * 2];
		for (int i = 0; i < num; i ++) {
			traindata_real[0, i] = RandomNumber.NextDouble() - dist;
			traindata_real[0, i + num] = RandomNumber.NextDouble() + dist;
			traindata_real[1, i] = RandomNumber.NextDouble() - dist;
			traindata_real[1, i + num] = RandomNumber.NextDouble() + dist;
		}

		double[,] testdata_real = new double[2, num * 2];
		for (int i = 0; i < num; i ++) {
			testdata_real[0, i] = RandomNumber.NextDouble() - dist;
			testdata_real[0, i + num] = RandomNumber.NextDouble() + dist;
			testdata_real[1, i] = RandomNumber.NextDouble() - dist;
			testdata_real[1, i + num] = RandomNumber.NextDouble() + dist;
		}

		double[] trainlab = new double[num * 2];
		for (int i = 0; i < num; i ++) {
			trainlab[i] = -1;
			trainlab[i + num] = 1;
		}

		double[] testlab = new double[num * 2];
		for (int i = 0; i < num; i ++) {
			testlab[i] = -1;
			testlab[i + num] = 1;
		}

		RealFeatures feats_train = new RealFeatures(traindata_real);
		RealFeatures feats_test = new RealFeatures(testdata_real);
		GaussianKernel kernel = new GaussianKernel(feats_train, feats_train, width);
		Labels labels = new Labels(trainlab);
		LibSVM svm = new LibSVM(C, kernel, labels);
		svm.train();

		double[] result = svm.apply(feats_test).get_labels();

		int err_num = 0;
		for (int i = 0; i < num; i++) {
			if (result[i] > 0) {
				err_num += 1;			
			}
			if (result[i+num] < 0) { 
				err_num += 1;
			}
		}

		double testerr=err_num/(2*num);
		Console.WriteLine(testerr);
		modshogun.exit_shogun();
	}
}
