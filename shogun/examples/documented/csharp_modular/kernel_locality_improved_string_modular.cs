//  The LocalityImprovedString kernel is inspired by the polynomial kernel.
// Comparing neighboring characters it puts emphasize on local features.
// 
// It can be defined as
// K({\bf x},{\bf x'})=\left(\sum_{i=0}^{T-1}\left(\sum_{j=-l}^{+l}w_jI_{i+j}({\bf x},{\bf x'})\right)^{d_1}\right)^{d_2},
// where
// I_i({\bf x},{\bf x'})=1 
// if $x_i=x'_i and 0 otherwise.
// 

using System;

public class kernel_locality_improved_string_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		int length = 5;
		int inner_degree = 5;
		int outer_degree = 7;

		String[] fm_train_dna = Load.load_dna("../data/fm_train_dna.dat");
		String[] fm_test_dna = Load.load_dna("../data/fm_test_dna.dat");

		StringCharFeatures feats_train = new StringCharFeatures(fm_train_dna, EAlphabet.DNA);
		StringCharFeatures feats_test = new StringCharFeatures(fm_test_dna, EAlphabet.DNA);

		LocalityImprovedStringKernel kernel = new LocalityImprovedStringKernel(feats_train, feats_train, length, inner_degree, outer_degree);

		double[,] km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		double[,] km_test = kernel.get_kernel_matrix();
		modshogun.exit_shogun();
	}
}
