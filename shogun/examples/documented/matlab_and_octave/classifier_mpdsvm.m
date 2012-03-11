% In this example a two-class support vector machine classifier is trained on a
% toy data set and the trained classifier is used to predict labels of test
% examples. As training algorithm the Minimal Primal Dual SVM is used with SVM
% regularization parameter C=1.2 and a Gaussian kernel of width 2.1 and 10MB of
% kernel cache and the precision parameter epsilon=1e-5.
% 
% For more details on the MPD solver see 
%  Kienzle, W. and B. Schölkopf: Training Support Vector Machines with Multiple
%  Equality Constraints. Machine Learning: ECML 2005, 182-193. (Eds.) Carbonell,
%  J. G., J. Siekmann, Springer, Berlin, Germany (11 2005)

size_cache=10;
C=1.2;
use_bias=false;
epsilon=1e-5;
width=2.1;

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% MPDSVM
disp('MPDSVM');

sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width);
sg('set_features', 'TRAIN', fm_train_real);
sg('set_labels', 'TRAIN', label_train_twoclass);
sg('new_classifier', 'MPDSVM');
sg('svm_epsilon', epsilon);
sg('svm_use_bias', use_bias);
sg('c', C);

sg('train_classifier');

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');

