% In this example a multi-class support vector machine is trained on a toy data
% set and the trained classifier is then used to predict labels of test
% examples. The training algorithm is based on BSVM formulation (L2-soft margin
% and the bias added to the objective function) which is solved by the Improved
% Mitchell-Demyanov-Malozemov algorithm. The training algorithm uses the Gaussian
% kernel of width 2.1 and the regularization constant C=1. The solver stops if the
% relative duality gap falls below 1e-5. 
% 
% For more details on the used SVM solver see 
%  V.Franc: Optimization Algorithms for Kernel Methods. Research report.
%  CTU-CMP-2005-22. CTU FEL Prague. 2005.
%  ftp://cmp.felk.cvut.cz/pub/cmp/articles/franc/Franc-PhD.pdf .
% 

init_shogun

addpath('tools');
label_train_multiclass=load_matrix('../data/label_train_multiclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% gmnpsvm
disp('GMNPSVM')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);
width=2.1;
kernel=GaussianKernel(feats_train, feats_train, width);

C=1.2;
epsilon=1e-5;
num_threads=1;
labels=Labels(label_train_multiclass);

svm=GMNPSVM(C, kernel, labels);
svm.set_epsilon(epsilon);
svm.parallel.set_num_threads(num_threads);
svm.train();

kernel.init(feats_train, feats_test);
svm.apply().get_labels();
