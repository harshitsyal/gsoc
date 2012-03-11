% In this example a support vector regression algorithm is trained on a
% real-valued toy data set. The underlying library used for the SVR training is
% SVM^light. The SVR is trained with regularization parameter C=1 and a gaussian
% kernel with width=2.1.
% 
% For more details on the SVM^light see
%  T. Joachims. Making large-scale SVM learning practical. In Advances in Kernel
%  Methods -- Support Vector Learning, pages 169-184. MIT Press, Cambridge, MA USA, 1999.

size_cache=10;
width=2.1;
C=1.2;
tube_epsilon=1e-2;

addpath('tools');
label_train=load_matrix('../data/label_train_twoclass.dat');
fm_train=load_matrix('../data/fm_train_real.dat');
fm_test=load_matrix('../data/fm_test_real.dat');

% SVR Light
try
	disp('SVRLight');

	sg('set_kernel', 'GAUSSIAN', 'REAL', size_cache, width);
	sg('set_features', 'TRAIN', fm_train);
	sg('set_labels', 'TRAIN', label_train);
	sg('new_regression', 'SVRLIGHT');
	sg('svr_tube_epsilon', tube_epsilon);
	sg('c', C);

	sg('train_regression');

	sg('set_features', 'TEST', fm_test);
	result=sg('classify');
catch
	disp('No support for SVRLight available.')
end

