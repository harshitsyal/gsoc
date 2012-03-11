// In this example the k-means clustering method is used to cluster a given toy
// data set. In k-means clustering one tries to partition n observations into k
// clusters in which each observation belongs to the cluster with the nearest mean.
// The algorithm class constructor takes the number of clusters and a distance to
// be used as input. The distance used in this example is Euclidean distance.
// After training one can fetch the result of clustering by obtaining the cluster
// centers and their radiuses.

//import org.shogun.*;
//import org.jblas.*;
//import static org.shogun.Math.init_random;
using System;

public class clustering_kmeans_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		int k = 3;
		// already tried init_random(17)
		Math.init_random(17);

		double[,] fm_train = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures feats_train = new RealFeatures(fm_train);
		EuclidianDistance distance = new EuclidianDistance(feats_train, feats_train);

		KMeans kmeans = new KMeans(k, distance);
		kmeans.train();

		double[,] out_centers = kmeans.get_cluster_centers();
		kmeans.get_radiuses();

		modshogun.exit_shogun();
	}
}
