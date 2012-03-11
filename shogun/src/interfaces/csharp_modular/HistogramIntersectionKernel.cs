/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class HistogramIntersectionKernel : DotKernel {
  private HandleRef swigCPtr;

  internal HistogramIntersectionKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.HistogramIntersectionKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HistogramIntersectionKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HistogramIntersectionKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_HistogramIntersectionKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HistogramIntersectionKernel() : this(modshogunPINVOKE.new_HistogramIntersectionKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HistogramIntersectionKernel(int size) : this(modshogunPINVOKE.new_HistogramIntersectionKernel__SWIG_1(size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HistogramIntersectionKernel(RealFeatures l, RealFeatures r, double beta, int size) : this(modshogunPINVOKE.new_HistogramIntersectionKernel__SWIG_2(RealFeatures.getCPtr(l), RealFeatures.getCPtr(r), beta, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HistogramIntersectionKernel(RealFeatures l, RealFeatures r, double beta) : this(modshogunPINVOKE.new_HistogramIntersectionKernel__SWIG_3(RealFeatures.getCPtr(l), RealFeatures.getCPtr(r), beta), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HistogramIntersectionKernel(RealFeatures l, RealFeatures r) : this(modshogunPINVOKE.new_HistogramIntersectionKernel__SWIG_4(RealFeatures.getCPtr(l), RealFeatures.getCPtr(r)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void register_params() {
    modshogunPINVOKE.HistogramIntersectionKernel_register_params(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_beta() {
    double ret = modshogunPINVOKE.HistogramIntersectionKernel_get_beta(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_beta(double beta) {
    modshogunPINVOKE.HistogramIntersectionKernel_set_beta(swigCPtr, beta);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
