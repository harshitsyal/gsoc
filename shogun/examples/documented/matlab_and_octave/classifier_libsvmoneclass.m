% In this example a one-class support vector machine classifier is trained on a
% toy data set. The training algorithm finds a hyperplane in the RKHS which
% separates the training data from the origin. The one-class classifier is
% typically used to estimate the support of a high-dimesnional distribution. 
% For more details see e.g. 
%   B. Schoelkopf et al. Estimating the support of a high-dimensional
%   distribution. Neural Computation, 13, 2001, 1443-1471. 
% 
% In the example, the one-class SVM is trained by the LIBSVM solver with the
% regularization parameter C=1.2 and the Gaussian kernel of width 2.1 and the
% precision parameter epsilon=1e-5 and 10MB of the kernel cache.
% 
% For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/ .
% 
% 

% Explicit examples on how to use the different classifiers

size_cache=10;
C=1.2;
use_bias=false;
epsilon=1e-5;
width=2.1;

addpath('tools');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% LibSVM OneClass
disp('LibSVMOneClass');

sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width);
sg('set_features', 'TRAIN', fm_train_real);
sg('new_classifier', 'LIBSVM_ONECLASS');
sg('svm_epsilon', epsilon);
sg('svm_use_bias', use_bias);
sg('c', C);

sg('train_classifier');

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');

