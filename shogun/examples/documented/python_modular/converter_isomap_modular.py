# In this example toy data is being processed using the Isomap algorithm
# as described in
# 
# Silva, V. D., & Tenenbaum, J. B. (2003). 
# Global versus local methods in nonlinear dimensionality reduction. 
# Advances in Neural Information Processing Systems 15, 15(Figure 2), 721-728. MIT Press. 
# Retrieved from http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.9.3407&rep=rep1&type=pdf
# 
# Before applying to the data the landmark approximation is enabled with 
# specified number of landmarks. The landmark approximation is described in
# 
# Sparse multidimensional scaling using landmark points
# V De Silva, J B Tenenbaum (2004) Technology, p. 1-4
# 
# After enabling the landmark approximation k parameter -- the number 
# of neighbors in the k nearest neighbor graph -- is initialized.

from tools.load import LoadMatrix

lm=LoadMatrix()
data = lm.load_numbers('../data/fm_train_real.dat')

parameter_list = [[data]]

def converter_isomap_modular(data):
	from shogun.Features import RealFeatures
	from shogun.Converter import Isomap
	
	features = RealFeatures(data)
		
	converter = Isomap()
	converter.set_landmark(True)
	converter.set_landmark_number(5)
	converter.set_k(6)
	converter.set_target_dim(1)
	converter.apply(features)

	return features


if __name__=='__main__':
	print 'Isomap'
	converter_isomap_modular(*parameter_list[0])

