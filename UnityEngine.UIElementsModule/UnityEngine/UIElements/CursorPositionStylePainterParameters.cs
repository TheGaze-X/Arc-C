using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	internal struct CursorPositionStylePainterParameters
	{
		// Token: 0x06000260 RID: 608 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x5A3CD00", Offset = "0x5A3B900", VA = "0x185A3CD00")]
		public static CursorPositionStylePainterParameters GetDefault(VisualElement ve, string text)
		{
			return default(CursorPositionStylePainterParameters);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x5A3CEA0", Offset = "0x5A3BAA0", VA = "0x185A3CEA0")]
		internal TextNativeSettings GetTextNativeSettings(float scaling)
		{
			return default(TextNativeSettings);
		}

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x0")]
		public Rect rect;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x18")]
		public Font font;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x20")]
		public int fontSize;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x24")]
		public FontStyle fontStyle;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x28")]
		public TextAnchor anchor;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x2C")]
		public float wordWrapWidth;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x30")]
		public bool richText;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x34")]
		public int cursorIndex;
	}
}
