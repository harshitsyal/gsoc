# The WeightedCommWordString kernel may be used to compute the weighted
# spectrum kernel (i.e. a spectrum kernel for 1 to K-mers, where each k-mer
# length is weighted by some coefficient \f$\beta_k\f$) from strings that have
# been mapped into unsigned 16bit integers.
# 
# These 16bit integers correspond to k-mers. To applicable in this kernel they
# need to be sorted (e.g. via the SortWordString pre-processor).
# 
# It basically uses the algorithm in the unix "comm" command (hence the name)
# to compute:
# 
# k({\bf x},({\bf x'})= \sum_{k=1}^K\beta_k\Phi_k({\bf x})\cdot \Phi_k({\bf x'})
# 
# where \f$\Phi_k\f$ maps a sequence \f${\bf x}\f$ that consists of letters in
# \f$\Sigma\f$ to a feature vector of size \f$|\Sigma|^k\f$. In this feature
# vector each entry denotes how often the k-mer appears in that \f${\bf x}\f$.
# 
# Note that this representation is especially tuned to small alphabets
# (like the 2-bit alphabet DNA), for which it enables spectrum kernels
# of order 8.
# 
# For this kernel the linadd speedups are quite efficiently implemented using
# direct maps.
# 

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindna=lm.load_dna('../data/fm_train_dna.dat')
testdna=lm.load_dna('../data/fm_test_dna.dat')
trainlabel=lm.load_labels('../data/label_train_dna.dat')
parameter_list=[[traindna,testdna,trainlabel,10,3,0,'n',False,'FULL'],
		[traindna,testdna,trainlabel,11,4,0,'n',False,'FULL']]

def kernel_weightedcommwordstring (fm_train_dna=traindna,fm_test_dna=testdna,
				   label_train_dna=trainlabel,size_cache=10,
				   order=3,gap=0,reverse='n',use_sign=False,
				   normalization='FULL'):

	sg('add_preproc', 'SORTWORDSTRING')
	sg('set_features', 'TRAIN', fm_train_dna, 'DNA')
	sg('convert', 'TRAIN', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TRAIN')

	sg('set_features', 'TEST', fm_test_dna, 'DNA')
	sg('convert', 'TEST', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TEST')

	sg('set_kernel', 'WEIGHTEDCOMMSTRING', 'WORD', size_cache, use_sign, normalization)
	km=sg('get_kernel_matrix', 'TRAIN')
	km=sg('get_kernel_matrix', 'TEST')
	return km

if __name__=='__main__':
	print 'WeightedCommWordString'
	kernel_weightedcommwordstring(*parameter_list[0])
