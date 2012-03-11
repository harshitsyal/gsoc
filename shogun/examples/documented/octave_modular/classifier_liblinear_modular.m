% In this example a two-class linear support vector machine classifier is trained
% on a toy data set and the trained classifier is then used to predict labels of
% test examples. As training algorithm the LIBLINEAR solver is used with the SVM
% regularization parameter C=0.9 and the bias in the classification rule switched
% on and the precision parameters epsilon=1e-5.
% 
% For more details on LIBLINEAR see
%     http://www.csie.ntu.edu.tw/~cjlin/liblinear/

init_shogun

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% liblinear
disp('LibLinear')

realfeat=RealFeatures(fm_train_real);
feats_train=SparseRealFeatures();
feats_train.obtain_from_simple(realfeat);
realfeat=RealFeatures(fm_test_real);
feats_test=SparseRealFeatures();
feats_test.obtain_from_simple(realfeat);

C=1.2;
epsilon=1e-5;
num_threads=1;
labels=Labels(label_train_twoclass);

svm=LibLinear(C, feats_train, labels);
svm.set_epsilon(epsilon);
svm.parallel.set_num_threads(num_threads);
svm.set_bias_enabled(true);
svm.train();

svm.set_features(feats_test);
svm.apply().get_labels();

