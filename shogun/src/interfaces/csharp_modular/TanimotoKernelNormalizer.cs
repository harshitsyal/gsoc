/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TanimotoKernelNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal TanimotoKernelNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.TanimotoKernelNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TanimotoKernelNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TanimotoKernelNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_TanimotoKernelNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public TanimotoKernelNormalizer(bool use_opt_diag) : this(modshogunPINVOKE.new_TanimotoKernelNormalizer__SWIG_0(use_opt_diag), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public TanimotoKernelNormalizer() : this(modshogunPINVOKE.new_TanimotoKernelNormalizer__SWIG_1(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool alloc_and_compute_diag(Kernel k, SWIGTYPE_p_double v, int num) {
    bool ret = modshogunPINVOKE.TanimotoKernelNormalizer_alloc_and_compute_diag(swigCPtr, Kernel.getCPtr(k), SWIGTYPE_p_double.getCPtr(v), num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
