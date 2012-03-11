/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class LogPlusOne : RealPreprocessor {
  private HandleRef swigCPtr;

  internal LogPlusOne(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.LogPlusOneUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(LogPlusOne obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~LogPlusOne() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_LogPlusOne(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public LogPlusOne() : this(modshogunPINVOKE.new_LogPlusOne(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool load(SWIGTYPE_p_FILE f) {
    bool ret = modshogunPINVOKE.LogPlusOne_load(swigCPtr, SWIGTYPE_p_FILE.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool save(SWIGTYPE_p_FILE f) {
    bool ret = modshogunPINVOKE.LogPlusOne_save(swigCPtr, SWIGTYPE_p_FILE.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
