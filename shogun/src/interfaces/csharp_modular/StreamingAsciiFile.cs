/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingAsciiFile : StreamingFile {
  private HandleRef swigCPtr;

  internal StreamingAsciiFile(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingAsciiFileUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingAsciiFile obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingAsciiFile() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingAsciiFile(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingAsciiFile() : this(modshogunPINVOKE.new_StreamingAsciiFile__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingAsciiFile(string fname, char rw) : this(modshogunPINVOKE.new_StreamingAsciiFile__SWIG_1(fname, rw), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingAsciiFile(string fname) : this(modshogunPINVOKE.new_StreamingAsciiFile__SWIG_2(fname), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool str_to_bool(string str) {
    bool ret = modshogunPINVOKE.StreamingAsciiFile_str_to_bool(swigCPtr, str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void get_vector(SWIGTYPE_p_bool vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_bool vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_bool vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_bool vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_bool_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_0(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_bool_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_bool_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_0(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_bool_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_unsigned_char vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_unsigned_char vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_unsigned_char vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_unsigned_char vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_char_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_1(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_char_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_char_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_1(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_char_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(string vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_2(swigCPtr, vector, SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(string vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_2(swigCPtr, vector, SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(string vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_2(swigCPtr, vector, SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(string vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_2(swigCPtr, vector, SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_char_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_2(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_char_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_char_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_2(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_char_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_int vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_int vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_int vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_int vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_3(swigCPtr, SWIGTYPE_p_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_int_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_3(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_int_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_int_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_3(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_int_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_float vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_float vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_float vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_float vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_4(swigCPtr, SWIGTYPE_p_float.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_float_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_4(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_float_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_float_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_4(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_float_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_double vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_double vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_double vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_double vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_5(swigCPtr, SWIGTYPE_p_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_double_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_5(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_double_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_double_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_5(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_double_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_short vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_short vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_6(swigCPtr, SWIGTYPE_p_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_short_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_6(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_short_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_short_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_6(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_short_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_unsigned_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_unsigned_short vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_unsigned_short vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_unsigned_short vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_7(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_short_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_7(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_short_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_short_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_7(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_short_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_signed_char vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_8(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_signed_char vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_8(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_signed_char vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_8(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_signed_char vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_8(swigCPtr, SWIGTYPE_p_signed_char.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_signed_char_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_8(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_signed_char_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_signed_char_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_8(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_signed_char_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_unsigned_int vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_9(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_unsigned_int vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_9(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_unsigned_int vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_9(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_unsigned_int vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_9(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_int_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_9(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_int_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_int_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_9(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_int_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_long_long vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_10(swigCPtr, SWIGTYPE_p_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_long_long vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_10(swigCPtr, SWIGTYPE_p_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_long_long vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_10(swigCPtr, SWIGTYPE_p_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_long_long vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_10(swigCPtr, SWIGTYPE_p_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_long_long_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_10(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_long_long_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_long_long_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_10(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_long_long_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_unsigned_long_long vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_11(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_unsigned_long_long vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_11(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_unsigned_long_long vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_11(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_unsigned_long_long vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_11(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_long_long_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_11(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_long_long_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_unsigned_long_long_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_11(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_unsigned_long_long_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector(SWIGTYPE_p_long_double vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector__SWIG_12(swigCPtr, SWIGTYPE_p_long_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_vector_and_label(SWIGTYPE_p_long_double vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_vector_and_label__SWIG_12(swigCPtr, SWIGTYPE_p_long_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string(SWIGTYPE_p_long_double vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_string__SWIG_12(swigCPtr, SWIGTYPE_p_long_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_string_and_label(SWIGTYPE_p_long_double vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_string_and_label__SWIG_12(swigCPtr, SWIGTYPE_p_long_double.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector(SWIGTYPE_p_SGSparseVectorEntryT_long_double_t vector, SWIGTYPE_p_int len) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector__SWIG_12(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_long_double_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void get_sparse_vector_and_label(SWIGTYPE_p_SGSparseVectorEntryT_long_double_t vector, SWIGTYPE_p_int len, SWIGTYPE_p_double label) {
    modshogunPINVOKE.StreamingAsciiFile_get_sparse_vector_and_label__SWIG_12(swigCPtr, SWIGTYPE_p_SGSparseVectorEntryT_long_double_t.getCPtr(vector), SWIGTYPE_p_int.getCPtr(len), SWIGTYPE_p_double.getCPtr(label));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
