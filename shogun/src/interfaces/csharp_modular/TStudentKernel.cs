/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TStudentKernel : Kernel {
  private HandleRef swigCPtr;

  internal TStudentKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.TStudentKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TStudentKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TStudentKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_TStudentKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public TStudentKernel() : this(modshogunPINVOKE.new_TStudentKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public TStudentKernel(int cache, double d, Distance dist) : this(modshogunPINVOKE.new_TStudentKernel__SWIG_1(cache, d, Distance.getCPtr(dist)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public TStudentKernel(Features l, Features r, double d, Distance dist) : this(modshogunPINVOKE.new_TStudentKernel__SWIG_2(Features.getCPtr(l), Features.getCPtr(r), d, Distance.getCPtr(dist)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_degree() {
    double ret = modshogunPINVOKE.TStudentKernel_get_degree(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_degree(double value) {
    modshogunPINVOKE.TStudentKernel_set_degree(swigCPtr, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
