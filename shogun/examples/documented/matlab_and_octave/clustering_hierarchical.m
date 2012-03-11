% In this example an agglomerative hierarchical single linkage clustering method
% is used to cluster a given toy data set. Starting with each object being
% assigned to its own cluster clusters are iteratively merged. Here the clusters
% are merged that have the closest (minimum distance, here set via the Euclidean
% distance object) two elements.

addpath('tools');
fm_train=load_matrix('../data/fm_train_real.dat');

% KMEANS
disp('KMeans');

k=3;
iter=1000;

sg('set_features', 'TRAIN', fm_train);
sg('set_distance', 'EUCLIDIAN', 'REAL');
sg('new_clustering', 'KMEANS');

sg('train_clustering', k, iter);
[radi, centers]=sg('get_clustering');
