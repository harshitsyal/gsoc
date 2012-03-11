/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MultiClassSVM : SVM {
  private HandleRef swigCPtr;

  internal MultiClassSVM(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.MultiClassSVMUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MultiClassSVM obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MultiClassSVM() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_MultiClassSVM(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MultiClassSVM() : this(modshogunPINVOKE.new_MultiClassSVM__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultiClassSVM(EMultiClassSVM type) : this(modshogunPINVOKE.new_MultiClassSVM__SWIG_1((int)type), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultiClassSVM(EMultiClassSVM type, double C, Kernel k, Labels lab) : this(modshogunPINVOKE.new_MultiClassSVM__SWIG_2((int)type, C, Kernel.getCPtr(k), Labels.getCPtr(lab)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool create_multiclass_svm(int num_classes) {
    bool ret = modshogunPINVOKE.MultiClassSVM_create_multiclass_svm(swigCPtr, num_classes);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_svm(int num, SVM svm) {
    bool ret = modshogunPINVOKE.MultiClassSVM_set_svm(swigCPtr, num, SVM.getCPtr(svm));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SVM get_svm(int num) {
    IntPtr cPtr = modshogunPINVOKE.MultiClassSVM_get_svm(swigCPtr, num);
    SVM ret = (cPtr == IntPtr.Zero) ? null : new SVM(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_svms() {
    int ret = modshogunPINVOKE.MultiClassSVM_get_num_svms(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Labels apply() {
    IntPtr cPtr = modshogunPINVOKE.MultiClassSVM_apply__SWIG_0(swigCPtr);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Labels apply(Features data) {
    IntPtr cPtr = modshogunPINVOKE.MultiClassSVM_apply__SWIG_1(swigCPtr, Features.getCPtr(data));
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double apply(int num) {
    double ret = modshogunPINVOKE.MultiClassSVM_apply__SWIG_2(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Labels classify_one_vs_rest() {
    IntPtr cPtr = modshogunPINVOKE.MultiClassSVM_classify_one_vs_rest(swigCPtr);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double classify_example_one_vs_rest(int num) {
    double ret = modshogunPINVOKE.MultiClassSVM_classify_example_one_vs_rest(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Labels classify_one_vs_one() {
    IntPtr cPtr = modshogunPINVOKE.MultiClassSVM_classify_one_vs_one(swigCPtr);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double classify_example_one_vs_one(int num) {
    double ret = modshogunPINVOKE.MultiClassSVM_classify_example_one_vs_one(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EMultiClassSVM get_multiclass_type() {
    EMultiClassSVM ret = (EMultiClassSVM)modshogunPINVOKE.MultiClassSVM_get_multiclass_type(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
