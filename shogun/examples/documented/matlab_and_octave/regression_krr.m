% In this example a kernelized version of ridge regression (KRR) is trained on a
% real-valued data set. The KRR is trained with regularization parameter tau=1e-6
% and a gaussian kernel with width=0.8.

size_cache=10;
width=2.1;
C=1.2;
tube_epsilon=1e-2;

addpath('tools');
label_train=load_matrix('../data/label_train_twoclass.dat');
fm_train=load_matrix('../data/fm_train_real.dat');
fm_test=load_matrix('../data/fm_test_real.dat');

% KRR
disp('KRR');

tau=1.2;

sg('set_features', 'TRAIN', fm_train);
sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width);
sg('set_labels', 'TRAIN', label_train);
sg('new_regression', 'KRR');
sg('krr_tau', tau);
sg('c', C);

sg('train_regression');

sg('set_features', 'TEST', fm_test);
result=sg('classify');
