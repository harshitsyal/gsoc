# In this example we show how to perform Multiple Kernel Learning (MKL)
# with the modular interface for multi-class classification. 
# First, we create a number of base kernels and features.
# These kernels can capture different views of the same features, or actually
# consider entirely different features associated with the same example 
# (e.g. DNA sequences = strings AND gene expression data = real values of the same tissue sample). 
# The base kernels are then subsequently added to a CombinedKernel, which
# contains a weight for each kernel and encapsulates the base kernels
# from the training procedure. When the CombinedKernel between two examples is
# evaluated it computes the corresponding linear combination of kernels according to their weights.
# We then show how to create an MKLMultiClass classifier that trains an SVM and learns the optimal
# weighting of kernels (w.r.t. a given norm q) at the same time. The main difference to the binary
# classification version of MKL is that we can use more than two values as labels, when training
# the classifier.
# Finally, the example shows how to classify with a trained MKLMultiClass classifier.
# 

from tools.load import LoadMatrix
lm = LoadMatrix()
fm_train_real = lm.load_numbers('../data/fm_train_real.dat')
fm_test_real = lm.load_numbers('../data/fm_test_real.dat')
label_train_multiclass = lm.load_labels('../data/label_train_multiclass.dat')

parameter_list=[
		[ fm_train_real, fm_test_real, label_train_multiclass, 1.2, 1.2, 1e-5, 1, 0.001, 1.5],
		[ fm_train_real, fm_test_real, label_train_multiclass, 5, 1.2, 1e-2, 1, 0.001, 2]]

def mkl_multiclass_modular(fm_train_real, fm_test_real, label_train_multiclass,
	width, C, epsilon, num_threads, mkl_epsilon, mkl_norm):

	from shogun.Features import CombinedFeatures, RealFeatures, Labels
	from shogun.Kernel import CombinedKernel, GaussianKernel, LinearKernel,PolyKernel
	from shogun.Classifier import MKLMultiClass

	kernel = CombinedKernel()
	feats_train = CombinedFeatures()
	feats_test = CombinedFeatures()

	subkfeats_train = RealFeatures(fm_train_real)
	subkfeats_test = RealFeatures(fm_test_real)
	subkernel = GaussianKernel(10, width)
	feats_train.append_feature_obj(subkfeats_train)
	feats_test.append_feature_obj(subkfeats_test)
	kernel.append_kernel(subkernel)

	subkfeats_train = RealFeatures(fm_train_real)
	subkfeats_test = RealFeatures(fm_test_real)
	subkernel = LinearKernel()
	feats_train.append_feature_obj(subkfeats_train)
	feats_test.append_feature_obj(subkfeats_test)
	kernel.append_kernel(subkernel)

	subkfeats_train = RealFeatures(fm_train_real)
	subkfeats_test = RealFeatures(fm_test_real)
	subkernel = PolyKernel(10,2)
	feats_train.append_feature_obj(subkfeats_train)
	feats_test.append_feature_obj(subkfeats_test)
	kernel.append_kernel(subkernel)
	
	kernel.init(feats_train, feats_train)

	labels = Labels(label_train_multiclass)

	mkl = MKLMultiClass(C, kernel, labels)
	
	mkl.set_epsilon(epsilon);
	mkl.parallel.set_num_threads(num_threads)
	mkl.set_mkl_epsilon(mkl_epsilon)
	mkl.set_mkl_norm(mkl_norm)

	mkl.train()

	kernel.init(feats_train, feats_test)

	out =  mkl.apply().get_labels()
	return out

if __name__ == '__main__':
	print 'mkl_multiclass'
	mkl_multiclass_modular(*parameter_list[0])
