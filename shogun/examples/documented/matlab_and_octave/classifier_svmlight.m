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

C=1.2;
use_bias=false;
epsilon=1e-5;

addpath('tools');
label_train_dna=load_matrix('../data/label_train_dna.dat');
fm_train_dna=load_matrix('../data/fm_train_dna.dat');
fm_test_dna=load_matrix('../data/fm_test_dna.dat');

% SVMLight
try
	disp('SVMLight');

	degree=20;
	sg('set_kernel', 'WEIGHTEDDEGREE', 'CHAR', size_cache, degree);
	sg('set_features', 'TRAIN', fm_train_dna, 'DNA');
	sg('set_labels', 'TRAIN', label_train_dna);
	sg('new_classifier', 'SVMLIGHT');
	sg('svm_epsilon', epsilon);
	sg('svm_use_bias', use_bias);
	sg('c', C);

	sg('train_classifier');

	sg('set_features', 'TEST', fm_test_dna, 'DNA');
	result=sg('classify');
catch
	disp('No support for SVMLight available.')
end

