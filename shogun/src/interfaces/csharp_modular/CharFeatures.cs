/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CharFeatures : DotFeatures {
  private HandleRef swigCPtr;

  internal CharFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CharFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CharFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CharFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CharFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CharFeatures(int size) : this(modshogunPINVOKE.new_CharFeatures__SWIG_0(size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CharFeatures() : this(modshogunPINVOKE.new_CharFeatures__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CharFeatures(CharFeatures orig) : this(modshogunPINVOKE.new_CharFeatures__SWIG_2(CharFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CharFeatures(byte[,] matrix) : this(modshogunPINVOKE.new_CharFeatures__SWIG_3(matrix.GetLength(0), matrix.GetLength(1), matrix), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CharFeatures(File loader) : this(modshogunPINVOKE.new_CharFeatures__SWIG_4(File.getCPtr(loader)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_feature_matrix() {
    modshogunPINVOKE.CharFeatures_free_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_features() {
    modshogunPINVOKE.CharFeatures_free_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_feature_vector(byte[] vector, int num) {
    modshogunPINVOKE.CharFeatures_set_feature_vector(swigCPtr, vector.Length, vector, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte[] get_feature_vector(int num) {
		IntPtr ptr = modshogunPINVOKE.CharFeatures_get_feature_vector(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		byte[] ret = new byte[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public byte[,] get_feature_matrix() {
	IntPtr ptr = modshogunPINVOKE.CharFeatures_get_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	byte[] ret = new byte[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	byte[,] result = new byte[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public byte[,] steal_feature_matrix() {
	IntPtr ptr = modshogunPINVOKE.CharFeatures_steal_feature_matrix(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
	int[] ranks = new int[2];
	Marshal.Copy(ptr, ranks, 0, 2);

	int rows = ranks[0];
	int cols = ranks[1];
	int len = rows * cols;

	byte[] ret = new byte[len];

	Marshal.Copy(new IntPtr(ptr.ToInt64() + 2 * Marshal.SizeOf(typeof(int))), ret, 0, len);

	byte[,] result = new byte[rows, cols];
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			result[i, j] = ret[i * cols + j];
		}
	}
	return result;
}

  public void set_feature_matrix(byte[,] matrix) {
    modshogunPINVOKE.CharFeatures_set_feature_matrix(swigCPtr, matrix.GetLength(0), matrix.GetLength(1), matrix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CharFeatures get_transposed() {
    IntPtr cPtr = modshogunPINVOKE.CharFeatures_get_transposed(swigCPtr);
    CharFeatures ret = (cPtr == IntPtr.Zero) ? null : new CharFeatures(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void copy_feature_matrix(byte[,] src) {
    modshogunPINVOKE.CharFeatures_copy_feature_matrix(swigCPtr, src.GetLength(0), src.GetLength(1), src);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void obtain_from_dot(DotFeatures df) {
    modshogunPINVOKE.CharFeatures_obtain_from_dot(swigCPtr, DotFeatures.getCPtr(df));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool apply_preprocessor(bool force_preprocessing) {
    bool ret = modshogunPINVOKE.CharFeatures_apply_preprocessor__SWIG_0(swigCPtr, force_preprocessing);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool apply_preprocessor() {
    bool ret = modshogunPINVOKE.CharFeatures_apply_preprocessor__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_features() {
    int ret = modshogunPINVOKE.CharFeatures_get_num_features(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_num_features(int num) {
    modshogunPINVOKE.CharFeatures_set_num_features(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_num_vectors(int num) {
    modshogunPINVOKE.CharFeatures_set_num_vectors(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initialize_cache() {
    modshogunPINVOKE.CharFeatures_initialize_cache(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool Align_char_features(StringCharFeatures cf, StringCharFeatures Ref, double gapCost) {
    bool ret = modshogunPINVOKE.CharFeatures_Align_char_features(swigCPtr, StringCharFeatures.getCPtr(cf), StringCharFeatures.getCPtr(Ref), gapCost);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}