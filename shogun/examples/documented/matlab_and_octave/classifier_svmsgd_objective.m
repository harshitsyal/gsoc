% In this example a two-class linear support vector machine classifier is trained
% on randomly generated data. As training algorithm the Stochastic Gradient
% Descent (SGD) solver is used with the SVM regularization parameter C=10 and the
% bias term in the classification rule switched off. The example also shows how to
% compute classifier outputs on the test data and the value of the primal SVM
% objective function.
% 
% For more details on the SGD solver see
%  L. Bottou, O. Bousquet. The tradeoff of large scale learning. In NIPS 20. MIT
%  Press. 2008.

C=10;

rand('state',17);
num=16;
dim=10;
dist=0.001;
traindat=[rand(dim,num/2)-dist, rand(dim,num/2)+dist];
scale=(dim*mean(traindat(:)));
traindat=sparse(traindat/scale);
trainlab=[-ones(1,num/2), +ones(1,num/2) ];

sg('set_features', 'TRAIN', traindat);
sg('set_labels', 'TRAIN', trainlab);
sg('c', C);
sg('svm_use_bias', false);
sg('new_classifier', 'SVMSGD');
tic;
sg('train_classifier');
timesgd=toc

[b,W]=sg('get_classifier');

sg('set_features', 'TEST', traindat);
trainout=sg('classify');
trainerr=mean(trainlab~=sign(trainout))

b
W'
obj=sum(W.^2)+C*sum((1-trainlab.*(W'*traindat+b)).^2)
