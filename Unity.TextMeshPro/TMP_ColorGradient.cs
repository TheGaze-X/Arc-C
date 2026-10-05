using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[ExcludeFromPreset]
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5881F80", Offset = "0x5880B80", VA = "0x185881F80")]
		public TMP_ColorGradient()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5882030", Offset = "0x5880C30", VA = "0x185882030")]
		public TMP_ColorGradient(Color color)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x5882080", Offset = "0x5880C80", VA = "0x185882080")]
		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
		{
		}

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x18")]
		public ColorMode colorMode;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x1C")]
		public Color topLeft;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x2C")]
		public Color topRight;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x3C")]
		public Color bottomLeft;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x4C")]
		public Color bottomRight;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color k_DefaultColor;
	}
}
