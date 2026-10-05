using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
	[ExcludeFromPreset]
	public sealed class CubemapArray : Texture
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600060C RID: 1548
		[Token(Token = "0x17000167")]
		public override extern bool isReadable { [Token(Token = "0x600060C")] [Address(RVA = "0x5924A10", Offset = "0x5923610", VA = "0x185924A10", Slot = "11")] [MethodImpl(4096)] get; }

		// Token: 0x0600060D RID: 1549
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x59241F0", Offset = "0x5922DF0", VA = "0x1859241F0")]
		[FreeFunction("CubemapArrayScripting::Create")]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags);

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x5924250", Offset = "0x5922E50", VA = "0x185924250")]
		private static void Internal_Create([Writable] CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5924680", Offset = "0x5923280", VA = "0x185924680")]
		[ExcludeFromDocs]
		public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5924850", Offset = "0x5923450", VA = "0x185924850")]
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x59243A0", Offset = "0x5922FA0", VA = "0x1859243A0")]
		[ExcludeFromDocs]
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x59244F0", Offset = "0x59230F0", VA = "0x1859244F0")]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5924820", Offset = "0x5923420", VA = "0x185924820")]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x59249E0", Offset = "0x59235E0", VA = "0x1859249E0")]
		[ExcludeFromDocs]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5924330", Offset = "0x5922F30", VA = "0x185924330")]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
