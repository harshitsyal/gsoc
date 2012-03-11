% In this example a linear two-class classifier is trained based on the Linear 
% Discriminant Analysis (LDA) from a toy 2-dimensional examples. The trained 
% LDA classifier is used to predict test examples. Note that the LDA classifier
% is optimal under the assumption that both classes are Gaussian distributed with equal
% co-variance. For more details on the LDA see e.g.
%              http://en.wikipedia.org/wiki/Linear_discriminant_analysis
% 

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% LDA
disp('LDA');

sg('set_features', 'TRAIN', fm_train_real);
sg('set_labels', 'TRAIN', label_train_twoclass);
sg('new_classifier', 'LDA');

sg('train_classifier');

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');
