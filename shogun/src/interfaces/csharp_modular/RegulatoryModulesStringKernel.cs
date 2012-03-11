/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RegulatoryModulesStringKernel : StringCharKernel {
  private HandleRef swigCPtr;

  internal RegulatoryModulesStringKernel(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.RegulatoryModulesStringKernelUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RegulatoryModulesStringKernel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RegulatoryModulesStringKernel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_RegulatoryModulesStringKernel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RegulatoryModulesStringKernel() : this(modshogunPINVOKE.new_RegulatoryModulesStringKernel__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RegulatoryModulesStringKernel(int size, double width, int degree, int shift, int window) : this(modshogunPINVOKE.new_RegulatoryModulesStringKernel__SWIG_1(size, width, degree, shift, window), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RegulatoryModulesStringKernel(StringCharFeatures lstr, StringCharFeatures rstr, WordFeatures lpos, WordFeatures rpos, double width, int degree, int shift, int window, int size) : this(modshogunPINVOKE.new_RegulatoryModulesStringKernel__SWIG_2(StringCharFeatures.getCPtr(lstr), StringCharFeatures.getCPtr(rstr), WordFeatures.getCPtr(lpos), WordFeatures.getCPtr(rpos), width, degree, shift, window, size), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public RegulatoryModulesStringKernel(StringCharFeatures lstr, StringCharFeatures rstr, WordFeatures lpos, WordFeatures rpos, double width, int degree, int shift, int window) : this(modshogunPINVOKE.new_RegulatoryModulesStringKernel__SWIG_3(StringCharFeatures.getCPtr(lstr), StringCharFeatures.getCPtr(rstr), WordFeatures.getCPtr(lpos), WordFeatures.getCPtr(rpos), width, degree, shift, window), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_motif_positions(WordFeatures positions_lhs, WordFeatures positions_rhs) {
    modshogunPINVOKE.RegulatoryModulesStringKernel_set_motif_positions(swigCPtr, WordFeatures.getCPtr(positions_lhs), WordFeatures.getCPtr(positions_rhs));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void register_params() {
    modshogunPINVOKE.RegulatoryModulesStringKernel_register_params(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

}