/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class HMM : Distribution {
  private HandleRef swigCPtr;

  internal HMM(IntPtr cPtr, bool cMemoryOwn) : base(modshogunPINVOKE.HMMUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HMM obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HMM() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          modshogunPINVOKE.delete_HMM(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HMM() : this(modshogunPINVOKE.new_HMM__SWIG_0(), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HMM(int N, int M, SWIGTYPE_p_shogun__Model model, double PSEUDO) : this(modshogunPINVOKE.new_HMM__SWIG_1(N, M, SWIGTYPE_p_shogun__Model.getCPtr(model), PSEUDO), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HMM(StringWordFeatures obs, int N, int M, double PSEUDO) : this(modshogunPINVOKE.new_HMM__SWIG_2(StringWordFeatures.getCPtr(obs), N, M, PSEUDO), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HMM(int N, SWIGTYPE_p_double p, SWIGTYPE_p_double q, SWIGTYPE_p_double a) : this(modshogunPINVOKE.new_HMM__SWIG_3(N, SWIGTYPE_p_double.getCPtr(p), SWIGTYPE_p_double.getCPtr(q), SWIGTYPE_p_double.getCPtr(a)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HMM(int N, SWIGTYPE_p_double p, SWIGTYPE_p_double q, int num_trans, SWIGTYPE_p_double a_trans) : this(modshogunPINVOKE.new_HMM__SWIG_4(N, SWIGTYPE_p_double.getCPtr(p), SWIGTYPE_p_double.getCPtr(q), num_trans, SWIGTYPE_p_double.getCPtr(a_trans)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HMM(SWIGTYPE_p_FILE model_file, double PSEUDO) : this(modshogunPINVOKE.new_HMM__SWIG_5(SWIGTYPE_p_FILE.getCPtr(model_file), PSEUDO), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public HMM(HMM h) : this(modshogunPINVOKE.new_HMM__SWIG_6(HMM.getCPtr(h)), true) {
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool train(Features data) {
    bool ret = modshogunPINVOKE.HMM_train__SWIG_0(swigCPtr, Features.getCPtr(data));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool train() {
    bool ret = modshogunPINVOKE.HMM_train__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool initialize(SWIGTYPE_p_shogun__Model model, double PSEUDO, SWIGTYPE_p_FILE model_file) {
    bool ret = modshogunPINVOKE.HMM_initialize__SWIG_0(swigCPtr, SWIGTYPE_p_shogun__Model.getCPtr(model), PSEUDO, SWIGTYPE_p_FILE.getCPtr(model_file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool initialize(SWIGTYPE_p_shogun__Model model, double PSEUDO) {
    bool ret = modshogunPINVOKE.HMM_initialize__SWIG_1(swigCPtr, SWIGTYPE_p_shogun__Model.getCPtr(model), PSEUDO);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool alloc_state_dependend_arrays() {
    bool ret = modshogunPINVOKE.HMM_alloc_state_dependend_arrays(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void free_state_dependend_arrays() {
    modshogunPINVOKE.HMM_free_state_dependend_arrays(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double forward_comp(int time, int state, int dimension) {
    double ret = modshogunPINVOKE.HMM_forward_comp(swigCPtr, time, state, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double forward_comp_old(int time, int state, int dimension) {
    double ret = modshogunPINVOKE.HMM_forward_comp_old(swigCPtr, time, state, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double backward_comp(int time, int state, int dimension) {
    double ret = modshogunPINVOKE.HMM_backward_comp(swigCPtr, time, state, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double backward_comp_old(int time, int state, int dimension) {
    double ret = modshogunPINVOKE.HMM_backward_comp_old(swigCPtr, time, state, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double best_path(int dimension) {
    double ret = modshogunPINVOKE.HMM_best_path(swigCPtr, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort get_best_path_state(int dim, int t) {
    ushort ret = modshogunPINVOKE.HMM_get_best_path_state(swigCPtr, dim, t);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_probability_comp() {
    double ret = modshogunPINVOKE.HMM_model_probability_comp(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_probability(int dimension) {
    double ret = modshogunPINVOKE.HMM_model_probability__SWIG_0(swigCPtr, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_probability() {
    double ret = modshogunPINVOKE.HMM_model_probability__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double linear_model_probability(int dimension) {
    double ret = modshogunPINVOKE.HMM_linear_model_probability(swigCPtr, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_iterations(int num) {
    bool ret = modshogunPINVOKE.HMM_set_iterations(swigCPtr, num);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_iterations() {
    int ret = modshogunPINVOKE.HMM_get_iterations(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool set_epsilon(double eps) {
    bool ret = modshogunPINVOKE.HMM_set_epsilon(swigCPtr, eps);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_epsilon() {
    double ret = modshogunPINVOKE.HMM_get_epsilon(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool baum_welch_viterbi_train(BaumWelchViterbiType type) {
    bool ret = modshogunPINVOKE.HMM_baum_welch_viterbi_train(swigCPtr, (int)type);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void estimate_model_baum_welch(HMM train) {
    modshogunPINVOKE.HMM_estimate_model_baum_welch(swigCPtr, HMM.getCPtr(train));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void estimate_model_baum_welch_trans(HMM train) {
    modshogunPINVOKE.HMM_estimate_model_baum_welch_trans(swigCPtr, HMM.getCPtr(train));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void estimate_model_baum_welch_old(HMM train) {
    modshogunPINVOKE.HMM_estimate_model_baum_welch_old(swigCPtr, HMM.getCPtr(train));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void estimate_model_baum_welch_defined(HMM train) {
    modshogunPINVOKE.HMM_estimate_model_baum_welch_defined(swigCPtr, HMM.getCPtr(train));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void estimate_model_viterbi(HMM train) {
    modshogunPINVOKE.HMM_estimate_model_viterbi(swigCPtr, HMM.getCPtr(train));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void estimate_model_viterbi_defined(HMM train) {
    modshogunPINVOKE.HMM_estimate_model_viterbi_defined(swigCPtr, HMM.getCPtr(train));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool linear_train(bool right_align) {
    bool ret = modshogunPINVOKE.HMM_linear_train__SWIG_0(swigCPtr, right_align);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool linear_train() {
    bool ret = modshogunPINVOKE.HMM_linear_train__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool permutation_entropy(int window_width, int sequence_number) {
    bool ret = modshogunPINVOKE.HMM_permutation_entropy(swigCPtr, window_width, sequence_number);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void output_model(bool verbose) {
    modshogunPINVOKE.HMM_output_model__SWIG_0(swigCPtr, verbose);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void output_model() {
    modshogunPINVOKE.HMM_output_model__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void output_model_defined(bool verbose) {
    modshogunPINVOKE.HMM_output_model_defined__SWIG_0(swigCPtr, verbose);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void output_model_defined() {
    modshogunPINVOKE.HMM_output_model_defined__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void normalize(bool keep_dead_states) {
    modshogunPINVOKE.HMM_normalize__SWIG_0(swigCPtr, keep_dead_states);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void normalize() {
    modshogunPINVOKE.HMM_normalize__SWIG_1(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_states(int num_states, double default_val) {
    modshogunPINVOKE.HMM_add_states__SWIG_0(swigCPtr, num_states, default_val);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_states(int num_states) {
    modshogunPINVOKE.HMM_add_states__SWIG_1(swigCPtr, num_states);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool append_model(HMM append_model, SWIGTYPE_p_double cur_out, SWIGTYPE_p_double app_out) {
    bool ret = modshogunPINVOKE.HMM_append_model__SWIG_0(swigCPtr, HMM.getCPtr(append_model), SWIGTYPE_p_double.getCPtr(cur_out), SWIGTYPE_p_double.getCPtr(app_out));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool append_model(HMM append_model) {
    bool ret = modshogunPINVOKE.HMM_append_model__SWIG_1(swigCPtr, HMM.getCPtr(append_model));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void chop(double value) {
    modshogunPINVOKE.HMM_chop(swigCPtr, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void convert_to_log() {
    modshogunPINVOKE.HMM_convert_to_log(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void init_model_random() {
    modshogunPINVOKE.HMM_init_model_random(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void init_model_defined() {
    modshogunPINVOKE.HMM_init_model_defined(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear_model() {
    modshogunPINVOKE.HMM_clear_model(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear_model_defined() {
    modshogunPINVOKE.HMM_clear_model_defined(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void copy_model(HMM l) {
    modshogunPINVOKE.HMM_copy_model(swigCPtr, HMM.getCPtr(l));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void invalidate_model() {
    modshogunPINVOKE.HMM_invalidate_model(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool get_status() {
    bool ret = modshogunPINVOKE.HMM_get_status(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_pseudo() {
    double ret = modshogunPINVOKE.HMM_get_pseudo(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_pseudo(double pseudo) {
    modshogunPINVOKE.HMM_set_pseudo(swigCPtr, pseudo);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_observations(StringWordFeatures obs, HMM hmm) {
    modshogunPINVOKE.HMM_set_observations__SWIG_0(swigCPtr, StringWordFeatures.getCPtr(obs), HMM.getCPtr(hmm));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_observations(StringWordFeatures obs) {
    modshogunPINVOKE.HMM_set_observations__SWIG_1(swigCPtr, StringWordFeatures.getCPtr(obs));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_observation_nocache(StringWordFeatures obs) {
    modshogunPINVOKE.HMM_set_observation_nocache(swigCPtr, StringWordFeatures.getCPtr(obs));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public StringWordFeatures get_observations() {
    IntPtr cPtr = modshogunPINVOKE.HMM_get_observations(swigCPtr);
    StringWordFeatures ret = (cPtr == IntPtr.Zero) ? null : new StringWordFeatures(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_definitions(SWIGTYPE_p_FILE file, bool verbose, bool initialize) {
    bool ret = modshogunPINVOKE.HMM_load_definitions__SWIG_0(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file), verbose, initialize);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_definitions(SWIGTYPE_p_FILE file, bool verbose) {
    bool ret = modshogunPINVOKE.HMM_load_definitions__SWIG_1(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file), verbose);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool load_model(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_load_model(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_model(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_model(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_model_derivatives(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_model_derivatives(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_model_derivatives_bin(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_model_derivatives_bin(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_model_bin(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_model_bin(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool check_model_derivatives() {
    bool ret = modshogunPINVOKE.HMM_check_model_derivatives(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool check_model_derivatives_combined() {
    bool ret = modshogunPINVOKE.HMM_check_model_derivatives_combined(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned_short get_path(int dim, SWIGTYPE_p_double prob) {
    IntPtr cPtr = modshogunPINVOKE.HMM_get_path(swigCPtr, dim, SWIGTYPE_p_double.getCPtr(prob));
    SWIGTYPE_p_unsigned_short ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_path(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_path(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_path_derivatives(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_path_derivatives(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_path_derivatives_bin(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_path_derivatives_bin(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_likelihood_bin(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_likelihood_bin(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_likelihood(SWIGTYPE_p_FILE file) {
    bool ret = modshogunPINVOKE.HMM_save_likelihood(swigCPtr, SWIGTYPE_p_FILE.getCPtr(file));
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort get_N() {
    ushort ret = modshogunPINVOKE.HMM_get_N(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_M() {
    int ret = modshogunPINVOKE.HMM_get_M(swigCPtr);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_q(ushort offset, double value) {
    modshogunPINVOKE.HMM_set_q(swigCPtr, offset, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_p(ushort offset, double value) {
    modshogunPINVOKE.HMM_set_p(swigCPtr, offset, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_A(ushort line_, ushort column, double value) {
    modshogunPINVOKE.HMM_set_A(swigCPtr, line_, column, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_a(ushort line_, ushort column, double value) {
    modshogunPINVOKE.HMM_set_a(swigCPtr, line_, column, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_B(ushort line_, ushort column, double value) {
    modshogunPINVOKE.HMM_set_B(swigCPtr, line_, column, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_b(ushort line_, ushort column, double value) {
    modshogunPINVOKE.HMM_set_b(swigCPtr, line_, column, value);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_psi(int time, ushort state, ushort value, int dimension) {
    modshogunPINVOKE.HMM_set_psi(swigCPtr, time, state, value, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
  }

  public double get_q(ushort offset) {
    double ret = modshogunPINVOKE.HMM_get_q(swigCPtr, offset);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_p(ushort offset) {
    double ret = modshogunPINVOKE.HMM_get_p(swigCPtr, offset);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_A(ushort line_, ushort column) {
    double ret = modshogunPINVOKE.HMM_get_A(swigCPtr, line_, column);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_a(ushort line_, ushort column) {
    double ret = modshogunPINVOKE.HMM_get_a(swigCPtr, line_, column);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_B(ushort line_, ushort column) {
    double ret = modshogunPINVOKE.HMM_get_B(swigCPtr, line_, column);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double get_b(ushort line_, ushort column) {
    double ret = modshogunPINVOKE.HMM_get_b(swigCPtr, line_, column);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort get_psi(int time, ushort state, int dimension) {
    ushort ret = modshogunPINVOKE.HMM_get_psi(swigCPtr, time, state, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double state_probability(int time, int state, int dimension) {
    double ret = modshogunPINVOKE.HMM_state_probability(swigCPtr, time, state, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double transition_probability(int time, int state_i, int state_j, int dimension) {
    double ret = modshogunPINVOKE.HMM_transition_probability(swigCPtr, time, state_i, state_j, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double linear_model_derivative(ushort i, ushort j, int dimension) {
    double ret = modshogunPINVOKE.HMM_linear_model_derivative(swigCPtr, i, j, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_derivative_p(ushort i, int dimension) {
    double ret = modshogunPINVOKE.HMM_model_derivative_p(swigCPtr, i, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_derivative_q(ushort i, int dimension) {
    double ret = modshogunPINVOKE.HMM_model_derivative_q(swigCPtr, i, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_derivative_a(ushort i, ushort j, int dimension) {
    double ret = modshogunPINVOKE.HMM_model_derivative_a(swigCPtr, i, j, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double model_derivative_b(ushort i, ushort j, int dimension) {
    double ret = modshogunPINVOKE.HMM_model_derivative_b(swigCPtr, i, j, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double path_derivative_p(ushort i, int dimension) {
    double ret = modshogunPINVOKE.HMM_path_derivative_p(swigCPtr, i, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double path_derivative_q(ushort i, int dimension) {
    double ret = modshogunPINVOKE.HMM_path_derivative_q(swigCPtr, i, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double path_derivative_a(ushort i, ushort j, int dimension) {
    double ret = modshogunPINVOKE.HMM_path_derivative_a(swigCPtr, i, j, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double path_derivative_b(ushort i, ushort j, int dimension) {
    double ret = modshogunPINVOKE.HMM_path_derivative_b(swigCPtr, i, j, dimension);
    if (modshogunPINVOKE.SWIGPendingException.Pending) throw modshogunPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
