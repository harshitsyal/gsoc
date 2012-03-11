/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class HammingWordDistance : StringWordDistance {
  private HandleRef swigCPtr;

  internal HammingWordDistance(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.HammingWordDistanceUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HammingWordDistance obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HammingWordDistance() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_HammingWordDistance(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HammingWordDistance() : this(modshogunPINVOKE.new_HammingWordDistance__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HammingWordDistance(bool use_sign) : this(modshogunPINVOKE.new_HammingWordDistance__SWIG_1(use_sign), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HammingWordDistance(StringWordFeatures l, StringWordFeatures r, bool use_sign) : this(modshogunPINVOKE.new_HammingWordDistance__SWIG_2(StringWordFeatures.getCPtr(l), StringWordFeatures.getCPtr(r), use_sign), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}