# This is an example for the initialization of a linear kernel on string data. The 
# strings are all of the same length and consist of the characters 'ACGT' corresponding 
# to the DNA-alphabet. Each column of the matrices of type char corresponds to 
# one training/test example.

from tools.load import LoadMatrix
lm=LoadMatrix()
traindat = lm.load_dna('../data/fm_train_dna.dat')
testdat = lm.load_dna('../data/fm_test_dna.dat')

parameter_list=[[traindat,testdat],[traindat,testdat]]

def kernel_linear_string_modular (fm_train_dna=traindat,fm_test_dna=testdat):
	from shogun.Features import StringCharFeatures, DNA
	from shogun.Kernel import LinearStringKernel

	feats_train=StringCharFeatures(fm_train_dna, DNA)
	feats_test=StringCharFeatures(fm_test_dna, DNA)

	kernel=LinearStringKernel(feats_train, feats_train)
	km_train=kernel.get_kernel_matrix()

	kernel.init(feats_train, feats_test)
	km_test=kernel.get_kernel_matrix()
	return km_train,km_test,kernel

if __name__=='__main__':
	from tools.load import LoadMatrix
	print 'LinearString'
 	kernel_linear_string_modular(*parameter_list[0])
