# In this example toy data is being processed using Laplacian Eigenmaps
# algorithm as described in
# 
# Belkin, M., & Niyogi, P. (2002). 
# Laplacian Eigenmaps and Spectral Techniques for Embedding and Clustering. 
# Science, 14, 585-591. MIT Press. 
# Retrieved from http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.19.9400&rep=rep1&type=pdf
# 
# The number of neighbors for the kNN graph and the heat distribution
# coeffcient is set before processing the data

from tools.load import LoadMatrix

lm=LoadMatrix()
data = lm.load_numbers('../data/fm_train_real.dat')

parameter_list = [[data,10],[data,20]]

def converter_laplacianeigenmaps_modular(data,k):
	from shogun.Features import RealFeatures
	from shogun.Converter import LaplacianEigenmaps
	
	features = RealFeatures(data)
		
	converter = LaplacianEigenmaps()
	converter.set_target_dim(1)
	converter.set_k(k)
	converter.set_tau(2.0)
	converter.apply(features)

	return features


if __name__=='__main__':
	print 'LaplacianEigenmaps'
	converter_laplacianeigenmaps_modular(*parameter_list[0])

