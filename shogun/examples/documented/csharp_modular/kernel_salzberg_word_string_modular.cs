// The SalzbergWordString kernel implements the Salzberg kernel.
// 
// It is described in
// 
// Engineering Support Vector Machine Kernels That Recognize Translation Initiation Sites
// A. Zien, G.Raetsch, S. Mika, B. Schoelkopf, T. Lengauer, K.-R. Mueller
// 

using System;

public class kernel_salzberg_word_string_modular {
	public static void Main() {
		modshogun.init_shogun_with_defaults();

		bool reverse = false;
		int order = 3;
		int gap = 0;

		String[] fm_train_dna = Load.load_dna("../data/fm_train_dna.dat");
		String[] fm_test_dna = Load.load_dna("../data/fm_test_dna.dat");

		StringCharFeatures charfeat = new StringCharFeatures(fm_train_dna, EAlphabet.DNA);
		StringWordFeatures feats_train = new StringWordFeatures(charfeat.get_alphabet());
		feats_train.obtain_from_char(charfeat, order-1, order, gap, false);

		charfeat = new StringCharFeatures(fm_test_dna, EAlphabet.DNA);
		StringWordFeatures feats_test = new StringWordFeatures(charfeat.get_alphabet());
		feats_test.obtain_from_char(charfeat, order-1, order, gap, false);

		Labels labels = new Labels(Load.load_labels("../data/label_train_dna.dat"));

		PluginEstimate pie = new PluginEstimate();
		pie.set_labels(labels);
		pie.set_features(feats_train);
		pie.train();

		SalzbergWordStringKernel kernel = new SalzbergWordStringKernel(feats_train, feats_train, pie, labels);
		double[,] km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		pie.set_features(feats_test);
		pie.apply().get_labels();
		double[,] km_test=kernel.get_kernel_matrix();

		modshogun.exit_shogun();
	}
}

