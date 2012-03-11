% In this example a two-class support vector machine classifier is trained on a
% 2-dimensional randomly generated data set and the trained classifier is used to
% predict labels of test examples. As training algorithm the LIBSVM solver is used
% with SVM regularization parameter C=1 and a Gaussian kernel of width 2.1.
% 
% For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

init_shogun

num=1000;
dist=1;
width=2.1;
C=1;

traindata_real=[randn(2,num)-dist, randn(2,num)+dist];
testdata_real=[randn(2,num)-dist, randn(2,num)+dist];

trainlab=[-ones(1,num), ones(1,num)];
testlab=[-ones(1,num), ones(1,num)];

feats_train=RealFeatures(traindata_real);
feats_test=RealFeatures(testdata_real);
kernel=GaussianKernel(feats_train, feats_train, width);

labels=Labels(trainlab);
svm=LibSVM(C, kernel, labels);
svm.parallel.set_num_threads(8);
svm.train();
kernel.init(feats_train, feats_test);
out=svm.apply().get_labels();
testerr=mean(sign(out)~=testlab)
