using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	internal class TextureRegistry
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700033A")]
		public static TextureRegistry instance
		{
			[Token(Token = "0x6000E1A")]
			[Address(RVA = "0x5B14C50", Offset = "0x5B13850", VA = "0x185B14C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x5B14300", Offset = "0x5B12F00", VA = "0x185B14300")]
		public Texture GetTexture(TextureId id)
		{
			return null;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x5B14020", Offset = "0x5B12C20", VA = "0x185B14020")]
		public TextureId AllocAndAcquireDynamic()
		{
			return default(TextureId);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x5B14730", Offset = "0x5B13330", VA = "0x185B14730")]
		public void UpdateDynamic(TextureId id, Texture texture)
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x5B14030", Offset = "0x5B12C30", VA = "0x185B14030")]
		private TextureId AllocAndAcquire(Texture texture, bool dynamic)
		{
			return default(TextureId);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x5B13E90", Offset = "0x5B12A90", VA = "0x185B13E90")]
		public TextureId Acquire(Texture tex)
		{
			return default(TextureId);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x5B144A0", Offset = "0x5B130A0", VA = "0x185B144A0")]
		public void Release(TextureId id)
		{
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x5B14B20", Offset = "0x5B13720", VA = "0x185B14B20")]
		public TextureRegistry()
		{
		}

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x10")]
		private List<TextureRegistry.TextureInfo> m_Textures;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Texture, TextureId> m_TextureToId;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x20")]
		private Stack<TextureId> m_FreeIds;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		internal const int maxTextures = 2048;

		// Token: 0x02000214 RID: 532
		[Token(Token = "0x2000214")]
		private struct TextureInfo
		{
			// Token: 0x0400078F RID: 1935
			[Token(Token = "0x400078F")]
			[FieldOffset(Offset = "0x0")]
			public Texture texture;

			// Token: 0x04000790 RID: 1936
			[Token(Token = "0x4000790")]
			[FieldOffset(Offset = "0x8")]
			public bool dynamic;

			// Token: 0x04000791 RID: 1937
			[Token(Token = "0x4000791")]
			[FieldOffset(Offset = "0xC")]
			public int refCount;
		}
	}
}
