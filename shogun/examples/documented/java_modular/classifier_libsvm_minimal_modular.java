// In this example a two-class support vector machine classifier is trained on a
// 2-dimensional randomly generated data set and the trained classifier is used to
// predict labels of test examples. As training algorithm the LIBSVM solver is used
// with SVM regularization parameter C=1 and a Gaussian kernel of width 2.1.
// 
// For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

import org.shogun.*;
import org.jblas.*;
import static org.jblas.MatrixFunctions.signum;
import static org.jblas.DoubleMatrix.concatHorizontally;
import static org.jblas.DoubleMatrix.ones;
import static org.jblas.DoubleMatrix.randn;

public class classifier_libsvm_minimal_modular {
	static {
		System.loadLibrary("modshogun");
	}
	
	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();

		int num = 1000;
		double dist = 1.0;
		double width = 2.1;
		double C = 1.0;

		DoubleMatrix offs=ones(2, num).mmul(dist);
		DoubleMatrix x = randn(2, num).sub(offs);
		DoubleMatrix y = randn(2, num).add(offs);
		DoubleMatrix traindata_real = concatHorizontally(x, y);

		DoubleMatrix m = randn(2, num).sub(offs);
		DoubleMatrix n = randn(2, num).add(offs);
		DoubleMatrix testdata_real = concatHorizontally(m, n);

		DoubleMatrix o = ones(1,num);
		DoubleMatrix trainlab = concatHorizontally(o.neg(), o);
		DoubleMatrix testlab = concatHorizontally(o.neg(), o);

		RealFeatures feats_train = new RealFeatures(traindata_real);
		RealFeatures feats_test = new RealFeatures(testdata_real);
		GaussianKernel kernel = new GaussianKernel(feats_train, feats_train, width);
		Labels labels = new Labels(trainlab);
		LibSVM svm = new LibSVM(C, kernel, labels);
		svm.train();

		DoubleMatrix out = svm.apply(feats_test).get_labels();

		System.out.println("Mean Error = " + signum(out).ne(testlab).mean());
		modshogun.exit_shogun();
	}
}
