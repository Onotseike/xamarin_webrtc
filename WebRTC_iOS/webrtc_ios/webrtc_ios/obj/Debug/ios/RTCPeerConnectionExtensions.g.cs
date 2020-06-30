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
	public unsafe static partial class RTCPeerConnectionExtensions  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("RTCPeerConnection");
		
		[Export ("dataChannelForLabel:configuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static RTCDataChannel DataChannelForLabel (this RTCPeerConnection This, string label, RTCDataChannelConfiguration configuration)
		{
			if (label == null)
				throw new ArgumentNullException ("label");
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			var nslabel = NSString.CreateNative (label);
			
			RTCDataChannel ret;
			ret =  Runtime.GetNSObject<RTCDataChannel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("dataChannelForLabel:configuration:"), nslabel, configuration.Handle));
			NSString.ReleaseNative (nslabel);
			
			return ret;
		}
		
		[Export ("senderWithKind:streamId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static RTCRtpSender SenderWithKind (this RTCPeerConnection This, string kind, string streamId)
		{
			if (kind == null)
				throw new ArgumentNullException ("kind");
			if (streamId == null)
				throw new ArgumentNullException ("streamId");
			var nskind = NSString.CreateNative (kind);
			var nsstreamId = NSString.CreateNative (streamId);
			
			RTCRtpSender ret;
			ret =  Runtime.GetNSObject<RTCRtpSender> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("senderWithKind:streamId:"), nskind, nsstreamId));
			NSString.ReleaseNative (nskind);
			NSString.ReleaseNative (nsstreamId);
			
			return ret;
		}
		
		[Export ("statsForTrack:statsOutputLevel:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void StatsForTrack (this RTCPeerConnection This, RTCMediaStreamTrack mediaStreamTrack, RTCStatsOutputLevel statsOutputLevel, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<RTCLegacyStatsReport[]> completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completionHandler);
			}
			
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr (This.Handle, Selector.GetHandle ("statsForTrack:statsOutputLevel:completionHandler:"), mediaStreamTrack == null ? IntPtr.Zero : mediaStreamTrack.Handle, (Int64)statsOutputLevel, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (This.Handle, Selector.GetHandle ("statsForTrack:statsOutputLevel:completionHandler:"), mediaStreamTrack == null ? IntPtr.Zero : mediaStreamTrack.Handle, (int)statsOutputLevel, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
	} /* class RTCPeerConnectionExtensions */
}
