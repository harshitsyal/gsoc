/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PolyMatchStringKernel : StringCharKernel {
  private HandleRef swigCPtr;

  internal PolyMatchStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.PolyMatchStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PolyMatchStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PolyMatchStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_PolyMatchStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PolyMatchStringKernel() : this(modshogunPINVOKE.new_PolyMatchStringKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public PolyMatchStringKernel(int size, int degree, bool inhomogene) : this(modshogunPINVOKE.new_PolyMatchStringKernel__SWIG_1(size, degree, inhomogene), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public PolyMatchStringKernel(StringCharFeatures l, StringCharFeatures r, int degree, bool inhomogene) : this(modshogunPINVOKE.new_PolyMatchStringKernel__SWIG_2(StringCharFeatures.getCPtr(l), StringCharFeatures.getCPtr(r), degree, inhomogene), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_rescaling_enabled(bool n) {
    modshogunPINVOKE.PolyMatchStringKernel_set_rescaling_enabled(swigCPtr, n);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_rescaling_enabled() {
    bool ret = modshogunPINVOKE.PolyMatchStringKernel_get_rescaling_enabled(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
