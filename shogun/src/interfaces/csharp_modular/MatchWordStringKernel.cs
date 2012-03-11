/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MatchWordStringKernel : StringWordKernel {
  private HandleRef swigCPtr;

  internal MatchWordStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.MatchWordStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MatchWordStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MatchWordStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_MatchWordStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MatchWordStringKernel() : this(modshogunPINVOKE.new_MatchWordStringKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public MatchWordStringKernel(int size, int d) : this(modshogunPINVOKE.new_MatchWordStringKernel__SWIG_1(size, d), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public MatchWordStringKernel(StringWordFeatures l, StringWordFeatures r, int degree) : this(modshogunPINVOKE.new_MatchWordStringKernel__SWIG_2(StringWordFeatures.getCPtr(l), StringWordFeatures.getCPtr(r), degree), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
