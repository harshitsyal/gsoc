/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DecompressCharString : StringCharPreprocessor {
  private HandleRef swigCPtr;

  internal DecompressCharString(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DecompressCharStringUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DecompressCharString obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DecompressCharString() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_DecompressCharString(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DecompressCharString() : this(modshogunPINVOKE.new_DecompressCharString__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DecompressCharString(E_COMPRESSION_TYPE ct) : this(modshogunPINVOKE.new_DecompressCharString__SWIG_1((int)ct), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool load(SWIGTYPE_p_FILE f) {
    bool ret = modshogunPINVOKE.DecompressCharString_load(swigCPtr, SWIGTYPE_p_FILE.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save(SWIGTYPE_p_FILE f) {
    bool ret = modshogunPINVOKE.DecompressCharString_save(swigCPtr, SWIGTYPE_p_FILE.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
