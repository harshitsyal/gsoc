% In this example a two-class linear support vector machine classifier is trained
% on a toy data set and the trained classifier is used to predict labels of
% test examples. As training algorithm the steepest descent subgradient algorithm
% is used with the SVM regularization parameter C=1.2 and the bias in the classification
% rule switched off. The solver iterates until it finds epsilon-precise solution 
% (epsilon=1e-5) or the maximal training time (max_train_time=60 seconds) is exceeded. 
% 
% Note that this solver often has a tendency not to converge because the steepest descent
% subgradient algorithm is oversensitive to rounding errors. Note also that this
% is an unpublished work which was predecessor of the OCAS solver (see
% classifier_svmocas).

C=1.2;
use_bias=false;
epsilon=1e-5;
width=2.1;
max_train_time=60;

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% SubgradientSVM - often does not converge
disp('SubGradientSVM');

C=0.9;
sg('set_features', 'TRAIN', sparse(fm_train_real));
sg('set_labels', 'TRAIN', label_train_twoclass);
sg('new_classifier', 'SUBGRADIENTSVM');
sg('svm_epsilon', epsilon);
sg('svm_use_bias', use_bias);
sg('svm_max_train_time', max_train_time);
sg('c', C);
% sometimes does not terminate
%sg('train_classifier');

%sg('set_features', 'TEST', sparse(fm_test_real));
%result=sg('classify');
