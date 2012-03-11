# This example shows usage of a k-nearest neighbor (KNN) classification rule on
# a toy data set. The number of the nearest neighbors is set to k=3 and the distances
# are measured by the Euclidean metric. Finally, the KNN rule is applied to predict
# labels of test examples. 

library(shogun)

fm_train_real <- t(as.matrix(read.table('../data/fm_train_real.dat')))
fm_test_real <- t(as.matrix(read.table('../data/fm_test_real.dat')))
label_train_multiclass <- as.real(read.table('../data/label_train_multiclass.dat')$V1)

# knn
print('KNN')

feats_train <- RealFeatures(fm_train_real)
feats_test <- RealFeatures(fm_test_real)
distance <- EuclidianDistance()

k <- as.integer(3)
num_threads <- as.integer(1)
labels <- Labels(label_train_multiclass)

knn <- KNN(k, distance, labels)
dump <- knn$parallel$set_num_threads(knn$parallel, num_threads)
dump <- knn$train(knn, feats_train)
lab <- knn$apply(knn, feats_test)
out <- lab$get_labels(lab)
