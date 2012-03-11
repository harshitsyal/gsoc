% In this example the k-means clustering method is used to cluster a given toy
% data set. In k-means clustering one tries to partition n observations into k
% clusters in which each observation belongs to the cluster with the nearest mean.
% The algorithm class constructor takes the number of clusters and a distance to
% be used as input. The distance used in this example is Euclidean distance.
% After training one can fetch the result of clustering by obtaining the cluster
% centers and their radiuses.

addpath('tools');
fm_train=load_matrix('../data/fm_train_real.dat');

% Hierarchical
disp('Hierarchical');

merges=3;

sg('set_features', 'TRAIN', fm_train);
sg('set_distance', 'EUCLIDIAN', 'REAL');
sg('new_clustering', 'HIERARCHICAL');

sg('train_clustering', merges);
[merge_distance, pairs]=sg('get_clustering');
