# In this example a support vector regression algorithm is trained on a
# real-valued toy data set. The underlying library used for the SVR training is
# LIBSVM. The SVR is trained with regularization parameter C=1 and a gaussian
# kernel with width=2.1. The labels of both the train and the test data are
# fetched via svr.classify().get_labels().
# 
# For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/ .

from numpy import array
from numpy.random import seed, rand
from tools.load import LoadMatrix
lm=LoadMatrix()

traindat = lm.load_numbers('../data/fm_train_real.dat')
testdat = lm.load_numbers('../data/fm_test_real.dat')
label_traindat = lm.load_labels('../data/label_train_twoclass.dat')


parameter_list = [[traindat,testdat,label_traindat,2.1,1,1e-5,1e-2], \
                 [traindat,testdat,label_traindat,2.1,1,1e-5,1e-2]]


def regression_libsvr_modular (fm_train=traindat,fm_test=testdat,label_train=label_traindat,\
				       width=2.1,C=1,epsilon=1e-5,tube_epsilon=1e-2):

	from shogun.Features import Labels, RealFeatures
	from shogun.Kernel import GaussianKernel
	from shogun.Regression import LibSVR

	feats_train=RealFeatures(fm_train)
	feats_test=RealFeatures(fm_test)

	kernel=GaussianKernel(feats_train, feats_train, width)
	labels=Labels(label_train)

	svr=LibSVR(C, tube_epsilon, kernel, labels)
	svr.set_epsilon(epsilon)
	svr.train()

	kernel.init(feats_train, feats_test)
	out1=svr.apply().get_labels()
	out2=svr.apply(feats_test).get_labels()

	return out1,out2,kernel

if __name__=='__main__':
	print 'LibSVR'
	regression_libsvr_modular(*parameter_list[0])
