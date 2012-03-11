# In this example toy data is being preprocessed using the Locally Linear Embedding (LLE)
# algorithm as described in
# 
# Saul, L. K., Ave, P., Park, F., & Roweis, S. T. (2001).
# An Introduction to Locally Linear Embedding. Available from, 290(5500), 2323-2326.
# Retrieved from: http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.123.7319&rep=rep1&type=pdf
# 
# The number of neighbors used during the linear reconstruction step of the algorithm is set
# before processing of the data.

from tools.load import LoadMatrix

lm=LoadMatrix()
data = lm.load_numbers('../data/fm_train_real.dat')

parameter_list = [[data,10],[data,20]]

def converter_locallylinearembedding_modular(data,k):
	from shogun.Features import RealFeatures
	from shogun.Converter import LocallyLinearEmbedding
	
	features = RealFeatures(data)
		
	converter = LocallyLinearEmbedding()
	converter.set_target_dim(1)
	converter.set_k(k)
	converter.apply(features)

	return features


if __name__=='__main__':
	print 'LocallyLinearEmbedding'
	converter_locallylinearembedding_modular(*parameter_list[0])

