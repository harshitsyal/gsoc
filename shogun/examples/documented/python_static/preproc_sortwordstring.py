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
from sg import sg
lm=LoadMatrix()

traindna=lm.load_dna('../data/fm_train_dna.dat')
testdna=lm.load_dna('../data/fm_test_dna.dat')
parameter_list=[[traindna,testdna,10,3,0,'n',False,'FULL'],
		[traindna,testdna,11,4,0,'n',False,'FULL']]

def preproc_sortwordstring (fm_train_dna=traindna,fm_test_dna=testdna,
				 size_cache=10,order=3,gap=0,reverse='n',
				 use_sign=False,normalization='FULL'):

	sg('add_preproc', 'SORTWORDSTRING')
	sg('set_features', 'TRAIN', fm_train_dna, 'DNA')
	sg('convert', 'TRAIN', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TRAIN')

	sg('set_features', 'TEST', fm_test_dna, 'DNA')
	sg('convert', 'TEST', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TEST')

	sg('set_kernel', 'COMMSTRING', 'WORD', size_cache, use_sign, normalization)
	km=sg('get_kernel_matrix', 'TRAIN')
	km=sg('get_kernel_matrix', 'TEST')
	return km

if __name__=='__main__':
	print 'CommWordString'
	preproc_sortwordstring(*parameter_list[0])
