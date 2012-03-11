# In this example a kernel matrix is computed for a given string data set. The
# CommWordString kernel is used to compute the spectrum kernel from strings that
# have been mapped into unsigned 16bit integers. These 16bit integers correspond
# to k-mers. To be applicable in this kernel the mapped k-mers have to be sorted.
# This is done using the SortWordString preprocessor, which sorts the indivual
# strings in ascending order. The kernel function basically uses the algorithm in
# the unix "comm" command (hence the name). Note that this representation is
# especially tuned to small alphabets (like the 2-bit alphabet DNA), for which it
# enables spectrum kernels of order up to 8. For this kernel the linadd speedups
# are quite efficiently implemented using direct maps.

from tools.load import LoadMatrix
lm=LoadMatrix()

traindna = lm.load_dna('../data/fm_train_dna.dat')
testdna = lm.load_dna('../data/fm_test_dna.dat')

parameter_list = [[traindna,testdna,3,0,False,False],[traindna,testdna,3,0,False,False]]

def preprocessor_sortwordstring_modular (fm_train_dna=traindna,fm_test_dna=testdna,order=3,gap=0,reverse=False,use_sign=False):

	from shogun.Kernel import CommWordStringKernel
	from shogun.Features import StringCharFeatures, StringWordFeatures, DNA
	from shogun.Preprocessor import SortWordString

	charfeat=StringCharFeatures(fm_train_dna, DNA)
	feats_train=StringWordFeatures(charfeat.get_alphabet())
	feats_train.obtain_from_char(charfeat, order-1, order, gap, reverse)
	preproc=SortWordString()
	preproc.init(feats_train)
	feats_train.add_preprocessor(preproc)
	feats_train.apply_preprocessor()

	charfeat=StringCharFeatures(fm_test_dna, DNA)
	feats_test=StringWordFeatures(charfeat.get_alphabet())
	feats_test.obtain_from_char(charfeat, order-1, order, gap, reverse)
	feats_test.add_preprocessor(preproc)
	feats_test.apply_preprocessor()

	kernel=CommWordStringKernel(feats_train, feats_train, use_sign)

	km_train=kernel.get_kernel_matrix()
	kernel.init(feats_train, feats_test)
	km_test=kernel.get_kernel_matrix()

	return km_train,km_test,kernel

if __name__=='__main__':
	print 'CommWordString'
	preprocessor_sortwordstring_modular(*parameter_list[0])
