/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Distribution : SGObject {
  private HandleRef swigCPtr;

  internal Distribution(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DistributionUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Distribution obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Distribution() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_Distribution(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual bool train(Features data) {
    bool ret = modshogunPINVOKE.Distribution_train__SWIG_0(swigCPtr, Features.getCPtr(data));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool train() {
    bool ret = modshogunPINVOKE.Distribution_train__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int get_num_model_parameters() {
    int ret = modshogunPINVOKE.Distribution_get_num_model_parameters(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int get_num_relevant_model_parameters() {
    int ret = modshogunPINVOKE.Distribution_get_num_relevant_model_parameters(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_log_model_parameter(int num_param) {
    double ret = modshogunPINVOKE.Distribution_get_log_model_parameter(swigCPtr, num_param);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_log_derivative(int num_param, int num_example) {
    double ret = modshogunPINVOKE.Distribution_get_log_derivative(swigCPtr, num_param, num_example);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_log_likelihood_example(int num_example) {
    double ret = modshogunPINVOKE.Distribution_get_log_likelihood_example(swigCPtr, num_example);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_log_likelihood_sample() {
    double ret = modshogunPINVOKE.Distribution_get_log_likelihood_sample(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double[] get_log_likelihood() {
		IntPtr ptr = modshogunPINVOKE.Distribution_get_log_likelihood(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		double[] ret = new double[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public virtual double get_model_parameter(int num_param) {
    double ret = modshogunPINVOKE.Distribution_get_model_parameter(swigCPtr, num_param);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_derivative(int num_param, int num_example) {
    double ret = modshogunPINVOKE.Distribution_get_derivative(swigCPtr, num_param, num_example);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double get_likelihood_example(int num_example) {
    double ret = modshogunPINVOKE.Distribution_get_likelihood_example(swigCPtr, num_example);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_features(Features f) {
    modshogunPINVOKE.Distribution_set_features(swigCPtr, Features.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Features get_features() {
    IntPtr cPtr = modshogunPINVOKE.Distribution_get_features(swigCPtr);
    Features ret = (cPtr == IntPtr.Zero) ? null : new Features(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_pseudo_count(double pseudo) {
    modshogunPINVOKE.Distribution_set_pseudo_count(swigCPtr, pseudo);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double get_pseudo_count() {
    double ret = modshogunPINVOKE.Distribution_get_pseudo_count(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}