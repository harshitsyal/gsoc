// In this example a kernel matrix is computed for a given string data set. The
// CommUlongString kernel is used to compute the spectrum kernel from strings that
// have been mapped into unsigned 64bit integers. These 64bit integers correspond
// to k-mers. To be applicable in this kernel the mapped k-mers have to be sorted.
// This is done using the SortUlongString preprocessor, which sorts the indivual
// strings in ascending order. The kernel function basically uses the algorithm in
// the unix "comm" command (hence the name). Note that this representation enables
// spectrum kernels of order 8 for 8bit alphabets (like binaries) and order 32 for
// 2-bit alphabets like DNA. For this kernel the linadd speedups are implemented
// (though there is room for improvement here when a whole set of sequences is
// ADDed) using sorted lists.

using System;

public class preprocessor_sortulongstring_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();
		bool reverse = false;
		int order = 3;
		int gap = 0;

		string[] fm_train_dna = Load.load_dna("../data/fm_train_dna.dat");
		string[] fm_test_dna = Load.load_dna("../data/fm_test_dna.dat");

		StringCharFeatures charfeat = new StringCharFeatures(fm_train_dna, EAlphabet.DNA);
		StringUlongFeatures feats_train = new StringUlongFeatures(charfeat.get_alphabet());
		feats_train.obtain_from_char(charfeat, order-1, order, gap, reverse);

		charfeat = new StringCharFeatures(fm_test_dna, EAlphabet.DNA);
		StringUlongFeatures feats_test = new StringUlongFeatures(charfeat.get_alphabet());
		feats_test.obtain_from_char(charfeat, order-1, order, gap, reverse);

		SortUlongString preproc = new SortUlongString();
		preproc.init(feats_train);
		feats_train.add_preprocessor(preproc);
		feats_train.apply_preprocessor();
		feats_test.add_preprocessor(preproc);
		feats_test.apply_preprocessor();

		CommUlongStringKernel kernel = new CommUlongStringKernel(feats_train, feats_train, false);

		double[,] km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		double[,] km_test = kernel.get_kernel_matrix();

		modshogun.exit_shogun();
	}
}