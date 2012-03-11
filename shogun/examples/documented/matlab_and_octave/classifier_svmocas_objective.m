% In this example a two-class linear support vector machine classifier is trained
% on randomly generated data. As training algorithm the OCAS solver is used with
% the SVM regularization parameter C=10 and the bias term in the classification
% rule switched off. The solver iterates until the relative duality gap falls
% below epsilon=1e-3. The trained classifier is then used to compute outputs on
% the training examples and the primal SVM objective function is computed.
% 
% For more details on the OCAS solver see
%  V. Franc, S. Sonnenburg. Optimized Cutting Plane Algorithm for Large-Scale Risk
%  Minimization.The Journal of Machine Learning Research, vol. 10,
%  pp. 2157--2192. October 2009. 

C=10;
epsilon=1e-3;

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
sg('svm_bufsize', 1000);
sg('svm_epsilon', epsilon);
sg('new_classifier', 'SVMOCAS');
tic;
sg('train_classifier');
timeocas=toc

[b,W]=sg('get_classifier');

sg('set_features', 'TEST', traindat);
trainout=sg('classify');
trainerr=mean(trainlab~=sign(trainout))

sg('new_classifier', 'SVMOCAS');
sg('set_linear_classifier', b, W');

sg('set_features', 'TEST', traindat);
trainout2=sg('classify');
trainerr2=mean(trainlab~=sign(trainout2))

max(abs(trainout-trainout2))

b
W'
obj=sum(W.^2)+C*sum((1-trainlab.*(W'*traindat+b)).^2)
