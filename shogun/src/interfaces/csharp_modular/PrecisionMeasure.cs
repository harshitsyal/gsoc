/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PrecisionMeasure : ContingencyTableEvaluation {
  private HandleRef swigCPtr;

  internal PrecisionMeasure(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.PrecisionMeasureUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PrecisionMeasure obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PrecisionMeasure() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_PrecisionMeasure(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PrecisionMeasure() : this(modshogunPINVOKE.new_PrecisionMeasure(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
