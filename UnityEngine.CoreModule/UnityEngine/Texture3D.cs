using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/Texture3D.h")]
	public sealed class Texture3D : Texture
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005EE RID: 1518
		[Token(Token = "0x17000163")]
		public extern int depth { [Token(Token = "0x60005EE")] [Address(RVA = "0x5945B10", Offset = "0x5944710", VA = "0x185945B10")] [NativeName("GetTextureLayerCount")] [MethodImpl(4096)] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005EF RID: 1519
		[Token(Token = "0x17000164")]
		public override extern bool isReadable { [Token(Token = "0x60005EF")] [Address(RVA = "0x5945B50", Offset = "0x5944750", VA = "0x185945B50", Slot = "11")] [MethodImpl(4096)] get; }

		// Token: 0x060005F0 RID: 1520
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x5944CB0", Offset = "0x59438B0", VA = "0x185944CB0")]
		[FreeFunction("Texture3DScripting::Create")]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex);

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x5944D10", Offset = "0x5943910", VA = "0x185944D10")]
		private static void Internal_Create([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
		}

		// Token: 0x060005F2 RID: 1522
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x5944B10", Offset = "0x5943710", VA = "0x185944B10")]
		[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x060005F3 RID: 1523
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x5944E00", Offset = "0x5943A00", VA = "0x185944E00")]
		[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void SetPixels([Unmarshalled] Color[] colors, int miplevel);

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x5944E60", Offset = "0x5943A60", VA = "0x185944E60")]
		public void SetPixels(Color[] colors)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x5945440", Offset = "0x5944040", VA = "0x185945440")]
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x5945270", Offset = "0x5943E70", VA = "0x185945270")]
		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x59450E0", Offset = "0x5943CE0", VA = "0x1859450E0")]
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x5945960", Offset = "0x5944560", VA = "0x185945960")]
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x59457C0", Offset = "0x59443C0", VA = "0x1859457C0")]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x5944F20", Offset = "0x5943B20", VA = "0x185944F20")]
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x5945620", Offset = "0x5944220", VA = "0x185945620")]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x5944C00", Offset = "0x5943800", VA = "0x185944C00")]
		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x5944B70", Offset = "0x5943770", VA = "0x185944B70")]
		[ExcludeFromDocs]
		public void Apply()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x5944EB0", Offset = "0x5943AB0", VA = "0x185944EB0")]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
