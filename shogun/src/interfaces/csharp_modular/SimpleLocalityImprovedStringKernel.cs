/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class SimpleLocalityImprovedStringKernel : StringCharKernel {
  private HandleRef swigCPtr;

  internal SimpleLocalityImprovedStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.SimpleLocalityImprovedStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SimpleLocalityImprovedStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SimpleLocalityImprovedStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_SimpleLocalityImprovedStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SimpleLocalityImprovedStringKernel() : this(modshogunPINVOKE.new_SimpleLocalityImprovedStringKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SimpleLocalityImprovedStringKernel(int size, int length, int inner_degree, int outer_degree) : this(modshogunPINVOKE.new_SimpleLocalityImprovedStringKernel__SWIG_1(size, length, inner_degree, outer_degree), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public SimpleLocalityImprovedStringKernel(StringCharFeatures l, StringCharFeatures r, int length, int inner_degree, int outer_degree) : this(modshogunPINVOKE.new_SimpleLocalityImprovedStringKernel__SWIG_2(StringCharFeatures.getCPtr(l), StringCharFeatures.getCPtr(r), length, inner_degree, outer_degree), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}
