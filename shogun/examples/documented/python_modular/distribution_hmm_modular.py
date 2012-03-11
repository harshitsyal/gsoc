# In this example a hidden markov model with 3 states and 6 transitions is trained
# on a string data set. After calling the constructor of the HMM class specifying
# the number of states and transitions the model is trained. Via the Baum-Welch
# algorithm the optimal transition and emission probabilities are estimated. The
# best path, i.e. the path with highest probability given the model can then be
# calculated using get_best_path_state.

from tools.load import LoadMatrix
lm=LoadMatrix()
data=lm.load_cubes('../data/fm_train_cube.dat')

parameter_list=[[data, 1, 64, 1e-5, 2, 0, False, 5], [data, 3, 6, 1e-1, 1, 0, False, 2]]

def distribution_hmm_modular(fm_cube, N, M, pseudo, order, gap, reverse, num_examples):
	from shogun.Features import StringWordFeatures, StringCharFeatures, CUBE
	from shogun.Distribution import HMM, BW_NORMAL

	charfeat=StringCharFeatures(CUBE)
	charfeat.set_features(fm_cube)
	feats=StringWordFeatures(charfeat.get_alphabet())
	feats.obtain_from_char(charfeat, order-1, order, gap, reverse)

	hmm=HMM(feats, N, M, pseudo)
	hmm.train()
	hmm.baum_welch_viterbi_train(BW_NORMAL)

	num_examples=feats.get_num_vectors()
	num_param=hmm.get_num_model_parameters()
	for i in xrange(num_examples):
		for j in xrange(num_param):
			hmm.get_log_derivative(j, i)

	best_path=0
	best_path_state=0
	for i in xrange(num_examples):
		best_path+=hmm.best_path(i)
		for j in xrange(N):
			best_path_state+=hmm.get_best_path_state(i, j)

	lik_example = hmm.get_log_likelihood()
	lik_sample = hmm.get_log_likelihood_sample()

	return lik_example, lik_sample, hmm

###########################################################################
# call functions
###########################################################################

if __name__=='__main__':
	print 'HMM'
	distribution_hmm_modular(*parameter_list[0])
