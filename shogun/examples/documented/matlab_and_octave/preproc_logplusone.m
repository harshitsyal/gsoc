% In this example a kernel matrix is computed for a given real-valued data set.
% The kernel used is the Chi2 kernel which operates on real-valued vectors. It
% computes the chi-squared distance between sets of histograms. It is a very
% useful distance in image recognition (used to detect objects). The preprocessor
% LogPlusOne adds one to a dense real-valued vector and takes the logarithm of
% each component of it. It is most useful in situations where the inputs are
% counts: When one compares differences of small counts any difference may matter
% a lot, while small differences in large counts don't. This is what this log
% transformation controls for.

size_cache=10;

addpath('tools');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

width=1.4;

% LogPlusOne
disp('LogPlusOne');

sg('add_preproc', 'LOGPLUSONE');
sg('set_kernel', 'CHI2', 'REAL', size_cache, width);

sg('set_features', 'TRAIN', fm_train_real);
sg('attach_preproc', 'TRAIN');
km=sg('get_kernel_matrix', 'TRAIN');

sg('set_features', 'TEST', fm_test_real);
sg('attach_preproc', 'TEST');
km=sg('get_kernel_matrix', 'TEST');

