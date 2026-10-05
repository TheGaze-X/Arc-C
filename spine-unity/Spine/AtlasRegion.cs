using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class AtlasRegion
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4E41AE0", Offset = "0x4E406E0", VA = "0x184E41AE0")]
		public AtlasRegion Clone()
		{
			return null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AtlasRegion()
		{
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x10")]
		public AtlasPage page;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x20")]
		public int x;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x24")]
		public int y;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x28")]
		public int width;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x2C")]
		public int height;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x30")]
		public float u;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x34")]
		public float v;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x38")]
		public float u2;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x3C")]
		public float v2;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x40")]
		public float offsetX;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x44")]
		public float offsetY;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x48")]
		public int originalWidth;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x4C")]
		public int originalHeight;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x50")]
		public int index;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x54")]
		public bool rotate;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x58")]
		public int degrees;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x60")]
		public int[] splits;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x68")]
		public int[] pads;
	}
}
