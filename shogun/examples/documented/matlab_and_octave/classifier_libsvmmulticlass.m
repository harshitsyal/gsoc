% In this example a multi-class support vector machine classifier is trained on a
% toy data set and the trained classifier is used to predict labels of test
% examples. As training algorithm LIBSVM is used with SVM regularization
% parameter C=1.2 and the bias in the classification rule switched off and 
% a Gaussian kernel of width 2.1 and 10MB of kernel cache and the precision 
% parameter epsilon=1e-5.
% 
% For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/ 

% Explicit examples on how to use the different classifiers

size_cache=10;
C=1.2;
use_bias=false;
epsilon=1e-5;
width=2.1;

addpath('tools');
label_train_multiclass=load_matrix('../data/label_train_multiclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% LibSVM MultiClass
disp('LibSVMMultiClass');

sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width);
sg('set_features', 'TRAIN', fm_train_real);
sg('set_labels', 'TRAIN', label_train_multiclass);
sg('new_classifier', 'LIBSVM_MULTICLASS');
sg('svm_epsilon', epsilon);
sg('svm_use_bias', use_bias);
sg('c', C);

sg('train_classifier');

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');

[b,alphas]=sg('get_classifier',0)
