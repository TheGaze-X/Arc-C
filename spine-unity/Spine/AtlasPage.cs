using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class AtlasPage
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4E41A30", Offset = "0x4E40630", VA = "0x184E41A30")]
		public AtlasPage Clone()
		{
			return null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AtlasPage()
		{
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x18")]
		public Format format;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x1C")]
		public TextureFilter minFilter;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x20")]
		public TextureFilter magFilter;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x24")]
		public TextureWrap uWrap;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x28")]
		public TextureWrap vWrap;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x30")]
		public object rendererObject;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x38")]
		public int width;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x3C")]
		public int height;
	}
}
