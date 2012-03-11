// In this example ROC (Receiver Operator Characteristic) is being computed
// for the pair of ground truth toy labels and random labels.
// ROC curve (as matrix) and auROC (area under ROC) is returned.

import org.shogun.*;
import org.jblas.*;
import static org.jblas.DoubleMatrix.randn;

public class evaluation_rocevaluation_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();

		DoubleMatrix ground_truth = Load.load_labels("../data/label_train_twoclass.dat");
		DoubleMatrix predicted = randn(1, ground_truth.getLength());

		Labels ground_truth_labels = new Labels(ground_truth);
		Labels predicted_labels = new Labels(predicted);

		ROCEvaluation evaluator = new ROCEvaluation();
		evaluator.evaluate(predicted_labels, ground_truth_labels);

		System.out.println(evaluator.get_ROC());
		System.out.println(evaluator.get_auROC());

		modshogun.exit_shogun();
	}
}
