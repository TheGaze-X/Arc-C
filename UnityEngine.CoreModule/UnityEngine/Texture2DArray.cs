using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005FF RID: 1535
		[Token(Token = "0x17000165")]
		public static extern int allSlices { [Token(Token = "0x60005FF")] [Address(RVA = "0x5942690", Offset = "0x5941290", VA = "0x185942690")] [NativeName("GetAllTextureLayersIdentifier")] [MethodImpl(4096)] get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000600 RID: 1536
		[Token(Token = "0x17000166")]
		public override extern bool isReadable { [Token(Token = "0x6000600")] [Address(RVA = "0x59426C0", Offset = "0x59412C0", VA = "0x1859426C0", Slot = "11")] [MethodImpl(4096)] get; }

		// Token: 0x06000601 RID: 1537
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x5941C00", Offset = "0x5940800", VA = "0x185941C00")]
		[FreeFunction("Texture2DArrayScripting::Create")]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags);

		// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x5941C60", Offset = "0x5940860", VA = "0x185941C60")]
		private static void Internal_Create([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x5941E80", Offset = "0x5940A80", VA = "0x185941E80")]
		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x5941D40", Offset = "0x5940940", VA = "0x185941D40")]
		internal bool ValidateFormat(GraphicsFormat format, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x59425D0", Offset = "0x59411D0", VA = "0x1859425D0")]
		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x5942020", Offset = "0x5940C20", VA = "0x185942020")]
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x59420D0", Offset = "0x5940CD0", VA = "0x1859420D0")]
		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5942330", Offset = "0x5940F30", VA = "0x185942330")]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x59425A0", Offset = "0x59411A0", VA = "0x1859425A0")]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x5941FE0", Offset = "0x5940BE0", VA = "0x185941FE0")]
		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x5941F70", Offset = "0x5940B70", VA = "0x185941F70")]
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
