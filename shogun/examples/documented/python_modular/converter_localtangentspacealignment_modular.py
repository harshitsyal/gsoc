# In this example toy data is being processed using the Local Tangent Space
# Alignment (LTSA) algorithms as described in
# 
# Zhang, Z., & Zha, H. (2002). Principal Manifolds 
# and Nonlinear Dimension Reduction via Local Tangent Space Alignment. 
# Journal of Shanghai University English Edition, 8(4), 406-424. SIAM. 
# Retrieved from http://arxiv.org/abs/cs/0212008
# 
# Before processing the number of neighbors for computing local tangent space
# is set

from tools.load import LoadMatrix

lm=LoadMatrix()
data = lm.load_numbers('../data/fm_train_real.dat')

parameter_list = [[data,10],[data,20]]

def converter_localtangentspacealignment_modular(data,k):
	from shogun.Features import RealFeatures
	from shogun.Converter import LocalTangentSpaceAlignment
	
	features = RealFeatures(data)
		
	converter = LocalTangentSpaceAlignment()
	converter.set_target_dim(1)
	converter.set_k(k)
	converter.apply(features)

	return features


if __name__=='__main__':
	print 'LocalTangentSpaceAlignment'
	converter_localtangentspacealignment_modular(*parameter_list[0])

