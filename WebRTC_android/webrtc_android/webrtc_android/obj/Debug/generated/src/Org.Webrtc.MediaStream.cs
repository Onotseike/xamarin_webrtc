using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']"
	[global::Android.Runtime.Register ("org/webrtc/MediaStream", DoNotGenerateAcw=true)]
	public partial class MediaStream : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/field[@name='audioTracks']"
		[Register ("audioTracks")]
		public global::System.Collections.IList AudioTracks {
			get {
				const string __id = "audioTracks.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "audioTracks.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/field[@name='preservedVideoTracks']"
		[Register ("preservedVideoTracks")]
		public global::System.Collections.IList PreservedVideoTracks {
			get {
				const string __id = "preservedVideoTracks.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "preservedVideoTracks.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/field[@name='videoTracks']"
		[Register ("videoTracks")]
		public global::System.Collections.IList VideoTracks {
			get {
				const string __id = "videoTracks.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "videoTracks.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaStream", typeof (MediaStream));
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

		protected MediaStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/constructor[@name='MediaStream' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaStream (long nativeStream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeStream);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addPreservedTrack_Lorg_webrtc_VideoTrack_;
#pragma warning disable 0169
		static Delegate GetAddPreservedTrack_Lorg_webrtc_VideoTrack_Handler ()
		{
			if (cb_addPreservedTrack_Lorg_webrtc_VideoTrack_ == null)
				cb_addPreservedTrack_Lorg_webrtc_VideoTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddPreservedTrack_Lorg_webrtc_VideoTrack_);
			return cb_addPreservedTrack_Lorg_webrtc_VideoTrack_;
		}

		static bool n_AddPreservedTrack_Lorg_webrtc_VideoTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPreservedTrack (track);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='addPreservedTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoTrack']]"
		[Register ("addPreservedTrack", "(Lorg/webrtc/VideoTrack;)Z", "GetAddPreservedTrack_Lorg_webrtc_VideoTrack_Handler")]
		public virtual unsafe bool AddPreservedTrack (global::Org.Webrtc.VideoTrack track)
		{
			const string __id = "addPreservedTrack.(Lorg/webrtc/VideoTrack;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_addTrack_Lorg_webrtc_AudioTrack_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_webrtc_AudioTrack_Handler ()
		{
			if (cb_addTrack_Lorg_webrtc_AudioTrack_ == null)
				cb_addTrack_Lorg_webrtc_AudioTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddTrack_Lorg_webrtc_AudioTrack_);
			return cb_addTrack_Lorg_webrtc_AudioTrack_;
		}

		static bool n_AddTrack_Lorg_webrtc_AudioTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.AudioTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddTrack (track);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='addTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioTrack']]"
		[Register ("addTrack", "(Lorg/webrtc/AudioTrack;)Z", "GetAddTrack_Lorg_webrtc_AudioTrack_Handler")]
		public virtual unsafe bool AddTrack (global::Org.Webrtc.AudioTrack track)
		{
			const string __id = "addTrack.(Lorg/webrtc/AudioTrack;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_addTrack_Lorg_webrtc_VideoTrack_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_webrtc_VideoTrack_Handler ()
		{
			if (cb_addTrack_Lorg_webrtc_VideoTrack_ == null)
				cb_addTrack_Lorg_webrtc_VideoTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddTrack_Lorg_webrtc_VideoTrack_);
			return cb_addTrack_Lorg_webrtc_VideoTrack_;
		}

		static bool n_AddTrack_Lorg_webrtc_VideoTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddTrack (track);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='addTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoTrack']]"
		[Register ("addTrack", "(Lorg/webrtc/VideoTrack;)Z", "GetAddTrack_Lorg_webrtc_VideoTrack_Handler")]
		public virtual unsafe bool AddTrack (global::Org.Webrtc.VideoTrack track)
		{
			const string __id = "addTrack.(Lorg/webrtc/VideoTrack;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
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
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeTrack_Lorg_webrtc_AudioTrack_;
#pragma warning disable 0169
		static Delegate GetRemoveTrack_Lorg_webrtc_AudioTrack_Handler ()
		{
			if (cb_removeTrack_Lorg_webrtc_AudioTrack_ == null)
				cb_removeTrack_Lorg_webrtc_AudioTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveTrack_Lorg_webrtc_AudioTrack_);
			return cb_removeTrack_Lorg_webrtc_AudioTrack_;
		}

		static bool n_RemoveTrack_Lorg_webrtc_AudioTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.AudioTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveTrack (track);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='removeTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioTrack']]"
		[Register ("removeTrack", "(Lorg/webrtc/AudioTrack;)Z", "GetRemoveTrack_Lorg_webrtc_AudioTrack_Handler")]
		public virtual unsafe bool RemoveTrack (global::Org.Webrtc.AudioTrack track)
		{
			const string __id = "removeTrack.(Lorg/webrtc/AudioTrack;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeTrack_Lorg_webrtc_VideoTrack_;
#pragma warning disable 0169
		static Delegate GetRemoveTrack_Lorg_webrtc_VideoTrack_Handler ()
		{
			if (cb_removeTrack_Lorg_webrtc_VideoTrack_ == null)
				cb_removeTrack_Lorg_webrtc_VideoTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveTrack_Lorg_webrtc_VideoTrack_);
			return cb_removeTrack_Lorg_webrtc_VideoTrack_;
		}

		static bool n_RemoveTrack_Lorg_webrtc_VideoTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveTrack (track);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='removeTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoTrack']]"
		[Register ("removeTrack", "(Lorg/webrtc/VideoTrack;)Z", "GetRemoveTrack_Lorg_webrtc_VideoTrack_Handler")]
		public virtual unsafe bool RemoveTrack (global::Org.Webrtc.VideoTrack track)
		{
			const string __id = "removeTrack.(Lorg/webrtc/VideoTrack;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
