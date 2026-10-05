using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
	public sealed class Cubemap : Texture
	{
		// Token: 0x060005E1 RID: 1505
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x5924A50", Offset = "0x5923650", VA = "0x185924A50")]
		[FreeFunction("CubemapScripting::Create")]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex);

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5924AB0", Offset = "0x59236B0", VA = "0x185924AB0")]
		private static void Internal_Create([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005E3 RID: 1507
		[Token(Token = "0x17000162")]
		public override extern bool isReadable { [Token(Token = "0x60005E3")] [Address(RVA = "0x59255C0", Offset = "0x59241C0", VA = "0x1859255C0", Slot = "11")] [MethodImpl(4096)] get; }

		// Token: 0x060005E4 RID: 1508 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x5924B90", Offset = "0x5923790", VA = "0x185924B90")]
		internal bool ValidateFormat(TextureFormat format, int width)
		{
			return default(bool);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x5924C70", Offset = "0x5923870", VA = "0x185924C70")]
		internal bool ValidateFormat(GraphicsFormat format, int width)
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x5924E00", Offset = "0x5923A00", VA = "0x185924E00")]
		[ExcludeFromDocs]
		public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x5924F80", Offset = "0x5923B80", VA = "0x185924F80")]
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x5925260", Offset = "0x5923E60", VA = "0x185925260")]
		public Cubemap(int width, TextureFormat format, int mipCount)
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x5925100", Offset = "0x5923D00", VA = "0x185925100")]
		[ExcludeFromDocs]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x5925370", Offset = "0x5923F70", VA = "0x185925370")]
		internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x59255A0", Offset = "0x59241A0", VA = "0x1859255A0")]
		internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x59252E0", Offset = "0x5923EE0", VA = "0x1859252E0")]
		public Cubemap(int width, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x5924D90", Offset = "0x5923990", VA = "0x185924D90")]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
