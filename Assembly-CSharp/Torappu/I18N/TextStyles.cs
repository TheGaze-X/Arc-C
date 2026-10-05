using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.I18N
{
	// Token: 0x02001625 RID: 5669
	[Token(Token = "0x2001625")]
	[Serializable]
	public class TextStyles
	{
		// Token: 0x060080B4 RID: 32948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080B4")]
		[Address(RVA = "0x28A1520", Offset = "0x28A0120", VA = "0x1828A1520")]
		public TextStyles(Vector2 transSize, TextAnchor alignment, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverFlow, int fontSize, bool isBestFit, int minSize, int maxSize)
		{
		}

		// Token: 0x04008202 RID: 33282
		[Token(Token = "0x4008202")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 transSize;

		// Token: 0x04008203 RID: 33283
		[Token(Token = "0x4008203")]
		[FieldOffset(Offset = "0x18")]
		public TextAnchor alignment;

		// Token: 0x04008204 RID: 33284
		[Token(Token = "0x4008204")]
		[FieldOffset(Offset = "0x1C")]
		public VerticalWrapMode verticalOverFlow;

		// Token: 0x04008205 RID: 33285
		[Token(Token = "0x4008205")]
		[FieldOffset(Offset = "0x20")]
		public HorizontalWrapMode horizontalOverFlow;

		// Token: 0x04008206 RID: 33286
		[Token(Token = "0x4008206")]
		[FieldOffset(Offset = "0x24")]
		public int fontSize;

		// Token: 0x04008207 RID: 33287
		[Token(Token = "0x4008207")]
		[FieldOffset(Offset = "0x28")]
		public bool isBestFit;

		// Token: 0x04008208 RID: 33288
		[Token(Token = "0x4008208")]
		[FieldOffset(Offset = "0x2C")]
		public int minSize;

		// Token: 0x04008209 RID: 33289
		[Token(Token = "0x4008209")]
		[FieldOffset(Offset = "0x30")]
		public int maxSize;
	}
}
