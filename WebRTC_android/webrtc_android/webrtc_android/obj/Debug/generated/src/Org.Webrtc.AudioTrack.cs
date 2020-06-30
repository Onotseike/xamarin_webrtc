using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='AudioTrack']"
	[global::Android.Runtime.Register ("org/webrtc/AudioTrack", DoNotGenerateAcw=true)]
	public partial class AudioTrack : global::Org.Webrtc.MediaStreamTrack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/AudioTrack", typeof (AudioTrack));
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

		protected AudioTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='AudioTrack']/constructor[@name='AudioTrack' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe AudioTrack (long nativeTrack)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeTrack);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVolume_D;
#pragma warning disable 0169
		static Delegate GetSetVolume_DHandler ()
		{
			if (cb_setVolume_D == null)
				cb_setVolume_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVolume_D);
			return cb_setVolume_D;
		}

		static void n_SetVolume_D (IntPtr jnienv, IntPtr native__this, double volume)
		{
			global::Org.Webrtc.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (volume);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='AudioTrack']/method[@name='setVolume' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setVolume", "(D)V", "GetSetVolume_DHandler")]
		public virtual unsafe void SetVolume (double volume)
		{
			const string __id = "setVolume.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (volume);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
