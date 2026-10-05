using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	internal struct ExpressionMultiplier
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0000B4A8 File Offset: 0x000096A8
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000528")]
		public ExpressionMultiplierType type
		{
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return ExpressionMultiplierType.None;
			}
			[Token(Token = "0x6001500")]
			[Address(RVA = "0x5A7B810", Offset = "0x5A7A410", VA = "0x185A7B810")]
			set
			{
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x5A7B7F0", Offset = "0x5A7A3F0", VA = "0x185A7B7F0")]
		public ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x5A7B770", Offset = "0x5A7A370", VA = "0x185A7B770")]
		private void SetType(ExpressionMultiplierType value)
		{
		}

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		public const int Infinity = 100;

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x0")]
		private ExpressionMultiplierType m_Type;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x4")]
		public int min;

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x8")]
		public int max;
	}
}
