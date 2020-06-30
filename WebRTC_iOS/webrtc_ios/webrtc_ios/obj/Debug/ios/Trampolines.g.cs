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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal sealed class NIDAction : TrampolineBlockBase {
			DAction invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAction (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action) GetExistingManagedDelegate (block);
				return del ?? new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSError>))]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSError>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError obj)
			{
				invoker (BlockPointer, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::WebRTC.iOS.Binding.RTCLegacyStatsReport[]>))]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::WebRTC.iOS.Binding.RTCLegacyStatsReport[]>) (descriptor->Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<global::WebRTC.iOS.Binding.RTCLegacyStatsReport> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::WebRTC.iOS.Binding.RTCLegacyStatsReport[]> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::WebRTC.iOS.Binding.RTCLegacyStatsReport[]>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::WebRTC.iOS.Binding.RTCLegacyStatsReport[] obj)
			{
				var nsa_obj = obj == null ? null : NSArray.FromNSObjects (obj);
				
				invoker (BlockPointer, nsa_obj == null ? IntPtr.Zero : nsa_obj.Handle);
				if (nsa_obj != null)
					nsa_obj.Dispose ();
				
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::WebRTC.iOS.Binding.RTCSessionDescription, NSError>))]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::WebRTC.iOS.Binding.RTCSessionDescription, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<WebRTC.iOS.Binding.RTCSessionDescription> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V0 */
		
		internal sealed class NIDActionArity2V0 : TrampolineBlockBase {
			DActionArity2V0 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::WebRTC.iOS.Binding.RTCSessionDescription, NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::WebRTC.iOS.Binding.RTCSessionDescription, NSError>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::WebRTC.iOS.Binding.RTCSessionDescription arg1, NSError arg2)
			{
				invoker (BlockPointer, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageAndSeverityHandler))]
		internal delegate void DRTCCallbackLoggerMessageAndSeverityHandler (IntPtr block, IntPtr arg0, nint arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRTCCallbackLoggerMessageAndSeverityHandler {
			static internal readonly DRTCCallbackLoggerMessageAndSeverityHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRTCCallbackLoggerMessageAndSeverityHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, nint arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageAndSeverityHandler) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0), (global::WebRTC.iOS.Binding.RTCLoggingSeverity) (long) arg1);
			}
		} /* class SDRTCCallbackLoggerMessageAndSeverityHandler */
		
		internal sealed class NIDRTCCallbackLoggerMessageAndSeverityHandler : TrampolineBlockBase {
			DRTCCallbackLoggerMessageAndSeverityHandler invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDRTCCallbackLoggerMessageAndSeverityHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DRTCCallbackLoggerMessageAndSeverityHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageAndSeverityHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageAndSeverityHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDRTCCallbackLoggerMessageAndSeverityHandler ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (string arg0, global::WebRTC.iOS.Binding.RTCLoggingSeverity arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (BlockPointer, nsarg0, (nint) (Int64) arg1);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDRTCCallbackLoggerMessageAndSeverityHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageHandler))]
		internal delegate void DRTCCallbackLoggerMessageHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRTCCallbackLoggerMessageHandler {
			static internal readonly DRTCCallbackLoggerMessageHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRTCCallbackLoggerMessageHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageHandler) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0));
			}
		} /* class SDRTCCallbackLoggerMessageHandler */
		
		internal sealed class NIDRTCCallbackLoggerMessageHandler : TrampolineBlockBase {
			DRTCCallbackLoggerMessageHandler invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDRTCCallbackLoggerMessageHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DRTCCallbackLoggerMessageHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::WebRTC.iOS.Binding.RTCCallbackLoggerMessageHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDRTCCallbackLoggerMessageHandler ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (string arg0)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (BlockPointer, nsarg0);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDRTCCallbackLoggerMessageHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::WebRTC.iOS.Binding.RTCFileVideoCapturerErrorBlock))]
		internal delegate void DRTCFileVideoCapturerErrorBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRTCFileVideoCapturerErrorBlock {
			static internal readonly DRTCFileVideoCapturerErrorBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRTCFileVideoCapturerErrorBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::WebRTC.iOS.Binding.RTCFileVideoCapturerErrorBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDRTCFileVideoCapturerErrorBlock */
		
		internal sealed class NIDRTCFileVideoCapturerErrorBlock : TrampolineBlockBase {
			DRTCFileVideoCapturerErrorBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDRTCFileVideoCapturerErrorBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DRTCFileVideoCapturerErrorBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::WebRTC.iOS.Binding.RTCFileVideoCapturerErrorBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::WebRTC.iOS.Binding.RTCFileVideoCapturerErrorBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDRTCFileVideoCapturerErrorBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRTCFileVideoCapturerErrorBlock */
	}
}
