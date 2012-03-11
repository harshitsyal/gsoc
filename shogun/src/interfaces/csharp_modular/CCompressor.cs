/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCompressor : SGObject {
  private HandleRef swigCPtr;

  internal CCompressor(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.CCompressorUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCompressor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCompressor() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_CCompressor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CCompressor() : this(modshogunPINVOKE.new_CCompressor__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public CCompressor(E_COMPRESSION_TYPE ct) : this(modshogunPINVOKE.new_CCompressor__SWIG_1((int)ct), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void compress(SWIGTYPE_p_unsigned_char uncompressed, ulong uncompressed_size, SWIGTYPE_p_unsigned_char compressed, SWIGTYPE_p_unsigned_long_long compressed_size, int level) {
    modshogunPINVOKE.CCompressor_compress__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(uncompressed), uncompressed_size, SWIGTYPE_p_unsigned_char.getCPtr(compressed), SWIGTYPE_p_unsigned_long_long.getCPtr(compressed_size), level);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void compress(SWIGTYPE_p_unsigned_char uncompressed, ulong uncompressed_size, SWIGTYPE_p_unsigned_char compressed, SWIGTYPE_p_unsigned_long_long compressed_size) {
    modshogunPINVOKE.CCompressor_compress__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(uncompressed), uncompressed_size, SWIGTYPE_p_unsigned_char.getCPtr(compressed), SWIGTYPE_p_unsigned_long_long.getCPtr(compressed_size));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void decompress(SWIGTYPE_p_unsigned_char compressed, ulong compressed_size, SWIGTYPE_p_unsigned_char uncompressed, SWIGTYPE_p_unsigned_long_long uncompressed_size) {
    modshogunPINVOKE.CCompressor_decompress(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(compressed), compressed_size, SWIGTYPE_p_unsigned_char.getCPtr(uncompressed), SWIGTYPE_p_unsigned_long_long.getCPtr(uncompressed_size));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}