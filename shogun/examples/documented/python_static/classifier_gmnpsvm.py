# In this example a multi-class support vector machine is trained on a toy data
# set and the trained classifier is used to predict labels of test examples. 
# The training algorithm is based on BSVM formulation (L2-soft margin
# and the bias added to the objective function) which is solved by the Improved
# Mitchell-Demyanov-Malozemov algorithm. The training algorithm uses the Gaussian
# kernel of width 2.1 and the regularization constant C=1.2. The bias term of the
# classification rule is not used. The solver stops if the relative duality gap
# falls below 1e-5 and it uses 10MB for kernel cache.
# 
# For more details on the used SVM solver see 
#  V.Franc: Optimization Algorithms for Kernel Methods. Research report.
#  CTU-CMP-2005-22. CTU FEL Prague. 2005.
#  ftp://cmp.felk.cvut.cz/pub/cmp/articles/franc/Franc-PhD.pdf .
# 

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()


traindat=lm.load_numbers('../data/fm_train_real.dat')
testdat=lm.load_numbers('../data/fm_test_real.dat')
train_label=lm.load_labels('../data/label_train_multiclass.dat')
parameter_list=[[traindat,testdat, train_label,10,2.1,1.2,1e-5,False],
		[traindat,testdat,train_label,10,2.1,1.3,1e-4,False]]

def classifier_gmnpsvm (fm_train_real=traindat,fm_test_real=testdat,
			label_train_multiclass=train_label,
			size_cache=10, width=2.1,C=1.2,
			epsilon=1e-5,use_bias=False):

	sg('set_features', 'TRAIN', fm_train_real)
	sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width)

	sg('set_labels', 'TRAIN', label_train_multiclass)
	sg('new_classifier', 'GMNPSVM')
	sg('svm_epsilon', epsilon)
	sg('c', C)
	sg('svm_use_bias', use_bias)
	sg('train_classifier')

	sg('set_features', 'TEST', fm_test_real)
	result=sg('classify')
	kernel_matrix = sg('get_kernel_matrix', 'TEST')
	return result, kernel_matrix

if __name__=='__main__':
	print 'GMNPSVM'
	classifier_gmnpsvm(*parameter_list[0])
