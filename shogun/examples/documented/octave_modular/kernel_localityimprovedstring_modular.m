% This example initializes the locality improved string kernel. The locality improved string 
% kernel is defined on sequences of the same length and inspects letters matching at 
% corresponding positions in both sequences. The kernel sums over all matches in windows of 
% length l and takes this sum to the power of 'inner_degree'. The sum over all these 
% terms along the sequence is taken to the power of 'outer_degree'. 

init_shogun

addpath('tools');
fm_train_dna=load_matrix('../data/fm_train_dna.dat');
fm_test_dna=load_matrix('../data/fm_test_dna.dat');

% locality_improved_string
disp('LocalityImprovedString')

feats_train=StringCharFeatures(DNA);
feats_train.set_features(fm_train_dna);
feats_test=StringCharFeatures(DNA);
feats_test.set_features(fm_test_dna);
l=5;
inner_degree=5;
outer_degree=7;

kernel=LocalityImprovedStringKernel(
	feats_train, feats_train, l, inner_degree, outer_degree);

km_train=kernel.get_kernel_matrix();
kernel.init(feats_train, feats_test);
km_test=kernel.get_kernel_matrix();

