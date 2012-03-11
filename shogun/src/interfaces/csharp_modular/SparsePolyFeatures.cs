/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class SparsePolyFeatures : DotFeatures {
  private HandleRef swigCPtr;

  internal SparsePolyFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.SparsePolyFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SparsePolyFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SparsePolyFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_SparsePolyFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SparsePolyFeatures() : this(modshogunPINVOKE.new_SparsePolyFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparsePolyFeatures(SparseRealFeatures feat, int degree, bool normalize, int hash_bits) : this(modshogunPINVOKE.new_SparsePolyFeatures__SWIG_1(SparseRealFeatures.getCPtr(feat), degree, normalize, hash_bits), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparsePolyFeatures(SparsePolyFeatures orig) : this(modshogunPINVOKE.new_SparsePolyFeatures__SWIG_2(SparsePolyFeatures.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
