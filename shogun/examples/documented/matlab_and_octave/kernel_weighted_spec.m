% The WeightedCommWordString kernel may be used to compute the weighted
% spectrum kernel (i.e. a spectrum kernel for 1 to K-mers, where each k-mer
% length is weighted by some coefficient $\beta_k$ from strings that have
% been mapped into unsigned 16bit integers.
% 
% These 16bit integers correspond to k-mers. To applicable in this kernel they
% need to be sorted (e.g. via the SortWordString pre-processor).
% 
% It basically uses the algorithm in the unix "comm" command (hence the name)
% to compute:
% 
% k({\bf x},({\bf x'})= \sum_{k=1}^K\beta_k\Phi_k({\bf x})\cdot \Phi_k({\bf x'})
% 
% where $\Phi_k$ maps a sequence ${\bf x}$ that consists of letters in
% $\Sigma$ to a feature vector of size $|\Sigma|^k$. In this feature
% vector each entry denotes how often the k-mer appears in that ${\bf x}$.
% 
% Note that this representation is especially tuned to small alphabets
% (like the 2-bit alphabet DNA), for which it enables spectrum kernels
% of order 8.
% 
% For this kernel the linadd speedups are quite efficiently implemented using
% direct maps.
% 

rand('seed',17);
%sequence lengths, number of sequences
len=100;
num_train=10;
num_a=5;
aa=(round(len/2-num_a/2)):(round(len/2+num_a/2-1));

%SVM regularization factor C
C=1;

%Spectrum kernel parameters
order=8;
cache=10;
use_sign=false;
normalization='NO'; %NO,SQRT,LEN,SQLEN,FULL

%generate some toy data
acgt='ACGT';
shift=40;
rand('state',1);
traindat=acgt(ceil(4*rand(len,num_train)));
trainlab=[-ones(1,num_train/2),ones(1,num_train/2)];
aas=floor((shift+1)*rand(num_train,1));
idx=find(trainlab==1);
for i=1:length(idx),
	traindat(aa+aas(i),idx(i))='A';
end

%%% spec
weights=(order:-1:1);
weights=weights/sum(weights);
km=zeros(size(traindat,2));
for o=1:order,
	sg('set_features', 'TRAIN', traindat, 'DNA');
	sg('convert', 'TRAIN', 'STRING', 'CHAR', 'STRING', 'WORD', o, order-1);
	sg('add_preproc', 'SORTWORDSTRING');
	sg('attach_preproc', 'TRAIN');
	sg('set_kernel', 'COMMSTRING', 'WORD',cache, use_sign, normalization);
	km=km+weights(o)*sg('get_kernel_matrix', 'TRAIN');
end

%%% wdspec
sg('set_features', 'TRAIN', traindat, 'DNA');
sg('convert', 'TRAIN', 'STRING', 'CHAR', 'STRING', 'WORD', order, order-1, 0, 'r');
sg('add_preproc', 'SORTWORDSTRING');
sg('attach_preproc', 'TRAIN');
sg('set_kernel', 'WEIGHTEDCOMMSTRING', 'WORD', cache, use_sign, normalization);

wkm=sg('get_kernel_matrix', 'TRAIN');


max(abs(wkm(:)-km(:)))
