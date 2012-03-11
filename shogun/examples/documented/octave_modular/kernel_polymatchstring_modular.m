% This is an example for the initialization of the PolyMatchString kernel on string data. 
% The PolyMatchString kernel sums over the matches of two stings of the same length and 
% takes the sum to the power of 'degree'. The strings consist of the characters 'ACGT' corresponding 
% to the DNA-alphabet. Each column of the matrices of type char corresponds to 
% one training/test example.

init_shogun

addpath('tools');
fm_train_dna=load_matrix('../data/fm_train_dna.dat');
fm_test_dna=load_matrix('../data/fm_test_dna.dat');

% poly_match_string
disp('PolyMatchString')

feats_train=StringCharFeatures(DNA);
feats_train.set_features(fm_train_dna);
feats_test=StringCharFeatures(DNA);
feats_test.set_features(fm_test_dna);
degree=3;
inhomogene=false;

kernel=PolyMatchStringKernel(feats_train, feats_train, degree, inhomogene);

km_train=kernel.get_kernel_matrix();
kernel.init(feats_train, feats_test);
km_test=kernel.get_kernel_matrix();

