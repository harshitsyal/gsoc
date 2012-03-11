/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StreamingWordFeatures : StreamingDotFeatures {
  private HandleRef swigCPtr;

  internal StreamingWordFeatures(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.StreamingWordFeaturesUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StreamingWordFeatures obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamingWordFeatures() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_StreamingWordFeatures(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StreamingWordFeatures() : this(modshogunPINVOKE.new_StreamingWordFeatures__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingWordFeatures(StreamingFile file, bool is_labelled, int size) : this(modshogunPINVOKE.new_StreamingWordFeatures__SWIG_1(StreamingFile.getCPtr(file), is_labelled, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingWordFeatures(WordFeatures simple_features, SWIGTYPE_p_double lab) : this(modshogunPINVOKE.new_StreamingWordFeatures__SWIG_2(WordFeatures.getCPtr(simple_features), SWIGTYPE_p_double.getCPtr(lab)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamingWordFeatures(WordFeatures simple_features) : this(modshogunPINVOKE.new_StreamingWordFeatures__SWIG_3(WordFeatures.getCPtr(simple_features)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public short[] get_vector() {
		IntPtr ptr = modshogunPINVOKE.StreamingWordFeatures_get_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		short[] ret = new short[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public virtual float dot(short[] vec) {
    float ret = modshogunPINVOKE.StreamingWordFeatures_dot__SWIG_0(swigCPtr, vec.Length, vec);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float dot(StreamingDotFeatures df) {
    float ret = modshogunPINVOKE.StreamingWordFeatures_dot__SWIG_1(swigCPtr, StreamingDotFeatures.getCPtr(df));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
