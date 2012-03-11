% This example shows usage of a k-nearest neighbor (KNN) classification rule on
% a toy data set. The number of the nearest neighbors is set to k=3 and the distances
% are measured by the Euclidean metric. Finally, the KNN rule is applied to predict
% labels of test examples. 

addpath('tools');
label_train_twoclass=load_matrix('../data/label_train_twoclass.dat');
fm_train_real=load_matrix('../data/fm_train_real.dat');
fm_test_real=load_matrix('../data/fm_test_real.dat');

% KNN
disp('KNN');

sg('set_distance', 'EUCLIDIAN', 'REAL');
sg('set_features', 'TRAIN', fm_train_real);
sg('set_labels', 'TRAIN', label_train_twoclass);
sg('new_classifier', 'KNN');

sg('train_classifier', 3);

sg('set_features', 'TEST', fm_test_real);
result=sg('classify');

