/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IntVector : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IntVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IntVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IntVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_IntVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public IntVector() : this(modshogunPINVOKE.new_IntVector__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntVector(SWIGTYPE_p_int v, int len, bool free_vec) : this(modshogunPINVOKE.new_IntVector__SWIG_1(SWIGTYPE_p_int.getCPtr(v), len, free_vec), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntVector(SWIGTYPE_p_int v, int len) : this(modshogunPINVOKE.new_IntVector__SWIG_2(SWIGTYPE_p_int.getCPtr(v), len), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntVector(int len, bool free_vec) : this(modshogunPINVOKE.new_IntVector__SWIG_3(len, free_vec), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntVector(int len) : this(modshogunPINVOKE.new_IntVector__SWIG_4(len), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public IntVector(IntVector orig) : this(modshogunPINVOKE.new_IntVector__SWIG_5(IntVector.getCPtr(orig)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public static int[] get_vector(IntVector src, bool own) {
		IntPtr ptr = modshogunPINVOKE.IntVector_get_vector__SWIG_0(IntVector.getCPtr(src), own);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		int[] ret = new int[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public static int[] get_vector(IntVector src) {
		IntPtr ptr = modshogunPINVOKE.IntVector_get_vector__SWIG_1(IntVector.getCPtr(src));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		int[] ret = new int[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public void zero() {
    modshogunPINVOKE.IntVector_zero(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_const(int const_elem) {
    modshogunPINVOKE.IntVector_set_const(swigCPtr, const_elem);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void range_fill(int start) {
    modshogunPINVOKE.IntVector_range_fill__SWIG_0(swigCPtr, start);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void range_fill() {
    modshogunPINVOKE.IntVector_range_fill__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void random(int min_value, int max_value) {
    modshogunPINVOKE.IntVector_random(swigCPtr, min_value, max_value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void randperm() {
    modshogunPINVOKE.IntVector_randperm(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_element(int index) {
    int ret = modshogunPINVOKE.IntVector_get_element(swigCPtr, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_element(int p_element, int index) {
    modshogunPINVOKE.IntVector_set_element(swigCPtr, p_element, index);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize_vector(int n) {
    modshogunPINVOKE.IntVector_resize_vector(swigCPtr, n);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void free_vector() {
    modshogunPINVOKE.IntVector_free_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void destroy_vector() {
    modshogunPINVOKE.IntVector_destroy_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void display_size() {
    modshogunPINVOKE.IntVector_display_size(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void display_vector() {
    modshogunPINVOKE.IntVector_display_vector(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_int vector {
    set {
      modshogunPINVOKE.IntVector_vector_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = modshogunPINVOKE.IntVector_vector_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int vlen {
    set {
      modshogunPINVOKE.IntVector_vlen_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = modshogunPINVOKE.IntVector_vlen_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool do_free {
    set {
      modshogunPINVOKE.IntVector_do_free_set(swigCPtr, value);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = modshogunPINVOKE.IntVector_do_free_get(swigCPtr);
      if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool save_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.IntVector_save_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.IntVector_save_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file, string prefix) {
    bool ret = modshogunPINVOKE.IntVector_load_serializable__SWIG_0(swigCPtr, SerializableFile.getCPtr(file), prefix);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_serializable(SerializableFile file) {
    bool ret = modshogunPINVOKE.IntVector_load_serializable__SWIG_1(swigCPtr, SerializableFile.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
