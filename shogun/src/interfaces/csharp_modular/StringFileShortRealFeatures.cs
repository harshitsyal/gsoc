/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StringFileShortRealFeatures : StringShortRealFeatures {
  private HandleRef swigCPtr;

  internal StringFileShortRealFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StringFileShortRealFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StringFileShortRealFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringFileShortRealFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StringFileShortRealFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StringFileShortRealFeatures() : this(modshogunPINVOKE.new_StringFileShortRealFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringFileShortRealFeatures(string fname, EAlphabet alpha) : this(modshogunPINVOKE.new_StringFileShortRealFeatures__SWIG_1(fname, (int)alpha), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
