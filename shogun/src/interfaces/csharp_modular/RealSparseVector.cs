/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RealSparseVector : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RealSparseVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RealSparseVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RealSparseVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_RealSparseVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public RealSparseVector() : this(modshogunPINVOKE.new_RealSparseVector__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RealSparseVector(SWIGTYPE_p_shogun__SGSparseVectorEntryT_double_t feats, int num_entries, int index, bool free_v) : this(modshogunPINVOKE.new_RealSparseVector__SWIG_1(SWIGTYPE_p_shogun__SGSparseVectorEntryT_double_t.getCPtr(feats), num_entries, index, free_v), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RealSparseVector(SWIGTYPE_p_shogun__SGSparseVectorEntryT_double_t feats, int num_entries, int index) : this(modshogunPINVOKE.new_RealSparseVector__SWIG_2(SWIGTYPE_p_shogun__SGSparseVectorEntryT_double_t.getCPtr(feats), num_entries, index), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RealSparseVector(int num_entries, int index, bool free_v) : this(modshogunPINVOKE.new_RealSparseVector__SWIG_3(num_entries, index, free_v), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RealSparseVector(int num_entries, int index) : this(modshogunPINVOKE.new_RealSparseVector__SWIG_4(num_entries, index), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RealSparseVector(RealSparseVector orig) : this(modshogunPINVOKE.new_RealSparseVector__SWIG_5(RealSparseVector.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_vector() {
    modshogunPINVOKE.RealSparseVector_free_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroy_vector() {
    modshogunPINVOKE.RealSparseVector_destroy_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int vec_index {
    set {
      modshogunPINVOKE.RealSparseVector_vec_index_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.RealSparseVector_vec_index_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int num_feat_entries {
    set {
      modshogunPINVOKE.RealSparseVector_num_feat_entries_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.RealSparseVector_num_feat_entries_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool do_free {
    set {
      modshogunPINVOKE.RealSparseVector_do_free_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = modshogunPINVOKE.RealSparseVector_do_free_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool save_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.RealSparseVector_save_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.RealSparseVector_save_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.RealSparseVector_load_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.RealSparseVector_load_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}