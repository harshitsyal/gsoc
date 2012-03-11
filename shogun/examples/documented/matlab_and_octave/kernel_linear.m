% This is an example for the initialization of a linear kernel on real valued 
% data using scaling factor 1.2. 

size_cache=10;

addpath('tools');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% Linear
disp('Linear');

scale=1.2;

sg('set_kernel', 'LINEAR', 'REAL', size_cache, scale);

sg('set_features', 'TRAIN', fm_train_real);
km=sg('get_kernel_matrix', 'TRAIN');

sg('set_features', 'TEST', fm_test_real);
km=sg('get_kernel_matrix', 'TEST');
