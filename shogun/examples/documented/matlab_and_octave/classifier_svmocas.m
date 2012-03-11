% In this example a two-class linear support vector machine classifier is trained
% on a toy data set and the trained classifier is used to predict labels of
% test examples. As training algorithm the OCAS solver is used with the SVM
% regularization parameter C=1.2 and the bias term in the classification rule 
% switched off. The solver iterates until the relative duality gap falls below
% epsilon=1e-5 or the maximal training time (max_train_time=60 seconds) is
% exceeded.
% 
% For more details on the OCAS solver see
%  V. Franc, S. Sonnenburg. Optimized Cutting Plane Algorithm for Large-Scale Risk
%  Minimization.The Journal of Machine Learning Research, vol. 10,
%  pp. 2157--2192. October 2009. 
% 

C=1.2;
use_bias=false;
epsilon=1e-5;
max_train_time=60;

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% SVMOcas
disp('SVMOcas');
sg('new_classifier', 'SVMOCAS');

sg('set_features', 'TRAIN', sparse(fm_train_real));
sg('set_labels', 'TRAIN', label_train_twoclass);
sg('svm_epsilon', epsilon);
sg('svm_use_bias', use_bias);
sg('svm_max_train_time', max_train_time);
sg('c', C);

sg('train_classifier');

sg('set_features', 'TEST', sparse(fm_test_real));
result=sg('classify');

