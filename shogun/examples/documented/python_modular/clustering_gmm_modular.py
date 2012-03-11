# In this example the GMM clustering method is used to cluster a generated
# data set. In GMM clustering one tries to partition n observations into k
# clusters in which each observation belongs to the cluster defined by a Gaussian
# distribution, whose probability of generating the observation is highest.
# The algorithm class constructor takes the number of clusters and a type of
# covariance as input. The covariance used in this example is the full covariance.
# The training method used in this example is Expectation-Maximization. It takes
# minimum covariance, maximum iterations and minimum log-likelihood change as
# input. After training one can cluster observations by selecting the most
# likely cluster to have generated the observation. 
# 

##!/usr/bin/env python
#"""
#Explicit examples on how to use clustering
#"""
from numpy import array, append
from shogun.Distribution import GMM
from shogun.Library import Math_init_random

Math_init_random(5)

real_gmm=GMM(2,0)

real_gmm.set_nth_mean(array([1.0, 1.0]), 0)
real_gmm.set_nth_mean(array([-1.0, -1.0]), 1)

real_gmm.set_nth_cov(array([[1.0, 0.2],[0.2, 0.1]]), 0)
real_gmm.set_nth_cov(array([[0.3, 0.1],[0.1, 1.0]]), 1)

real_gmm.set_coef(array([0.3, 0.7]))

generated=array([real_gmm.sample()])
for i in range(199):
    generated=append(generated, array([real_gmm.sample()]), axis=0)

generated=generated.transpose()

parameter_list = [[generated,2,1e-9,1000,1e-9,0]]

def clustering_gmm_modular (fm_train=generated,n=2,min_cov=1e-9,max_iter=1000,min_change=1e-9,cov_type=0):

	from shogun.Distribution import GMM
	from shogun.Features import RealFeatures
	from shogun.Library import Math_init_random

	Math_init_random(5)

	feat_train=RealFeatures(generated)

	est_gmm=GMM(n, cov_type)
	est_gmm.train(feat_train)
	est_gmm.train_em(min_cov, max_iter, min_change)

	return est_gmm

if __name__=='__main__':
	print 'GMM'
	clustering_gmm_modular(*parameter_list[0])

