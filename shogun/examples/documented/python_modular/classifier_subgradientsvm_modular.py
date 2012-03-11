# In this example a two-class linear support vector machine classifier is trained
# on a toy data set and the trained classifier is used to predict labels of test
# examples. As training algorithm the steepest descent subgradient algorithm is
# used. The SVM regularization parameter is set to C=0.9 and the bias in the
# classification rule is switched off. The solver iterates until it finds an
# epsilon-precise solution (epsilon=1e-3) or the maximal training time
# max_train_time=1 (seconds) is exceeded. The unbiased linear rule is trained.
# 
# Note that this solver often does not converges because the steepest descent
# subgradient algorithm is oversensitive to rounding errors. Note also that this
# is an unpublished work which was predecessor of the OCAS solver (see
# classifier_svmocas).

from tools.load import LoadMatrix
lm=LoadMatrix()
train=lm.load_numbers('../data/fm_train_real.dat')
test=lm.load_numbers('../data/fm_test_real.dat')
labels=lm.load_labels('../data/label_train_twoclass.dat')

parameter_list=[[train,test,labels,5,1e-3,3.0], [train,test,labels,0.9,1e-2,1.0]]

def classifier_subgradientsvm_modular(fm_train_real, fm_test_real,
		label_train_twoclass, C, epsilon, max_train_time):

	from shogun.Features import RealFeatures, SparseRealFeatures, Labels
	from shogun.Classifier import SubGradientSVM

	realfeat=RealFeatures(fm_train_real)
	feats_train=SparseRealFeatures()
	feats_train.obtain_from_simple(realfeat)
	realfeat=RealFeatures(fm_test_real)
	feats_test=SparseRealFeatures()
	feats_test.obtain_from_simple(realfeat)

	labels=Labels(label_train_twoclass)

	svm=SubGradientSVM(C, feats_train, labels)
	svm.set_epsilon(epsilon)
	svm.set_max_train_time(max_train_time)
	svm.train()

	svm.set_features(feats_test)
	labels=svm.apply().get_labels()

	return labels, svm

if __name__=='__main__':
	print 'SubGradientSVM'
	classifier_subgradientsvm_modular(*parameter_list[0])
