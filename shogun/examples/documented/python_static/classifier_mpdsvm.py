# In this example a two-class support vector machine classifier is trained on a
# toy data set and the trained classifier is used to predict labels of test
# examples. As training algorithm the Minimal Primal Dual SVM is used with SVM
# regularization parameter C=1.2 and a Gaussian kernel of width 2.1 and 10MB of
# kernel cache and the precision parameter epsilon=1e-5.
# 
# For more details on the MPD solver see 
#  Kienzle, W. and B. Schölkopf: Training Support Vector Machines with Multiple
#  Equality Constraints. Machine Learning: ECML 2005, 182-193. (Eds.) Carbonell,
#  J. G., J. Siekmann, Springer, Berlin, Germany (11 2005)

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()


traindat=lm.load_numbers('../data/fm_train_real.dat')
testdat=lm.load_numbers('../data/fm_test_real.dat')
train_label=lm.load_labels('../data/label_train_twoclass.dat')
parameter_list=[[traindat,testdat, train_label,10,2.1,1.2,1e-5,False],
		[traindat,testdat,train_label,10,2.1,1.3,1e-4,False]]

def classifier_mpdsvm (fm_train_real=traindat,fm_test_real=testdat,
			label_train_twoclass=train_label,
			size_cache=10, width=2.1,C=1.2,
			epsilon=1e-5,use_bias=False):

	sg('set_features', 'TRAIN', fm_train_real)
	sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width)

	sg('set_labels', 'TRAIN', label_train_twoclass)
	sg('new_classifier', 'MPDSVM')
	sg('svm_epsilon', epsilon)
	sg('c', C)
	sg('svm_use_bias', use_bias)
	sg('train_classifier')

	sg('set_features', 'TEST', fm_test_real)
	result=sg('classify')
	kernel_matrix = sg('get_kernel_matrix', 'TEST')
	return result, kernel_matrix

if __name__=='__main__':
	print 'MPDSVM'
	classifier_mpdsvm(*parameter_list[0])
