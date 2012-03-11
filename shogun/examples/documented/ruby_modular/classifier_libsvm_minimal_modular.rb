# In this example a two-class support vector machine classifier is trained on a
# 2-dimensional randomly generated data set and the trained classifier is used to
# predict labels of test examples. As training algorithm the LIBSVM solver is used
# with SVM regularization parameter C=1 and a Gaussian kernel of width 2.1.
# 
# For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

require 'modshogun'
require 'load'
require 'narray'

@num = 1000
@dist = 1
@width = 2.1
C = 1

puts "generating training data"
traindata_real = gen_rand_ary @num
testdata_real = gen_rand_ary @num

puts "generating labels"
trainlab = gen_ones_vec @num
testlab = gen_ones_vec @num

puts "doing feature stuff"
feats_train = Modshogun::RealFeatures.new
feats_train.set_feature_matrix traindata_real
feats_test = Modshogun::RealFeatures.new
feats_test.set_feature_matrix testdata_real
kernel = Modshogun::GaussianKernel.new feats_train, feats_train, @width

puts "labeling stuff"
labels = Modshogun::Labels.new
labels.set_labels trainlab
svm = Modshogun::LibSVM.new C, kernel, labels
svm.train

puts "the grand finale"
kernel.init feats_train, feats_test
out = svm.apply.get_labels
testerr = mean out.sign.eql_items? testlab
puts testerr
