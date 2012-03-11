% In this example the k-means clustering method is used to cluster a given toy
% data set. In k-means clustering one tries to partition n observations into k
% clusters in which each observation belongs to the cluster with the nearest mean.
% The algorithm class constructor takes the number of clusters and a distance to
% be used as input. The distance used in this example is Euclidean distance.
% After training one can fetch the result of clustering by obtaining the cluster
% centers and their radiuses.

init_shogun

% Explicit examples on how to use clustering

addpath('tools');
fm_train=load_matrix('../data/fm_train_real.dat');

% KMeans
disp('KMeans')

k=4;
feats_train=RealFeatures(fm_train);
distance=EuclidianDistance(feats_train, feats_train);

kmeans=KMeans(k, distance);
kmeans.train();

c=kmeans.get_cluster_centers();
r=kmeans.get_radiuses();
