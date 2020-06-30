using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']"
	[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory", DoNotGenerateAcw=true)]
	public partial class PeerConnectionFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/field[@name='TRIAL_ENABLED']"
		[Register ("TRIAL_ENABLED")]
		public const string TrialEnabled = (string) "Enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/field[@name='VIDEO_FRAME_EMIT_TRIAL']"
		[Register ("VIDEO_FRAME_EMIT_TRIAL")]
		[Obsolete ("deprecated")]
		public const string VideoFrameEmitTrial = (string) "VideoFrameEmit";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionFactory$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_createPeerConnectionFactory;
#pragma warning disable 0169
			static Delegate GetCreatePeerConnectionFactoryHandler ()
			{
				if (cb_createPeerConnectionFactory == null)
					cb_createPeerConnectionFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreatePeerConnectionFactory);
				return cb_createPeerConnectionFactory;
			}

			static IntPtr n_CreatePeerConnectionFactory (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CreatePeerConnectionFactory ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='createPeerConnectionFactory' and count(parameter)=0]"
			[Register ("createPeerConnectionFactory", "()Lorg/webrtc/PeerConnectionFactory;", "GetCreatePeerConnectionFactoryHandler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory CreatePeerConnectionFactory ()
			{
				const string __id = "createPeerConnectionFactory.()Lorg/webrtc/PeerConnectionFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_;
#pragma warning disable 0169
			static Delegate GetSetAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_Handler ()
			{
				if (cb_setAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_ == null)
					cb_setAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_);
				return cb_setAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_;
			}

			static IntPtr n_SetAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioDecoderFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IAudioDecoderFactoryFactory audioDecoderFactoryFactory = (global::Org.Webrtc.IAudioDecoderFactoryFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAudioDecoderFactoryFactory> (native_audioDecoderFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioDecoderFactoryFactory (audioDecoderFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setAudioDecoderFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioDecoderFactoryFactory']]"
			[Register ("setAudioDecoderFactoryFactory", "(Lorg/webrtc/AudioDecoderFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetAudioDecoderFactoryFactory_Lorg_webrtc_AudioDecoderFactoryFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetAudioDecoderFactoryFactory (global::Org.Webrtc.IAudioDecoderFactoryFactory audioDecoderFactoryFactory)
			{
				const string __id = "setAudioDecoderFactoryFactory.(Lorg/webrtc/AudioDecoderFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioDecoderFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioDecoderFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_;
#pragma warning disable 0169
			static Delegate GetSetAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_Handler ()
			{
				if (cb_setAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_ == null)
					cb_setAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_);
				return cb_setAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_;
			}

			static IntPtr n_SetAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioDeviceModule)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.IAudioDeviceModule audioDeviceModule = (global::Org.Webrtc.Audio.IAudioDeviceModule)global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.IAudioDeviceModule> (native_audioDeviceModule, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioDeviceModule (audioDeviceModule));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setAudioDeviceModule' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.AudioDeviceModule']]"
			[Register ("setAudioDeviceModule", "(Lorg/webrtc/audio/AudioDeviceModule;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetAudioDeviceModule_Lorg_webrtc_audio_AudioDeviceModule_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetAudioDeviceModule (global::Org.Webrtc.Audio.IAudioDeviceModule audioDeviceModule)
			{
				const string __id = "setAudioDeviceModule.(Lorg/webrtc/audio/AudioDeviceModule;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioDeviceModule == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioDeviceModule).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_;
#pragma warning disable 0169
			static Delegate GetSetAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_Handler ()
			{
				if (cb_setAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_ == null)
					cb_setAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_);
				return cb_setAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_;
			}

			static IntPtr n_SetAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioEncoderFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IAudioEncoderFactoryFactory audioEncoderFactoryFactory = (global::Org.Webrtc.IAudioEncoderFactoryFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAudioEncoderFactoryFactory> (native_audioEncoderFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioEncoderFactoryFactory (audioEncoderFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setAudioEncoderFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioEncoderFactoryFactory']]"
			[Register ("setAudioEncoderFactoryFactory", "(Lorg/webrtc/AudioEncoderFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetAudioEncoderFactoryFactory_Lorg_webrtc_AudioEncoderFactoryFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetAudioEncoderFactoryFactory (global::Org.Webrtc.IAudioEncoderFactoryFactory audioEncoderFactoryFactory)
			{
				const string __id = "setAudioEncoderFactoryFactory.(Lorg/webrtc/AudioEncoderFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioEncoderFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioEncoderFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_;
#pragma warning disable 0169
			static Delegate GetSetAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_Handler ()
			{
				if (cb_setAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_ == null)
					cb_setAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_);
				return cb_setAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_;
			}

			static IntPtr n_SetAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioProcessingFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IAudioProcessingFactory audioProcessingFactory = (global::Org.Webrtc.IAudioProcessingFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAudioProcessingFactory> (native_audioProcessingFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioProcessingFactory (audioProcessingFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setAudioProcessingFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioProcessingFactory']]"
			[Register ("setAudioProcessingFactory", "(Lorg/webrtc/AudioProcessingFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetAudioProcessingFactory_Lorg_webrtc_AudioProcessingFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetAudioProcessingFactory (global::Org.Webrtc.IAudioProcessingFactory audioProcessingFactory)
			{
				const string __id = "setAudioProcessingFactory.(Lorg/webrtc/AudioProcessingFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioProcessingFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioProcessingFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_;
#pragma warning disable 0169
			static Delegate GetSetFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_Handler ()
			{
				if (cb_setFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_ == null)
					cb_setFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_);
				return cb_setFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_;
			}

			static IntPtr n_SetFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fecControllerFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IFecControllerFactoryFactoryInterface fecControllerFactoryFactory = (global::Org.Webrtc.IFecControllerFactoryFactoryInterface)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IFecControllerFactoryFactoryInterface> (native_fecControllerFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFecControllerFactoryFactoryInterface (fecControllerFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setFecControllerFactoryFactoryInterface' and count(parameter)=1 and parameter[1][@type='org.webrtc.FecControllerFactoryFactoryInterface']]"
			[Register ("setFecControllerFactoryFactoryInterface", "(Lorg/webrtc/FecControllerFactoryFactoryInterface;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetFecControllerFactoryFactoryInterface_Lorg_webrtc_FecControllerFactoryFactoryInterface_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetFecControllerFactoryFactoryInterface (global::Org.Webrtc.IFecControllerFactoryFactoryInterface fecControllerFactoryFactory)
			{
				const string __id = "setFecControllerFactoryFactoryInterface.(Lorg/webrtc/FecControllerFactoryFactoryInterface;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((fecControllerFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fecControllerFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_;
#pragma warning disable 0169
			static Delegate GetSetMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_Handler ()
			{
				if (cb_setMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_ == null)
					cb_setMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_);
				return cb_setMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_;
			}

			static IntPtr n_SetMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaTransportFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IMediaTransportFactoryFactory mediaTransportFactoryFactory = (global::Org.Webrtc.IMediaTransportFactoryFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IMediaTransportFactoryFactory> (native_mediaTransportFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMediaTransportFactoryFactory (mediaTransportFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setMediaTransportFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaTransportFactoryFactory']]"
			[Register ("setMediaTransportFactoryFactory", "(Lorg/webrtc/MediaTransportFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetMediaTransportFactoryFactory_Lorg_webrtc_MediaTransportFactoryFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetMediaTransportFactoryFactory (global::Org.Webrtc.IMediaTransportFactoryFactory mediaTransportFactoryFactory)
			{
				const string __id = "setMediaTransportFactoryFactory.(Lorg/webrtc/MediaTransportFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((mediaTransportFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaTransportFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_;
#pragma warning disable 0169
			static Delegate GetSetNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_Handler ()
			{
				if (cb_setNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_ == null)
					cb_setNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_);
				return cb_setNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_;
			}

			static IntPtr n_SetNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_neteqFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.INetEqFactoryFactory neteqFactoryFactory = (global::Org.Webrtc.INetEqFactoryFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetEqFactoryFactory> (native_neteqFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNetEqFactoryFactory (neteqFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setNetEqFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetEqFactoryFactory']]"
			[Register ("setNetEqFactoryFactory", "(Lorg/webrtc/NetEqFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetNetEqFactoryFactory_Lorg_webrtc_NetEqFactoryFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetNetEqFactoryFactory (global::Org.Webrtc.INetEqFactoryFactory neteqFactoryFactory)
			{
				const string __id = "setNetEqFactoryFactory.(Lorg/webrtc/NetEqFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((neteqFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) neteqFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_;
#pragma warning disable 0169
			static Delegate GetSetNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_Handler ()
			{
				if (cb_setNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_ == null)
					cb_setNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_);
				return cb_setNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_;
			}

			static IntPtr n_SetNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkControllerFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.INetworkControllerFactoryFactory networkControllerFactoryFactory = (global::Org.Webrtc.INetworkControllerFactoryFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkControllerFactoryFactory> (native_networkControllerFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNetworkControllerFactoryFactory (networkControllerFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setNetworkControllerFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkControllerFactoryFactory']]"
			[Register ("setNetworkControllerFactoryFactory", "(Lorg/webrtc/NetworkControllerFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetNetworkControllerFactoryFactory_Lorg_webrtc_NetworkControllerFactoryFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetNetworkControllerFactoryFactory (global::Org.Webrtc.INetworkControllerFactoryFactory networkControllerFactoryFactory)
			{
				const string __id = "setNetworkControllerFactoryFactory.(Lorg/webrtc/NetworkControllerFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((networkControllerFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) networkControllerFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_;
#pragma warning disable 0169
			static Delegate GetSetNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_Handler ()
			{
				if (cb_setNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_ == null)
					cb_setNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_);
				return cb_setNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_;
			}

			static IntPtr n_SetNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkStatePredictorFactoryFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.INetworkStatePredictorFactoryFactory networkStatePredictorFactoryFactory = (global::Org.Webrtc.INetworkStatePredictorFactoryFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkStatePredictorFactoryFactory> (native_networkStatePredictorFactoryFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNetworkStatePredictorFactoryFactory (networkStatePredictorFactoryFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setNetworkStatePredictorFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkStatePredictorFactoryFactory']]"
			[Register ("setNetworkStatePredictorFactoryFactory", "(Lorg/webrtc/NetworkStatePredictorFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetNetworkStatePredictorFactoryFactory_Lorg_webrtc_NetworkStatePredictorFactoryFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetNetworkStatePredictorFactoryFactory (global::Org.Webrtc.INetworkStatePredictorFactoryFactory networkStatePredictorFactoryFactory)
			{
				const string __id = "setNetworkStatePredictorFactoryFactory.(Lorg/webrtc/NetworkStatePredictorFactoryFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((networkStatePredictorFactoryFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) networkStatePredictorFactoryFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_;
#pragma warning disable 0169
			static Delegate GetSetOptions_Lorg_webrtc_PeerConnectionFactory_Options_Handler ()
			{
				if (cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_ == null)
					cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOptions_Lorg_webrtc_PeerConnectionFactory_Options_);
				return cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_;
			}

			static IntPtr n_SetOptions_Lorg_webrtc_PeerConnectionFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnectionFactory.Options options = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Options> (native_options, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOptions (options));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnectionFactory.Options']]"
			[Register ("setOptions", "(Lorg/webrtc/PeerConnectionFactory$Options;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetOptions_Lorg_webrtc_PeerConnectionFactory_Options_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetOptions (global::Org.Webrtc.PeerConnectionFactory.Options options)
			{
				const string __id = "setOptions.(Lorg/webrtc/PeerConnectionFactory$Options;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_;
#pragma warning disable 0169
			static Delegate GetSetVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_Handler ()
			{
				if (cb_setVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_ == null)
					cb_setVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_);
				return cb_setVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_;
			}

			static IntPtr n_SetVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_videoDecoderFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IVideoDecoderFactory videoDecoderFactory = (global::Org.Webrtc.IVideoDecoderFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoderFactory> (native_videoDecoderFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVideoDecoderFactory (videoDecoderFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setVideoDecoderFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoDecoderFactory']]"
			[Register ("setVideoDecoderFactory", "(Lorg/webrtc/VideoDecoderFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetVideoDecoderFactory_Lorg_webrtc_VideoDecoderFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetVideoDecoderFactory (global::Org.Webrtc.IVideoDecoderFactory videoDecoderFactory)
			{
				const string __id = "setVideoDecoderFactory.(Lorg/webrtc/VideoDecoderFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((videoDecoderFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoDecoderFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_;
#pragma warning disable 0169
			static Delegate GetSetVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_Handler ()
			{
				if (cb_setVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_ == null)
					cb_setVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_);
				return cb_setVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_;
			}

			static IntPtr n_SetVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_videoEncoderFactory)
			{
				global::Org.Webrtc.PeerConnectionFactory.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IVideoEncoderFactory videoEncoderFactory = (global::Org.Webrtc.IVideoEncoderFactory)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoderFactory> (native_videoEncoderFactory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVideoEncoderFactory (videoEncoderFactory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Builder']/method[@name='setVideoEncoderFactory' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoEncoderFactory']]"
			[Register ("setVideoEncoderFactory", "(Lorg/webrtc/VideoEncoderFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;", "GetSetVideoEncoderFactory_Lorg_webrtc_VideoEncoderFactory_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.Builder SetVideoEncoderFactory (global::Org.Webrtc.IVideoEncoderFactory videoEncoderFactory)
			{
				const string __id = "setVideoEncoderFactory.(Lorg/webrtc/VideoEncoderFactory;)Lorg/webrtc/PeerConnectionFactory$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((videoEncoderFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoEncoderFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory$InitializationOptions", DoNotGenerateAcw=true)]
		public partial class InitializationOptions : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']"
			[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory$InitializationOptions$Builder", DoNotGenerateAcw=true)]
			public partial class Builder : global::Java.Lang.Object {

				static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionFactory$InitializationOptions$Builder", typeof (Builder));
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

				protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_createInitializationOptions;
#pragma warning disable 0169
				static Delegate GetCreateInitializationOptionsHandler ()
				{
					if (cb_createInitializationOptions == null)
						cb_createInitializationOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateInitializationOptions);
					return cb_createInitializationOptions;
				}

				static IntPtr n_CreateInitializationOptions (IntPtr jnienv, IntPtr native__this)
				{
					global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.CreateInitializationOptions ());
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']/method[@name='createInitializationOptions' and count(parameter)=0]"
				[Register ("createInitializationOptions", "()Lorg/webrtc/PeerConnectionFactory$InitializationOptions;", "GetCreateInitializationOptionsHandler")]
				public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions CreateInitializationOptions ()
				{
					const string __id = "createInitializationOptions.()Lorg/webrtc/PeerConnectionFactory$InitializationOptions;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setEnableInternalTracer_Z;
#pragma warning disable 0169
				static Delegate GetSetEnableInternalTracer_ZHandler ()
				{
					if (cb_setEnableInternalTracer_Z == null)
						cb_setEnableInternalTracer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableInternalTracer_Z);
					return cb_setEnableInternalTracer_Z;
				}

				static IntPtr n_SetEnableInternalTracer_Z (IntPtr jnienv, IntPtr native__this, bool enableInternalTracer)
				{
					global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.SetEnableInternalTracer (enableInternalTracer));
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']/method[@name='setEnableInternalTracer' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setEnableInternalTracer", "(Z)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;", "GetSetEnableInternalTracer_ZHandler")]
				public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder SetEnableInternalTracer (bool enableInternalTracer)
				{
					const string __id = "setEnableInternalTracer.(Z)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (enableInternalTracer);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setFieldTrials_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetSetFieldTrials_Ljava_lang_String_Handler ()
				{
					if (cb_setFieldTrials_Ljava_lang_String_ == null)
						cb_setFieldTrials_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFieldTrials_Ljava_lang_String_);
					return cb_setFieldTrials_Ljava_lang_String_;
				}

				static IntPtr n_SetFieldTrials_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldTrials)
				{
					global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string fieldTrials = JNIEnv.GetString (native_fieldTrials, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFieldTrials (fieldTrials));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']/method[@name='setFieldTrials' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setFieldTrials", "(Ljava/lang/String;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;", "GetSetFieldTrials_Ljava_lang_String_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder SetFieldTrials (string fieldTrials)
				{
					const string __id = "setFieldTrials.(Ljava/lang/String;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;";
					IntPtr native_fieldTrials = JNIEnv.NewString (fieldTrials);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_fieldTrials);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_fieldTrials);
					}
				}

				static Delegate cb_setInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_;
#pragma warning disable 0169
				static Delegate GetSetInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_Handler ()
				{
					if (cb_setInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_ == null)
						cb_setInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_);
					return cb_setInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_;
				}

				static IntPtr n_SetInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loggable, IntPtr native_severity)
				{
					global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Org.Webrtc.ILoggable loggable = (global::Org.Webrtc.ILoggable)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ILoggable> (native_loggable, JniHandleOwnership.DoNotTransfer);
					global::Org.Webrtc.Logging.Severity severity = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (native_severity, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInjectableLogger (loggable, severity));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']/method[@name='setInjectableLogger' and count(parameter)=2 and parameter[1][@type='org.webrtc.Loggable'] and parameter[2][@type='org.webrtc.Logging.Severity']]"
				[Register ("setInjectableLogger", "(Lorg/webrtc/Loggable;Lorg/webrtc/Logging$Severity;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;", "GetSetInjectableLogger_Lorg_webrtc_Loggable_Lorg_webrtc_Logging_Severity_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder SetInjectableLogger (global::Org.Webrtc.ILoggable loggable, global::Org.Webrtc.Logging.Severity severity)
				{
					const string __id = "setInjectableLogger.(Lorg/webrtc/Loggable;Lorg/webrtc/Logging$Severity;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [2];
						__args [0] = new JniArgumentValue ((loggable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loggable).Handle);
						__args [1] = new JniArgumentValue ((severity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) severity).Handle);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_;
#pragma warning disable 0169
				static Delegate GetSetNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_Handler ()
				{
					if (cb_setNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_ == null)
						cb_setNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_);
					return cb_setNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_;
				}

				static IntPtr n_SetNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nativeLibraryLoader)
				{
					global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Org.Webrtc.INativeLibraryLoader nativeLibraryLoader = (global::Org.Webrtc.INativeLibraryLoader)global::Java.Lang.Object.GetObject<global::Org.Webrtc.INativeLibraryLoader> (native_nativeLibraryLoader, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNativeLibraryLoader (nativeLibraryLoader));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']/method[@name='setNativeLibraryLoader' and count(parameter)=1 and parameter[1][@type='org.webrtc.NativeLibraryLoader']]"
				[Register ("setNativeLibraryLoader", "(Lorg/webrtc/NativeLibraryLoader;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;", "GetSetNativeLibraryLoader_Lorg_webrtc_NativeLibraryLoader_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder SetNativeLibraryLoader (global::Org.Webrtc.INativeLibraryLoader nativeLibraryLoader)
				{
					const string __id = "setNativeLibraryLoader.(Lorg/webrtc/NativeLibraryLoader;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((nativeLibraryLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeLibraryLoader).Handle);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setNativeLibraryName_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetSetNativeLibraryName_Ljava_lang_String_Handler ()
				{
					if (cb_setNativeLibraryName_Ljava_lang_String_ == null)
						cb_setNativeLibraryName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNativeLibraryName_Ljava_lang_String_);
					return cb_setNativeLibraryName_Ljava_lang_String_;
				}

				static IntPtr n_SetNativeLibraryName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nativeLibraryName)
				{
					global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string nativeLibraryName = JNIEnv.GetString (native_nativeLibraryName, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNativeLibraryName (nativeLibraryName));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions.Builder']/method[@name='setNativeLibraryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setNativeLibraryName", "(Ljava/lang/String;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;", "GetSetNativeLibraryName_Ljava_lang_String_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder SetNativeLibraryName (string nativeLibraryName)
				{
					const string __id = "setNativeLibraryName.(Ljava/lang/String;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;";
					IntPtr native_nativeLibraryName = JNIEnv.NewString (nativeLibraryName);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_nativeLibraryName);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_nativeLibraryName);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionFactory$InitializationOptions", typeof (InitializationOptions));
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

			protected InitializationOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.InitializationOptions']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("builder", "(Landroid/content/Context;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;", "")]
			public static unsafe global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder InvokeBuilder (global::Android.Content.Context applicationContext)
			{
				const string __id = "builder.(Landroid/content/Context;)Lorg/webrtc/PeerConnectionFactory$InitializationOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.InitializationOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/field[@name='disableEncryption']"
			[Register ("disableEncryption")]
			public bool DisableEncryption {
				get {
					const string __id = "disableEncryption.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "disableEncryption.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/field[@name='disableNetworkMonitor']"
			[Register ("disableNetworkMonitor")]
			public bool DisableNetworkMonitor {
				get {
					const string __id = "disableNetworkMonitor.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "disableNetworkMonitor.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/field[@name='networkIgnoreMask']"
			[Register ("networkIgnoreMask")]
			public int NetworkIgnoreMask {
				get {
					const string __id = "networkIgnoreMask.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "networkIgnoreMask.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionFactory$Options", typeof (Options));
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

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/constructor[@name='PeerConnectionFactory.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionFactory", typeof (PeerConnectionFactory));
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

		protected PeerConnectionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNativeOwnedFactoryAndThreads;
#pragma warning disable 0169
		static Delegate GetGetNativeOwnedFactoryAndThreadsHandler ()
		{
			if (cb_getNativeOwnedFactoryAndThreads == null)
				cb_getNativeOwnedFactoryAndThreads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeOwnedFactoryAndThreads);
			return cb_getNativeOwnedFactoryAndThreads;
		}

		static long n_GetNativeOwnedFactoryAndThreads (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeOwnedFactoryAndThreads;
		}
#pragma warning restore 0169

		public virtual unsafe long NativeOwnedFactoryAndThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='getNativeOwnedFactoryAndThreads' and count(parameter)=0]"
			[Register ("getNativeOwnedFactoryAndThreads", "()J", "GetGetNativeOwnedFactoryAndThreadsHandler")]
			get {
				const string __id = "getNativeOwnedFactoryAndThreads.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNativePeerConnectionFactory;
#pragma warning disable 0169
		static Delegate GetGetNativePeerConnectionFactoryHandler ()
		{
			if (cb_getNativePeerConnectionFactory == null)
				cb_getNativePeerConnectionFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativePeerConnectionFactory);
			return cb_getNativePeerConnectionFactory;
		}

		static long n_GetNativePeerConnectionFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativePeerConnectionFactory;
		}
#pragma warning restore 0169

		public virtual unsafe long NativePeerConnectionFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='getNativePeerConnectionFactory' and count(parameter)=0]"
			[Register ("getNativePeerConnectionFactory", "()J", "GetGetNativePeerConnectionFactoryHandler")]
			get {
				const string __id = "getNativePeerConnectionFactory.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lorg/webrtc/PeerConnectionFactory$Builder;", "")]
		public static unsafe global::Org.Webrtc.PeerConnectionFactory.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lorg/webrtc/PeerConnectionFactory$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createAudioSource_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateAudioSource_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createAudioSource_Lorg_webrtc_MediaConstraints_ == null)
				cb_createAudioSource_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAudioSource_Lorg_webrtc_MediaConstraints_);
			return cb_createAudioSource_Lorg_webrtc_MediaConstraints_;
		}

		static IntPtr n_CreateAudioSource_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_constraints)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints constraints = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_constraints, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAudioSource (constraints));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createAudioSource' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaConstraints']]"
		[Register ("createAudioSource", "(Lorg/webrtc/MediaConstraints;)Lorg/webrtc/AudioSource;", "GetCreateAudioSource_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe global::Org.Webrtc.AudioSource CreateAudioSource (global::Org.Webrtc.MediaConstraints constraints)
		{
			const string __id = "createAudioSource.(Lorg/webrtc/MediaConstraints;)Lorg/webrtc/AudioSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((constraints == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constraints).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_;
#pragma warning disable 0169
		static Delegate GetCreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_Handler ()
		{
			if (cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ == null)
				cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_);
			return cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_;
		}

		static IntPtr n_CreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_source)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.AudioSource source = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioSource> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAudioTrack (id, source));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createAudioTrack' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.AudioSource']]"
		[Register ("createAudioTrack", "(Ljava/lang/String;Lorg/webrtc/AudioSource;)Lorg/webrtc/AudioTrack;", "GetCreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_Handler")]
		public virtual unsafe global::Org.Webrtc.AudioTrack CreateAudioTrack (string id, global::Org.Webrtc.AudioSource source)
		{
			const string __id = "createAudioTrack.(Ljava/lang/String;Lorg/webrtc/AudioSource;)Lorg/webrtc/AudioTrack;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_createLocalMediaStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateLocalMediaStream_Ljava_lang_String_Handler ()
		{
			if (cb_createLocalMediaStream_Ljava_lang_String_ == null)
				cb_createLocalMediaStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateLocalMediaStream_Ljava_lang_String_);
			return cb_createLocalMediaStream_Ljava_lang_String_;
		}

		static IntPtr n_CreateLocalMediaStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateLocalMediaStream (label));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createLocalMediaStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createLocalMediaStream", "(Ljava/lang/String;)Lorg/webrtc/MediaStream;", "GetCreateLocalMediaStream_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Webrtc.MediaStream CreateLocalMediaStream (string label)
		{
			const string __id = "createLocalMediaStream.(Ljava/lang/String;)Lorg/webrtc/MediaStream;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetCreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler ()
		{
			if (cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ == null)
				cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_);
			return cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
		}

		[Obsolete]
		static IntPtr n_CreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iceServers, IntPtr native_constraints, IntPtr native_observer)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var iceServers = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.FromJniHandle (native_iceServers, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints constraints = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_constraints, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IObserver observer = (global::Org.Webrtc.PeerConnection.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (iceServers, constraints, observer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;'] and parameter[2][@type='org.webrtc.MediaConstraints'] and parameter[3][@type='org.webrtc.PeerConnection.Observer']]"
		[Obsolete (@"deprecated")]
		[Register ("createPeerConnection", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> iceServers, global::Org.Webrtc.MediaConstraints constraints, global::Org.Webrtc.PeerConnection.IObserver observer)
		{
			const string __id = "createPeerConnection.(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;";
			IntPtr native_iceServers = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (iceServers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_iceServers);
				__args [1] = new JniArgumentValue ((constraints == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constraints).Handle);
				__args [2] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_iceServers);
			}
		}

		static Delegate cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_;
#pragma warning disable 0169
		static Delegate GetCreatePeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_Handler ()
		{
			if (cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_ == null)
				cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_);
			return cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_;
		}

		static IntPtr n_CreatePeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iceServers, IntPtr native_observer)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var iceServers = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.FromJniHandle (native_iceServers, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IObserver observer = (global::Org.Webrtc.PeerConnection.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (iceServers, observer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;'] and parameter[2][@type='org.webrtc.PeerConnection.Observer']]"
		[Register ("createPeerConnection", "(Ljava/util/List;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Ljava_util_List_Lorg_webrtc_PeerConnection_Observer_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> iceServers, global::Org.Webrtc.PeerConnection.IObserver observer)
		{
			const string __id = "createPeerConnection.(Ljava/util/List;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;";
			IntPtr native_iceServers = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (iceServers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_iceServers);
				__args [1] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_iceServers);
			}
		}

		static Delegate cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler ()
		{
			if (cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ == null)
				cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_);
			return cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
		}

		[Obsolete]
		static IntPtr n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtcConfig, IntPtr native_constraints, IntPtr native_observer)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.RTCConfiguration rtcConfig = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RTCConfiguration> (native_rtcConfig, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints constraints = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_constraints, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IObserver observer = (global::Org.Webrtc.PeerConnection.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (rtcConfig, constraints, observer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=3 and parameter[1][@type='org.webrtc.PeerConnection.RTCConfiguration'] and parameter[2][@type='org.webrtc.MediaConstraints'] and parameter[3][@type='org.webrtc.PeerConnection.Observer']]"
		[Obsolete (@"deprecated")]
		[Register ("createPeerConnection", "(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::Org.Webrtc.PeerConnection.RTCConfiguration rtcConfig, global::Org.Webrtc.MediaConstraints constraints, global::Org.Webrtc.PeerConnection.IObserver observer)
		{
			const string __id = "createPeerConnection.(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((rtcConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcConfig).Handle);
				__args [1] = new JniArgumentValue ((constraints == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constraints).Handle);
				__args [2] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_;
#pragma warning disable 0169
		static Delegate GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_Handler ()
		{
			if (cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_ == null)
				cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_);
			return cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_;
		}

		static IntPtr n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtcConfig, IntPtr native_observer)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.RTCConfiguration rtcConfig = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RTCConfiguration> (native_rtcConfig, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IObserver observer = (global::Org.Webrtc.PeerConnection.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (rtcConfig, observer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=2 and parameter[1][@type='org.webrtc.PeerConnection.RTCConfiguration'] and parameter[2][@type='org.webrtc.PeerConnection.Observer']]"
		[Register ("createPeerConnection", "(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnection_Observer_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::Org.Webrtc.PeerConnection.RTCConfiguration rtcConfig, global::Org.Webrtc.PeerConnection.IObserver observer)
		{
			const string __id = "createPeerConnection.(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rtcConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcConfig).Handle);
				__args [1] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_;
#pragma warning disable 0169
		static Delegate GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_Handler ()
		{
			if (cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_ == null)
				cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_);
			return cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_;
		}

		static IntPtr n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtcConfig, IntPtr native_dependencies)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.RTCConfiguration rtcConfig = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RTCConfiguration> (native_rtcConfig, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnectionDependencies dependencies = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionDependencies> (native_dependencies, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (rtcConfig, dependencies));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=2 and parameter[1][@type='org.webrtc.PeerConnection.RTCConfiguration'] and parameter[2][@type='org.webrtc.PeerConnectionDependencies']]"
		[Register ("createPeerConnection", "(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/PeerConnectionDependencies;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_PeerConnectionDependencies_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::Org.Webrtc.PeerConnection.RTCConfiguration rtcConfig, global::Org.Webrtc.PeerConnectionDependencies dependencies)
		{
			const string __id = "createPeerConnection.(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/PeerConnectionDependencies;)Lorg/webrtc/PeerConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rtcConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rtcConfig).Handle);
				__args [1] = new JniArgumentValue ((dependencies == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dependencies).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createVideoSource_Z;
#pragma warning disable 0169
		static Delegate GetCreateVideoSource_ZHandler ()
		{
			if (cb_createVideoSource_Z == null)
				cb_createVideoSource_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_CreateVideoSource_Z);
			return cb_createVideoSource_Z;
		}

		static IntPtr n_CreateVideoSource_Z (IntPtr jnienv, IntPtr native__this, bool isScreencast)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateVideoSource (isScreencast));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createVideoSource' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("createVideoSource", "(Z)Lorg/webrtc/VideoSource;", "GetCreateVideoSource_ZHandler")]
		public virtual unsafe global::Org.Webrtc.VideoSource CreateVideoSource (bool isScreencast)
		{
			const string __id = "createVideoSource.(Z)Lorg/webrtc/VideoSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isScreencast);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createVideoSource_ZZ;
#pragma warning disable 0169
		static Delegate GetCreateVideoSource_ZZHandler ()
		{
			if (cb_createVideoSource_ZZ == null)
				cb_createVideoSource_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool, IntPtr>) n_CreateVideoSource_ZZ);
			return cb_createVideoSource_ZZ;
		}

		static IntPtr n_CreateVideoSource_ZZ (IntPtr jnienv, IntPtr native__this, bool isScreencast, bool alignTimestamps)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateVideoSource (isScreencast, alignTimestamps));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createVideoSource' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("createVideoSource", "(ZZ)Lorg/webrtc/VideoSource;", "GetCreateVideoSource_ZZHandler")]
		public virtual unsafe global::Org.Webrtc.VideoSource CreateVideoSource (bool isScreencast, bool alignTimestamps)
		{
			const string __id = "createVideoSource.(ZZ)Lorg/webrtc/VideoSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (isScreencast);
				__args [1] = new JniArgumentValue (alignTimestamps);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_;
#pragma warning disable 0169
		static Delegate GetCreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_Handler ()
		{
			if (cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ == null)
				cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_);
			return cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_;
		}

		static IntPtr n_CreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_source)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoSource source = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateVideoTrack (id, source));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createVideoTrack' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.VideoSource']]"
		[Register ("createVideoTrack", "(Ljava/lang/String;Lorg/webrtc/VideoSource;)Lorg/webrtc/VideoTrack;", "GetCreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_Handler")]
		public virtual unsafe global::Org.Webrtc.VideoTrack CreateVideoTrack (string id, global::Org.Webrtc.VideoSource source)
		{
			const string __id = "createVideoTrack.(Ljava/lang/String;Lorg/webrtc/VideoSource;)Lorg/webrtc/VideoTrack;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
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
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='fieldTrialsFindFullName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fieldTrialsFindFullName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FieldTrialsFindFullName (string name)
		{
			const string __id = "fieldTrialsFindFullName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnectionFactory.InitializationOptions']]"
		[Register ("initialize", "(Lorg/webrtc/PeerConnectionFactory$InitializationOptions;)V", "")]
		public static unsafe void Initialize (global::Org.Webrtc.PeerConnectionFactory.InitializationOptions options)
		{
			const string __id = "initialize.(Lorg/webrtc/PeerConnectionFactory$InitializationOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='initializeFieldTrials' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("initializeFieldTrials", "(Ljava/lang/String;)V", "")]
		public static unsafe void InitializeFieldTrials (string fieldTrialsInitString)
		{
			const string __id = "initializeFieldTrials.(Ljava/lang/String;)V";
			IntPtr native_fieldTrialsInitString = JNIEnv.NewString (fieldTrialsInitString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fieldTrialsInitString);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldTrialsInitString);
			}
		}

		static Delegate cb_printInternalStackTraces_Z;
#pragma warning disable 0169
		static Delegate GetPrintInternalStackTraces_ZHandler ()
		{
			if (cb_printInternalStackTraces_Z == null)
				cb_printInternalStackTraces_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PrintInternalStackTraces_Z);
			return cb_printInternalStackTraces_Z;
		}

		static void n_PrintInternalStackTraces_Z (IntPtr jnienv, IntPtr native__this, bool printNativeStackTraces)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrintInternalStackTraces (printNativeStackTraces);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='printInternalStackTraces' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("printInternalStackTraces", "(Z)V", "GetPrintInternalStackTraces_ZHandler")]
		public virtual unsafe void PrintInternalStackTraces (bool printNativeStackTraces)
		{
			const string __id = "printInternalStackTraces.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (printNativeStackTraces);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='printStackTraces' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("printStackTraces", "()V", "")]
		public static unsafe void PrintStackTraces ()
		{
			const string __id = "printStackTraces.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='shutdownInternalTracer' and count(parameter)=0]"
		[Register ("shutdownInternalTracer", "()V", "")]
		public static unsafe void ShutdownInternalTracer ()
		{
			const string __id = "shutdownInternalTracer.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		static Delegate cb_startAecDump_II;
#pragma warning disable 0169
		static Delegate GetStartAecDump_IIHandler ()
		{
			if (cb_startAecDump_II == null)
				cb_startAecDump_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_StartAecDump_II);
			return cb_startAecDump_II;
		}

		static bool n_StartAecDump_II (IntPtr jnienv, IntPtr native__this, int file_descriptor, int filesize_limit_bytes)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartAecDump (file_descriptor, filesize_limit_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='startAecDump' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("startAecDump", "(II)Z", "GetStartAecDump_IIHandler")]
		public virtual unsafe bool StartAecDump (int file_descriptor, int filesize_limit_bytes)
		{
			const string __id = "startAecDump.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (file_descriptor);
				__args [1] = new JniArgumentValue (filesize_limit_bytes);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='startInternalTracingCapture' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startInternalTracingCapture", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool StartInternalTracingCapture (string tracingFilename)
		{
			const string __id = "startInternalTracingCapture.(Ljava/lang/String;)Z";
			IntPtr native_tracingFilename = JNIEnv.NewString (tracingFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tracingFilename);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_tracingFilename);
			}
		}

		static Delegate cb_stopAecDump;
#pragma warning disable 0169
		static Delegate GetStopAecDumpHandler ()
		{
			if (cb_stopAecDump == null)
				cb_stopAecDump = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAecDump);
			return cb_stopAecDump;
		}

		static void n_StopAecDump (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAecDump ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='stopAecDump' and count(parameter)=0]"
		[Register ("stopAecDump", "()V", "GetStopAecDumpHandler")]
		public virtual unsafe void StopAecDump ()
		{
			const string __id = "stopAecDump.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='stopInternalTracingCapture' and count(parameter)=0]"
		[Register ("stopInternalTracingCapture", "()V", "")]
		public static unsafe void StopInternalTracingCapture ()
		{
			const string __id = "stopInternalTracingCapture.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
