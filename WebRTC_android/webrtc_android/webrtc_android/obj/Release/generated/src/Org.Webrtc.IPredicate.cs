using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']"
	[Register ("org/webrtc/Predicate", "", "Org.Webrtc.IPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='Predicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("test", "(Ljava/lang/Object;)Z", "GetTest_Ljava_lang_Object_Handler:Org.Webrtc.IPredicateInvoker, webrtc_android")]
		bool Test (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/Predicate", DoNotGenerateAcw=true)]
	internal partial class IPredicateInvoker : global::Java.Lang.Object, IPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Predicate", typeof (IPredicateInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.Predicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTest_Ljava_lang_Object_Handler ()
		{
			if (cb_test_Ljava_lang_Object_ == null)
				cb_test_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Test_Ljava_lang_Object_);
			return cb_test_Ljava_lang_Object_;
		}

		static bool n_Test_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IPredicate __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Test (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_test_Ljava_lang_Object_;
		public unsafe bool Test (global::Java.Lang.Object p0)
		{
			if (id_test_Ljava_lang_Object_ == IntPtr.Zero)
				id_test_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
