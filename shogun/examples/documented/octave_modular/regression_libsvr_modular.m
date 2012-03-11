% In this example a support vector regression algorithm is trained on a
% real-valued toy data set. The underlying library used for the SVR training is
% LIBSVM. The SVR is trained with regularization parameter C=1 and a gaussian
% kernel with width=2.1. The labels of both the train and the test data are
% fetched via svr.classify().get_labels().
% 
% For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/ .

init_shogun

addpath('tools');
label_train=load_matrix('../data/label_train_twoclass.dat');
fm_train=load_matrix('../data/fm_train_real.dat');
fm_test=load_matrix('../data/fm_test_real.dat');

%% libsvm based support vector regression
disp('LibSVR')

feats_train=RealFeatures(fm_train);
feats_test=RealFeatures(fm_test);
width=2.1;
kernel=GaussianKernel(feats_train, feats_train, width);

C=1.2;
epsilon=1e-5;
tube_epsilon=1e-2;
num_threads=3;
labels=Labels(label_train);

svr=LibSVR(C, epsilon, kernel, labels);
svr.set_tube_epsilon(tube_epsilon);
svr.parallel.set_num_threads(num_threads);
svr.train();

kernel.init(feats_train, feats_test);
out=svr.apply().get_labels();

