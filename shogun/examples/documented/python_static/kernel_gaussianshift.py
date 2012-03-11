# An experimental kernel inspired by the WeightedDegreePositionStringKernel and the Gaussian kernel.
# The idea is to shift the dimensions of the input vectors against eachother. 'shift_step' is the step 
# size of the shifts and  max_shift is the maximal shift.

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindat=lm.load_numbers('../data/fm_train_real.dat')
testdat=lm.load_numbers('../data/fm_test_real.dat')
parameter_list=[[traindat,testdat,1.9,2,1,10],[traindat,testdat,1.5,2,1,11]]

def kernel_gaussianshift (fm_train_real=traindat,fm_test_real=testdat,
		 width=1.4,max_shift=2,shift_step=1,size_cache=10):

	sg('set_features', 'TRAIN', fm_train_real)
	sg('set_features', 'TEST', fm_test_real)
	sg('set_kernel', 'GAUSSIANSHIFT', 'REAL', size_cache, width, max_shift, shift_step)
	km=sg('get_kernel_matrix', 'TRAIN')
	km=sg('get_kernel_matrix', 'TEST')
	return km

if __name__=='__main__':
	print 'GaussianShift'
	kernel_gaussianshift(*parameter_list[0])
