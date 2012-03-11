% In this example a two-class linear support vector machine classifier is trained
% on a randomly generated data. As training algorithm the LIBLINEAR solver is used
% with the SVM regularization parameter C=0.1 and the bias term in the
% classification rule switched off. The solver iterates until it reaches the
% epsilon-precise (epsilon=1e-3) solution. The example also shows how to compute 
% classifier outputs on the training examples and the value of the primal SVM 
% objective function.
% 
% For more details on LIBLINEAR see
%     http://www.csie.ntu.edu.tw/~cjlin/liblinear/

C=0.1;
epsilon=1e-3;

rand('state',17);
num=1000;
dim=20;
dist=1;

traindat=sparse([randn(dim,num/2)-dist, randn(dim,num/2)+dist]);
trainlab=[-ones(1,num/2), ones(1,num/2) ];

sg('set_features', 'TRAIN', traindat);
sg('set_labels', 'TRAIN', trainlab);
sg('c', C);
sg('svm_use_bias', false);
sg('svm_epsilon', epsilon);
% type can be one of LIBLINEAR_L2R_LR, LIBLINEAR_L2R_L2LOSS_SVC_DUAL,
%            LIBLINEAR_L2R_L2LOSS_SVC, LIBLINEAR_L2R_L1LOSS_SVC_DUAL
sg('new_classifier', 'LIBLINEAR_L2R_L1LOSS_SVC_DUAL');
tic;
sg('train_classifier');
timeliblinear=toc

[b,W]=sg('get_classifier');

sg('set_features', 'TEST', traindat);
trainout=sg('classify');
trainerr=mean(trainlab~=sign(trainout))

b
W'
obj=sum(W.^2)+C*sum((1-trainlab.*(W'*traindat+b)).^2)
