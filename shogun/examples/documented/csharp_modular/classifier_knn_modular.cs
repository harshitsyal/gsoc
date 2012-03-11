// This example shows usage of a k-nearest neighbor (KNN) classification rule on
// a toy data set. The number of the nearest neighbors is set to k=3 and the distances
// are measured by the Euclidean metric. Finally, the KNN rule is applied to predict
// labels of test examples. 

using System;

public class classifier_knn_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		int k = 3;

		double[,] traindata_real = Load.load_numbers("../data/fm_train_real.dat");
		double[,] testdata_real = Load.load_numbers("../data/fm_test_real.dat");

		double[] trainlab = Load.load_labels("../data/label_train_multiclass.dat");

		RealFeatures feats_train = new RealFeatures(traindata_real);
		RealFeatures feats_test = new RealFeatures(testdata_real);
		EuclidianDistance distance = new EuclidianDistance(feats_train, feats_train);

		Labels labels = new Labels(trainlab);

		KNN knn = new KNN(k, distance, labels);
		knn.train();
		double[] out_labels = knn.apply(feats_test).get_labels();

		foreach(double item in out_labels) {
			Console.Write(item);
		}

		modshogun.exit_shogun();
	}
}
