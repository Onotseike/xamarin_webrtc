using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/BuildInfo", DoNotGenerateAcw=true)]
	public sealed partial class BuildInfo : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/BuildInfo", typeof (BuildInfo));
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

		internal BuildInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/constructor[@name='BuildInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildInfo ()
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

		public static unsafe string AndroidBuildId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getAndroidBuildId' and count(parameter)=0]"
			[Register ("getAndroidBuildId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAndroidBuildId.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Brand {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getBrand' and count(parameter)=0]"
			[Register ("getBrand", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBrand.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string BuildRelease {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getBuildRelease' and count(parameter)=0]"
			[Register ("getBuildRelease", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBuildRelease.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string BuildType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getBuildType' and count(parameter)=0]"
			[Register ("getBuildType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBuildType.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDevice.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string DeviceManufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getDeviceManufacturer' and count(parameter)=0]"
			[Register ("getDeviceManufacturer", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceManufacturer.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceModel.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Product {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getProduct' and count(parameter)=0]"
			[Register ("getProduct", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getProduct.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()I", "")]
			get {
				const string __id = "getSdkVersion.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
