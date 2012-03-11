% This is an example initializing the oligo string kernel which takes distances 
% between matching oligos (k-mers) into account via a gaussian. Variable 'k' defines the length 
% of the oligo and variable 'w' the width of the gaussian. The oligo string kernel is 
% implemented for the DNA-alphabet 'ACGT'. 
%  

size_cache=10;

addpath('tools');
fm_train_dna=load_matrix('../data/fm_train_dna.dat');
fm_test_dna=load_matrix('../data/fm_test_dna.dat');

% Oligo String
k=3;
w=1.2;

sg('set_kernel', 'OLIGO', 'CHAR', size_cache, k, w);

sg('set_features', 'TRAIN', fm_train_dna, 'DNA');
km=sg('get_kernel_matrix', 'TRAIN');

sg('set_features', 'TEST', fm_test_dna, 'DNA');
km=sg('get_kernel_matrix', 'TEST');

