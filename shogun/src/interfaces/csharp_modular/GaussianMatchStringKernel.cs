/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GaussianMatchStringKernel : StringCharKernel {
  private HandleRef swigCPtr;

  internal GaussianMatchStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.GaussianMatchStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GaussianMatchStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GaussianMatchStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_GaussianMatchStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public GaussianMatchStringKernel() : this(modshogunPINVOKE.new_GaussianMatchStringKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public GaussianMatchStringKernel(int size, double width) : this(modshogunPINVOKE.new_GaussianMatchStringKernel__SWIG_1(size, width), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public GaussianMatchStringKernel(StringCharFeatures l, StringCharFeatures r, double width) : this(modshogunPINVOKE.new_GaussianMatchStringKernel__SWIG_2(StringCharFeatures.getCPtr(l), StringCharFeatures.getCPtr(r), width), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void register_params() {
    modshogunPINVOKE.GaussianMatchStringKernel_register_params(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
