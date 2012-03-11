/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ScatterKernelNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal ScatterKernelNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.ScatterKernelNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ScatterKernelNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ScatterKernelNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_ScatterKernelNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ScatterKernelNormalizer() : this(modshogunPINVOKE.new_ScatterKernelNormalizer__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ScatterKernelNormalizer(double const_diag, double const_offdiag, Labels labels, KernelNormalizer normalizer) : this(modshogunPINVOKE.new_ScatterKernelNormalizer__SWIG_1(const_diag, const_offdiag, Labels.getCPtr(labels), KernelNormalizer.getCPtr(normalizer)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ScatterKernelNormalizer(double const_diag, double const_offdiag, Labels labels) : this(modshogunPINVOKE.new_ScatterKernelNormalizer__SWIG_2(const_diag, const_offdiag, Labels.getCPtr(labels)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_testing_class() {
    int ret = modshogunPINVOKE.ScatterKernelNormalizer_get_testing_class(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_testing_class(int c) {
    modshogunPINVOKE.ScatterKernelNormalizer_set_testing_class(swigCPtr, c);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
