/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CommUlongStringKernel : StringUlongKernel {
  private HandleRef swigCPtr;

  internal CommUlongStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CommUlongStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CommUlongStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommUlongStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CommUlongStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CommUlongStringKernel(int size, bool use_sign) : this(modshogunPINVOKE.new_CommUlongStringKernel__SWIG_0(size, use_sign), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommUlongStringKernel(int size) : this(modshogunPINVOKE.new_CommUlongStringKernel__SWIG_1(size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommUlongStringKernel() : this(modshogunPINVOKE.new_CommUlongStringKernel__SWIG_2(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommUlongStringKernel(StringUlongFeatures l, StringUlongFeatures r, bool use_sign, int size) : this(modshogunPINVOKE.new_CommUlongStringKernel__SWIG_3(StringUlongFeatures.getCPtr(l), StringUlongFeatures.getCPtr(r), use_sign, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommUlongStringKernel(StringUlongFeatures l, StringUlongFeatures r, bool use_sign) : this(modshogunPINVOKE.new_CommUlongStringKernel__SWIG_4(StringUlongFeatures.getCPtr(l), StringUlongFeatures.getCPtr(r), use_sign), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommUlongStringKernel(StringUlongFeatures l, StringUlongFeatures r) : this(modshogunPINVOKE.new_CommUlongStringKernel__SWIG_5(StringUlongFeatures.getCPtr(l), StringUlongFeatures.getCPtr(r)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void merge_dictionaries(SWIGTYPE_p_int t, int j, SWIGTYPE_p_int k, SWIGTYPE_p_unsigned_long_long vec, SWIGTYPE_p_unsigned_long_long dic, SWIGTYPE_p_double dic_weights, double weight, int vec_idx) {
    modshogunPINVOKE.CommUlongStringKernel_merge_dictionaries(swigCPtr, SWIGTYPE_p_int.getCPtr(t), j, SWIGTYPE_p_int.getCPtr(k), SWIGTYPE_p_unsigned_long_long.getCPtr(vec), SWIGTYPE_p_unsigned_long_long.getCPtr(dic), SWIGTYPE_p_double.getCPtr(dic_weights), weight, vec_idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void get_dictionary(SWIGTYPE_p_int dsize, SWIGTYPE_p_unsigned_long_long dict, SWIGTYPE_p_double dweights) {
    modshogunPINVOKE.CommUlongStringKernel_get_dictionary(swigCPtr, SWIGTYPE_p_int.getCPtr(dsize), SWIGTYPE_p_unsigned_long_long.getCPtr(dict), SWIGTYPE_p_double.getCPtr(dweights));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}