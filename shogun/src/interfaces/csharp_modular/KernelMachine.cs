/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class KernelMachine : Machine {
  private HandleRef swigCPtr;

  internal KernelMachine(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.KernelMachineUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(KernelMachine obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~KernelMachine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_KernelMachine(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public KernelMachine() : this(modshogunPINVOKE.new_KernelMachine(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_kernel(Kernel k) {
    modshogunPINVOKE.KernelMachine_set_kernel(swigCPtr, Kernel.getCPtr(k));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public Kernel get_kernel() {
    IntPtr cPtr = modshogunPINVOKE.KernelMachine_get_kernel(swigCPtr);
    Kernel ret = (cPtr == IntPtr.Zero) ? null : new Kernel(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_batch_computation_enabled(bool enable) {
    modshogunPINVOKE.KernelMachine_set_batch_computation_enabled(swigCPtr, enable);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_batch_computation_enabled() {
    bool ret = modshogunPINVOKE.KernelMachine_get_batch_computation_enabled(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_linadd_enabled(bool enable) {
    modshogunPINVOKE.KernelMachine_set_linadd_enabled(swigCPtr, enable);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_linadd_enabled() {
    bool ret = modshogunPINVOKE.KernelMachine_get_linadd_enabled(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_bias_enabled(bool enable_bias) {
    modshogunPINVOKE.KernelMachine_set_bias_enabled(swigCPtr, enable_bias);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_bias_enabled() {
    bool ret = modshogunPINVOKE.KernelMachine_get_bias_enabled(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_bias() {
    double ret = modshogunPINVOKE.KernelMachine_get_bias(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_bias(double bias) {
    modshogunPINVOKE.KernelMachine_set_bias(swigCPtr, bias);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_support_vector(int idx) {
    int ret = modshogunPINVOKE.KernelMachine_get_support_vector(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_alpha(int idx) {
    double ret = modshogunPINVOKE.KernelMachine_get_alpha(swigCPtr, idx);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_support_vector(int idx, int val) {
    bool ret = modshogunPINVOKE.KernelMachine_set_support_vector(swigCPtr, idx, val);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_alpha(int idx, double val) {
    bool ret = modshogunPINVOKE.KernelMachine_set_alpha(swigCPtr, idx, val);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_num_support_vectors() {
    int ret = modshogunPINVOKE.KernelMachine_get_num_support_vectors(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_alphas(double[] alphas) {
    modshogunPINVOKE.KernelMachine_set_alphas(swigCPtr, alphas.Length, alphas);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_support_vectors(int[] svs) {
    modshogunPINVOKE.KernelMachine_set_support_vectors(swigCPtr, svs.Length, svs);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public int[] get_support_vectors() {
		IntPtr ptr = modshogunPINVOKE.KernelMachine_get_support_vectors(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		int[] ret = new int[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public double[] get_alphas() {
		IntPtr ptr = modshogunPINVOKE.KernelMachine_get_alphas(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
		int[] size = new int[1];
		Marshal.Copy(ptr, size, 0, 1);

		int len = size[0];

		double[] ret = new double[len];

		Marshal.Copy(new IntPtr(ptr.ToInt64() + Marshal.SizeOf(typeof(int))), ret, 0, len);
		return ret;
}

  public bool create_new_model(int num) {
    bool ret = modshogunPINVOKE.KernelMachine_create_new_model(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool init_kernel_optimization() {
    bool ret = modshogunPINVOKE.KernelMachine_init_kernel_optimization(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Labels apply() {
    IntPtr cPtr = modshogunPINVOKE.KernelMachine_apply__SWIG_0(swigCPtr);
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Labels apply(Features data) {
    IntPtr cPtr = modshogunPINVOKE.KernelMachine_apply__SWIG_1(swigCPtr, Features.getCPtr(data));
    Labels ret = (cPtr == IntPtr.Zero) ? null : new Labels(cPtr, true);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double apply(int num) {
    double ret = modshogunPINVOKE.KernelMachine_apply__SWIG_2(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_void apply_helper(SWIGTYPE_p_void p) {
    IntPtr cPtr = modshogunPINVOKE.KernelMachine_apply_helper(SWIGTYPE_p_void.getCPtr(p));
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
