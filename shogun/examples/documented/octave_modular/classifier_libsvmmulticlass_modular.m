% In this example a multi-class support vector machine classifier is trained on a
% toy data set and the trained classifier is used to predict labels of test
% examples. As training algorithm the LIBSVM solver is used with SVM
% regularization parameter C=1 and a Gaussian kernel of width 2.1 and the
% precision parameter epsilon=1e-5. 
% 
% For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

init_shogun

addpath('tools');
label_train_multiclass=load_matrix('../data/label_train_multiclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% libsvmmulticlass
disp('LibSVMMultiClass')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);
width=2.1;
kernel=GaussianKernel(feats_train, feats_train, width);

C=1.2;
epsilon=1e-5;
num_threads=8;
labels=Labels(label_train_multiclass);

svm=LibSVMMultiClass(C, kernel, labels);
svm.set_epsilon(epsilon);
svm.parallel.set_num_threads(num_threads);
svm.train();

kernel.init(feats_train, feats_test);
svm.apply().get_labels();
