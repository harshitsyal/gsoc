% In this example a multi-class support vector machine is trained on a toy data
% set and the trained classifier is used to predict labels of test examples. 
% The training algorithm is based on BSVM formulation (L2-soft margin
% and the bias added to the objective function) which is solved by the Improved
% Mitchell-Demyanov-Malozemov algorithm. The training algorithm uses the Gaussian
% kernel of width 2.1 and the regularization constant C=1.2. The bias term of the
% classification rule is not used. The solver stops if the relative duality gap
% falls below 1e-5 and it uses 10MB for kernel cache.
% 
% For more details on the used SVM solver see 
%  V.Franc: Optimization Algorithms for Kernel Methods. Research report.
%  CTU-CMP-2005-22. CTU FEL Prague. 2005.
%  ftp://cmp.felk.cvut.cz/pub/cmp/articles/franc/Franc-PhD.pdf .
% 

% Explicit examples on how to use the different classifiers

size_cache=10;
C=1.2;
use_bias=false;
epsilon=1e-5;
width=2.1;
max_train_time=60;

addpath('tools');
label_train_multiclass=load_matrix('../data/label_train_multiclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% GMNPSVM
disp('GMNPSVM');
sg('new_classifier', 'GMNPSVM');

sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width);
sg('set_features', 'TRAIN', fm_train_real);
sg('set_labels', 'TRAIN', label_train_multiclass);
sg('svm_epsilon', epsilon);
sg('svm_use_bias', use_bias);
sg('c', C);

sg('train_classifier');

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');

