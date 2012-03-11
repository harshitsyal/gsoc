-  In this example a two-class support vector machine classifier is trained on a
-  2-dimensional randomly generated data set and the trained classifier is used to
-  predict labels of test examples. As training algorithm the LIBSVM solver is used
-  with SVM regularization parameter C=1 and a Gaussian kernel of width 2.1.
-  
-  For more details on LIBSVM solver see http://www.csie.ntu.edu.tw/~cjlin/libsvm/

require 'modshogun'
require 'load'

function concatenate(...)
	local result = ...
	for _,t in ipairs{select(2, ...)} do
		for row,rowdata in ipairs(t) do
			for col,coldata in ipairs(rowdata) do
				table.insert(result[row], coldata)
			end		
		end
	end
	return result
end

function rand_matrix(rows, cols, dist)
  local matrix = {}
	for i = 1, rows do
		matrix[i] = {}
		for j = 1, cols do
			matrix[i][j] = math.random() + dist
		end	
	end
	return matrix
end

function ones(num)
	r={}
	for i=1,num do
		r[i]=1
	end
	return r
end


num=1000
dist=1
width=2.1
C=1

traindata_real=concatenate(rand_matrix(2,num, -dist),rand_matrix(2,num,dist))
testdata_real=concatenate(rand_matrix(2,num,-dist), rand_matrix(2,num, dist))

trainlab={}
for i = 1, num do
	trainlab[i] = -1
	trainlab[i + num] = 1
end

testlab={}
for i = 1, num do
	testlab[i] = -1
	testlab[i + num] = 1
end

feats_train=modshogun.RealFeatures(traindata_real)
feats_test=modshogun.RealFeatures(testdata_real)
kernel=modshogun.GaussianKernel(feats_train, feats_train, width)

labels=modshogun.Labels(trainlab)
svm=modshogun.LibSVM(C, kernel, labels)
svm:train()

kernel:init(feats_train, feats_test)
out=svm:apply():get_labels()

err_num = 0
for i = 1, num do 
	if out[i] > 0 then
		err_num = err_num+1
	end
	if out[i+num] < 0 then
		err_num = err_num+1
	end
end

testerr=err_num/(2*num)
print(testerr)
