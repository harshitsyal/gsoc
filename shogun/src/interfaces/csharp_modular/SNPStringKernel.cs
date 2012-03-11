/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class SNPStringKernel : StringCharKernel {
  private HandleRef swigCPtr;

  internal SNPStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.SNPStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SNPStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SNPStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_SNPStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SNPStringKernel() : this(modshogunPINVOKE.new_SNPStringKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SNPStringKernel(int size, int degree, int win_len, bool inhomogene) : this(modshogunPINVOKE.new_SNPStringKernel__SWIG_1(size, degree, win_len, inhomogene), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SNPStringKernel(StringCharFeatures l, StringCharFeatures r, int degree, int win_len, bool inhomogene) : this(modshogunPINVOKE.new_SNPStringKernel__SWIG_2(StringCharFeatures.getCPtr(l), StringCharFeatures.getCPtr(r), degree, win_len, inhomogene), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_minor_base_string(string str) {
    modshogunPINVOKE.SNPStringKernel_set_minor_base_string(swigCPtr, str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_major_base_string(string str) {
    modshogunPINVOKE.SNPStringKernel_set_major_base_string(swigCPtr, str);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_minor_base_string() {
    string ret = modshogunPINVOKE.SNPStringKernel_get_minor_base_string(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_major_base_string() {
    string ret = modshogunPINVOKE.SNPStringKernel_get_major_base_string(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void obtain_base_strings() {
    modshogunPINVOKE.SNPStringKernel_obtain_base_strings(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void register_params() {
    modshogunPINVOKE.SNPStringKernel_register_params(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
