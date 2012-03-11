% In this example a two-class linear classifier based on the Linear Discriminant
% Analysis (LDA) is trained on a toy data set and then the trained classifier is
% used to predict test examples. The regularization parameter, which corresponds
% to a weight of a unitary matrix added to the covariance matrix, is set to
% gamma=3.
% 
% For more details on the LDA see e.g.
%     http://en.wikipedia.org/wiki/Linear_discriminant_analysis

init_shogun

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% lda
disp('LDA')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);

gamma=3;
num_threads=1;
labels=Labels(label_train_twoclass);

lda=LDA(gamma, feats_train, labels);
lda.parallel.set_num_threads(num_threads);
lda.train();

lda.get_bias();
lda.get_w();
lda.set_features(feats_test);
lda.apply().get_labels();
