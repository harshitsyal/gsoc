/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class File : SGObject {
  private HandleRef swigCPtr;

  internal File(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.FileUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(File obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~File() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_File(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public void close() {
    modshogunPINVOKE.File_close(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_FILE get_file_descriptor() {
    IntPtr cPtr = modshogunPINVOKE.File_get_file_descriptor(swigCPtr);
    SWIGTYPE_p_FILE ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_FILE(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_variable_name(string name) {
    modshogunPINVOKE.File_set_variable_name(swigCPtr, name);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_variable_name() {
    string ret = modshogunPINVOKE.File_get_variable_name(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void get_vector(SWIGTYPE_p_bool vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(SWIGTYPE_p_unsigned_char vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(string vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_2(swigCPtr, vector, SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(SWIGTYPE_p_int vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(SWIGTYPE_p_double vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(SWIGTYPE_p_float vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_5(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(SWIGTYPE_p_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_vector(SWIGTYPE_p_unsigned_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.File_get_vector__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_bool matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_unsigned_char matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_int8_matrix(SWIGTYPE_p_signed_char matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_int8_matrix(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(string matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_2(swigCPtr, matrix, SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_int matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_uint_matrix(SWIGTYPE_p_unsigned_int matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_uint_matrix(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_long_matrix(SWIGTYPE_p_long_long matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_long_matrix(swigCPtr, SWIGTYPE_p_long_long.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ulong_matrix(SWIGTYPE_p_unsigned_long_long matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_ulong_matrix(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_float matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_double matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_longreal_matrix(SWIGTYPE_p_long_double matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_longreal_matrix(swigCPtr, SWIGTYPE_p_long_double.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_short matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_matrix(SWIGTYPE_p_unsigned_short matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_matrix__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(SWIGTYPE_p_unsigned_char array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(string array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_1(swigCPtr, array, SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(SWIGTYPE_p_int array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(SWIGTYPE_p_float array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_3(swigCPtr, SWIGTYPE_p_float.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(SWIGTYPE_p_double array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_4(swigCPtr, SWIGTYPE_p_double.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(SWIGTYPE_p_short array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_5(swigCPtr, SWIGTYPE_p_short.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ndarray(SWIGTYPE_p_unsigned_short array, SWIGTYPE_p_int dims, SWIGTYPE_p_int num_dims) {
    modshogunPINVOKE.File_get_ndarray__SWIG_6(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(array), SWIGTYPE_p_int.getCPtr(dims), SWIGTYPE_p_int.getCPtr(num_dims));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(BoolSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_0(swigCPtr, BoolSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(ByteSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_1(swigCPtr, ByteSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_int8_sparsematrix(SWIGTYPE_p_shogun__SGSparseVectorT_signed_char_t matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_int8_sparsematrix(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_signed_char_t.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(CharSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_2(swigCPtr, CharSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(IntSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_3(swigCPtr, IntSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_uint_sparsematrix(SWIGTYPE_p_shogun__SGSparseVectorT_unsigned_int_t matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_uint_sparsematrix(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_unsigned_int_t.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_long_sparsematrix(LongIntSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_long_sparsematrix(swigCPtr, LongIntSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ulong_sparsematrix(ULongIntSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_ulong_sparsematrix(swigCPtr, ULongIntSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(SWIGTYPE_p_shogun__SGSparseVectorT_short_t matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_short_t.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(WordSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_5(swigCPtr, WordSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(ShortRealSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_6(swigCPtr, ShortRealSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_sparse_matrix(RealSparseVector matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_sparse_matrix__SWIG_7(swigCPtr, RealSparseVector.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_longreal_sparsematrix(SWIGTYPE_p_shogun__SGSparseVectorT_long_double_t matrix, SWIGTYPE_p_int num_feat, SWIGTYPE_p_int num_vec) {
    modshogunPINVOKE.File_get_longreal_sparsematrix(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_long_double_t.getCPtr(matrix), SWIGTYPE_p_int.getCPtr(num_feat), SWIGTYPE_p_int.getCPtr(num_vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_bool_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_0(swigCPtr, SWIGTYPE_p_shogun__SGStringT_bool_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_char_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_1(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_char_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_int8_string_list(SWIGTYPE_p_shogun__SGStringT_signed_char_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_int8_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_signed_char_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_char_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_2(swigCPtr, SWIGTYPE_p_shogun__SGStringT_char_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_int_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_3(swigCPtr, SWIGTYPE_p_shogun__SGStringT_int_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_uint_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_int_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_uint_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_int_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_short_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGStringT_short_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_short_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_5(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_short_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_long_string_list(SWIGTYPE_p_shogun__SGStringT_long_long_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_long_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_long_long_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_ulong_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_ulong_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_float_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_6(swigCPtr, SWIGTYPE_p_shogun__SGStringT_float_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_string_list(SWIGTYPE_p_shogun__SGStringT_double_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_string_list__SWIG_7(swigCPtr, SWIGTYPE_p_shogun__SGStringT_double_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void get_longreal_string_list(SWIGTYPE_p_shogun__SGStringT_long_double_t strings, SWIGTYPE_p_int num_str, SWIGTYPE_p_int max_string_len) {
    modshogunPINVOKE.File_get_longreal_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_long_double_t.getCPtr(strings), SWIGTYPE_p_int.getCPtr(num_str), SWIGTYPE_p_int.getCPtr(max_string_len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_bool vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_unsigned_char vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(string vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_2(swigCPtr, vector, len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_int vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_float vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_double vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_short vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_vector(SWIGTYPE_p_unsigned_short vector, int len) {
    modshogunPINVOKE.File_set_vector__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), len);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_bool matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_unsigned_char matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_int8_matrix(SWIGTYPE_p_signed_char matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_int8_matrix(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(string matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_2(swigCPtr, matrix, num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_int matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_uint_matrix(SWIGTYPE_p_unsigned_int matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_uint_matrix(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_long_matrix(SWIGTYPE_p_long_long matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_long_matrix(swigCPtr, SWIGTYPE_p_long_long.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ulong_matrix(SWIGTYPE_p_unsigned_long_long matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_ulong_matrix(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_float matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_double matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_longreal_matrix(SWIGTYPE_p_long_double matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_longreal_matrix(swigCPtr, SWIGTYPE_p_long_double.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_short matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_matrix(SWIGTYPE_p_unsigned_short matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_matrix__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(BoolSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_0(swigCPtr, BoolSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(ByteSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_1(swigCPtr, ByteSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_int8_sparsematrix(SWIGTYPE_p_shogun__SGSparseVectorT_signed_char_t matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_int8_sparsematrix(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_signed_char_t.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(CharSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_2(swigCPtr, CharSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(IntSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_3(swigCPtr, IntSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_uint_sparsematrix(SWIGTYPE_p_shogun__SGSparseVectorT_unsigned_int_t matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_uint_sparsematrix(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_unsigned_int_t.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_long_sparsematrix(LongIntSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_long_sparsematrix(swigCPtr, LongIntSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ulong_sparsematrix(ULongIntSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_ulong_sparsematrix(swigCPtr, ULongIntSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(SWIGTYPE_p_shogun__SGSparseVectorT_short_t matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_short_t.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(WordSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_5(swigCPtr, WordSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(ShortRealSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_6(swigCPtr, ShortRealSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_sparse_matrix(RealSparseVector matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_sparse_matrix__SWIG_7(swigCPtr, RealSparseVector.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_longreal_sparsematrix(SWIGTYPE_p_shogun__SGSparseVectorT_long_double_t matrix, int num_feat, int num_vec) {
    modshogunPINVOKE.File_set_longreal_sparsematrix(swigCPtr, SWIGTYPE_p_shogun__SGSparseVectorT_long_double_t.getCPtr(matrix), num_feat, num_vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_bool_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_0(swigCPtr, SWIGTYPE_p_shogun__SGStringT_bool_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_char_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_1(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_char_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_int8_string_list(SWIGTYPE_p_shogun__SGStringT_signed_char_t strings, int num_str) {
    modshogunPINVOKE.File_set_int8_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_signed_char_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_char_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_2(swigCPtr, SWIGTYPE_p_shogun__SGStringT_char_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_int_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_3(swigCPtr, SWIGTYPE_p_shogun__SGStringT_int_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_uint_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_int_t strings, int num_str) {
    modshogunPINVOKE.File_set_uint_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_int_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_short_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_4(swigCPtr, SWIGTYPE_p_shogun__SGStringT_short_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_short_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_5(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_short_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_long_string_list(SWIGTYPE_p_shogun__SGStringT_long_long_t strings, int num_str) {
    modshogunPINVOKE.File_set_long_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_long_long_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_ulong_string_list(SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t strings, int num_str) {
    modshogunPINVOKE.File_set_ulong_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_unsigned_long_long_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_float_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_6(swigCPtr, SWIGTYPE_p_shogun__SGStringT_float_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_string_list(SWIGTYPE_p_shogun__SGStringT_double_t strings, int num_str) {
    modshogunPINVOKE.File_set_string_list__SWIG_7(swigCPtr, SWIGTYPE_p_shogun__SGStringT_double_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_longreal_string_list(SWIGTYPE_p_shogun__SGStringT_long_double_t strings, int num_str) {
    modshogunPINVOKE.File_set_longreal_string_list(swigCPtr, SWIGTYPE_p_shogun__SGStringT_long_double_t.getCPtr(strings), num_str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}