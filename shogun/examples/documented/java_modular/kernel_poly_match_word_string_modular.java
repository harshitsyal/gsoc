// This is an example for the initialization of the PolyMatchString kernel on string data. 
// The PolyMatchString kernel sums over the matches of two stings of the same length and 
// takes the sum to the power of 'degree'. The strings consist of the characters 'ACGT' corresponding 
// to the DNA-alphabet. Each column of the matrices of type char corresponds to 
// one training/test example.

import org.shogun.*;
import org.jblas.*;
import static org.shogun.EAlphabet.DNA;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class kernel_poly_match_word_string_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();

		boolean reverse = false;
		int order = 3;
		int gap = 0;
		int degree = 2;

		String[] fm_train_dna = Load.load_dna("../data/fm_train_dna.dat");
		String[] fm_test_dna = Load.load_dna("../data/fm_test_dna.dat");

		StringCharFeatures charfeat = new StringCharFeatures(fm_train_dna, DNA);
		StringWordFeatures feats_train = new StringWordFeatures(charfeat.get_alphabet());
		feats_train.obtain_from_char(charfeat, order-1, order, gap, false);

		charfeat = new StringCharFeatures(fm_test_dna, DNA);
		StringWordFeatures feats_test = new StringWordFeatures(charfeat.get_alphabet());
		feats_test.obtain_from_char(charfeat, order-1, order, gap, false);

		PolyMatchWordStringKernel kernel = new PolyMatchWordStringKernel(feats_train, feats_train, degree, true);
		DoubleMatrix km_train = kernel.get_kernel_matrix();
		kernel.init(feats_train, feats_test);
		DoubleMatrix km_test=kernel.get_kernel_matrix();

		modshogun.exit_shogun();
	}
}
