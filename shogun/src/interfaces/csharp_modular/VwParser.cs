/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class VwParser : SGObject {
  private HandleRef swigCPtr;

  internal VwParser(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.VwParserUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(VwParser obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~VwParser() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_VwParser(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public VwParser() : this(modshogunPINVOKE.new_VwParser__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public VwParser(SWIGTYPE_p_CVwEnvironment env_to_use) : this(modshogunPINVOKE.new_VwParser__SWIG_1(SWIGTYPE_p_CVwEnvironment.getCPtr(env_to_use)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_CVwEnvironment get_env() {
    IntPtr cPtr = modshogunPINVOKE.VwParser_get_env(swigCPtr);
    SWIGTYPE_p_CVwEnvironment ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_CVwEnvironment(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_env(SWIGTYPE_p_CVwEnvironment env_to_use) {
    modshogunPINVOKE.VwParser_set_env(swigCPtr, SWIGTYPE_p_CVwEnvironment.getCPtr(env_to_use));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_cache_parameters(string fname, SWIGTYPE_p_EVwCacheType type) {
    modshogunPINVOKE.VwParser_set_cache_parameters__SWIG_0(swigCPtr, fname, SWIGTYPE_p_EVwCacheType.getCPtr(type));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_cache_parameters(string fname) {
    modshogunPINVOKE.VwParser_set_cache_parameters__SWIG_1(swigCPtr, fname);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_EVwCacheType get_cache_type() {
    SWIGTYPE_p_EVwCacheType ret = new SWIGTYPE_p_EVwCacheType(modshogunPINVOKE.VwParser_get_cache_type(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_write_cache(bool wr_cache) {
    modshogunPINVOKE.VwParser_set_write_cache(swigCPtr, wr_cache);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_write_cache() {
    bool ret = modshogunPINVOKE.VwParser_get_write_cache(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_mm(double label) {
    modshogunPINVOKE.VwParser_set_mm(swigCPtr, label);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void noop_mm(double label) {
    modshogunPINVOKE.VwParser_noop_mm(swigCPtr, label);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_minmax(double label) {
    modshogunPINVOKE.VwParser_set_minmax(swigCPtr, label);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int read_features(SWIGTYPE_p_CIOBuffer buf, SWIGTYPE_p_VwExample ex) {
    int ret = modshogunPINVOKE.VwParser_read_features(swigCPtr, SWIGTYPE_p_CIOBuffer.getCPtr(buf), SWIGTYPE_p_VwExample.getCPtr(ex));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int read_svmlight_features(SWIGTYPE_p_CIOBuffer buf, SWIGTYPE_p_VwExample ae) {
    int ret = modshogunPINVOKE.VwParser_read_svmlight_features(swigCPtr, SWIGTYPE_p_CIOBuffer.getCPtr(buf), SWIGTYPE_p_VwExample.getCPtr(ae));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int read_dense_features(SWIGTYPE_p_CIOBuffer buf, SWIGTYPE_p_VwExample ae) {
    int ret = modshogunPINVOKE.VwParser_read_dense_features(swigCPtr, SWIGTYPE_p_CIOBuffer.getCPtr(buf), SWIGTYPE_p_VwExample.getCPtr(ae));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_hash_func_t hasher {
    set {
      modshogunPINVOKE.VwParser_hasher_set(swigCPtr, SWIGTYPE_p_hash_func_t.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_hash_func_t ret = new SWIGTYPE_p_hash_func_t(modshogunPINVOKE.VwParser_hasher_get(swigCPtr), true);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
