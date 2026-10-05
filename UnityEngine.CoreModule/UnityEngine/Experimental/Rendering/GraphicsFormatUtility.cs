using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002BB RID: 699
	[Token(Token = "0x20002BB")]
	[NativeHeader("Runtime/Graphics/Format.h")]
	[NativeHeader("Runtime/Graphics/TextureFormat.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	public class GraphicsFormatUtility
	{
		// Token: 0x06000FA8 RID: 4008
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x597F030", Offset = "0x597DC30", VA = "0x18597F030")]
		[FreeFunction("GetTextureGraphicsFormat")]
		[MethodImpl(4096)]
		internal static extern GraphicsFormat GetFormat([NotNull("NullExceptionObject")] Texture texture);

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x597F240", Offset = "0x597DE40", VA = "0x18597F240")]
		public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000FAA RID: 4010
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x597F0B0", Offset = "0x597DCB0", VA = "0x18597F0B0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB);

		// Token: 0x06000FAB RID: 4011 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x597F1C0", Offset = "0x597DDC0", VA = "0x18597F1C0")]
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000FAC RID: 4012
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x597F070", Offset = "0x597DC70", VA = "0x18597F070")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB);

		// Token: 0x06000FAD RID: 4013 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x597F0F0", Offset = "0x597DCF0", VA = "0x18597F0F0")]
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000FAE RID: 4014
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x597ECE0", Offset = "0x597D8E0", VA = "0x18597ECE0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);

		// Token: 0x06000FAF RID: 4015 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x597ED20", Offset = "0x597D920", VA = "0x18597ED20")]
		internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000FB0 RID: 4016
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x597ECA0", Offset = "0x597D8A0", VA = "0x18597ECA0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern int GetDepthBits(GraphicsFormat format);

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x597ED90", Offset = "0x597D990", VA = "0x18597ED90")]
		public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000FB2 RID: 4018
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x597F460", Offset = "0x597E060", VA = "0x18597F460")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern bool IsSRGBFormat(GraphicsFormat format);

		// Token: 0x06000FB3 RID: 4019
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x597F340", Offset = "0x597DF40", VA = "0x18597F340")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern GraphicsFormat GetSRGBFormat(GraphicsFormat format);

		// Token: 0x06000FB4 RID: 4020
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x597F2C0", Offset = "0x597DEC0", VA = "0x18597F2C0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern GraphicsFormat GetLinearFormat(GraphicsFormat format);

		// Token: 0x06000FB5 RID: 4021
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x597F300", Offset = "0x597DF00", VA = "0x18597F300")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format);

		// Token: 0x06000FB6 RID: 4022
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x597F380", Offset = "0x597DF80", VA = "0x18597F380")]
		[FreeFunction("IsAnyCompressedTextureFormat", true)]
		[MethodImpl(4096)]
		internal static extern bool IsCompressedTextureFormat(TextureFormat format);

		// Token: 0x06000FB7 RID: 4023
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x597EC60", Offset = "0x597D860", VA = "0x18597EC60")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern bool CanDecompressFormat(GraphicsFormat format, bool wholeImage);

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x597EBF0", Offset = "0x597D7F0", VA = "0x18597EBF0")]
		internal static bool CanDecompressFormat(GraphicsFormat format)
		{
			return default(bool);
		}

		// Token: 0x06000FB9 RID: 4025
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x597F3E0", Offset = "0x597DFE0", VA = "0x18597F3E0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern bool IsDepthFormat(GraphicsFormat format);

		// Token: 0x06000FBA RID: 4026
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x597F4A0", Offset = "0x597E0A0", VA = "0x18597F4A0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern bool IsStencilFormat(GraphicsFormat format);

		// Token: 0x06000FBB RID: 4027
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x597F420", Offset = "0x597E020", VA = "0x18597F420")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern bool IsPVRTCFormat(GraphicsFormat format);

		// Token: 0x06000FBC RID: 4028 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x597F3C0", Offset = "0x597DFC0", VA = "0x18597F3C0")]
		public static bool IsCrunchFormat(TextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GraphicsFormat[] tableNoStencil;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly GraphicsFormat[] tableStencil;
	}
}
