# In this example a two-class support vector machine classifier is trained on a
# toy data set and the trained classifier is then used to predict labels of test
# examples. As training algorithm Gradient Projection Decomposition Technique
# (GPDT) is used with SVM regularization parameter C=1 and a Gaussian
# kernel of width 2.1. The solver returns an epsilon-precise (epsilon=1e-5) solution. 
# 
# For more details on GPDT solver see http://dm.unife.it/gpdt . 
# 

library(shogun)

fm_train_real <- t(as.matrix(read.table('../data/fm_train_real.dat')))
fm_test_real <- t(as.matrix(read.table('../data/fm_test_real.dat')))
label_train_twoclass <- as.real(read.table('../data/label_train_twoclass.dat')$V1)

# gpbtsvm
print('GPBTSVM')

feats_train <- RealFeatures(fm_train_real)
feats_test <- RealFeatures(fm_test_real)
width <- 2.1
kernel <- GaussianKernel(feats_train, feats_train, width)

C <- 0.017
epsilon <- 1e-5
num_threads <- as.integer(2)
labels <- Labels(label_train_twoclass)

svm <- GPBTSVM(C, kernel, labels)
dump <- svm$set_epsilon(svm, epsilon)
dump <- svm$parallel$set_num_threads(svm$parallel, num_threads)
dump <- svm$train(svm)

dump <- kernel$init(kernel, feats_train, feats_test)
lab <- svm$apply(svm)
out <- lab$get_labels(lab)
