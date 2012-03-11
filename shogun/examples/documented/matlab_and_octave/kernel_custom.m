% A user defined custom kernel is assigned in this example, for which only the upper triangle may be given (DIAG) or 
% the FULL matrix (FULL), or the full matrix which is then internally stored as a upper 
% triangle (FULL2DIAG). Labels for the examples are given, a svm is trained and the svm is used to classify the examples. 
% 

truth = sign(2*rand(1,60) - 1);
km=rand(length(truth));
km=km+km';

sg('set_kernel', 'CUSTOM', km, 'FULL');
sg('set_labels', 'TRAIN', truth);
sg('new_classifier', 'LIBSVM');
sg('train_classifier');
out_all = sg('classify');
out = sg('classify_example',0);
