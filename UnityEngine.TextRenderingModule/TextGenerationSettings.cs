using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public struct TextGenerationSettings
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5A03000", Offset = "0x5A01C00", VA = "0x185A03000")]
		private bool CompareColors(Color left, Color right)
		{
			return default(bool);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5A03080", Offset = "0x5A01C80", VA = "0x185A03080")]
		private bool CompareVector2(Vector2 left, Vector2 right)
		{
			return default(bool);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5A030D0", Offset = "0x5A01CD0", VA = "0x185A030D0")]
		public bool Equals(TextGenerationSettings other)
		{
			return default(bool);
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public Font font;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8")]
		public Color color;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public int fontSize;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x1C")]
		public float lineSpacing;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		public bool richText;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x24")]
		public float scaleFactor;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		public FontStyle fontStyle;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x2C")]
		public TextAnchor textAnchor;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x30")]
		public bool alignByGeometry;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x31")]
		public bool resizeTextForBestFit;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x34")]
		public int resizeTextMinSize;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		public int resizeTextMaxSize;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x3C")]
		public bool updateBounds;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		public VerticalWrapMode verticalOverflow;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x44")]
		public HorizontalWrapMode horizontalOverflow;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 generationExtents;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 pivot;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		public bool generateOutOfBounds;
	}
}
