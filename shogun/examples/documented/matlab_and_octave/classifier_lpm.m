% In this example a two-class linear programming machine (LPM) classifier is
% trained on a randomly generated examples. The linear programming problem to
% which the learning problem is transformed is solved by the CPLEX solver which
% must be installed. The LPM regularization parameter is set to C=100 and the bias
% term in the classification rule is switched on. The example also shows how to
% compute classifier outputs on the training examples and the primal SVM objective
% function.
% 
% For more details on the LPM see
%     Weida Zhou, Li Zhang, Licheng Jiao. Linear programming support vector
%     machines. Pattern Recognition, Volume 35, Issue 12, December 2002, 
%     pages 2927-2936. 
% 

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
sg('svm_use_bias', true);

try
	sg('new_classifier', 'LPM');
catch
	return
end_try_catch

tic;
sg('train_classifier');
timelpm=toc

[b,W]=sg('get_classifier');

sg('set_features', 'TEST', traindat);
trainout=sg('classify');
trainerr=mean(trainlab~=sign(trainout))

b
W'
obj=sum(abs(W))+C*sum(max(0,1-trainlab.*(W'*traindat+b)))
