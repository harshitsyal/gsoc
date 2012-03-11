// In this example a kernel matrix is computed for a given string data set. The
// CommWordString kernel is used to compute the spectrum kernel from strings that
// have been mapped into unsigned 16bit integers. These 16bit integers correspond
// to k-mers. To be applicable in this kernel the mapped k-mers have to be sorted.
// This is done using the SortWordString preprocessor, which sorts the indivual
// strings in ascending order. The kernel function basically uses the algorithm in
// the unix "comm" command (hence the name). Note that this representation is
// especially tuned to small alphabets (like the 2-bit alphabet DNA), for which it
// enables spectrum kernels of order up to 8. For this kernel the linadd speedups
// are quite efficiently implemented using direct maps.

using System;

public class preprocessor_sortwordstring_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		bool reverse = false;
		int order = 3;
		int gap = 0;

		string[] fm_train_dna = Load.load_dna("../data/fm_train_dna.dat");
		string[] fm_test_dna = Load.load_dna("../data/fm_test_dna.dat");

		StringCharFeatures charfeat = new StringCharFeatures(fm_train_dna, EAlphabet.DNA);
		StringWordFeatures feats_train = new StringWordFeatures(charfeat.get_alphabet());
		feats_train.obtain_from_char(charfeat, order-1, order, gap, reverse);

		charfeat = new StringCharFeatures(fm_test_dna, EAlphabet.DNA);
		StringWordFeatures feats_test = new StringWordFeatures(charfeat.get_alphabet());
		feats_test.obtain_from_char(charfeat, order-1, order, gap, reverse);

		SortWordString preproc = new SortWordString();
		preproc.init(feats_train);
		feats_train.add_preprocessor(preproc);
		feats_train.apply_preprocessor();
		feats_test.add_preprocessor(preproc);
		feats_test.apply_preprocessor();

		CommWordStringKernel kernel = new CommWordStringKernel(feats_train, feats_train, false);

		double[,] km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		double[,] km_test = kernel.get_kernel_matrix();

		modshogun.exit_shogun();
	}
}