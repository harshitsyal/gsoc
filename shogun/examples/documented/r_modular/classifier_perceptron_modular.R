# This example shows usage of the Perceptron algorithm for training a two-class
# linear classifier, i.e.  y = sign( <x,w>+b). The Perceptron algorithm works by
# iteratively passing though the training examples and applying the update rule on
# those examples which are misclassified by the current classifier. The Perceptron
# update rule reads
# 
#   w(t+1) = w(t) + alpha * y_t * x_t
#   b(t+1) = b(t) + alpha * y_t
# 
# where (x_t,y_t) is feature vector and label (must be +1/-1) of the misclassified example
#       (w(t),b(t)) are the current parameters of the linear classifier
#       (w(t+1),b(t+1)) are the new parameters of the linear classifier
#       alpha is the learning rate; in this examples alpha=1
# 
# The Perceptron algorithm iterates until all training examples are correctly
# classified or the prescribed maximal number of iterations, in this example
# max_iter=1000, is reached.

library(shogun)

fm_train_real <- t(as.matrix(read.table('../data/fm_train_real.dat')))
fm_test_real <- t(as.matrix(read.table('../data/fm_test_real.dat')))
label_train_twoclass <- as.real(read.table('../data/label_train_twoclass.dat')$V1)

# perceptron
print('Perceptron')

feats_train <- RealFeatures(fm_train_real)
feats_test <- RealFeatures(fm_test_real)

learn_rate <- 1.
max_iter <- as.integer(1000)
num_threads <- as.integer(1)
labels <- Labels(label_train_twoclass)

perceptron <- Perceptron(feats_train, labels)
dump <- perceptron$set_learn_rate(perceptron, learn_rate)
dump <- perceptron$set_max_iter(perceptron, max_iter)
dump <- perceptron$train(perceptron)

dump <- perceptron$set_features(perceptron, feats_test)
lab <- perceptron$apply(perceptron)
out <- lab$get_labels(lab)
