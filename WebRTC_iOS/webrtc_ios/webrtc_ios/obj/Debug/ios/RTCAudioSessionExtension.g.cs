//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace WebRTC.iOS.Binding {
	public unsafe static partial class RTCAudioSessionExtension  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("RTCAudioSession");
		
		[Export ("setConfiguration:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetConfiguration (this RTCAudioSession This, RTCAudioSessionConfiguration configuration, out NSError outError)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			IntPtr outErrorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (This.Handle, Selector.GetHandle ("setConfiguration:error:"), configuration.Handle, ref outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue);
			
			return ret;
		}
		
		[Export ("setConfiguration:active:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetConfiguration (this RTCAudioSession This, RTCAudioSessionConfiguration configuration, bool active, out NSError outError)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			IntPtr outErrorValue = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_ref_IntPtr (This.Handle, Selector.GetHandle ("setConfiguration:active:error:"), configuration.Handle, active, ref outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue);
			
			return ret;
		}
		
	} /* class RTCAudioSessionExtension */
}
