# In this example toy data is being preprocessed using the Hessian Locally Linear Embedding algorithm
# as described in
# 
# Donoho, D., & Grimes, C. (2003). 
# Hessian eigenmaps: new tools for nonlinear dimensionality reduction.
# Proceedings of National Academy of Science (Vol. 100, pp. 5591-5596).

from tools.load import LoadMatrix

lm=LoadMatrix()
data = lm.load_numbers('../data/fm_train_real.dat')

parameter_list = [[data,10],[data,20]]

def converter_hessianlocallylinearembedding_modular(data,k):
	from shogun.Features import RealFeatures
	from shogun.Converter import HessianLocallyLinearEmbedding
	
	features = RealFeatures(data)
		
	converter = HessianLocallyLinearEmbedding()
	converter.set_target_dim(1)
	converter.set_k(k)
	converter.apply(features)

	return features


if __name__=='__main__':
	print 'HessianLocallyLinearEmbedding'
	converter_hessianlocallylinearembedding_modular(*parameter_list[0])

