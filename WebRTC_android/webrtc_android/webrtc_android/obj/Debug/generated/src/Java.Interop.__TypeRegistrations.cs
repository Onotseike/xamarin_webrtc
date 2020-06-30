using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/webrtc",
					},
					new Converter<string, Type>[]{
						lookup_org_webrtc_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_webrtc_mappings;
		static Type lookup_org_webrtc_package (string klass)
		{
			if (package_org_webrtc_mappings == null) {
				package_org_webrtc_mappings = new string[]{
					"org/webrtc/CameraVideoCapturer$CameraStatistics:Org.Webrtc.CameraVideoCapturerCameraStatistics",
					"org/webrtc/EglBase$ConfigBuilder:Org.Webrtc.EglBaseConfigBuilder",
					"org/webrtc/VideoDecoder$DecodeInfo:Org.Webrtc.VideoDecoderDecodeInfo",
					"org/webrtc/VideoDecoder$Settings:Org.Webrtc.VideoDecoderSettings",
					"org/webrtc/VideoEncoder$BitrateAllocation:Org.Webrtc.VideoEncoderBitrateAllocation",
					"org/webrtc/VideoEncoder$Capabilities:Org.Webrtc.VideoEncoderCapabilities",
					"org/webrtc/VideoEncoder$CodecSpecificInfo:Org.Webrtc.VideoEncoderCodecSpecificInfo",
					"org/webrtc/VideoEncoder$CodecSpecificInfoH264:Org.Webrtc.VideoEncoderCodecSpecificInfoH264",
					"org/webrtc/VideoEncoder$CodecSpecificInfoVP8:Org.Webrtc.VideoEncoderCodecSpecificInfoVP8",
					"org/webrtc/VideoEncoder$CodecSpecificInfoVP9:Org.Webrtc.VideoEncoderCodecSpecificInfoVP9",
					"org/webrtc/VideoEncoder$EncodeInfo:Org.Webrtc.VideoEncoderEncodeInfo",
					"org/webrtc/VideoEncoder$ResolutionBitrateLimits:Org.Webrtc.VideoEncoderResolutionBitrateLimits",
					"org/webrtc/VideoEncoder$ScalingSettings:Org.Webrtc.VideoEncoderScalingSettings",
					"org/webrtc/VideoEncoder$Settings:Org.Webrtc.VideoEncoderSettings",
					"org/webrtc/VideoFrame$TextureBuffer$Type:Org.Webrtc.VideoFrame/TextureBufferType",
					"org/webrtc/VideoProcessor$FrameAdaptationParameters:Org.Webrtc.VideoProcessorFrameAdaptationParameters",
				};
			}

			return Lookup (package_org_webrtc_mappings, klass);
		}
	}
}
