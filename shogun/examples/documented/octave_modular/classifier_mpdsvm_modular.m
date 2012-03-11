% In this example a two-class support vector machine classifier is trained on a
% toy data set and the trained classifier is used to predict labels of test
% examples. As training algorithm the Minimal Primal Dual SVM is used with SVM
% regularization parameter C=1 and a Gaussian kernel of width 1.2 and the
% precision parameter 1e-5. 
% 
% For more details on the MPD solver see 
%  Kienzle, W. and B. Schölkopf: Training Support Vector Machines with Multiple
%  Equality Constraints. Machine Learning: ECML 2005, 182-193. (Eds.) Carbonell,
%  J. G., J. Siekmann, Springer, Berlin, Germany (11 2005)

init_shogun

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% mpdsvm
disp('MPDSVM')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);
width=2.1;
kernel=GaussianKernel(feats_train, feats_train, width);

C=1.2;
epsilon=1e-5;
num_threads=1;
labels=Labels(label_train_twoclass);

svm=MPDSVM(C, kernel, labels);
svm.set_epsilon(epsilon);
svm.parallel.set_num_threads(num_threads);
svm.train();

kernel.init(feats_train, feats_test);
svm.apply().get_labels();
