# In this example a kernel matrix is computed for a given string data set. The
# CommUlongString kernel is used to compute the spectrum kernel from strings that
# have been mapped into unsigned 64bit integers. These 64bit integers correspond
# to k-mers. To be applicable in this kernel the mapped k-mers have to be sorted.
# This is done using the SortUlongString preprocessor, which sorts the indivual
# strings in ascending order. The kernel function basically uses the algorithm in
# the unix "comm" command (hence the name). Note that this representation enables
# spectrum kernels of order 8 for 8bit alphabets (like binaries) and order 32 for
# 2-bit alphabets like DNA. For this kernel the linadd speedups are implemented
# (though there is room for improvement here when a whole set of sequences is
# ADDed) using sorted lists.

from tools.load import LoadMatrix
lm=LoadMatrix()

traindna = lm.load_dna('../data/fm_train_dna.dat')
testdna = lm.load_dna('../data/fm_test_dna.dat')

parameter_list = [[traindna,testdna,4,0,False,False],[traindna,testdna,3,0,False,False]]

def preprocessor_sortulongstring_modular (fm_train_dna=traindna,fm_test_dna=testdna,order=3,gap=0,reverse=False,use_sign=False):

	from shogun.Kernel import CommUlongStringKernel
	from shogun.Features import StringCharFeatures, StringUlongFeatures, DNA
	from shogun.Preprocessor import SortUlongString


	charfeat=StringCharFeatures(DNA)
	charfeat.set_features(fm_train_dna)
	feats_train=StringUlongFeatures(charfeat.get_alphabet())
	feats_train.obtain_from_char(charfeat, order-1, order, gap, reverse)

	charfeat=StringCharFeatures(DNA)
	charfeat.set_features(fm_test_dna)
	feats_test=StringUlongFeatures(charfeat.get_alphabet())
	feats_test.obtain_from_char(charfeat, order-1, order, gap, reverse)

	preproc=SortUlongString()
	preproc.init(feats_train)
	feats_train.add_preprocessor(preproc)
	feats_train.apply_preprocessor()
	feats_test.add_preprocessor(preproc)
	feats_test.apply_preprocessor()

	kernel=CommUlongStringKernel(feats_train, feats_train, use_sign)

	km_train=kernel.get_kernel_matrix()
	kernel.init(feats_train, feats_test)
	km_test=kernel.get_kernel_matrix()
	return km_train,km_test,kernel

if __name__=='__main__':
	print 'CommUlongString'
	preprocessor_sortulongstring_modular(*parameter_list[0])
