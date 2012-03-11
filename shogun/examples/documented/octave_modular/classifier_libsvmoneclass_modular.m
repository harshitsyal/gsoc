% In this example a one-class support vector machine classifier is trained on a
% toy data set. The training algorithm finds a hyperplane in the RKHS which
% separates the training data from the origin. The one-class classifier is
% typically used to estimate the support of a high-dimesnional distribution. 
% For more details see e.g. 
%   B. Schoelkopf et al. Estimating the support of a high-dimensional
%   distribution. Neural Computation, 13, 2001, 1443-1471. 
% 
% In the example, the one-class SVM is trained by the LIBSVM solver with the
% regularization parameter C=1 and the Gaussian kernel of width 2.1 and the
% precision parameter epsilon=1e-5.
% 
% For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

init_shogun

addpath('tools');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% libsvm twoclass
disp('LibSVMOneClass')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);
width=2.1;
kernel=GaussianKernel(feats_train, feats_train, width);

C=1.2;
epsilon=1e-5;
num_threads=4;

svm=LibSVMOneClass(C, kernel);
svm.set_epsilon(epsilon);
svm.parallel.set_num_threads(num_threads);
svm.train();

kernel.init(feats_train, feats_test);
svm.apply().get_labels();
