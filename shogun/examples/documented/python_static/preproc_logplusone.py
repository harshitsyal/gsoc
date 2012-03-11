# In this example a kernel matrix is computed for a given real-valued data set.
# The kernel used is the Chi2 kernel which operates on real-valued vectors. It
# computes the chi-squared distance between sets of histograms. It is a very
# useful distance in image recognition (used to detect objects). The preprocessor
# LogPlusOne adds one to a dense real-valued vector and takes the logarithm of
# each component of it. It is most useful in situations where the inputs are
# counts: When one compares differences of small counts any difference may matter
# a lot, while small differences in large counts don't. This is what this log
# transformation controls for.

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindat=lm.load_numbers('../data/fm_train_real.dat')
testdat=lm.load_numbers('../data/fm_test_real.dat')
parameter_list=[[traindat,testdat,1.4,10],[traindat,testdat,1.5,11]]

def preproc_logplusone (fm_train_real=traindat,fm_test_real=testdat,
		 width=1.4,size_cache=10):

	sg('add_preproc', 'LOGPLUSONE')
	sg('set_kernel', 'CHI2', 'REAL', size_cache, width)

	sg('set_features', 'TRAIN', fm_train_real)
	sg('attach_preproc', 'TRAIN')
	km=sg('get_kernel_matrix', 'TRAIN')

	sg('set_features', 'TEST', fm_test_real)
	sg('attach_preproc', 'TEST')
	km=sg('get_kernel_matrix', 'TEST')
	return km

if __name__=='__main__':
	print 'LogPlusOne'
	preproc_logplusone(*parameter_list[0])
