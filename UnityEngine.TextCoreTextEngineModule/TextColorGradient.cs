using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[ExcludeFromPreset]
	[ExcludeFromObjectFactory]
	[Serializable]
	public class TextColorGradient : ScriptableObject
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x59F6E50", Offset = "0x59F5A50", VA = "0x1859F6E50")]
		public TextColorGradient()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x5882030", Offset = "0x5880C30", VA = "0x185882030")]
		public TextColorGradient(Color color)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x5882080", Offset = "0x5880C80", VA = "0x185882080")]
		public TextColorGradient(Color color0, Color color1, Color color2, Color color3)
		{
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x18")]
		public ColorGradientMode colorMode;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x1C")]
		public Color topLeft;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x2C")]
		public Color topRight;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x3C")]
		public Color bottomLeft;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x4C")]
		public Color bottomRight;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		private const ColorGradientMode k_DefaultColorMode = ColorGradientMode.FourCornersGradient;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color k_DefaultColor;
	}
}
