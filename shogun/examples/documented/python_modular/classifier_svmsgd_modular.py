# In this example a two-class linear support vector machine classifier is trained
# on a toy data set and the trained classifier is used to predict labels of test
# examples. As training algorithm the Stochastic Gradient Descent (SGD) solver is
# used with the SVM regularization parameter C=0.9. The number of iterations, i.e.
# passes though all training examples, is set to num_iter=5 .
# 
# For more details on the SGD solver see
#  L. Bottou, O. Bousquet. The tradeoff of large scale learning. In NIPS 20. MIT
#  Press. 2008.

from tools.load import LoadMatrix
lm=LoadMatrix()

traindat = lm.load_numbers('../data/fm_train_real.dat')
testdat = lm.load_numbers('../data/fm_test_real.dat')
label_traindat = lm.load_labels('../data/label_train_twoclass.dat')

parameter_list = [[traindat,testdat,label_traindat,0.9,1,6],[traindat,testdat,label_traindat,0.8,1,5]]

def classifier_svmsgd_modular (fm_train_real=traindat,fm_test_real=testdat,label_train_twoclass=label_traindat,C=0.9,num_threads=1,num_iter=5):

	from shogun.Features import RealFeatures, SparseRealFeatures, Labels
	from shogun.Classifier import SVMSGD

	realfeat=RealFeatures(fm_train_real)
	feats_train=SparseRealFeatures()
	feats_train.obtain_from_simple(realfeat)
	realfeat=RealFeatures(fm_test_real)
	feats_test=SparseRealFeatures()
	feats_test.obtain_from_simple(realfeat)

	labels=Labels(label_train_twoclass)

	svm=SVMSGD(C, feats_train, labels)
	svm.set_epochs(num_iter)
	#svm.io.set_loglevel(0)
	svm.train()

	svm.set_features(feats_test)
	svm.apply().get_labels()
	predictions = svm.apply()
	return predictions, svm, predictions.get_labels()



if __name__=='__main__':
	print 'SVMSGD'
	classifier_svmsgd_modular(*parameter_list[0])
