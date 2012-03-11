/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MultitaskKernelMaskNormalizer : KernelNormalizer {
  private HandleRef swigCPtr;

  internal MultitaskKernelMaskNormalizer(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.MultitaskKernelMaskNormalizerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MultitaskKernelMaskNormalizer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MultitaskKernelMaskNormalizer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_MultitaskKernelMaskNormalizer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MultitaskKernelMaskNormalizer() : this(modshogunPINVOKE.new_MultitaskKernelMaskNormalizer__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultitaskKernelMaskNormalizer(SWIGTYPE_p_std__vectorT_int_t task_lhs, SWIGTYPE_p_std__vectorT_int_t task_rhs, SWIGTYPE_p_std__vectorT_int_t active_tasks_vec) : this(modshogunPINVOKE.new_MultitaskKernelMaskNormalizer__SWIG_1(SWIGTYPE_p_std__vectorT_int_t.getCPtr(task_lhs), SWIGTYPE_p_std__vectorT_int_t.getCPtr(task_rhs), SWIGTYPE_p_std__vectorT_int_t.getCPtr(active_tasks_vec)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_int_t get_task_vector_lhs() {
    SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(modshogunPINVOKE.MultitaskKernelMaskNormalizer_get_task_vector_lhs(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_task_vector_lhs(SWIGTYPE_p_std__vectorT_int_t vec) {
    modshogunPINVOKE.MultitaskKernelMaskNormalizer_set_task_vector_lhs(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_int_t get_task_vector_rhs() {
    SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(modshogunPINVOKE.MultitaskKernelMaskNormalizer_get_task_vector_rhs(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_task_vector_rhs(SWIGTYPE_p_std__vectorT_int_t vec) {
    modshogunPINVOKE.MultitaskKernelMaskNormalizer_set_task_vector_rhs(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_task_vector(SWIGTYPE_p_std__vectorT_int_t vec) {
    modshogunPINVOKE.MultitaskKernelMaskNormalizer_set_task_vector(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vec));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_similarity(int task_lhs, int task_rhs) {
    double ret = modshogunPINVOKE.MultitaskKernelMaskNormalizer_get_similarity(swigCPtr, task_lhs, task_rhs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_int_t get_active_tasks() {
    SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(modshogunPINVOKE.MultitaskKernelMaskNormalizer_get_active_tasks(swigCPtr), true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_normalization_constant() {
    double ret = modshogunPINVOKE.MultitaskKernelMaskNormalizer_get_normalization_constant(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double set_normalization_constant(double constant) {
    double ret = modshogunPINVOKE.MultitaskKernelMaskNormalizer_set_normalization_constant(swigCPtr, constant);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MultitaskKernelMaskNormalizer KernelNormalizerToMultitaskKernelMaskNormalizer(KernelNormalizer n) {
    IntPtr cPtr = modshogunPINVOKE.MultitaskKernelMaskNormalizer_KernelNormalizerToMultitaskKernelMaskNormalizer(swigCPtr, KernelNormalizer.getCPtr(n));
    MultitaskKernelMaskNormalizer ret = (cPtr == IntPtr.Zero) ? null : new MultitaskKernelMaskNormalizer(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
