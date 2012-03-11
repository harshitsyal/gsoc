/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class SparseUlongFeatures : DotFeatures {
  private HandleRef swigCPtr;

  internal SparseUlongFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.SparseUlongFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SparseUlongFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SparseUlongFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_SparseUlongFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SparseUlongFeatures(int size) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_0(size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures() : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures(ULongIntSparseVector src, int num_feat, int num_vec, bool copy) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_2(ULongIntSparseVector.getCPtr(src), num_feat, num_vec, copy), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures(ULongIntSparseVector src, int num_feat, int num_vec) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_3(ULongIntSparseVector.getCPtr(src), num_feat, num_vec), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures(ULongIntSparseMatrix sparse) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_4(ULongIntSparseMatrix.getCPtr(sparse)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures(long[,] dense) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_5(dense.GetLength(0), dense.GetLength(1), dense), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures(SparseUlongFeatures orig) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_6(SparseUlongFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseUlongFeatures(File loader) : this(modshogunPINVOKE.new_SparseUlongFeatures__SWIG_7(File.getCPtr(loader)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_sparse_feature_matrix() {
    modshogunPINVOKE.SparseUlongFeatures_free_sparse_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_sparse_features() {
    modshogunPINVOKE.SparseUlongFeatures_free_sparse_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong get_feature(int num, int index) {
    ulong ret = modshogunPINVOKE.SparseUlongFeatures_get_feature(swigCPtr, num, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long[] get_full_feature_vector(int num) {
		IntPtr ptr = modshogunPINVOKE.SparseUlongFeatures_get_full_feature_vector(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		long[] ret = new long[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public ULongIntSparseVector get_sparse_feature_vector(int num) {
    ULongIntSparseVector ret = new ULongIntSparseVector(modshogunPINVOKE.SparseUlongFeatures_get_sparse_feature_vector(swigCPtr, num), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ULongIntSparseMatrix get_sparse_feature_matrix() {
    ULongIntSparseMatrix ret = new ULongIntSparseMatrix(modshogunPINVOKE.SparseUlongFeatures_get_sparse_feature_matrix(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SparseUlongFeatures get_transposed() {
    IntPtr cPtr = modshogunPINVOKE.SparseUlongFeatures_get_transposed(swigCPtr);
    SparseUlongFeatures ret = (cPtr == IntPtr.Zero) ? null : new SparseUlongFeatures(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_sparse_feature_matrix(ULongIntSparseMatrix sm) {
    modshogunPINVOKE.SparseUlongFeatures_set_sparse_feature_matrix(swigCPtr, ULongIntSparseMatrix.getCPtr(sm));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public long[,] get_full_feature_matrix() {
	IntPtr ptr = modshogunPINVOKE.SparseUlongFeatures_get_full_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	long[] ret = new long[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	long[,] result = new long[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public virtual bool set_full_feature_matrix(long[,] full) {
    bool ret = modshogunPINVOKE.SparseUlongFeatures_set_full_feature_matrix(swigCPtr, full.GetLength(0), full.GetLength(1), full);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool apply_preprocessor(bool force_preprocessing) {
    bool ret = modshogunPINVOKE.SparseUlongFeatures_apply_preprocessor__SWIG_0(swigCPtr, force_preprocessing);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool apply_preprocessor() {
    bool ret = modshogunPINVOKE.SparseUlongFeatures_apply_preprocessor__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool obtain_from_simple(ULongIntFeatures sf) {
    bool ret = modshogunPINVOKE.SparseUlongFeatures_obtain_from_simple(swigCPtr, ULongIntFeatures.getCPtr(sf));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_features() {
    int ret = modshogunPINVOKE.SparseUlongFeatures_get_num_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int set_num_features(int num) {
    int ret = modshogunPINVOKE.SparseUlongFeatures_set_num_features(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long get_num_nonzero_entries() {
    long ret = modshogunPINVOKE.SparseUlongFeatures_get_num_nonzero_entries(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Labels load_svmlight_file(string fname, bool do_sort_features) {
    IntPtr cPtr = modshogunPINVOKE.SparseUlongFeatures_load_svmlight_file__SWIG_0(swigCPtr, fname, do_sort_features);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Labels load_svmlight_file(string fname) {
    IntPtr cPtr = modshogunPINVOKE.SparseUlongFeatures_load_svmlight_file__SWIG_1(swigCPtr, fname);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sort_features() {
    modshogunPINVOKE.SparseUlongFeatures_sort_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool write_svmlight_file(string fname, Labels label) {
    bool ret = modshogunPINVOKE.SparseUlongFeatures_write_svmlight_file(swigCPtr, fname, Labels.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
