% In this example an agglomerative hierarchical single linkage clustering method
% is used to cluster a given toy data set. Starting with each object being
% assigned to its own cluster clusters are iteratively merged. Here the clusters
% are merged that have the closest (minimum distance, here set via the Euclidean
% distance object) two elements.

init_shogun

% Explicit examples on how to use clustering

addpath('tools');
fm_train=load_matrix('../data/fm_train_real.dat');

% Hierarchical
disp('Hierarchical')

merges=4;
feats_train=RealFeatures(fm_train);
feats_test=RealFeatures(fm_train);
distance=EuclidianDistance(feats_train, feats_train);

hierarchical=Hierarchical(merges, distance);
hierarchical.train();

distance.init(feats_train, feats_test);
mdist=hierarchical.get_merge_distances();
pairs=hierarchical.get_cluster_pairs();
