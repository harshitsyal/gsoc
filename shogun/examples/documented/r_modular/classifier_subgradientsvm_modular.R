# In this example a two-class linear support vector machine classifier is trained
# on a toy data set and the trained classifier is used to predict labels of test
# examples. As training algorithm the steepest descent subgradient algorithm is
# used. The SVM regularization parameter is set to C=0.9 and the bias in the
# classification rule is switched off. The solver iterates until it finds an
# epsilon-precise solution (epsilon=1e-3) or the maximal training time
# max_train_time=1 (seconds) is exceeded. The unbiased linear rule is trained.
# 
# Note that this solver often does not converges because the steepest descent
# subgradient algorithm is oversensitive to rounding errors. Note also that this
# is an unpublished work which was predecessor of the OCAS solver (see
# classifier_svmocas).

library(shogun)

fm_train_real <- t(as.matrix(read.table('../data/fm_train_real.dat')))
fm_test_real <- t(as.matrix(read.table('../data/fm_test_real.dat')))
label_train_twoclass <- as.real(read.table('../data/label_train_twoclass.dat')$V1)

# subgradient based svm
print('SubGradientSVM')

realfeat <- RealFeatures(fm_train_real)
feats_train <- SparseRealFeatures()
dump <- feats_train$obtain_from_simple(feats_train, realfeat)
realfeat <- RealFeatures(fm_test_real)
feats_test <- SparseRealFeatures()
dump <- feats_test$obtain_from_simple(feats_test, realfeat)

C <- 1.42
epsilon <- 1e-3
num_threads <- as.integer(1)
max_train_time <- 1.
labels <- Labels(label_train_twoclass)

svm <- SubGradientSVM(C, feats_train, labels)
dump <- svm$set_epsilon(svm, epsilon)
dump <- svm$parallel$set_num_threads(svm$parallel, num_threads)
dump <- svm$set_bias_enabled(svm, FALSE)
dump <- svm$set_max_train_time(svm, max_train_time)
dump <- svm$train(svm)

dump <- svm$set_features(svm, feats_test)
lab <- svm$apply(svm)
out <- lab$get_labels(lab)
