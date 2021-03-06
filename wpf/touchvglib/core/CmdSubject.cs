/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class CmdSubject : CmdObserver {
  private HandleRef swigCPtr;

  internal CmdSubject(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.CmdSubject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CmdSubject obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CmdSubject() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_CmdSubject(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void registerObserver(CmdObserver observer) {
    touchvgPINVOKE.CmdSubject_registerObserver(swigCPtr, CmdObserver.getCPtr(observer));
  }

  public virtual void unregisterObserver(CmdObserver observer) {
    touchvgPINVOKE.CmdSubject_unregisterObserver(swigCPtr, CmdObserver.getCPtr(observer));
  }

}

}
