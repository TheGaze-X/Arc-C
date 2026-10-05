using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro.SpriteAssetUtilities
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public class TexturePacker_JsonArray
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TexturePacker_JsonArray()
		{
		}

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		[Serializable]
		public struct SpriteFrame
		{
			// Token: 0x06000650 RID: 1616 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x58D96D0", Offset = "0x58D82D0", VA = "0x1858D96D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400060B RID: 1547
			[Token(Token = "0x400060B")]
			[FieldOffset(Offset = "0x0")]
			public float x;

			// Token: 0x0400060C RID: 1548
			[Token(Token = "0x400060C")]
			[FieldOffset(Offset = "0x4")]
			public float y;

			// Token: 0x0400060D RID: 1549
			[Token(Token = "0x400060D")]
			[FieldOffset(Offset = "0x8")]
			public float w;

			// Token: 0x0400060E RID: 1550
			[Token(Token = "0x400060E")]
			[FieldOffset(Offset = "0xC")]
			public float h;
		}

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		[Serializable]
		public struct SpriteSize
		{
			// Token: 0x06000651 RID: 1617 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x58D9A40", Offset = "0x58D8640", VA = "0x1858D9A40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400060F RID: 1551
			[Token(Token = "0x400060F")]
			[FieldOffset(Offset = "0x0")]
			public float w;

			// Token: 0x04000610 RID: 1552
			[Token(Token = "0x4000610")]
			[FieldOffset(Offset = "0x4")]
			public float h;
		}

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		[Serializable]
		public struct Frame
		{
			// Token: 0x04000611 RID: 1553
			[Token(Token = "0x4000611")]
			[FieldOffset(Offset = "0x0")]
			public string filename;

			// Token: 0x04000612 RID: 1554
			[Token(Token = "0x4000612")]
			[FieldOffset(Offset = "0x8")]
			public TexturePacker_JsonArray.SpriteFrame frame;

			// Token: 0x04000613 RID: 1555
			[Token(Token = "0x4000613")]
			[FieldOffset(Offset = "0x18")]
			public bool rotated;

			// Token: 0x04000614 RID: 1556
			[Token(Token = "0x4000614")]
			[FieldOffset(Offset = "0x19")]
			public bool trimmed;

			// Token: 0x04000615 RID: 1557
			[Token(Token = "0x4000615")]
			[FieldOffset(Offset = "0x1C")]
			public TexturePacker_JsonArray.SpriteFrame spriteSourceSize;

			// Token: 0x04000616 RID: 1558
			[Token(Token = "0x4000616")]
			[FieldOffset(Offset = "0x2C")]
			public TexturePacker_JsonArray.SpriteSize sourceSize;

			// Token: 0x04000617 RID: 1559
			[Token(Token = "0x4000617")]
			[FieldOffset(Offset = "0x34")]
			public Vector2 pivot;
		}

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		[Serializable]
		public struct Meta
		{
			// Token: 0x04000618 RID: 1560
			[Token(Token = "0x4000618")]
			[FieldOffset(Offset = "0x0")]
			public string app;

			// Token: 0x04000619 RID: 1561
			[Token(Token = "0x4000619")]
			[FieldOffset(Offset = "0x8")]
			public string version;

			// Token: 0x0400061A RID: 1562
			[Token(Token = "0x400061A")]
			[FieldOffset(Offset = "0x10")]
			public string image;

			// Token: 0x0400061B RID: 1563
			[Token(Token = "0x400061B")]
			[FieldOffset(Offset = "0x18")]
			public string format;

			// Token: 0x0400061C RID: 1564
			[Token(Token = "0x400061C")]
			[FieldOffset(Offset = "0x20")]
			public TexturePacker_JsonArray.SpriteSize size;

			// Token: 0x0400061D RID: 1565
			[Token(Token = "0x400061D")]
			[FieldOffset(Offset = "0x28")]
			public float scale;

			// Token: 0x0400061E RID: 1566
			[Token(Token = "0x400061E")]
			[FieldOffset(Offset = "0x30")]
			public string smartupdate;
		}

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20000AB")]
		[Serializable]
		public class SpriteDataObject
		{
			// Token: 0x06000652 RID: 1618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpriteDataObject()
			{
			}

			// Token: 0x0400061F RID: 1567
			[Token(Token = "0x400061F")]
			[FieldOffset(Offset = "0x10")]
			public List<TexturePacker_JsonArray.Frame> frames;

			// Token: 0x04000620 RID: 1568
			[Token(Token = "0x4000620")]
			[FieldOffset(Offset = "0x18")]
			public TexturePacker_JsonArray.Meta meta;
		}
	}
}
