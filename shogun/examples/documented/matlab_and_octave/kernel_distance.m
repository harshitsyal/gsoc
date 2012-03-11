% With the distance kernel one can use any of the following distance metrics: 
% MINKOWSKI MANHATTAN HAMMING CANBERRA CHEBYSHEW GEODESIC JENSEN CHISQUARE TANIMOTO COSINE BRAYCURTIS EUCLIDIAN

size_cache=10;

addpath('tools');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% Distance
disp('Distance');

width=1.7;

sg('set_distance', 'EUCLIDIAN', 'REAL');
sg('set_kernel', 'DISTANCE', size_cache, width);

sg('set_features', 'TRAIN', fm_train_real);
km=sg('get_kernel_matrix', 'TRAIN');

sg('set_features', 'TEST', fm_test_real);
km=sg('get_kernel_matrix', 'TEST');
