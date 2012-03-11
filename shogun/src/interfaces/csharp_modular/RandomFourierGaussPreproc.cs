/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RandomFourierGaussPreproc : RealPreprocessor {
  private HandleRef swigCPtr;

  internal RandomFourierGaussPreproc(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.RandomFourierGaussPreprocUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RandomFourierGaussPreproc obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RandomFourierGaussPreproc() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_RandomFourierGaussPreproc(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RandomFourierGaussPreproc() : this(modshogunPINVOKE.new_RandomFourierGaussPreproc__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RandomFourierGaussPreproc(RandomFourierGaussPreproc pr) : this(modshogunPINVOKE.new_RandomFourierGaussPreproc__SWIG_1(RandomFourierGaussPreproc.getCPtr(pr)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_kernelwidth(double width) {
    modshogunPINVOKE.RandomFourierGaussPreproc_set_kernelwidth(swigCPtr, width);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_kernelwidth() {
    double ret = modshogunPINVOKE.RandomFourierGaussPreproc_get_kernelwidth(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void get_randomcoefficients(SWIGTYPE_p_p_double randomcoeff_additive2, SWIGTYPE_p_p_double randomcoeff_multiplicative2, SWIGTYPE_p_int dim_feature_space2, SWIGTYPE_p_int dim_input_space2, SWIGTYPE_p_double kernelwidth2) {
    modshogunPINVOKE.RandomFourierGaussPreproc_get_randomcoefficients(swigCPtr, SWIGTYPE_p_p_double.getCPtr(randomcoeff_additive2), SWIGTYPE_p_p_double.getCPtr(randomcoeff_multiplicative2), SWIGTYPE_p_int.getCPtr(dim_feature_space2), SWIGTYPE_p_int.getCPtr(dim_input_space2), SWIGTYPE_p_double.getCPtr(kernelwidth2));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_randomcoefficients(SWIGTYPE_p_double randomcoeff_additive2, SWIGTYPE_p_double randomcoeff_multiplicative2, int dim_feature_space2, int dim_input_space2, double kernelwidth2) {
    modshogunPINVOKE.RandomFourierGaussPreproc_set_randomcoefficients(swigCPtr, SWIGTYPE_p_double.getCPtr(randomcoeff_additive2), SWIGTYPE_p_double.getCPtr(randomcoeff_multiplicative2), dim_feature_space2, dim_input_space2, kernelwidth2);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_dim_input_space(int dim) {
    modshogunPINVOKE.RandomFourierGaussPreproc_set_dim_input_space(swigCPtr, dim);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_dim_feature_space(int dim) {
    modshogunPINVOKE.RandomFourierGaussPreproc_set_dim_feature_space(swigCPtr, dim);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool init_randomcoefficients() {
    bool ret = modshogunPINVOKE.RandomFourierGaussPreproc_init_randomcoefficients(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_dim_input_space() {
    int ret = modshogunPINVOKE.RandomFourierGaussPreproc_get_dim_input_space(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_dim_feature_space() {
    int ret = modshogunPINVOKE.RandomFourierGaussPreproc_get_dim_feature_space(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}