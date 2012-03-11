# In this example a linear two-class classifier is trained based on the Linear 
# Discriminant Analysis (LDA) from a toy 2-dimensional examples. The trained 
# LDA classifier is used to predict test examples. Note that the LDA classifier
# is optimal under the assumption that both classes are Gaussian distributed with equal
# co-variance. For more details on the LDA see e.g.
#              http://en.wikipedia.org/wiki/Linear_discriminant_analysis
# 

from tools.load import LoadMatrix
from sg import sg
lm=LoadMatrix()

traindat=lm.load_numbers('../data/fm_train_real.dat')
testdat=lm.load_numbers('../data/fm_test_real.dat')
train_label=lm.load_labels('../data/label_train_twoclass.dat')
parameter_list=[[traindat,testdat, train_label],
		[traindat,testdat,train_label]]

def classifier_lda (fm_train_real=traindat,fm_test_real=testdat,
			label_train_twoclass=train_label):

	sg('set_features', 'TRAIN', fm_train_real)
	sg('set_labels', 'TRAIN', label_train_twoclass)
	sg('new_classifier', 'LDA')
	sg('train_classifier')

	sg('set_features', 'TEST', fm_test_real)
	result=sg('classify')
	return result

if __name__=='__main__': 
	print 'LDA'
	classifier_lda(*parameter_list[0])
