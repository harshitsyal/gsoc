/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DomainAdaptationSVM : SVMLight {
  private HandleRef swigCPtr;

  internal DomainAdaptationSVM(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DomainAdaptationSVMUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DomainAdaptationSVM obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DomainAdaptationSVM() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_DomainAdaptationSVM(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DomainAdaptationSVM() : this(modshogunPINVOKE.new_DomainAdaptationSVM__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DomainAdaptationSVM(double C, Kernel k, Labels lab, SVM presvm, double B) : this(modshogunPINVOKE.new_DomainAdaptationSVM__SWIG_1(C, Kernel.getCPtr(k), Labels.getCPtr(lab), SVM.getCPtr(presvm), B), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SVM get_presvm() {
    IntPtr cPtr = modshogunPINVOKE.DomainAdaptationSVM_get_presvm(swigCPtr);
    SVM ret = (cPtr == IntPtr.Zero) ? null : new SVM(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_B() {
    double ret = modshogunPINVOKE.DomainAdaptationSVM_get_B(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_train_factor() {
    double ret = modshogunPINVOKE.DomainAdaptationSVM_get_train_factor(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_train_factor(double factor) {
    modshogunPINVOKE.DomainAdaptationSVM_set_train_factor(swigCPtr, factor);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
