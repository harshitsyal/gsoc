/*
 * THIS IS A GENERATED FILE!  DO NOT CHANGE THIS FILE!  CHANGE THE
 * CORRESPONDING TEMPLAT FILE, PLEASE!
-e  */

/*
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * Written (W) 2009 Soeren Sonnenburg
 * Copyright (C) 2009 Fraunhofer Institute FIRST and Max-Planck-Society
 */

#include "lib/common.h"
#include "base/class_list.h"

#include <string.h>

#include "kernel/Kernel.h"

#include "distributions/Gaussian.h"
#include "distributions/GHMM.h"
#include "distributions/HMM.h"
#include "distributions/LinearHMM.h"
#include "distributions/Histogram.h"
#include "distributions/PositionalPWM.h"
#include "lib/Array.h"
#include "lib/Set.h"
#include "lib/HashSet.h"
#include "lib/Hash.h"
#include "lib/List.h"
#include "lib/BitString.h"
#include "lib/Cache.h"
#include "lib/FibonacciHeap.h"
#include "lib/Array3.h"
#include "lib/Time.h"
#include "lib/Array2.h"
#include "lib/DynamicObjectArray.h"
#include "lib/Signal.h"
#include "lib/DynamicArray.h"
#include "lib/Compressor.h"
#include "evaluation/MeanAbsoluteError.h"
#include "evaluation/CrossValidation.h"
#include "evaluation/MulticlassAccuracy.h"
#include "evaluation/PRCEvaluation.h"
#include "evaluation/StratifiedCrossValidationSplitting.h"
#include "evaluation/MeanSquaredError.h"
#include "evaluation/ROCEvaluation.h"
#include "evaluation/ContingencyTableEvaluation.h"
#include "converter/LocalTangentSpaceAlignment.h"
#include "converter/Isomap.h"
#include "converter/DiffusionMaps.h"
#include "converter/LocalityPreservingProjections.h"
#include "converter/KernelLocalTangentSpaceAlignment.h"
#include "converter/MultidimensionalScaling.h"
#include "converter/LocallyLinearEmbedding.h"
#include "converter/LaplacianEigenmaps.h"
#include "converter/NeighborhoodPreservingEmbedding.h"
#include "converter/LinearLocalTangentSpaceAlignment.h"
#include "converter/HessianLocallyLinearEmbedding.h"
#include "converter/KernelLocallyLinearEmbedding.h"
#include "modelselection/ModelSelectionParameters.h"
#include "modelselection/ParameterCombination.h"
#include "modelselection/GridSearchModelSelection.h"
#include "clustering/KMeans.h"
#include "clustering/Hierarchical.h"
#include "clustering/GMM.h"
#include "mathematics/Math.h"
#include "mathematics/Statistics.h"
#include "classifier/Perceptron.h"
#include "classifier/AveragedPerceptron.h"
#include "classifier/LDA.h"
#include "classifier/vw/VwRegressor.h"
#include "classifier/vw/VwEnvironment.h"
#include "classifier/vw/learners/VwAdaptiveLearner.h"
#include "classifier/vw/learners/VwNonAdaptiveLearner.h"
#include "classifier/vw/VowpalWabbit.h"
#include "classifier/vw/cache/VwNativeCacheWriter.h"
#include "classifier/vw/cache/VwNativeCacheReader.h"
#include "classifier/vw/VwParser.h"
#include "classifier/svm/OnlineSVMSGD.h"
#include "classifier/svm/MPDSVM.h"
#include "classifier/svm/MultiClassSVM.h"
#include "classifier/svm/QPBSVMLib.h"
#include "classifier/svm/LaRank.h"
#include "classifier/svm/GMNPLib.h"
#include "classifier/svm/SGDQN.h"
#include "classifier/svm/ScatterSVM.h"
#include "classifier/svm/GMNPSVM.h"
#include "classifier/svm/SubGradientSVM.h"
#include "classifier/svm/GNPPSVM.h"
#include "classifier/svm/LibLinear.h"
#include "classifier/svm/WDSVMOcas.h"
#include "classifier/svm/LibSVMMultiClass.h"
#include "classifier/svm/DomainAdaptationSVM.h"
#include "classifier/svm/LibSVM.h"
#include "classifier/svm/Tron.h"
#include "classifier/svm/SVMLin.h"
#include "classifier/svm/GNPPLib.h"
#include "classifier/svm/SVM.h"
#include "classifier/svm/LibSVMOneClass.h"
#include "classifier/svm/OnlineLibLinear.h"
#include "classifier/svm/SVMLight.h"
#include "classifier/svm/GPBTSVM.h"
#include "classifier/svm/SVMOcas.h"
#include "classifier/svm/SVMLightOneClass.h"
#include "classifier/svm/DomainAdaptationSVMLinear.h"
#include "classifier/svm/SVMSGD.h"
#include "classifier/KNN.h"
#include "classifier/PluginEstimate.h"
#include "classifier/mkl/MKLOneClass.h"
#include "classifier/mkl/MKLClassification.h"
#include "classifier/mkl/MKLMultiClass.h"
#include "classifier/GaussianNaiveBayes.h"
#include "structure/PlifMatrix.h"
#include "structure/IntronList.h"
#include "structure/DynProg.h"
#include "structure/SegmentLoss.h"
#include "structure/PlifArray.h"
#include "structure/Plif.h"
#include "kernel/AUCKernel.h"
#include "kernel/WeightedDegreePositionStringKernel.h"
#include "kernel/AvgDiagKernelNormalizer.h"
#include "kernel/DistanceKernel.h"
#include "kernel/SimpleLocalityImprovedStringKernel.h"
#include "kernel/GaussianShiftKernel.h"
#include "kernel/GaussianShortRealKernel.h"
#include "kernel/Chi2Kernel.h"
#include "kernel/SqrtDiagKernelNormalizer.h"
#include "kernel/SphericalKernel.h"
#include "kernel/WaveletKernel.h"
#include "kernel/CircularKernel.h"
#include "kernel/HistogramWordStringKernel.h"
#include "kernel/LocalAlignmentStringKernel.h"
#include "kernel/ExponentialKernel.h"
#include "kernel/ANOVAKernel.h"
#include "kernel/DiceKernelNormalizer.h"
#include "kernel/PolyMatchStringKernel.h"
#include "kernel/CommUlongStringKernel.h"
#include "kernel/CauchyKernel.h"
#include "kernel/DiagKernel.h"
#include "kernel/MultitaskKernelMaskNormalizer.h"
#include "kernel/WeightedCommWordStringKernel.h"
#include "kernel/LinearStringKernel.h"
#include "kernel/VarianceKernelNormalizer.h"
#include "kernel/SplineKernel.h"
#include "kernel/MultitaskKernelPlifNormalizer.h"
#include "kernel/PolyKernel.h"
#include "kernel/MultiquadricKernel.h"
#include "kernel/SigmoidKernel.h"
#include "kernel/MultitaskKernelNormalizer.h"
#include "kernel/LocalityImprovedStringKernel.h"
#include "kernel/MultitaskKernelMaskPairNormalizer.h"
#include "kernel/FixedDegreeStringKernel.h"
#include "kernel/OligoStringKernel.h"
#include "kernel/LinearKernel.h"
#include "kernel/SNPStringKernel.h"
#include "kernel/WaveKernel.h"
#include "kernel/PowerKernel.h"
#include "kernel/SpectrumMismatchRBFKernel.h"
#include "kernel/GaussianKernel.h"
#include "kernel/CombinedKernel.h"
#include "kernel/ScatterKernelNormalizer.h"
#include "kernel/SparseSpatialSampleStringKernel.h"
#include "kernel/ConstKernel.h"
#include "kernel/MultitaskKernelTreeNormalizer.h"
#include "kernel/PolyMatchWordStringKernel.h"
#include "kernel/GaussianMatchStringKernel.h"
#include "kernel/WeightedDegreeStringKernel.h"
#include "kernel/DistantSegmentsKernel.h"
#include "kernel/RationalQuadraticKernel.h"
#include "kernel/InverseMultiQuadricKernel.h"
#include "kernel/ZeroMeanCenterKernelNormalizer.h"
#include "kernel/FirstElementKernelNormalizer.h"
#include "kernel/SalzbergWordStringKernel.h"
#include "kernel/LogKernel.h"
#include "kernel/BesselKernel.h"
#include "kernel/TensorProductPairKernel.h"
#include "kernel/HistogramIntersectionKernel.h"
#include "kernel/RegulatoryModulesStringKernel.h"
#include "kernel/PyramidChi2.h"
#include "kernel/RidgeKernelNormalizer.h"
#include "kernel/CommWordStringKernel.h"
#include "kernel/IdentityKernelNormalizer.h"
#include "kernel/TStudentKernel.h"
#include "kernel/MatchWordStringKernel.h"
#include "kernel/WeightedDegreeRBFKernel.h"
#include "kernel/CustomKernel.h"
#include "kernel/SpectrumRBFKernel.h"
#include "kernel/TanimotoKernelNormalizer.h"
#include "ui/GUIKernel.h"
#include "ui/GUIPluginEstimate.h"
#include "ui/GUILabels.h"
#include "ui/GUITime.h"
#include "ui/GUIHMM.h"
#include "ui/GUIPreprocessor.h"
#include "ui/GUIDistance.h"
#include "ui/GUIMath.h"
#include "ui/GUIFeatures.h"
#include "ui/GUIClassifier.h"
#include "ui/GUIStructure.h"
#include "machine/DistanceMachine.h"
#include "machine/LinearMachine.h"
#include "machine/KernelMachine.h"
#include "machine/OnlineLinearMachine.h"
#include "features/HashedWDFeaturesTransposed.h"
#include "features/SNPFeatures.h"
#include "features/StringFileFeatures.h"
#include "features/StreamingSimpleFeatures.h"
#include "features/CombinedFeatures.h"
#include "features/DummyFeatures.h"
#include "features/Subset.h"
#include "features/LBPPyrDotFeatures.h"
#include "features/StreamingStringFeatures.h"
#include "features/TOPFeatures.h"
#include "features/HashedWDFeatures.h"
#include "features/RealFileFeatures.h"
#include "features/Labels.h"
#include "features/SparseFeatures.h"
#include "features/WDFeatures.h"
#include "features/SparsePolyFeatures.h"
#include "features/StreamingVwFeatures.h"
#include "features/CombinedDotFeatures.h"
#include "features/ExplicitSpecFeatures.h"
#include "features/ImplicitWeightedSpecFeatures.h"
#include "features/PolyFeatures.h"
#include "features/Alphabet.h"
#include "features/FKFeatures.h"
#include "features/StringFeatures.h"
#include "features/SimpleFeatures.h"
#include "features/StreamingSparseFeatures.h"
#include "distance/ChebyshewMetric.h"
#include "distance/CosineDistance.h"
#include "distance/HammingWordDistance.h"
#include "distance/AttenuatedEuclidianDistance.h"
#include "distance/EuclidianDistance.h"
#include "distance/JensenMetric.h"
#include "distance/KernelDistance.h"
#include "distance/CanberraMetric.h"
#include "distance/BrayCurtisDistance.h"
#include "distance/GeodesicMetric.h"
#include "distance/TanimotoDistance.h"
#include "distance/SparseEuclidianDistance.h"
#include "distance/ManhattanWordDistance.h"
#include "distance/CanberraWordDistance.h"
#include "distance/MinkowskiMetric.h"
#include "distance/ChiSquareDistance.h"
#include "distance/ManhattanMetric.h"
#include "distance/CustomDistance.h"
#include "io/StreamingFile.h"
#include "io/StreamingAsciiFile.h"
#include "io/ParseBuffer.h"
#include "io/IOBuffer.h"
#include "io/SimpleFile.h"
#include "io/StreamingVwFile.h"
#include "io/StreamingVwCacheFile.h"
#include "io/AsciiFile.h"
#include "io/MemoryMappedFile.h"
#include "io/StreamingFileFromFeatures.h"
#include "io/StreamingFileFromStringFeatures.h"
#include "io/SerializableAsciiFile.h"
#include "io/BinaryStream.h"
#include "io/StreamingFileFromSparseFeatures.h"
#include "io/StreamingFileFromSimpleFeatures.h"
#include "io/BinaryFile.h"
#include "regression/svr/SVRLight.h"
#include "regression/svr/MKLRegression.h"
#include "regression/svr/LibSVR.h"
#include "regression/KRR.h"
#include "loss/SmoothHingeLoss.h"
#include "loss/LogLoss.h"
#include "loss/SquaredHingeLoss.h"
#include "loss/SquaredLoss.h"
#include "loss/LogLossMargin.h"
#include "loss/HingeLoss.h"
#include "preprocessor/DimensionReductionPreprocessor.h"
#include "preprocessor/PCA.h"
#include "preprocessor/RandomFourierGaussPreproc.h"
#include "preprocessor/NormOne.h"
#include "preprocessor/SortWordString.h"
#include "preprocessor/KernelPCA.h"
#include "preprocessor/PruneVarSubMean.h"
#include "preprocessor/DecompressString.h"
#include "preprocessor/LogPlusOne.h"
#include "preprocessor/SortUlongString.h"
using namespace shogun;

static CSGObject* __new_CGaussian(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGaussian(): NULL; }
static CSGObject* __new_CGHMM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGHMM(): NULL; }
static CSGObject* __new_CHMM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHMM(): NULL; }
static CSGObject* __new_CLinearHMM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLinearHMM(): NULL; }
static CSGObject* __new_CHistogram(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHistogram(): NULL; }
static CSGObject* __new_CPositionalPWM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPositionalPWM(): NULL; }
static CSGObject* __new_CHashSet(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHashSet(): NULL; }
static CSGObject* __new_CHash(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHash(): NULL; }
static CSGObject* __new_CListElement(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CListElement(): NULL; }
static CSGObject* __new_CList(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CList(): NULL; }
static CSGObject* __new_CBitString(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CBitString(): NULL; }
static CSGObject* __new_CFibonacciHeap(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CFibonacciHeap(): NULL; }
static CSGObject* __new_CTime(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTime(): NULL; }
static CSGObject* __new_CSignal(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSignal(): NULL; }
static CSGObject* __new_CCompressor(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCompressor(): NULL; }
static CSGObject* __new_CMeanAbsoluteError(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMeanAbsoluteError(): NULL; }
static CSGObject* __new_CCrossValidation(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCrossValidation(): NULL; }
static CSGObject* __new_CMulticlassAccuracy(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMulticlassAccuracy(): NULL; }
static CSGObject* __new_CPRCEvaluation(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPRCEvaluation(): NULL; }
static CSGObject* __new_CStratifiedCrossValidationSplitting(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStratifiedCrossValidationSplitting(): NULL; }
static CSGObject* __new_CMeanSquaredError(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMeanSquaredError(): NULL; }
static CSGObject* __new_CROCEvaluation(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CROCEvaluation(): NULL; }
static CSGObject* __new_CContingencyTableEvaluation(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CContingencyTableEvaluation(): NULL; }
static CSGObject* __new_CAccuracyMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAccuracyMeasure(): NULL; }
static CSGObject* __new_CErrorRateMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CErrorRateMeasure(): NULL; }
static CSGObject* __new_CBALMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CBALMeasure(): NULL; }
static CSGObject* __new_CWRACCMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWRACCMeasure(): NULL; }
static CSGObject* __new_CF1Measure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CF1Measure(): NULL; }
static CSGObject* __new_CCrossCorrelationMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCrossCorrelationMeasure(): NULL; }
static CSGObject* __new_CRecallMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CRecallMeasure(): NULL; }
static CSGObject* __new_CPrecisionMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPrecisionMeasure(): NULL; }
static CSGObject* __new_CSpecificityMeasure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSpecificityMeasure(): NULL; }
static CSGObject* __new_CLocalTangentSpaceAlignment(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLocalTangentSpaceAlignment(): NULL; }
static CSGObject* __new_CIsomap(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CIsomap(): NULL; }
static CSGObject* __new_CDiffusionMaps(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDiffusionMaps(): NULL; }
static CSGObject* __new_CLocalityPreservingProjections(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLocalityPreservingProjections(): NULL; }
static CSGObject* __new_CKernelLocalTangentSpaceAlignment(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKernelLocalTangentSpaceAlignment(): NULL; }
static CSGObject* __new_CMultidimensionalScaling(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultidimensionalScaling(): NULL; }
static CSGObject* __new_CLocallyLinearEmbedding(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLocallyLinearEmbedding(): NULL; }
static CSGObject* __new_CLaplacianEigenmaps(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLaplacianEigenmaps(): NULL; }
static CSGObject* __new_CNeighborhoodPreservingEmbedding(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CNeighborhoodPreservingEmbedding(): NULL; }
static CSGObject* __new_CLinearLocalTangentSpaceAlignment(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLinearLocalTangentSpaceAlignment(): NULL; }
static CSGObject* __new_CHessianLocallyLinearEmbedding(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHessianLocallyLinearEmbedding(): NULL; }
static CSGObject* __new_CKernelLocallyLinearEmbedding(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKernelLocallyLinearEmbedding(): NULL; }
static CSGObject* __new_CModelSelectionParameters(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CModelSelectionParameters(): NULL; }
static CSGObject* __new_CParameterCombination(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CParameterCombination(): NULL; }
static CSGObject* __new_CGridSearchModelSelection(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGridSearchModelSelection(): NULL; }
static CSGObject* __new_CKMeans(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKMeans(): NULL; }
static CSGObject* __new_CHierarchical(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHierarchical(): NULL; }
static CSGObject* __new_CGMM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGMM(): NULL; }
static CSGObject* __new_CMath(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMath(): NULL; }
static CSGObject* __new_CStatistics(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStatistics(): NULL; }
static CSGObject* __new_CPerceptron(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPerceptron(): NULL; }
static CSGObject* __new_CAveragedPerceptron(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAveragedPerceptron(): NULL; }
static CSGObject* __new_CLDA(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLDA(): NULL; }
static CSGObject* __new_CVwRegressor(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwRegressor(): NULL; }
static CSGObject* __new_CVwEnvironment(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwEnvironment(): NULL; }
static CSGObject* __new_CVwAdaptiveLearner(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwAdaptiveLearner(): NULL; }
static CSGObject* __new_CVwNonAdaptiveLearner(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwNonAdaptiveLearner(): NULL; }
static CSGObject* __new_CVowpalWabbit(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVowpalWabbit(): NULL; }
static CSGObject* __new_CVwNativeCacheWriter(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwNativeCacheWriter(): NULL; }
static CSGObject* __new_CVwNativeCacheReader(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwNativeCacheReader(): NULL; }
static CSGObject* __new_CVwParser(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVwParser(): NULL; }
static CSGObject* __new_COnlineSVMSGD(EPrimitiveType g) { return g == PT_NOT_GENERIC? new COnlineSVMSGD(): NULL; }
static CSGObject* __new_CMPDSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMPDSVM(): NULL; }
static CSGObject* __new_CMultiClassSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultiClassSVM(): NULL; }
static CSGObject* __new_CQPBSVMLib(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CQPBSVMLib(): NULL; }
static CSGObject* __new_CLaRank(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLaRank(): NULL; }
static CSGObject* __new_CGMNPLib(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGMNPLib(): NULL; }
static CSGObject* __new_CSGDQN(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSGDQN(): NULL; }
static CSGObject* __new_CScatterSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CScatterSVM(): NULL; }
static CSGObject* __new_CGMNPSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGMNPSVM(): NULL; }
static CSGObject* __new_CSubGradientSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSubGradientSVM(): NULL; }
static CSGObject* __new_CGNPPSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGNPPSVM(): NULL; }
static CSGObject* __new_CLibLinear(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLibLinear(): NULL; }
static CSGObject* __new_CWDSVMOcas(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWDSVMOcas(): NULL; }
static CSGObject* __new_CLibSVMMultiClass(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLibSVMMultiClass(): NULL; }
static CSGObject* __new_CDomainAdaptationSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDomainAdaptationSVM(): NULL; }
static CSGObject* __new_CLibSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLibSVM(): NULL; }
static CSGObject* __new_CTron(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTron(): NULL; }
static CSGObject* __new_CSVMLin(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVMLin(): NULL; }
static CSGObject* __new_CGNPPLib(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGNPPLib(): NULL; }
static CSGObject* __new_CSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVM(): NULL; }
static CSGObject* __new_CLibSVMOneClass(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLibSVMOneClass(): NULL; }
static CSGObject* __new_COnlineLibLinear(EPrimitiveType g) { return g == PT_NOT_GENERIC? new COnlineLibLinear(): NULL; }
static CSGObject* __new_CSVMLight(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVMLight(): NULL; }
static CSGObject* __new_CGPBTSVM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGPBTSVM(): NULL; }
static CSGObject* __new_CSVMOcas(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVMOcas(): NULL; }
static CSGObject* __new_CSVMLightOneClass(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVMLightOneClass(): NULL; }
static CSGObject* __new_CDomainAdaptationSVMLinear(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDomainAdaptationSVMLinear(): NULL; }
static CSGObject* __new_CSVMSGD(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVMSGD(): NULL; }
static CSGObject* __new_CKNN(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKNN(): NULL; }
static CSGObject* __new_CPluginEstimate(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPluginEstimate(): NULL; }
static CSGObject* __new_CMKLOneClass(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMKLOneClass(): NULL; }
static CSGObject* __new_CMKLClassification(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMKLClassification(): NULL; }
static CSGObject* __new_CMKLMultiClass(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMKLMultiClass(): NULL; }
static CSGObject* __new_CGaussianNaiveBayes(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGaussianNaiveBayes(): NULL; }
static CSGObject* __new_CPlifMatrix(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPlifMatrix(): NULL; }
static CSGObject* __new_CIntronList(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CIntronList(): NULL; }
static CSGObject* __new_CDynProg(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDynProg(): NULL; }
static CSGObject* __new_CSegmentLoss(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSegmentLoss(): NULL; }
static CSGObject* __new_CPlifArray(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPlifArray(): NULL; }
static CSGObject* __new_CPlif(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPlif(): NULL; }
static CSGObject* __new_CAUCKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAUCKernel(): NULL; }
static CSGObject* __new_CWeightedDegreePositionStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWeightedDegreePositionStringKernel(): NULL; }
static CSGObject* __new_CAvgDiagKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAvgDiagKernelNormalizer(): NULL; }
static CSGObject* __new_CDistanceKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDistanceKernel(): NULL; }
static CSGObject* __new_CSimpleLocalityImprovedStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSimpleLocalityImprovedStringKernel(): NULL; }
static CSGObject* __new_CGaussianShiftKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGaussianShiftKernel(): NULL; }
static CSGObject* __new_CGaussianShortRealKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGaussianShortRealKernel(): NULL; }
static CSGObject* __new_CChi2Kernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CChi2Kernel(): NULL; }
static CSGObject* __new_CSqrtDiagKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSqrtDiagKernelNormalizer(): NULL; }
static CSGObject* __new_CSphericalKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSphericalKernel(): NULL; }
static CSGObject* __new_CWaveletKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWaveletKernel(): NULL; }
static CSGObject* __new_CCircularKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCircularKernel(): NULL; }
static CSGObject* __new_CHistogramWordStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHistogramWordStringKernel(): NULL; }
static CSGObject* __new_CLocalAlignmentStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLocalAlignmentStringKernel(): NULL; }
static CSGObject* __new_CExponentialKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CExponentialKernel(): NULL; }
static CSGObject* __new_CANOVAKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CANOVAKernel(): NULL; }
static CSGObject* __new_CDiceKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDiceKernelNormalizer(): NULL; }
static CSGObject* __new_CPolyMatchStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPolyMatchStringKernel(): NULL; }
static CSGObject* __new_CCommUlongStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCommUlongStringKernel(): NULL; }
static CSGObject* __new_CCauchyKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCauchyKernel(): NULL; }
static CSGObject* __new_CDiagKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDiagKernel(): NULL; }
static CSGObject* __new_CMultitaskKernelMaskNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultitaskKernelMaskNormalizer(): NULL; }
static CSGObject* __new_CWeightedCommWordStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWeightedCommWordStringKernel(): NULL; }
static CSGObject* __new_CLinearStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLinearStringKernel(): NULL; }
static CSGObject* __new_CVarianceKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CVarianceKernelNormalizer(): NULL; }
static CSGObject* __new_CSplineKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSplineKernel(): NULL; }
static CSGObject* __new_CMultitaskKernelPlifNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultitaskKernelPlifNormalizer(): NULL; }
static CSGObject* __new_CPolyKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPolyKernel(): NULL; }
static CSGObject* __new_CMultiquadricKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultiquadricKernel(): NULL; }
static CSGObject* __new_CSigmoidKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSigmoidKernel(): NULL; }
static CSGObject* __new_CMultitaskKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultitaskKernelNormalizer(): NULL; }
static CSGObject* __new_CLocalityImprovedStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLocalityImprovedStringKernel(): NULL; }
static CSGObject* __new_CMultitaskKernelMaskPairNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultitaskKernelMaskPairNormalizer(): NULL; }
static CSGObject* __new_CFixedDegreeStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CFixedDegreeStringKernel(): NULL; }
static CSGObject* __new_COligoStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new COligoStringKernel(): NULL; }
static CSGObject* __new_CLinearKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLinearKernel(): NULL; }
static CSGObject* __new_CSNPStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSNPStringKernel(): NULL; }
static CSGObject* __new_CWaveKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWaveKernel(): NULL; }
static CSGObject* __new_CPowerKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPowerKernel(): NULL; }
static CSGObject* __new_CSpectrumMismatchRBFKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSpectrumMismatchRBFKernel(): NULL; }
static CSGObject* __new_CGaussianKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGaussianKernel(): NULL; }
static CSGObject* __new_CCombinedKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCombinedKernel(): NULL; }
static CSGObject* __new_CScatterKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CScatterKernelNormalizer(): NULL; }
static CSGObject* __new_CSparseSpatialSampleStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSparseSpatialSampleStringKernel(): NULL; }
static CSGObject* __new_CConstKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CConstKernel(): NULL; }
static CSGObject* __new_CNode(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CNode(): NULL; }
static CSGObject* __new_CTaxonomy(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTaxonomy(): NULL; }
static CSGObject* __new_CMultitaskKernelTreeNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMultitaskKernelTreeNormalizer(): NULL; }
static CSGObject* __new_CPolyMatchWordStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPolyMatchWordStringKernel(): NULL; }
static CSGObject* __new_CGaussianMatchStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGaussianMatchStringKernel(): NULL; }
static CSGObject* __new_CWeightedDegreeStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWeightedDegreeStringKernel(): NULL; }
static CSGObject* __new_CDistantSegmentsKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDistantSegmentsKernel(): NULL; }
static CSGObject* __new_CRationalQuadraticKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CRationalQuadraticKernel(): NULL; }
static CSGObject* __new_CInverseMultiQuadricKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CInverseMultiQuadricKernel(): NULL; }
static CSGObject* __new_CZeroMeanCenterKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CZeroMeanCenterKernelNormalizer(): NULL; }
static CSGObject* __new_CFirstElementKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CFirstElementKernelNormalizer(): NULL; }
static CSGObject* __new_CSalzbergWordStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSalzbergWordStringKernel(): NULL; }
static CSGObject* __new_CLogKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLogKernel(): NULL; }
static CSGObject* __new_CBesselKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CBesselKernel(): NULL; }
static CSGObject* __new_CTensorProductPairKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTensorProductPairKernel(): NULL; }
static CSGObject* __new_CHistogramIntersectionKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHistogramIntersectionKernel(): NULL; }
static CSGObject* __new_CRegulatoryModulesStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CRegulatoryModulesStringKernel(): NULL; }
static CSGObject* __new_CPyramidChi2(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPyramidChi2(): NULL; }
static CSGObject* __new_CRidgeKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CRidgeKernelNormalizer(): NULL; }
static CSGObject* __new_CCommWordStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCommWordStringKernel(): NULL; }
static CSGObject* __new_CIdentityKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CIdentityKernelNormalizer(): NULL; }
static CSGObject* __new_CTStudentKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTStudentKernel(): NULL; }
static CSGObject* __new_CMatchWordStringKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMatchWordStringKernel(): NULL; }
static CSGObject* __new_CWeightedDegreeRBFKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWeightedDegreeRBFKernel(): NULL; }
static CSGObject* __new_CCustomKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCustomKernel(): NULL; }
static CSGObject* __new_CSpectrumRBFKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSpectrumRBFKernel(): NULL; }
static CSGObject* __new_CTanimotoKernelNormalizer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTanimotoKernelNormalizer(): NULL; }
static CSGObject* __new_CGUIKernel(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIKernel(): NULL; }
static CSGObject* __new_CGUIPluginEstimate(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIPluginEstimate(): NULL; }
static CSGObject* __new_CGUILabels(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUILabels(): NULL; }
static CSGObject* __new_CGUITime(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUITime(): NULL; }
static CSGObject* __new_CGUIHMM(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIHMM(): NULL; }
static CSGObject* __new_CGUIPreprocessor(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIPreprocessor(): NULL; }
static CSGObject* __new_CGUIDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIDistance(): NULL; }
static CSGObject* __new_CGUIMath(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIMath(): NULL; }
static CSGObject* __new_CGUIFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIFeatures(): NULL; }
static CSGObject* __new_CGUIClassifier(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIClassifier(): NULL; }
static CSGObject* __new_CGUIStructure(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGUIStructure(): NULL; }
static CSGObject* __new_CDistanceMachine(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDistanceMachine(): NULL; }
static CSGObject* __new_CLinearMachine(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLinearMachine(): NULL; }
static CSGObject* __new_CKernelMachine(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKernelMachine(): NULL; }
static CSGObject* __new_COnlineLinearMachine(EPrimitiveType g) { return g == PT_NOT_GENERIC? new COnlineLinearMachine(): NULL; }
static CSGObject* __new_CHashedWDFeaturesTransposed(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHashedWDFeaturesTransposed(): NULL; }
static CSGObject* __new_CSNPFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSNPFeatures(): NULL; }
static CSGObject* __new_CCombinedFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCombinedFeatures(): NULL; }
static CSGObject* __new_CDummyFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDummyFeatures(): NULL; }
static CSGObject* __new_CSubset(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSubset(): NULL; }
static CSGObject* __new_CLBPPyrDotFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLBPPyrDotFeatures(): NULL; }
static CSGObject* __new_CTOPFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTOPFeatures(): NULL; }
static CSGObject* __new_CHashedWDFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHashedWDFeatures(): NULL; }
static CSGObject* __new_CRealFileFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CRealFileFeatures(): NULL; }
static CSGObject* __new_CLabels(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLabels(): NULL; }
static CSGObject* __new_CWDFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CWDFeatures(): NULL; }
static CSGObject* __new_CSparsePolyFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSparsePolyFeatures(): NULL; }
static CSGObject* __new_CStreamingVwFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStreamingVwFeatures(): NULL; }
static CSGObject* __new_CCombinedDotFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCombinedDotFeatures(): NULL; }
static CSGObject* __new_CExplicitSpecFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CExplicitSpecFeatures(): NULL; }
static CSGObject* __new_CImplicitWeightedSpecFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CImplicitWeightedSpecFeatures(): NULL; }
static CSGObject* __new_CPolyFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPolyFeatures(): NULL; }
static CSGObject* __new_CAlphabet(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAlphabet(): NULL; }
static CSGObject* __new_CFKFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CFKFeatures(): NULL; }
static CSGObject* __new_CChebyshewMetric(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CChebyshewMetric(): NULL; }
static CSGObject* __new_CCosineDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCosineDistance(): NULL; }
static CSGObject* __new_CHammingWordDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHammingWordDistance(): NULL; }
static CSGObject* __new_CAttenuatedEuclidianDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAttenuatedEuclidianDistance(): NULL; }
static CSGObject* __new_CEuclidianDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CEuclidianDistance(): NULL; }
static CSGObject* __new_CJensenMetric(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CJensenMetric(): NULL; }
static CSGObject* __new_CKernelDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKernelDistance(): NULL; }
static CSGObject* __new_CCanberraMetric(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCanberraMetric(): NULL; }
static CSGObject* __new_CBrayCurtisDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CBrayCurtisDistance(): NULL; }
static CSGObject* __new_CGeodesicMetric(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CGeodesicMetric(): NULL; }
static CSGObject* __new_CTanimotoDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CTanimotoDistance(): NULL; }
static CSGObject* __new_CSparseEuclidianDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSparseEuclidianDistance(): NULL; }
static CSGObject* __new_CManhattanWordDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CManhattanWordDistance(): NULL; }
static CSGObject* __new_CCanberraWordDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCanberraWordDistance(): NULL; }
static CSGObject* __new_CMinkowskiMetric(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMinkowskiMetric(): NULL; }
static CSGObject* __new_CChiSquareDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CChiSquareDistance(): NULL; }
static CSGObject* __new_CManhattanMetric(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CManhattanMetric(): NULL; }
static CSGObject* __new_CCustomDistance(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CCustomDistance(): NULL; }
static CSGObject* __new_CStreamingFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStreamingFile(): NULL; }
static CSGObject* __new_CStreamingAsciiFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStreamingAsciiFile(): NULL; }
static CSGObject* __new_CIOBuffer(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CIOBuffer(): NULL; }
static CSGObject* __new_CStreamingVwFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStreamingVwFile(): NULL; }
static CSGObject* __new_CStreamingVwCacheFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStreamingVwCacheFile(): NULL; }
static CSGObject* __new_CAsciiFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CAsciiFile(): NULL; }
static CSGObject* __new_CStreamingFileFromFeatures(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CStreamingFileFromFeatures(): NULL; }
static CSGObject* __new_CSerializableAsciiFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSerializableAsciiFile(): NULL; }
static CSGObject* __new_CBinaryFile(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CBinaryFile(): NULL; }
static CSGObject* __new_CSVRLight(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSVRLight(): NULL; }
static CSGObject* __new_CMKLRegression(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CMKLRegression(): NULL; }
static CSGObject* __new_CLibSVR(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLibSVR(): NULL; }
static CSGObject* __new_CKRR(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKRR(): NULL; }
static CSGObject* __new_CSmoothHingeLoss(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSmoothHingeLoss(): NULL; }
static CSGObject* __new_CLogLoss(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLogLoss(): NULL; }
static CSGObject* __new_CSquaredHingeLoss(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSquaredHingeLoss(): NULL; }
static CSGObject* __new_CSquaredLoss(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSquaredLoss(): NULL; }
static CSGObject* __new_CLogLossMargin(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLogLossMargin(): NULL; }
static CSGObject* __new_CHingeLoss(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CHingeLoss(): NULL; }
static CSGObject* __new_CDimensionReductionPreprocessor(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CDimensionReductionPreprocessor(): NULL; }
static CSGObject* __new_CPCA(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPCA(): NULL; }
static CSGObject* __new_CRandomFourierGaussPreproc(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CRandomFourierGaussPreproc(): NULL; }
static CSGObject* __new_CNormOne(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CNormOne(): NULL; }
static CSGObject* __new_CSortWordString(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSortWordString(): NULL; }
static CSGObject* __new_CKernelPCA(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CKernelPCA(): NULL; }
static CSGObject* __new_CPruneVarSubMean(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CPruneVarSubMean(): NULL; }
static CSGObject* __new_CLogPlusOne(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CLogPlusOne(): NULL; }
static CSGObject* __new_CSortUlongString(EPrimitiveType g) { return g == PT_NOT_GENERIC? new CSortUlongString(): NULL; }
static CSGObject* __new_CArray(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CArray<bool>();
		case PT_CHAR: return new CArray<char>();
		case PT_INT8: return new CArray<int8_t>();
		case PT_UINT8: return new CArray<uint8_t>();
		case PT_INT16: return new CArray<int16_t>();
		case PT_UINT16: return new CArray<uint16_t>();
		case PT_INT32: return new CArray<int32_t>();
		case PT_UINT32: return new CArray<uint32_t>();
		case PT_INT64: return new CArray<int64_t>();
		case PT_UINT64: return new CArray<uint64_t>();
		case PT_FLOAT32: return new CArray<float32_t>();
		case PT_FLOAT64: return new CArray<float64_t>();
		case PT_FLOATMAX: return new CArray<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CSet(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CSet<bool>();
		case PT_CHAR: return new CSet<char>();
		case PT_INT8: return new CSet<int8_t>();
		case PT_UINT8: return new CSet<uint8_t>();
		case PT_INT16: return new CSet<int16_t>();
		case PT_UINT16: return new CSet<uint16_t>();
		case PT_INT32: return new CSet<int32_t>();
		case PT_UINT32: return new CSet<uint32_t>();
		case PT_INT64: return new CSet<int64_t>();
		case PT_UINT64: return new CSet<uint64_t>();
		case PT_FLOAT32: return new CSet<float32_t>();
		case PT_FLOAT64: return new CSet<float64_t>();
		case PT_FLOATMAX: return new CSet<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CCache(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CCache<bool>();
		case PT_CHAR: return new CCache<char>();
		case PT_INT8: return new CCache<int8_t>();
		case PT_UINT8: return new CCache<uint8_t>();
		case PT_INT16: return new CCache<int16_t>();
		case PT_UINT16: return new CCache<uint16_t>();
		case PT_INT32: return new CCache<int32_t>();
		case PT_UINT32: return new CCache<uint32_t>();
		case PT_INT64: return new CCache<int64_t>();
		case PT_UINT64: return new CCache<uint64_t>();
		case PT_FLOAT32: return new CCache<float32_t>();
		case PT_FLOAT64: return new CCache<float64_t>();
		case PT_FLOATMAX: return new CCache<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CArray3(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CArray3<bool>();
		case PT_CHAR: return new CArray3<char>();
		case PT_INT8: return new CArray3<int8_t>();
		case PT_UINT8: return new CArray3<uint8_t>();
		case PT_INT16: return new CArray3<int16_t>();
		case PT_UINT16: return new CArray3<uint16_t>();
		case PT_INT32: return new CArray3<int32_t>();
		case PT_UINT32: return new CArray3<uint32_t>();
		case PT_INT64: return new CArray3<int64_t>();
		case PT_UINT64: return new CArray3<uint64_t>();
		case PT_FLOAT32: return new CArray3<float32_t>();
		case PT_FLOAT64: return new CArray3<float64_t>();
		case PT_FLOATMAX: return new CArray3<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CArray2(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CArray2<bool>();
		case PT_CHAR: return new CArray2<char>();
		case PT_INT8: return new CArray2<int8_t>();
		case PT_UINT8: return new CArray2<uint8_t>();
		case PT_INT16: return new CArray2<int16_t>();
		case PT_UINT16: return new CArray2<uint16_t>();
		case PT_INT32: return new CArray2<int32_t>();
		case PT_UINT32: return new CArray2<uint32_t>();
		case PT_INT64: return new CArray2<int64_t>();
		case PT_UINT64: return new CArray2<uint64_t>();
		case PT_FLOAT32: return new CArray2<float32_t>();
		case PT_FLOAT64: return new CArray2<float64_t>();
		case PT_FLOATMAX: return new CArray2<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CDynamicObjectArray(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CDynamicObjectArray<bool>();
		case PT_CHAR: return new CDynamicObjectArray<char>();
		case PT_INT8: return new CDynamicObjectArray<int8_t>();
		case PT_UINT8: return new CDynamicObjectArray<uint8_t>();
		case PT_INT16: return new CDynamicObjectArray<int16_t>();
		case PT_UINT16: return new CDynamicObjectArray<uint16_t>();
		case PT_INT32: return new CDynamicObjectArray<int32_t>();
		case PT_UINT32: return new CDynamicObjectArray<uint32_t>();
		case PT_INT64: return new CDynamicObjectArray<int64_t>();
		case PT_UINT64: return new CDynamicObjectArray<uint64_t>();
		case PT_FLOAT32: return new CDynamicObjectArray<float32_t>();
		case PT_FLOAT64: return new CDynamicObjectArray<float64_t>();
		case PT_FLOATMAX: return new CDynamicObjectArray<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CDynamicArray(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CDynamicArray<bool>();
		case PT_CHAR: return new CDynamicArray<char>();
		case PT_INT8: return new CDynamicArray<int8_t>();
		case PT_UINT8: return new CDynamicArray<uint8_t>();
		case PT_INT16: return new CDynamicArray<int16_t>();
		case PT_UINT16: return new CDynamicArray<uint16_t>();
		case PT_INT32: return new CDynamicArray<int32_t>();
		case PT_UINT32: return new CDynamicArray<uint32_t>();
		case PT_INT64: return new CDynamicArray<int64_t>();
		case PT_UINT64: return new CDynamicArray<uint64_t>();
		case PT_FLOAT32: return new CDynamicArray<float32_t>();
		case PT_FLOAT64: return new CDynamicArray<float64_t>();
		case PT_FLOATMAX: return new CDynamicArray<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStringFileFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStringFileFeatures<bool>();
		case PT_CHAR: return new CStringFileFeatures<char>();
		case PT_INT8: return new CStringFileFeatures<int8_t>();
		case PT_UINT8: return new CStringFileFeatures<uint8_t>();
		case PT_INT16: return new CStringFileFeatures<int16_t>();
		case PT_UINT16: return new CStringFileFeatures<uint16_t>();
		case PT_INT32: return new CStringFileFeatures<int32_t>();
		case PT_UINT32: return new CStringFileFeatures<uint32_t>();
		case PT_INT64: return new CStringFileFeatures<int64_t>();
		case PT_UINT64: return new CStringFileFeatures<uint64_t>();
		case PT_FLOAT32: return new CStringFileFeatures<float32_t>();
		case PT_FLOAT64: return new CStringFileFeatures<float64_t>();
		case PT_FLOATMAX: return new CStringFileFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStreamingSimpleFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStreamingSimpleFeatures<bool>();
		case PT_CHAR: return new CStreamingSimpleFeatures<char>();
		case PT_INT8: return new CStreamingSimpleFeatures<int8_t>();
		case PT_UINT8: return new CStreamingSimpleFeatures<uint8_t>();
		case PT_INT16: return new CStreamingSimpleFeatures<int16_t>();
		case PT_UINT16: return new CStreamingSimpleFeatures<uint16_t>();
		case PT_INT32: return new CStreamingSimpleFeatures<int32_t>();
		case PT_UINT32: return new CStreamingSimpleFeatures<uint32_t>();
		case PT_INT64: return new CStreamingSimpleFeatures<int64_t>();
		case PT_UINT64: return new CStreamingSimpleFeatures<uint64_t>();
		case PT_FLOAT32: return new CStreamingSimpleFeatures<float32_t>();
		case PT_FLOAT64: return new CStreamingSimpleFeatures<float64_t>();
		case PT_FLOATMAX: return new CStreamingSimpleFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStreamingStringFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStreamingStringFeatures<bool>();
		case PT_CHAR: return new CStreamingStringFeatures<char>();
		case PT_INT8: return new CStreamingStringFeatures<int8_t>();
		case PT_UINT8: return new CStreamingStringFeatures<uint8_t>();
		case PT_INT16: return new CStreamingStringFeatures<int16_t>();
		case PT_UINT16: return new CStreamingStringFeatures<uint16_t>();
		case PT_INT32: return new CStreamingStringFeatures<int32_t>();
		case PT_UINT32: return new CStreamingStringFeatures<uint32_t>();
		case PT_INT64: return new CStreamingStringFeatures<int64_t>();
		case PT_UINT64: return new CStreamingStringFeatures<uint64_t>();
		case PT_FLOAT32: return new CStreamingStringFeatures<float32_t>();
		case PT_FLOAT64: return new CStreamingStringFeatures<float64_t>();
		case PT_FLOATMAX: return new CStreamingStringFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CSparseFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CSparseFeatures<bool>();
		case PT_CHAR: return new CSparseFeatures<char>();
		case PT_INT8: return new CSparseFeatures<int8_t>();
		case PT_UINT8: return new CSparseFeatures<uint8_t>();
		case PT_INT16: return new CSparseFeatures<int16_t>();
		case PT_UINT16: return new CSparseFeatures<uint16_t>();
		case PT_INT32: return new CSparseFeatures<int32_t>();
		case PT_UINT32: return new CSparseFeatures<uint32_t>();
		case PT_INT64: return new CSparseFeatures<int64_t>();
		case PT_UINT64: return new CSparseFeatures<uint64_t>();
		case PT_FLOAT32: return new CSparseFeatures<float32_t>();
		case PT_FLOAT64: return new CSparseFeatures<float64_t>();
		case PT_FLOATMAX: return new CSparseFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStringFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStringFeatures<bool>();
		case PT_CHAR: return new CStringFeatures<char>();
		case PT_INT8: return new CStringFeatures<int8_t>();
		case PT_UINT8: return new CStringFeatures<uint8_t>();
		case PT_INT16: return new CStringFeatures<int16_t>();
		case PT_UINT16: return new CStringFeatures<uint16_t>();
		case PT_INT32: return new CStringFeatures<int32_t>();
		case PT_UINT32: return new CStringFeatures<uint32_t>();
		case PT_INT64: return new CStringFeatures<int64_t>();
		case PT_UINT64: return new CStringFeatures<uint64_t>();
		case PT_FLOAT32: return new CStringFeatures<float32_t>();
		case PT_FLOAT64: return new CStringFeatures<float64_t>();
		case PT_FLOATMAX: return new CStringFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CSimpleFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CSimpleFeatures<bool>();
		case PT_CHAR: return new CSimpleFeatures<char>();
		case PT_INT8: return new CSimpleFeatures<int8_t>();
		case PT_UINT8: return new CSimpleFeatures<uint8_t>();
		case PT_INT16: return new CSimpleFeatures<int16_t>();
		case PT_UINT16: return new CSimpleFeatures<uint16_t>();
		case PT_INT32: return new CSimpleFeatures<int32_t>();
		case PT_UINT32: return new CSimpleFeatures<uint32_t>();
		case PT_INT64: return new CSimpleFeatures<int64_t>();
		case PT_UINT64: return new CSimpleFeatures<uint64_t>();
		case PT_FLOAT32: return new CSimpleFeatures<float32_t>();
		case PT_FLOAT64: return new CSimpleFeatures<float64_t>();
		case PT_FLOATMAX: return new CSimpleFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStreamingSparseFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStreamingSparseFeatures<bool>();
		case PT_CHAR: return new CStreamingSparseFeatures<char>();
		case PT_INT8: return new CStreamingSparseFeatures<int8_t>();
		case PT_UINT8: return new CStreamingSparseFeatures<uint8_t>();
		case PT_INT16: return new CStreamingSparseFeatures<int16_t>();
		case PT_UINT16: return new CStreamingSparseFeatures<uint16_t>();
		case PT_INT32: return new CStreamingSparseFeatures<int32_t>();
		case PT_UINT32: return new CStreamingSparseFeatures<uint32_t>();
		case PT_INT64: return new CStreamingSparseFeatures<int64_t>();
		case PT_UINT64: return new CStreamingSparseFeatures<uint64_t>();
		case PT_FLOAT32: return new CStreamingSparseFeatures<float32_t>();
		case PT_FLOAT64: return new CStreamingSparseFeatures<float64_t>();
		case PT_FLOATMAX: return new CStreamingSparseFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CParseBuffer(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CParseBuffer<bool>();
		case PT_CHAR: return new CParseBuffer<char>();
		case PT_INT8: return new CParseBuffer<int8_t>();
		case PT_UINT8: return new CParseBuffer<uint8_t>();
		case PT_INT16: return new CParseBuffer<int16_t>();
		case PT_UINT16: return new CParseBuffer<uint16_t>();
		case PT_INT32: return new CParseBuffer<int32_t>();
		case PT_UINT32: return new CParseBuffer<uint32_t>();
		case PT_INT64: return new CParseBuffer<int64_t>();
		case PT_UINT64: return new CParseBuffer<uint64_t>();
		case PT_FLOAT32: return new CParseBuffer<float32_t>();
		case PT_FLOAT64: return new CParseBuffer<float64_t>();
		case PT_FLOATMAX: return new CParseBuffer<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CSimpleFile(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CSimpleFile<bool>();
		case PT_CHAR: return new CSimpleFile<char>();
		case PT_INT8: return new CSimpleFile<int8_t>();
		case PT_UINT8: return new CSimpleFile<uint8_t>();
		case PT_INT16: return new CSimpleFile<int16_t>();
		case PT_UINT16: return new CSimpleFile<uint16_t>();
		case PT_INT32: return new CSimpleFile<int32_t>();
		case PT_UINT32: return new CSimpleFile<uint32_t>();
		case PT_INT64: return new CSimpleFile<int64_t>();
		case PT_UINT64: return new CSimpleFile<uint64_t>();
		case PT_FLOAT32: return new CSimpleFile<float32_t>();
		case PT_FLOAT64: return new CSimpleFile<float64_t>();
		case PT_FLOATMAX: return new CSimpleFile<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CMemoryMappedFile(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CMemoryMappedFile<bool>();
		case PT_CHAR: return new CMemoryMappedFile<char>();
		case PT_INT8: return new CMemoryMappedFile<int8_t>();
		case PT_UINT8: return new CMemoryMappedFile<uint8_t>();
		case PT_INT16: return new CMemoryMappedFile<int16_t>();
		case PT_UINT16: return new CMemoryMappedFile<uint16_t>();
		case PT_INT32: return new CMemoryMappedFile<int32_t>();
		case PT_UINT32: return new CMemoryMappedFile<uint32_t>();
		case PT_INT64: return new CMemoryMappedFile<int64_t>();
		case PT_UINT64: return new CMemoryMappedFile<uint64_t>();
		case PT_FLOAT32: return new CMemoryMappedFile<float32_t>();
		case PT_FLOAT64: return new CMemoryMappedFile<float64_t>();
		case PT_FLOATMAX: return new CMemoryMappedFile<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStreamingFileFromStringFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStreamingFileFromStringFeatures<bool>();
		case PT_CHAR: return new CStreamingFileFromStringFeatures<char>();
		case PT_INT8: return new CStreamingFileFromStringFeatures<int8_t>();
		case PT_UINT8: return new CStreamingFileFromStringFeatures<uint8_t>();
		case PT_INT16: return new CStreamingFileFromStringFeatures<int16_t>();
		case PT_UINT16: return new CStreamingFileFromStringFeatures<uint16_t>();
		case PT_INT32: return new CStreamingFileFromStringFeatures<int32_t>();
		case PT_UINT32: return new CStreamingFileFromStringFeatures<uint32_t>();
		case PT_INT64: return new CStreamingFileFromStringFeatures<int64_t>();
		case PT_UINT64: return new CStreamingFileFromStringFeatures<uint64_t>();
		case PT_FLOAT32: return new CStreamingFileFromStringFeatures<float32_t>();
		case PT_FLOAT64: return new CStreamingFileFromStringFeatures<float64_t>();
		case PT_FLOATMAX: return new CStreamingFileFromStringFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CBinaryStream(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CBinaryStream<bool>();
		case PT_CHAR: return new CBinaryStream<char>();
		case PT_INT8: return new CBinaryStream<int8_t>();
		case PT_UINT8: return new CBinaryStream<uint8_t>();
		case PT_INT16: return new CBinaryStream<int16_t>();
		case PT_UINT16: return new CBinaryStream<uint16_t>();
		case PT_INT32: return new CBinaryStream<int32_t>();
		case PT_UINT32: return new CBinaryStream<uint32_t>();
		case PT_INT64: return new CBinaryStream<int64_t>();
		case PT_UINT64: return new CBinaryStream<uint64_t>();
		case PT_FLOAT32: return new CBinaryStream<float32_t>();
		case PT_FLOAT64: return new CBinaryStream<float64_t>();
		case PT_FLOATMAX: return new CBinaryStream<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStreamingFileFromSparseFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStreamingFileFromSparseFeatures<bool>();
		case PT_CHAR: return new CStreamingFileFromSparseFeatures<char>();
		case PT_INT8: return new CStreamingFileFromSparseFeatures<int8_t>();
		case PT_UINT8: return new CStreamingFileFromSparseFeatures<uint8_t>();
		case PT_INT16: return new CStreamingFileFromSparseFeatures<int16_t>();
		case PT_UINT16: return new CStreamingFileFromSparseFeatures<uint16_t>();
		case PT_INT32: return new CStreamingFileFromSparseFeatures<int32_t>();
		case PT_UINT32: return new CStreamingFileFromSparseFeatures<uint32_t>();
		case PT_INT64: return new CStreamingFileFromSparseFeatures<int64_t>();
		case PT_UINT64: return new CStreamingFileFromSparseFeatures<uint64_t>();
		case PT_FLOAT32: return new CStreamingFileFromSparseFeatures<float32_t>();
		case PT_FLOAT64: return new CStreamingFileFromSparseFeatures<float64_t>();
		case PT_FLOATMAX: return new CStreamingFileFromSparseFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CStreamingFileFromSimpleFeatures(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CStreamingFileFromSimpleFeatures<bool>();
		case PT_CHAR: return new CStreamingFileFromSimpleFeatures<char>();
		case PT_INT8: return new CStreamingFileFromSimpleFeatures<int8_t>();
		case PT_UINT8: return new CStreamingFileFromSimpleFeatures<uint8_t>();
		case PT_INT16: return new CStreamingFileFromSimpleFeatures<int16_t>();
		case PT_UINT16: return new CStreamingFileFromSimpleFeatures<uint16_t>();
		case PT_INT32: return new CStreamingFileFromSimpleFeatures<int32_t>();
		case PT_UINT32: return new CStreamingFileFromSimpleFeatures<uint32_t>();
		case PT_INT64: return new CStreamingFileFromSimpleFeatures<int64_t>();
		case PT_UINT64: return new CStreamingFileFromSimpleFeatures<uint64_t>();
		case PT_FLOAT32: return new CStreamingFileFromSimpleFeatures<float32_t>();
		case PT_FLOAT64: return new CStreamingFileFromSimpleFeatures<float64_t>();
		case PT_FLOATMAX: return new CStreamingFileFromSimpleFeatures<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
static CSGObject* __new_CDecompressString(EPrimitiveType g)
{
	switch (g)
	{
		case PT_BOOL: return new CDecompressString<bool>();
		case PT_CHAR: return new CDecompressString<char>();
		case PT_INT8: return new CDecompressString<int8_t>();
		case PT_UINT8: return new CDecompressString<uint8_t>();
		case PT_INT16: return new CDecompressString<int16_t>();
		case PT_UINT16: return new CDecompressString<uint16_t>();
		case PT_INT32: return new CDecompressString<int32_t>();
		case PT_UINT32: return new CDecompressString<uint32_t>();
		case PT_INT64: return new CDecompressString<int64_t>();
		case PT_UINT64: return new CDecompressString<uint64_t>();
		case PT_FLOAT32: return new CDecompressString<float32_t>();
		case PT_FLOAT64: return new CDecompressString<float64_t>();
		case PT_FLOATMAX: return new CDecompressString<floatmax_t>();
		case PT_SGOBJECT: return NULL;
	}
	return NULL;
}
typedef CSGObject* (*new_sgserializable_t)(EPrimitiveType generic);
#ifndef DOXYGEN_SHOULD_SKIP_THIS
typedef struct
{
	const char* m_class_name;
	new_sgserializable_t m_new_sgserializable;
} class_list_entry_t;
#endif

static class_list_entry_t class_list[] = {
{"Gaussian", __new_CGaussian},
{"GHMM", __new_CGHMM},
{"HMM", __new_CHMM},
{"LinearHMM", __new_CLinearHMM},
{"Histogram", __new_CHistogram},
{"PositionalPWM", __new_CPositionalPWM},
{"HashSet", __new_CHashSet},
{"Hash", __new_CHash},
{"ListElement", __new_CListElement},
{"List", __new_CList},
{"BitString", __new_CBitString},
{"FibonacciHeap", __new_CFibonacciHeap},
{"Time", __new_CTime},
{"Signal", __new_CSignal},
{"Compressor", __new_CCompressor},
{"MeanAbsoluteError", __new_CMeanAbsoluteError},
{"CrossValidation", __new_CCrossValidation},
{"MulticlassAccuracy", __new_CMulticlassAccuracy},
{"PRCEvaluation", __new_CPRCEvaluation},
{"StratifiedCrossValidationSplitting", __new_CStratifiedCrossValidationSplitting},
{"MeanSquaredError", __new_CMeanSquaredError},
{"ROCEvaluation", __new_CROCEvaluation},
{"ContingencyTableEvaluation", __new_CContingencyTableEvaluation},
{"AccuracyMeasure", __new_CAccuracyMeasure},
{"ErrorRateMeasure", __new_CErrorRateMeasure},
{"BALMeasure", __new_CBALMeasure},
{"WRACCMeasure", __new_CWRACCMeasure},
{"F1Measure", __new_CF1Measure},
{"CrossCorrelationMeasure", __new_CCrossCorrelationMeasure},
{"RecallMeasure", __new_CRecallMeasure},
{"PrecisionMeasure", __new_CPrecisionMeasure},
{"SpecificityMeasure", __new_CSpecificityMeasure},
{"LocalTangentSpaceAlignment", __new_CLocalTangentSpaceAlignment},
{"Isomap", __new_CIsomap},
{"DiffusionMaps", __new_CDiffusionMaps},
{"LocalityPreservingProjections", __new_CLocalityPreservingProjections},
{"KernelLocalTangentSpaceAlignment", __new_CKernelLocalTangentSpaceAlignment},
{"MultidimensionalScaling", __new_CMultidimensionalScaling},
{"LocallyLinearEmbedding", __new_CLocallyLinearEmbedding},
{"LaplacianEigenmaps", __new_CLaplacianEigenmaps},
{"NeighborhoodPreservingEmbedding", __new_CNeighborhoodPreservingEmbedding},
{"LinearLocalTangentSpaceAlignment", __new_CLinearLocalTangentSpaceAlignment},
{"HessianLocallyLinearEmbedding", __new_CHessianLocallyLinearEmbedding},
{"KernelLocallyLinearEmbedding", __new_CKernelLocallyLinearEmbedding},
{"ModelSelectionParameters", __new_CModelSelectionParameters},
{"ParameterCombination", __new_CParameterCombination},
{"GridSearchModelSelection", __new_CGridSearchModelSelection},
{"KMeans", __new_CKMeans},
{"Hierarchical", __new_CHierarchical},
{"GMM", __new_CGMM},
{"Math", __new_CMath},
{"Statistics", __new_CStatistics},
{"Perceptron", __new_CPerceptron},
{"AveragedPerceptron", __new_CAveragedPerceptron},
{"LDA", __new_CLDA},
{"VwRegressor", __new_CVwRegressor},
{"VwEnvironment", __new_CVwEnvironment},
{"VwAdaptiveLearner", __new_CVwAdaptiveLearner},
{"VwNonAdaptiveLearner", __new_CVwNonAdaptiveLearner},
{"VowpalWabbit", __new_CVowpalWabbit},
{"VwNativeCacheWriter", __new_CVwNativeCacheWriter},
{"VwNativeCacheReader", __new_CVwNativeCacheReader},
{"VwParser", __new_CVwParser},
{"OnlineSVMSGD", __new_COnlineSVMSGD},
{"MPDSVM", __new_CMPDSVM},
{"MultiClassSVM", __new_CMultiClassSVM},
{"QPBSVMLib", __new_CQPBSVMLib},
{"LaRank", __new_CLaRank},
{"GMNPLib", __new_CGMNPLib},
{"SGDQN", __new_CSGDQN},
{"ScatterSVM", __new_CScatterSVM},
{"GMNPSVM", __new_CGMNPSVM},
{"SubGradientSVM", __new_CSubGradientSVM},
{"GNPPSVM", __new_CGNPPSVM},
{"LibLinear", __new_CLibLinear},
{"WDSVMOcas", __new_CWDSVMOcas},
{"LibSVMMultiClass", __new_CLibSVMMultiClass},
{"DomainAdaptationSVM", __new_CDomainAdaptationSVM},
{"LibSVM", __new_CLibSVM},
{"Tron", __new_CTron},
{"SVMLin", __new_CSVMLin},
{"GNPPLib", __new_CGNPPLib},
{"SVM", __new_CSVM},
{"LibSVMOneClass", __new_CLibSVMOneClass},
{"OnlineLibLinear", __new_COnlineLibLinear},
{"SVMLight", __new_CSVMLight},
{"GPBTSVM", __new_CGPBTSVM},
{"SVMOcas", __new_CSVMOcas},
{"SVMLightOneClass", __new_CSVMLightOneClass},
{"DomainAdaptationSVMLinear", __new_CDomainAdaptationSVMLinear},
{"SVMSGD", __new_CSVMSGD},
{"KNN", __new_CKNN},
{"PluginEstimate", __new_CPluginEstimate},
{"MKLOneClass", __new_CMKLOneClass},
{"MKLClassification", __new_CMKLClassification},
{"MKLMultiClass", __new_CMKLMultiClass},
{"GaussianNaiveBayes", __new_CGaussianNaiveBayes},
{"PlifMatrix", __new_CPlifMatrix},
{"IntronList", __new_CIntronList},
{"DynProg", __new_CDynProg},
{"SegmentLoss", __new_CSegmentLoss},
{"PlifArray", __new_CPlifArray},
{"Plif", __new_CPlif},
{"AUCKernel", __new_CAUCKernel},
{"WeightedDegreePositionStringKernel", __new_CWeightedDegreePositionStringKernel},
{"AvgDiagKernelNormalizer", __new_CAvgDiagKernelNormalizer},
{"DistanceKernel", __new_CDistanceKernel},
{"SimpleLocalityImprovedStringKernel", __new_CSimpleLocalityImprovedStringKernel},
{"GaussianShiftKernel", __new_CGaussianShiftKernel},
{"GaussianShortRealKernel", __new_CGaussianShortRealKernel},
{"Chi2Kernel", __new_CChi2Kernel},
{"SqrtDiagKernelNormalizer", __new_CSqrtDiagKernelNormalizer},
{"SphericalKernel", __new_CSphericalKernel},
{"WaveletKernel", __new_CWaveletKernel},
{"CircularKernel", __new_CCircularKernel},
{"HistogramWordStringKernel", __new_CHistogramWordStringKernel},
{"LocalAlignmentStringKernel", __new_CLocalAlignmentStringKernel},
{"ExponentialKernel", __new_CExponentialKernel},
{"ANOVAKernel", __new_CANOVAKernel},
{"DiceKernelNormalizer", __new_CDiceKernelNormalizer},
{"PolyMatchStringKernel", __new_CPolyMatchStringKernel},
{"CommUlongStringKernel", __new_CCommUlongStringKernel},
{"CauchyKernel", __new_CCauchyKernel},
{"DiagKernel", __new_CDiagKernel},
{"MultitaskKernelMaskNormalizer", __new_CMultitaskKernelMaskNormalizer},
{"WeightedCommWordStringKernel", __new_CWeightedCommWordStringKernel},
{"LinearStringKernel", __new_CLinearStringKernel},
{"VarianceKernelNormalizer", __new_CVarianceKernelNormalizer},
{"SplineKernel", __new_CSplineKernel},
{"MultitaskKernelPlifNormalizer", __new_CMultitaskKernelPlifNormalizer},
{"PolyKernel", __new_CPolyKernel},
{"MultiquadricKernel", __new_CMultiquadricKernel},
{"SigmoidKernel", __new_CSigmoidKernel},
{"MultitaskKernelNormalizer", __new_CMultitaskKernelNormalizer},
{"LocalityImprovedStringKernel", __new_CLocalityImprovedStringKernel},
{"MultitaskKernelMaskPairNormalizer", __new_CMultitaskKernelMaskPairNormalizer},
{"FixedDegreeStringKernel", __new_CFixedDegreeStringKernel},
{"OligoStringKernel", __new_COligoStringKernel},
{"LinearKernel", __new_CLinearKernel},
{"SNPStringKernel", __new_CSNPStringKernel},
{"WaveKernel", __new_CWaveKernel},
{"PowerKernel", __new_CPowerKernel},
{"SpectrumMismatchRBFKernel", __new_CSpectrumMismatchRBFKernel},
{"GaussianKernel", __new_CGaussianKernel},
{"CombinedKernel", __new_CCombinedKernel},
{"ScatterKernelNormalizer", __new_CScatterKernelNormalizer},
{"SparseSpatialSampleStringKernel", __new_CSparseSpatialSampleStringKernel},
{"ConstKernel", __new_CConstKernel},
{"Node", __new_CNode},
{"Taxonomy", __new_CTaxonomy},
{"MultitaskKernelTreeNormalizer", __new_CMultitaskKernelTreeNormalizer},
{"PolyMatchWordStringKernel", __new_CPolyMatchWordStringKernel},
{"GaussianMatchStringKernel", __new_CGaussianMatchStringKernel},
{"WeightedDegreeStringKernel", __new_CWeightedDegreeStringKernel},
{"DistantSegmentsKernel", __new_CDistantSegmentsKernel},
{"RationalQuadraticKernel", __new_CRationalQuadraticKernel},
{"InverseMultiQuadricKernel", __new_CInverseMultiQuadricKernel},
{"ZeroMeanCenterKernelNormalizer", __new_CZeroMeanCenterKernelNormalizer},
{"FirstElementKernelNormalizer", __new_CFirstElementKernelNormalizer},
{"SalzbergWordStringKernel", __new_CSalzbergWordStringKernel},
{"LogKernel", __new_CLogKernel},
{"BesselKernel", __new_CBesselKernel},
{"TensorProductPairKernel", __new_CTensorProductPairKernel},
{"HistogramIntersectionKernel", __new_CHistogramIntersectionKernel},
{"RegulatoryModulesStringKernel", __new_CRegulatoryModulesStringKernel},
{"PyramidChi2", __new_CPyramidChi2},
{"RidgeKernelNormalizer", __new_CRidgeKernelNormalizer},
{"CommWordStringKernel", __new_CCommWordStringKernel},
{"IdentityKernelNormalizer", __new_CIdentityKernelNormalizer},
{"TStudentKernel", __new_CTStudentKernel},
{"MatchWordStringKernel", __new_CMatchWordStringKernel},
{"WeightedDegreeRBFKernel", __new_CWeightedDegreeRBFKernel},
{"CustomKernel", __new_CCustomKernel},
{"SpectrumRBFKernel", __new_CSpectrumRBFKernel},
{"TanimotoKernelNormalizer", __new_CTanimotoKernelNormalizer},
{"GUIKernel", __new_CGUIKernel},
{"GUIPluginEstimate", __new_CGUIPluginEstimate},
{"GUILabels", __new_CGUILabels},
{"GUITime", __new_CGUITime},
{"GUIHMM", __new_CGUIHMM},
{"GUIPreprocessor", __new_CGUIPreprocessor},
{"GUIDistance", __new_CGUIDistance},
{"GUIMath", __new_CGUIMath},
{"GUIFeatures", __new_CGUIFeatures},
{"GUIClassifier", __new_CGUIClassifier},
{"GUIStructure", __new_CGUIStructure},
{"DistanceMachine", __new_CDistanceMachine},
{"LinearMachine", __new_CLinearMachine},
{"KernelMachine", __new_CKernelMachine},
{"OnlineLinearMachine", __new_COnlineLinearMachine},
{"HashedWDFeaturesTransposed", __new_CHashedWDFeaturesTransposed},
{"SNPFeatures", __new_CSNPFeatures},
{"CombinedFeatures", __new_CCombinedFeatures},
{"DummyFeatures", __new_CDummyFeatures},
{"Subset", __new_CSubset},
{"LBPPyrDotFeatures", __new_CLBPPyrDotFeatures},
{"TOPFeatures", __new_CTOPFeatures},
{"HashedWDFeatures", __new_CHashedWDFeatures},
{"RealFileFeatures", __new_CRealFileFeatures},
{"Labels", __new_CLabels},
{"WDFeatures", __new_CWDFeatures},
{"SparsePolyFeatures", __new_CSparsePolyFeatures},
{"StreamingVwFeatures", __new_CStreamingVwFeatures},
{"CombinedDotFeatures", __new_CCombinedDotFeatures},
{"ExplicitSpecFeatures", __new_CExplicitSpecFeatures},
{"ImplicitWeightedSpecFeatures", __new_CImplicitWeightedSpecFeatures},
{"PolyFeatures", __new_CPolyFeatures},
{"Alphabet", __new_CAlphabet},
{"FKFeatures", __new_CFKFeatures},
{"ChebyshewMetric", __new_CChebyshewMetric},
{"CosineDistance", __new_CCosineDistance},
{"HammingWordDistance", __new_CHammingWordDistance},
{"AttenuatedEuclidianDistance", __new_CAttenuatedEuclidianDistance},
{"EuclidianDistance", __new_CEuclidianDistance},
{"JensenMetric", __new_CJensenMetric},
{"KernelDistance", __new_CKernelDistance},
{"CanberraMetric", __new_CCanberraMetric},
{"BrayCurtisDistance", __new_CBrayCurtisDistance},
{"GeodesicMetric", __new_CGeodesicMetric},
{"TanimotoDistance", __new_CTanimotoDistance},
{"SparseEuclidianDistance", __new_CSparseEuclidianDistance},
{"ManhattanWordDistance", __new_CManhattanWordDistance},
{"CanberraWordDistance", __new_CCanberraWordDistance},
{"MinkowskiMetric", __new_CMinkowskiMetric},
{"ChiSquareDistance", __new_CChiSquareDistance},
{"ManhattanMetric", __new_CManhattanMetric},
{"CustomDistance", __new_CCustomDistance},
{"StreamingFile", __new_CStreamingFile},
{"StreamingAsciiFile", __new_CStreamingAsciiFile},
{"IOBuffer", __new_CIOBuffer},
{"StreamingVwFile", __new_CStreamingVwFile},
{"StreamingVwCacheFile", __new_CStreamingVwCacheFile},
{"AsciiFile", __new_CAsciiFile},
{"StreamingFileFromFeatures", __new_CStreamingFileFromFeatures},
{"SerializableAsciiFile", __new_CSerializableAsciiFile},
{"BinaryFile", __new_CBinaryFile},
{"SVRLight", __new_CSVRLight},
{"MKLRegression", __new_CMKLRegression},
{"LibSVR", __new_CLibSVR},
{"KRR", __new_CKRR},
{"SmoothHingeLoss", __new_CSmoothHingeLoss},
{"LogLoss", __new_CLogLoss},
{"SquaredHingeLoss", __new_CSquaredHingeLoss},
{"SquaredLoss", __new_CSquaredLoss},
{"LogLossMargin", __new_CLogLossMargin},
{"HingeLoss", __new_CHingeLoss},
{"DimensionReductionPreprocessor", __new_CDimensionReductionPreprocessor},
{"PCA", __new_CPCA},
{"RandomFourierGaussPreproc", __new_CRandomFourierGaussPreproc},
{"NormOne", __new_CNormOne},
{"SortWordString", __new_CSortWordString},
{"KernelPCA", __new_CKernelPCA},
{"PruneVarSubMean", __new_CPruneVarSubMean},
{"LogPlusOne", __new_CLogPlusOne},
{"SortUlongString", __new_CSortUlongString},
{"Array", __new_CArray},
{"Set", __new_CSet},
{"Cache", __new_CCache},
{"Array3", __new_CArray3},
{"Array2", __new_CArray2},
{"DynamicObjectArray", __new_CDynamicObjectArray},
{"DynamicArray", __new_CDynamicArray},
{"StringFileFeatures", __new_CStringFileFeatures},
{"StreamingSimpleFeatures", __new_CStreamingSimpleFeatures},
{"StreamingStringFeatures", __new_CStreamingStringFeatures},
{"SparseFeatures", __new_CSparseFeatures},
{"StringFeatures", __new_CStringFeatures},
{"SimpleFeatures", __new_CSimpleFeatures},
{"StreamingSparseFeatures", __new_CStreamingSparseFeatures},
{"ParseBuffer", __new_CParseBuffer},
{"SimpleFile", __new_CSimpleFile},
{"MemoryMappedFile", __new_CMemoryMappedFile},
{"StreamingFileFromStringFeatures", __new_CStreamingFileFromStringFeatures},
{"BinaryStream", __new_CBinaryStream},
{"StreamingFileFromSparseFeatures", __new_CStreamingFileFromSparseFeatures},
{"StreamingFileFromSimpleFeatures", __new_CStreamingFileFromSimpleFeatures},
{"DecompressString", __new_CDecompressString},	{NULL, NULL}
};

CSGObject* shogun::new_sgserializable(const char* sgserializable_name,
						   EPrimitiveType generic)
{
	for (class_list_entry_t* i=class_list; i->m_class_name != NULL;
		 i++)
	{
		if (strncmp(i->m_class_name, sgserializable_name, STRING_LEN) == 0)
			return i->m_new_sgserializable(generic);
	}

	return NULL;
}
