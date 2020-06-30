using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']"
	[global::Android.Runtime.Register ("org/webrtc/DtmfSender", DoNotGenerateAcw=true)]
	public partial class DtmfSender : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/DtmfSender", typeof (DtmfSender));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DtmfSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/constructor[@name='DtmfSender' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe DtmfSender (long nativeDtmfSender)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeDtmfSender);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_canInsertDtmf;
#pragma warning disable 0169
		static Delegate GetCanInsertDtmfHandler ()
		{
			if (cb_canInsertDtmf == null)
				cb_canInsertDtmf = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanInsertDtmf);
			return cb_canInsertDtmf;
		}

		static bool n_CanInsertDtmf (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DtmfSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanInsertDtmf ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/method[@name='canInsertDtmf' and count(parameter)=0]"
		[Register ("canInsertDtmf", "()Z", "GetCanInsertDtmfHandler")]
		public virtual unsafe bool CanInsertDtmf ()
		{
			const string __id = "canInsertDtmf.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DtmfSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_duration;
#pragma warning disable 0169
		static Delegate GetDurationHandler ()
		{
			if (cb_duration == null)
				cb_duration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Duration);
			return cb_duration;
		}

		static int n_Duration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DtmfSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/method[@name='duration' and count(parameter)=0]"
		[Register ("duration", "()I", "GetDurationHandler")]
		public virtual unsafe int Duration ()
		{
			const string __id = "duration.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_insertDtmf_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetInsertDtmf_Ljava_lang_String_IIHandler ()
		{
			if (cb_insertDtmf_Ljava_lang_String_II == null)
				cb_insertDtmf_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_InsertDtmf_Ljava_lang_String_II);
			return cb_insertDtmf_Ljava_lang_String_II;
		}

		static bool n_InsertDtmf_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_tones, int duration, int interToneGap)
		{
			global::Org.Webrtc.DtmfSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tones = JNIEnv.GetString (native_tones, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InsertDtmf (tones, duration, interToneGap);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/method[@name='insertDtmf' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("insertDtmf", "(Ljava/lang/String;II)Z", "GetInsertDtmf_Ljava_lang_String_IIHandler")]
		public virtual unsafe bool InsertDtmf (string tones, int duration, int interToneGap)
		{
			const string __id = "insertDtmf.(Ljava/lang/String;II)Z";
			IntPtr native_tones = JNIEnv.NewString (tones);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tones);
				__args [1] = new JniArgumentValue (duration);
				__args [2] = new JniArgumentValue (interToneGap);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_tones);
			}
		}

		static Delegate cb_interToneGap;
#pragma warning disable 0169
		static Delegate GetInterToneGapHandler ()
		{
			if (cb_interToneGap == null)
				cb_interToneGap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InterToneGap);
			return cb_interToneGap;
		}

		static int n_InterToneGap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DtmfSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InterToneGap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/method[@name='interToneGap' and count(parameter)=0]"
		[Register ("interToneGap", "()I", "GetInterToneGapHandler")]
		public virtual unsafe int InterToneGap ()
		{
			const string __id = "interToneGap.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_tones;
#pragma warning disable 0169
		static Delegate GetTonesHandler ()
		{
			if (cb_tones == null)
				cb_tones = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Tones);
			return cb_tones;
		}

		static IntPtr n_Tones (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DtmfSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tones ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DtmfSender']/method[@name='tones' and count(parameter)=0]"
		[Register ("tones", "()Ljava/lang/String;", "GetTonesHandler")]
		public virtual unsafe string Tones ()
		{
			const string __id = "tones.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
