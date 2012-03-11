# The Weighted Degree String kernel.
# 
# The WD kernel of order d compares two sequences X and
# Y of length L by summing all contributions of k-mer matches of
# lengths k in 1...d , weighted by coefficients beta_k. It
# is defined as
# 
#     k(X, Y)=\sum_{k=1}^d\beta_k\sum_{l=1}^{L-k+1}I(u_{k,l}(X)=u_{k,l}(Y)).
# 
# Here, $u_{k,l}(X)$ is the string of length k starting at position
# l of the sequence X and I(.) is the indicator function
# which evaluates to 1 when its argument is true and to 0
# otherwise.
# 

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindna=lm.load_dna('../data/fm_train_dna.dat')
testdna=lm.load_dna('../data/fm_test_dna.dat')
parameter_list=[[traindna,testdna,10,20],
		[traindna,testdna,11,21]]

def kernel_weighteddegreestring (fm_train_dna=traindna,fm_test_dna=testdna,
		size_cache=10,degree=20):

	sg('set_features', 'TRAIN', fm_train_dna, 'DNA')
	sg('set_features', 'TEST', fm_test_dna, 'DNA')
	sg('set_kernel', 'WEIGHTEDDEGREE', 'CHAR', size_cache, degree)
	km=sg('get_kernel_matrix', 'TRAIN')
	km=sg('get_kernel_matrix', 'TEST')
	return km

if __name__=='__main__':
	print 'WeightedDegreeString'
	kernel_weighteddegreestring(*parameter_list[0])
