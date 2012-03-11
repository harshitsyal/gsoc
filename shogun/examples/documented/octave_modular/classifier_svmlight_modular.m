% In this example a two-class support vector machine classifier is trained on a
% DNA splice-site detection data set and the trained classifier is used to predict
% labels on test set. As training algorithm SVM^light is used with SVM
% regularization parameter C=1.2 and the Weighted Degree kernel of degree 20 and
% the precision parameter epsilon=1e-5.
% 
% For more details on the SVM^light see
%  T. Joachims. Making large-scale SVM learning practical. In Advances in Kernel
%  Methods -- Support Vector Learning, pages 169-184. MIT Press, Cambridge, MA USA, 1999.
% 
% For more details on the Weighted Degree kernel see
%  G. Raetsch, S.Sonnenburg, and B. Schoelkopf. RASE: recognition of alternatively
%  spliced exons in C. elegans. Bioinformatics, 21:369-377, June 2005. 

init_shogun

% Explicit examples on how to use the different classifiers

addpath('tools');
label_train_dna=load_matrix('../data/label_train_dna.dat');
fm_train_dna=load_matrix('../data/fm_train_dna.dat');
fm_test_dna=load_matrix('../data/fm_test_dna.dat');

% svm light
try
	disp('SVMLight')

	feats_train=StringCharFeatures(DNA);
	feats_train.set_features(fm_train_dna);
	feats_test=StringCharFeatures(DNA);
	feats_test.set_features(fm_test_dna);
	degree=20;

	kernel=WeightedDegreeStringKernel(feats_train, feats_train, degree);

	C=1.2;
	epsilon=1e-5;
	num_threads=3;
	labels=Labels(label_train_dna);

	svm=SVMLight(C, kernel, labels);
	svm.set_epsilon(epsilon);
	svm.parallel.set_num_threads(num_threads);
	svm.train();

	kernel.init(feats_train, feats_test);
	svm.apply().get_labels();
catch
	disp('No support for SVMLight available.')
end
