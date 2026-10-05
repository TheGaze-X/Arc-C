using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
	public static class ImageConversion
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5989BB0", Offset = "0x59887B0", VA = "0x185989BB0")]
		[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern byte[] EncodeToPNG(this Texture2D tex);

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5989B70", Offset = "0x5988770", VA = "0x185989B70")]
		[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern byte[] EncodeToJPG(this Texture2D tex, int quality);

		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5989C40", Offset = "0x5988840", VA = "0x185989C40")]
		[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = true)]
		[MethodImpl(4096)]
		public static extern bool LoadImage([NotNull("ArgumentNullException")] this Texture2D tex, byte[] data, bool markNonReadable);

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5989BF0", Offset = "0x59887F0", VA = "0x185989BF0")]
		public static bool LoadImage(this Texture2D tex, byte[] data)
		{
			return default(bool);
		}
	}
}
