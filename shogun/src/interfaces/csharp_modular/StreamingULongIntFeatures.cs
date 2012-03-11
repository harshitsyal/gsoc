/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingULongIntFeatures : StreamingDotFeatures {
  private HandleRef swigCPtr;

  internal StreamingULongIntFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingULongIntFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingULongIntFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingULongIntFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingULongIntFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingULongIntFeatures() : this(modshogunPINVOKE.new_StreamingULongIntFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingULongIntFeatures(StreamingFile file, bool is_labelled, int size) : this(modshogunPINVOKE.new_StreamingULongIntFeatures__SWIG_1(StreamingFile.getCPtr(file), is_labelled, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingULongIntFeatures(ULongIntFeatures simple_features, SWIGTYPE_p_double lab) : this(modshogunPINVOKE.new_StreamingULongIntFeatures__SWIG_2(ULongIntFeatures.getCPtr(simple_features), SWIGTYPE_p_double.getCPtr(lab)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingULongIntFeatures(ULongIntFeatures simple_features) : this(modshogunPINVOKE.new_StreamingULongIntFeatures__SWIG_3(ULongIntFeatures.getCPtr(simple_features)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public long[] get_vector() {
		IntPtr ptr = modshogunPINVOKE.StreamingULongIntFeatures_get_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		long[] ret = new long[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public virtual float dot(long[] vec) {
    float ret = modshogunPINVOKE.StreamingULongIntFeatures_dot__SWIG_0(swigCPtr, vec.Length, vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float dot(StreamingDotFeatures df) {
    float ret = modshogunPINVOKE.StreamingULongIntFeatures_dot__SWIG_1(swigCPtr, StreamingDotFeatures.getCPtr(df));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}