/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Machine : SGObject {
  private HandleRef swigCPtr;

  internal Machine(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.MachineUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Machine obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Machine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_Machine(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual bool train(Features data) {
    bool ret = modshogunPINVOKE.Machine_train__SWIG_0(swigCPtr, Features.getCPtr(data));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool train() {
    bool ret = modshogunPINVOKE.Machine_train__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Labels apply() {
    IntPtr cPtr = modshogunPINVOKE.Machine_apply__SWIG_0(swigCPtr);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Labels apply(Features data) {
    IntPtr cPtr = modshogunPINVOKE.Machine_apply__SWIG_1(swigCPtr, Features.getCPtr(data));
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double apply(int num) {
    double ret = modshogunPINVOKE.Machine_apply__SWIG_2(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool load(SWIGTYPE_p_FILE srcfile) {
    bool ret = modshogunPINVOKE.Machine_load(swigCPtr, SWIGTYPE_p_FILE.getCPtr(srcfile));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool save(SWIGTYPE_p_FILE dstfile) {
    bool ret = modshogunPINVOKE.Machine_save(swigCPtr, SWIGTYPE_p_FILE.getCPtr(dstfile));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_labels(Labels lab) {
    modshogunPINVOKE.Machine_set_labels(swigCPtr, Labels.getCPtr(lab));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Labels get_labels() {
    IntPtr cPtr = modshogunPINVOKE.Machine_get_labels(swigCPtr);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_label(int i) {
    double ret = modshogunPINVOKE.Machine_get_label(swigCPtr, i);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_max_train_time(double t) {
    modshogunPINVOKE.Machine_set_max_train_time(swigCPtr, t);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_max_train_time() {
    double ret = modshogunPINVOKE.Machine_get_max_train_time(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual EClassifierType get_classifier_type() {
    EClassifierType ret = (EClassifierType)modshogunPINVOKE.Machine_get_classifier_type(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_solver_type(ESolverType st) {
    modshogunPINVOKE.Machine_set_solver_type(swigCPtr, (int)st);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public ESolverType get_solver_type() {
    ESolverType ret = (ESolverType)modshogunPINVOKE.Machine_get_solver_type(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_store_model_features(bool store_model) {
    modshogunPINVOKE.Machine_set_store_model_features(swigCPtr, store_model);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}