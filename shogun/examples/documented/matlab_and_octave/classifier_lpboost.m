% In this example a two-class linear programming machine (LPM) classifier is
% trained on a randomly generated examples. As solver the LPBOOST algorithm is
% used with the regularization parameter C=100 and the bias term in the
% classification rule switched off. Note that LPBOOST calls the CPLEX solver in
% its inner loop hence the CPLEX must be installed. The trained classifier is used
% to compute outputs on the training examples and the primal SVM objective
% function is computed.
% 
% For more details on the LPBOOST see
%     http://en.wikipedia.org/wiki/LPBoost

C=100;
epsilon=1e-3;

rand('state',17);
num=1000;
dim=20;
dist=1;

traindat=sparse([rand(dim,num/2)-4*dist, rand(dim,num/2)-dist]);
trainlab=[-ones(1,num/2), ones(1,num/2) ];

sg('set_features', 'TRAIN', traindat);
sg('set_labels', 'TRAIN', trainlab);
sg('c', C);
sg('svm_use_bias', false);
sg('svm_epsilon', epsilon);

try
	sg('new_classifier', 'LPBOOST');
catch
	return
end_try_catch

tic;
sg('train_classifier');
timelpboost=toc

[b,W]=sg('get_classifier');

sg('set_features', 'TEST', traindat);
trainout=sg('classify');
trainerr=mean(trainlab~=sign(trainout))

b
W'
obj=sum(abs(W))+C*sum(max(0,1-trainlab.*(W'*traindat+b)))
