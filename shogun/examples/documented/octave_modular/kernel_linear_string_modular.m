% This is an example for the initialization of a linear kernel on string data. The 
% strings are all of the same length and consist of the characters 'ACGT' corresponding 
% to the DNA-alphabet. Each column of the matrices of type char corresponds to 
% one training/test example.

init_shogun

addpath('tools');
fm_train_dna=load_matrix('../data/fm_train_dna.dat');
fm_test_dna=load_matrix('../data/fm_test_dna.dat');

% linear_string
disp('LinearString')

feats_train=StringCharFeatures(DNA);
feats_train.set_features(fm_train_dna);
feats_test=StringCharFeatures(DNA);
feats_test.set_features(fm_test_dna);

kernel=LinearStringKernel(feats_train, feats_train);

km_train=kernel.get_kernel_matrix();
kernel.init(feats_train, feats_test);
km_test=kernel.get_kernel_matrix();

