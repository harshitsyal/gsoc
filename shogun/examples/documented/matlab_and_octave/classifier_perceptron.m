% This example shows how to use the Perceptron algorithm for training a
% two-class linear classifier, i.e.  y = sign( <x,w>+b). The Perceptron algorithm
% works by iteratively passing though the training examples and applying the
% update rule on those examples which are misclassified by the current
% classifier. The Perceptron update rule reads
% 
%   w(t+1) = w(t) + alpha * y_t * x_t
%   b(t+1) = b(t) + alpha * y_t
% 
% where (x_t,y_t) is feature vector and label (must be +1/-1) of the misclassified example
%       (w(t),b(t)) are the current parameters of the linear classifier
%       (w(t+1),b(t+1)) are the new parameters of the linear classifier
%       alpha is the learning rate. 
% 
% The Perceptron algorithm iterates until all training examples are correctly
% classified or the prescribed maximal number of iterations is reached. 
% 
% The learning rate and the maximal number of iterations can be set by
%   sg('set_perceptron_parameters', alpha, max_iter);
% 

addpath('tools');

% Perceptron
disp('Perceptron');

% create some seperable toy data
num=50;
label_train_twoclass=[-ones(1,num/2) ones(1,num/2)];
fm_train_real=[randn(5,num/2)-1, randn(5,num/2)+1];
fm_test_real=[randn(5,num)-1, randn(5,num)+1];

sg('set_features', 'TRAIN', fm_train_real);
sg('set_labels', 'TRAIN', label_train_twoclass);
sg('new_classifier', 'PERCEPTRON');
%sg('set_perceptron_parameters', 1.6, 5000);
sg('train_classifier');

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');
