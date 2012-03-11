# In this example a two-class support vector machine classifier is trained on a
# toy data set and the trained classifier is used to predict labels of test
# examples. As training algorithm the Minimal Primal Dual SVM is used with SVM
# regularization parameter C=1 and a Gaussian kernel of width 1.2 and the
# precision parameter 1e-5. 
# 
# For more details on the MPD solver see 
#  Kienzle, W. and B. Schölkopf: Training Support Vector Machines with Multiple
#  Equality Constraints. Machine Learning: ECML 2005, 182-193. (Eds.) Carbonell,
#  J. G., J. Siekmann, Springer, Berlin, Germany (11 2005)

from tools.load import LoadMatrix
lm=LoadMatrix()

traindat = lm.load_numbers('../data/fm_train_real.dat')
testdat = lm.load_numbers('../data/fm_test_real.dat')
label_traindat = lm.load_labels('../data/label_train_twoclass.dat')

parameter_list = [[traindat,testdat,label_traindat,1,1e-5],[traindat,testdat,label_traindat,0.9,1e-5]]

def classifier_mpdsvm_modular (fm_train_real=traindat,fm_test_real=testdat,label_train_twoclass=label_traindat,C=1,epsilon=1e-5):

	from shogun.Features import RealFeatures, Labels
	from shogun.Kernel import GaussianKernel
	from shogun.Classifier import MPDSVM

	feats_train=RealFeatures(fm_train_real)
	feats_test=RealFeatures(fm_test_real)
	width=2.1
	kernel=GaussianKernel(feats_train, feats_train, width)

	labels=Labels(label_train_twoclass)

	svm=MPDSVM(C, kernel, labels)
	svm.set_epsilon(epsilon)
	svm.train()

	kernel.init(feats_train, feats_test)
	svm.apply().get_labels()
	predictions = svm.apply()
	return predictions, svm, predictions.get_labels()

if __name__=='__main__':
	print 'MPDSVM'
	classifier_mpdsvm_modular(*parameter_list[0])
