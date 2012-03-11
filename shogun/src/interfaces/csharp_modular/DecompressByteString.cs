/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DecompressByteString : StringBytePreprocessor {
  private HandleRef swigCPtr;

  internal DecompressByteString(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.DecompressByteStringUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DecompressByteString obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DecompressByteString() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_DecompressByteString(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DecompressByteString() : this(modshogunPINVOKE.new_DecompressByteString__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public DecompressByteString(E_COMPRESSION_TYPE ct) : this(modshogunPINVOKE.new_DecompressByteString__SWIG_1((int)ct), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool load(SWIGTYPE_p_FILE f) {
    bool ret = modshogunPINVOKE.DecompressByteString_load(swigCPtr, SWIGTYPE_p_FILE.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save(SWIGTYPE_p_FILE f) {
    bool ret = modshogunPINVOKE.DecompressByteString_save(swigCPtr, SWIGTYPE_p_FILE.getCPtr(f));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
