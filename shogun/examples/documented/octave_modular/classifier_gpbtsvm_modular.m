% In this example a two-class support vector machine classifier is trained on a
% toy data set and the trained classifier is then used to predict labels of test
% examples. As training algorithm Gradient Projection Decomposition Technique
% (GPDT) is used with SVM regularization parameter C=1 and a Gaussian
% kernel of width 2.1. The solver returns an epsilon-precise (epsilon=1e-5) solution. 
% 
% For more details on GPDT solver see http://dm.unife.it/gpdt . 
% 

init_shogun

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% gpbtsvm
disp('GPBTSVM')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);
width=2.1;
kernel=GaussianKernel(feats_train, feats_train, width);

C=1.2;
epsilon=1e-5;
num_threads=2;
labels=Labels(label_train_twoclass);

svm=GPBTSVM(C, kernel, labels);
svm.set_epsilon(epsilon);
svm.parallel.set_num_threads(num_threads);
svm.train();

kernel.init(feats_train, feats_test);
svm.apply().get_labels();
