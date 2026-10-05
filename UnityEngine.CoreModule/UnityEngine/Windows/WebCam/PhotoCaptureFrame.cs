using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	public sealed class PhotoCaptureFrame : IDisposable
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00006960 File Offset: 0x00004B60
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		public int dataLength
		{
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700028E RID: 654
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		private bool hasLocationData
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x1241210", Offset = "0x123FE10", VA = "0x181241210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700028F RID: 655
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		private CapturePixelFormat pixelFormat
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C56 RID: 3158
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x5964D30", Offset = "0x5963930", VA = "0x185964D30")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		private extern int GetDataLength();

		// Token: 0x06000C57 RID: 3159
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x5964D70", Offset = "0x5963970", VA = "0x185964D70")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		private extern bool GetHasLocationData();

		// Token: 0x06000C58 RID: 3160
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x5964CF0", Offset = "0x59638F0", VA = "0x185964CF0")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		private extern CapturePixelFormat GetCapturePixelFormat();

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x5964DB0", Offset = "0x59639B0", VA = "0x185964DB0")]
		internal PhotoCaptureFrame(IntPtr nativePtr)
		{
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x5964B30", Offset = "0x5963730", VA = "0x185964B30")]
		private void Cleanup()
		{
		}

		// Token: 0x06000C5B RID: 3163
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x5964BF0", Offset = "0x59637F0", VA = "0x185964BF0")]
		[ThreadAndSerializationSafe]
		[NativeName("Dispose")]
		[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
		[MethodImpl(4096)]
		private extern void Dispose_Internal();

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x5964C30", Offset = "0x5963830", VA = "0x185964C30", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x5964C90", Offset = "0x5963890", VA = "0x185964C90", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_NativePtr;
	}
}
