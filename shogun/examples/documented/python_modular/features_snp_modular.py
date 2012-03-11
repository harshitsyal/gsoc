# Creates features similar to the feature space of the SNP kernel. Useful when
# working with linear methods.

parameter_list=[['../data/snps.dat']]

def features_snp_modular(fname):
	from shogun.Features import StringByteFeatures, SNPFeatures, SNP

	sf=StringByteFeatures(SNP)
	sf.load_ascii_file(fname, False, SNP, SNP)
	#print sf.get_features()
	snps=SNPFeatures(sf)
	#print snps.get_feature_matrix()
	#print snps.get_minor_base_string()
	#print snps.get_major_base_string()

if __name__=='__main__':
	print 'SNP Features'
	features_snp_modular(*parameter_list[0])
