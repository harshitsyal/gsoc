/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MultitaskKernelMklNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal MultitaskKernelMklNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.MultitaskKernelMklNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MultitaskKernelMklNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MultitaskKernelMklNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_MultitaskKernelMklNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual double get_beta(int idx) {
    double ret = modshogunPINVOKE.MultitaskKernelMklNormalizer_get_beta(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_beta(int idx, double weight) {
    modshogunPINVOKE.MultitaskKernelMklNormalizer_set_beta(swigCPtr, idx, weight);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int get_num_betas() {
    int ret = modshogunPINVOKE.MultitaskKernelMklNormalizer_get_num_betas(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
