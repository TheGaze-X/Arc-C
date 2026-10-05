using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	[StaticAccessor("PhotoCapture", StaticAccessorType.DoubleColon)]
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	[NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
	[StructLayout(0)]
	public class PhotoCapture : IDisposable
	{
		// Token: 0x06000C3D RID: 3133 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x59653C0", Offset = "0x5963FC0", VA = "0x1859653C0")]
		private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult)
		{
			return default(PhotoCapture.PhotoCaptureResult);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x5965300", Offset = "0x5963F00", VA = "0x185965300")]
		[RequiredByNativeCode]
		private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr)
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x485B340", Offset = "0x4859F40", VA = "0x18485B340")]
		private PhotoCapture(IntPtr nativeCaptureObject)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x59650A0", Offset = "0x5963CA0", VA = "0x1859650A0")]
		[RequiredByNativeCode]
		private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult)
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x59650A0", Offset = "0x5963CA0", VA = "0x1859650A0")]
		[RequiredByNativeCode]
		private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult)
		{
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x59650A0", Offset = "0x5963CA0", VA = "0x1859650A0")]
		[RequiredByNativeCode]
		private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult)
		{
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x5965130", Offset = "0x5963D30", VA = "0x185965130")]
		[RequiredByNativeCode]
		private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr)
		{
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x5964F10", Offset = "0x5963B10", VA = "0x185964F10", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000C45 RID: 3141
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x5964ED0", Offset = "0x5963AD0", VA = "0x185964ED0")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[NativeName("Dispose")]
		[MethodImpl(4096)]
		private extern void Dispose_Internal();

		// Token: 0x06000C46 RID: 3142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x5964FC0", Offset = "0x5963BC0", VA = "0x185964FC0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000C47 RID: 3143
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x5964E90", Offset = "0x5963A90", VA = "0x185964E90")]
		[ThreadAndSerializationSafe]
		[NativeName("DisposeThreaded")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[MethodImpl(4096)]
		private extern void DisposeThreaded_Internal();

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_NativePtr;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly long HR_SUCCESS;

		// Token: 0x0200016E RID: 366
		[Token(Token = "0x200016E")]
		public enum CaptureResultType
		{
			// Token: 0x0400059A RID: 1434
			[Token(Token = "0x400059A")]
			Success,
			// Token: 0x0400059B RID: 1435
			[Token(Token = "0x400059B")]
			UnknownError
		}

		// Token: 0x0200016F RID: 367
		[Token(Token = "0x200016F")]
		public struct PhotoCaptureResult
		{
			// Token: 0x0400059C RID: 1436
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PhotoCapture.CaptureResultType resultType;

			// Token: 0x0400059D RID: 1437
			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long hResult;
		}

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000C49 RID: 3145
		[Token(Token = "0x2000170")]
		public delegate void OnCaptureResourceCreatedCallback(PhotoCapture captureObject);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x06000C4B RID: 3147
		[Token(Token = "0x2000171")]
		public delegate void OnPhotoModeStartedCallback(PhotoCapture.PhotoCaptureResult result);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x06000C4D RID: 3149
		[Token(Token = "0x2000172")]
		public delegate void OnPhotoModeStoppedCallback(PhotoCapture.PhotoCaptureResult result);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x06000C4F RID: 3151
		[Token(Token = "0x2000173")]
		public delegate void OnCapturedToDiskCallback(PhotoCapture.PhotoCaptureResult result);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x06000C51 RID: 3153
		[Token(Token = "0x2000174")]
		public delegate void OnCapturedToMemoryCallback(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame);
	}
}
