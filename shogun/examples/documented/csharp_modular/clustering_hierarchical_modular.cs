// In this example an agglomerative hierarchical single linkage clustering method
// is used to cluster a given toy data set. Starting with each object being
// assigned to its own cluster clusters are iteratively merged. Here the clusters
// are merged that have the closest (minimum distance, here set via the Euclidean
// distance object) two elements.

using System;

public class clustering_hierarchical_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		int merges = 3;

		double[,] fm_train = Load.load_numbers("../data/fm_train_real.dat");

		RealFeatures feats_train = new RealFeatures(fm_train);
		EuclidianDistance distance = new EuclidianDistance(feats_train, feats_train);

		Hierarchical hierarchical = new Hierarchical(merges, distance);
		hierarchical.train();

		double[] out_distance = hierarchical.get_merge_distances();
		int[,] out_cluster = hierarchical.get_cluster_pairs();

		modshogun.exit_shogun();
	}
}