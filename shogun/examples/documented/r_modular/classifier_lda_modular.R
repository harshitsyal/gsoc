# In this example a two-class linear classifier based on the Linear Discriminant
# Analysis (LDA) is trained on a toy data set and then the trained classifier is
# used to predict test examples. The regularization parameter, which corresponds
# to a weight of a unitary matrix added to the covariance matrix, is set to
# gamma=3.
# 
# For more details on the LDA see e.g.
#     http://en.wikipedia.org/wiki/Linear_discriminant_analysis

library(shogun)

fm_train_real <- t(as.matrix(read.table('../data/fm_train_real.dat')))
fm_test_real <- t(as.matrix(read.table('../data/fm_test_real.dat')))
label_train_twoclass <- as.real(read.table('../data/label_train_twoclass.dat')$V1)

# lda
print('LDA')

feats_train <- RealFeatures(fm_train_real)
feats_test <- RealFeatures(fm_test_real)

gamma <- 3
labels <- Labels(label_train_twoclass)

lda <- LDA(gamma, feats_train, labels)
dump <- lda$train(lda)

dump <- lda$get_bias(lda)
dump <- lda$get_w(lda)
dump <- lda$set_features(lda, feats_test)
lab <- lda$apply(lda)
out <- lab$get_labels(lab)
