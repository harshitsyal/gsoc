% In this example a kernel matrix is computed for a given real-valued data set.
% The kernel used is the Chi2 kernel which operates on real-valued vectors. It
% computes the chi-squared distance between sets of histograms. It is a very
% useful distance in image recognition (used to detect objects). The preprocessor
% NormOne, normalizes vectors to have norm 1.

init_shogun

addpath('tools');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

%NormOne
disp('NormOne')

feats_train=RealFeatures(fm_train_real);
feats_test=RealFeatures(fm_test_real);

preproc=NormOne();
preproc.init(feats_train);
feats_train.add_preprocessor(preproc);
feats_train.apply_preprocessor();
feats_test.add_preprocessor(preproc);
feats_test.apply_preprocessor();

width=1.4;
size_cache=10;

kernel=Chi2Kernel(feats_train, feats_train, width, size_cache);

km_train=kernel.get_kernel_matrix();
kernel.init(feats_train, feats_test);
km_test=kernel.get_kernel_matrix();
