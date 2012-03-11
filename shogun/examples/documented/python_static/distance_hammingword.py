# An approach as applied below, which shows the processing of input data
# from a file becomes a crucial factor for writing your own sample applications.
# This approach is just one example of what can be done using the distance
# functions provided by shogun.
# 
# First, you need to determine what type your data will be, because this
# will determine the distance function you can use.
# 
# This example loads two stored data sets in 'STRING' representation
# (feature type 'CHAR' with alphabet 'DNA') from different files and
# initializes the distance to 'HAMMING' with feature type 'WORD'.
# 
# Data points in this example are defined by the transformation function
# 'convert' and the preprocessing step applied afterwards (defined by
# 'add_preproc' and preprocessor 'SORTWORDSTRING').
# 
# The target 'TRAIN' for 'set_features' controls the binding of the given
# data points. In order to compute a pairwise distance matrix by
# 'get_distance_matrix', we have to perform two preprocessing steps for
# input data 'TRAIN'. The method 'convert' transforms the input data to
# a string representation suitable for the selected distance. The individual
# strings are sorted in ascending order after the execution of 'attach_preproc'.
# A pairwise distance matrix is computed by 'get_distance_matrix'.
# 
# The resulting distance matrix can be reaccessed by 'get_distance_matrix'
# and target 'TRAIN'.
# 
# The target 'TEST' for 'set_features' controls the binding of the given
# data points 'TRAIN' and 'TEST'. In order to compute a pairwise distance
# matrix between these two data sets by 'get_distance_matrix', we have to
# perform two preprocessing steps for input data 'TEST'. The method 'convert'
# transforms the input data 'TEST' to a string representation suitable for
# the selected distance. The individual strings are sorted in ascending order
# after the execution of 'attach_preproc'. A pairwise distance matrix between
# the data sets 'TRAIN' and 'TEST' is computed by 'get_distance_matrix'.
# 
# The resulting distance matrix can be reaccessed by 'get_distance_matrix'
# and target 'TEST'. The 'TRAIN' distance matrix ceased to exist.
# 
# For more details see
# doc/classshogun_1_1CSortWordString.html,
# doc/classshogun_1_1CPreprocessor.html,
# doc/classshogun_1_1CStringFeatures.html (method obtain_from_char_features) and
# doc/classshogun_1_1CHammingWordDistance.html.
# 
# Obviously, using the Hamming word distance is not limited to this showcase
# example.

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindna=lm.load_dna('../data/fm_train_dna.dat')
testdna=lm.load_dna('../data/fm_test_dna.dat')
parameter_list=[[traindna,testdna,3,0,'n'],[traindna,testdna,4,0,'n']]

def distance_hammingword (fm_train_dna=traindna,fm_test_dna=testdna,order=3,
			    gap=0,reverse='n'):

	sg('set_distance', 'HAMMING', 'WORD')
	sg('add_preproc', 'SORTWORDSTRING')
	sg('set_features', 'TRAIN', fm_train_dna, 'DNA')
	sg('convert', 'TRAIN', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TRAIN')
	dm=sg('get_distance_matrix', 'TRAIN')
	sg('set_features', 'TEST', fm_test_dna, 'DNA')
	sg('convert', 'TEST', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, gap, reverse)
	sg('attach_preproc', 'TEST')
	dm=sg('get_distance_matrix', 'TEST')
	return dm

if __name__=='__main__':
	print 'HammingWordDistance'
	distance_hammingword(*parameter_list[0])
