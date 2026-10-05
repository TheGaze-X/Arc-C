using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[StaticAccessor("VideoCaptureBindings", StaticAccessorType.DoubleColon)]
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
	[StructLayout(0)]
	public class VideoCapture : IDisposable
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x5979450", Offset = "0x5978050", VA = "0x185979450")]
		private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult)
		{
			return default(VideoCapture.VideoCaptureResult);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x5979300", Offset = "0x5977F00", VA = "0x185979300")]
		[RequiredByNativeCode]
		private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x485B340", Offset = "0x4859F40", VA = "0x18485B340")]
		private VideoCapture(IntPtr nativeCaptureObject)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x59793C0", Offset = "0x5977FC0", VA = "0x1859793C0")]
		[RequiredByNativeCode]
		private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult)
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x59793C0", Offset = "0x5977FC0", VA = "0x1859793C0")]
		[RequiredByNativeCode]
		private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x59793C0", Offset = "0x5977FC0", VA = "0x1859793C0")]
		[RequiredByNativeCode]
		private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult)
		{
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x59793C0", Offset = "0x5977FC0", VA = "0x1859793C0")]
		[RequiredByNativeCode]
		private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult)
		{
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x5979170", Offset = "0x5977D70", VA = "0x185979170", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000C66 RID: 3174
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x5979130", Offset = "0x5977D30", VA = "0x185979130")]
		[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = true)]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[MethodImpl(4096)]
		private extern void Dispose_Internal();

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x5979220", Offset = "0x5977E20", VA = "0x185979220", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000C68 RID: 3176
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x59790F0", Offset = "0x5977CF0", VA = "0x1859790F0")]
		[ThreadAndSerializationSafe]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void DisposeThreaded_Internal();

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_NativePtr;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly long HR_SUCCESS;

		// Token: 0x02000177 RID: 375
		[Token(Token = "0x2000177")]
		public enum CaptureResultType
		{
			// Token: 0x040005A5 RID: 1445
			[Token(Token = "0x40005A5")]
			Success,
			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			UnknownError
		}

		// Token: 0x02000178 RID: 376
		[Token(Token = "0x2000178")]
		public struct VideoCaptureResult
		{
			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VideoCapture.CaptureResultType resultType;

			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long hResult;
		}

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x06000C6A RID: 3178
		[Token(Token = "0x2000179")]
		public delegate void OnVideoCaptureResourceCreatedCallback(VideoCapture captureObject);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x06000C6C RID: 3180
		[Token(Token = "0x200017A")]
		public delegate void OnVideoModeStartedCallback(VideoCapture.VideoCaptureResult result);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x06000C6E RID: 3182
		[Token(Token = "0x200017B")]
		public delegate void OnVideoModeStoppedCallback(VideoCapture.VideoCaptureResult result);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x06000C70 RID: 3184
		[Token(Token = "0x200017C")]
		public delegate void OnStartedRecordingVideoCallback(VideoCapture.VideoCaptureResult result);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x06000C72 RID: 3186
		[Token(Token = "0x200017D")]
		public delegate void OnStoppedRecordingVideoCallback(VideoCapture.VideoCaptureResult result);
	}
}
