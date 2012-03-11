// In this example a two-class support vector machine classifier is trained on a
// DNA splice-site detection data set and the trained classifier is used to predict
// labels on test set. As training algorithm SVM^light is used with SVM
// regularization parameter C=1.2 and the Weighted Degree kernel of degree 20 and
// the precision parameter epsilon=1e-5.
// 
// For more details on the SVM^light see
//  T. Joachims. Making large-scale SVM learning practical. In Advances in Kernel
//  Methods -- Support Vector Learning, pages 169-184. MIT Press, Cambridge, MA USA, 1999.
// 
// For more details on the Weighted Degree kernel see
//  G. Raetsch, S.Sonnenburg, and B. Schoelkopf. RASE: recognition of alternatively
//  spliced exons in C. elegans. Bioinformatics, 21:369-377, June 2005. 

import org.shogun.*;
import org.jblas.*;
import static org.shogun.EAlphabet.DNA;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class classifier_svmlight_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		int degree = 20;
		modshogun.init_shogun_with_defaults();
		double C = 1.1;
		double epsilon = 1e-5;
		int num_threads = 1;

		String[] fm_train_dna = Load.load_dna("../data/fm_train_dna.dat");
		String[] fm_test_dna = Load.load_dna("../data/fm_test_dna.dat");

		StringCharFeatures feats_train = new StringCharFeatures(fm_train_dna, DNA);
		StringCharFeatures feats_test = new StringCharFeatures(fm_test_dna, DNA);

		Labels labels = new Labels(Load.load_labels("../data/label_train_dna.dat"));
		WeightedDegreeStringKernel kernel = new WeightedDegreeStringKernel(feats_train, feats_train, degree);

		SVMLight svm = new SVMLight(C, kernel, labels);
		svm.set_epsilon(epsilon);
		//svm.parallel.set_num_threads(num_threads);
		svm.train();

		kernel.init(feats_train, feats_test);
		svm.apply().get_labels();

		modshogun.exit_shogun();
	}
}
